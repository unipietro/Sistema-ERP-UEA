using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1.Forms
{
    public partial class FormControleDeVenda : Form
    {
        private MySqlDataAdapter da = new MySqlDataAdapter();
        private BindingSource bindingSource = new BindingSource();

        public FormControleDeVenda()
        {
            InitializeComponent();
        }
              
        private void FormControleDeVenda_Load(object sender, EventArgs e)
        {
            Conexao con = new Conexao();
            con.StringdeExecucao = "SELECT tabvendas.status AS Status, tabvendas.id_venda AS Venda, tabvendas.datadavenda AS Data, " +
                "tabclientes.id_cliente AS id_cliente, tabclientes.cpf AS CPF, tabclientes.nome as Nome, tabclientes.logradouro as logradouro," +
                "tabclientes.numero AS numero, tabclientes.bairro AS bairro, tabclientes.cidade AS cidade, tabclientes.uf AS uf," +
                "tabclientes.cep, IF(tabvendas.status='0', 'Cancelado', 'Venda') AS sta, tabclientes.celular AS celular, tabclientes.telefone AS telefone, tabclientes.email AS email, tabclientes.complemento AS complemento, tabfuncionarios.apelido AS Vendedor, tabvendas.observacoes AS Obs FROM tabvendas INNER JOIN tabclientes ON tabclientes.id_cliente=tabvendas.id_cliente INNER JOIN tabfuncionarios ON tabfuncionarios.id_funcionario=tabvendas.id_vendedor ORDER BY tabvendas.id_venda DESC;";
            DataTable dt = new DataTable();
            dt = con.RetornarDataTable();

            nometxt.DataBindings.Clear();
            nometxt.DataBindings.Add("Text", dt, "Nome");

            statustxt.DataBindings.Clear();
            statustxt.DataBindings.Add("Text", dt, "sta");

            datavendatxt.DataBindings.Clear();
            datavendatxt.DataBindings.Add("Text", dt, "Data");

            vendedortxt.DataBindings.Clear();
            vendedortxt.DataBindings.Add("Text", dt, "Vendedor");

            observacoestxt.DataBindings.Clear();
            observacoestxt.DataBindings.Add("Text", dt, "Obs");

            codigoclientetxt.DataBindings.Clear();
            codigoclientetxt.DataBindings.Add("Text", dt, "id_cliente");

            cpftxt.DataBindings.Clear();
            cpftxt.DataBindings.Add("Text", dt, "CPF");

            logradourotxt.DataBindings.Clear();
            logradourotxt.DataBindings.Add("Text", dt, "logradouro");

            ntxt.DataBindings.Clear();
            ntxt.DataBindings.Add("Text", dt, "numero");

            complementotxt.DataBindings.Clear();
            complementotxt.DataBindings.Add("Text", dt, "complemento");

            ceptxt.DataBindings.Clear();
            ceptxt.DataBindings.Add("Text", dt, "cep");

            bairrotxt.DataBindings.Clear();
            bairrotxt.DataBindings.Add("Text", dt, "bairro");

            cidadetxt.DataBindings.Clear();
            cidadetxt.DataBindings.Add("Text", dt, "cidade");

            uftxt.DataBindings.Clear();
            uftxt.DataBindings.Add("Text", dt, "uf");

            celulartxt.DataBindings.Clear();
            celulartxt.DataBindings.Add("Text", dt, "celular");

            telefonetxt.DataBindings.Clear();
            telefonetxt.DataBindings.Add("Text", dt, "telefone");

            emailtxt.DataBindings.Clear();
            emailtxt.DataBindings.Add("Text", dt, "email");

            //Preenche os Itens no DataGrid
            con.StringdeExecucao = "SELECT tab_prod_vendas.qntd AS Qntd, tabprodutos.nome AS Produto, CONCAT('R$ ', FORMAT((tab_prod_vendas.valortotal / tab_prod_vendas.qntd) , 2, 'DE_de')) AS ValorUnit, CONCAT('R$ ', FORMAT(tab_prod_vendas.valortotal, 2, 'DE_de')) AS Total FROM tab_prod_vendas INNER JOIN tabprodutos ON tabprodutos.id_produto=tab_prod_vendas.id_produto WHERE tab_prod_vendas.id_venda='" + codigovendatxt.Text + "'";
            ItensGridView.DataSource = con.RetornarDataTable();

            ItensGridView.Columns["qntd"].Width = 70;
            ItensGridView.Columns["Produto"].MinimumWidth = 150;
            ItensGridView.Columns["Produto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ItensGridView.Columns["ValorUnit"].Width = 80;
            ItensGridView.Columns["ValorUnit"].HeaderText = "Valor Unit";
            ItensGridView.Columns["Total"].Width = 80;
            ItensGridView.Columns["Total"].HeaderText = "Valor Total";

            CalculaItens();
        }

        private void CalculaItens()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in ItensGridView.Rows)
            {
                string valor = row.Cells["Total"].Value.ToString();

                total += Convert.ToDecimal(valor.Replace("R$ ", ""));
            }
            valortxt.Text = Convert.ToDouble(total).ToString("C");
        }

        private void btncCancelarVenda_Click(object sender, EventArgs e)
        {            
            if (MessageBox.Show("Tem certeza que deseja cancelar está venda?", "Cancelamento de Venda", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
            {
                return;
            }
            Conexao con = new Conexao();
            con.StringdeExecucao = "UPDATE tabvendas SET status=0 WHERE id_venda='" + codigovendatxt.Text + "';";
            con.ExecultaComando(con.StringdeExecucao);
            statustxt.Text = "Cancelado";
            MessageBox.Show("Cancelamento efetuado com sucesso.", "Venda Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            ClassePDF Pdf = new ClassePDF();
            Pdf.ImpressaoPDFdaVenda(codigovendatxt.Text, ItensGridView);
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            ClassePDF Pdf = new ClassePDF();
            string Caminho = Pdf.ImpressaoPDFdaVenda(codigovendatxt.Text, ItensGridView);
            if (Caminho == "")
            {   
                return;
            }

            string extensao = Path.GetExtension(Caminho);
            string nomedoarquivo = Path.GetFileNameWithoutExtension(Caminho);
            string pasta = Path.GetDirectoryName(Caminho);
            string LocalExatoArquivo = pasta + "\\" + nomedoarquivo + extensao;

            int numeroimagem;
            
            if (extensao.ToString() == ".xml" || extensao.ToString() == ".xlsx" || extensao.ToString() == ".xlsb" || extensao.ToString() == ".xltx" || extensao.ToString() == ".xltm" || extensao.ToString() == ".xls" || extensao.ToString() == ".xlt" || extensao.ToString() == ".xml" || extensao.ToString() == ".xlam" || extensao.ToString() == ".xla" || extensao.ToString() == ".xlw" || extensao.ToString() == ".xlr") //Se for Excel
            {
                numeroimagem = 2;
            }
            else if (extensao.ToString() == ".doc" || extensao.ToString() == ".docx" || extensao.ToString() == ".docm" || extensao.ToString() == ".dotx" || extensao.ToString() == ".dotm") //Se for WORD 
            {
                numeroimagem = 4;
            }
            else if (extensao.ToString() == ".pdf")//Se for PDF
            {
                numeroimagem = 3;
            }
            else //se for desconhecido
            {
                numeroimagem = 0;
            }

            ListViewItem item = new ListViewItem();
            item.Text = (nomedoarquivo).ToString();
            item.ImageIndex = numeroimagem;
            item.SubItems.Add(LocalExatoArquivo).ToString();

            FormEmail formEmail = new FormEmail();
            formEmail.Anexoslstview.Items.Add(item);
            formEmail.paracmb.Text = emailtxt.Text;
            formEmail.Show();
        }
    }
}
