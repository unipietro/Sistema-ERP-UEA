using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms
{
    public partial class FormEfetuarVenda : Form
    {
        public FormEfetuarVenda()
        {
            InitializeComponent();
        }

        private void Produto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Produto.SelectedTab.Name == "tabProduto")
            {
                Produto.Size = new Size(564, 110);
                ItensGridView.Size = new Size(562, 459);
                ItensGridView.Location = new Point(0, 106);
            }
            else
            {
                Produto.Size = new Size(564, 290);
                ItensGridView.Size = new Size(562, 273);
                ItensGridView.Location = new Point(0, 283);
            }
        }

        private void FormEfetuarVenda_Load(object sender, EventArgs e)
        {
            Conexao con = new Conexao();
            con.StringdeExecucao = "SELECT id_produto, nome, CONCAT('R$ ', FORMAT(venda, 2, 'DE_de')) AS venda, estoque, custo FROM tabprodutos WHERE status<>0;";
            DataTable dt = new DataTable();
            dt = con.RetornaDataTableparaComboBox();
            descricaocmb.DataSource = dt;
            descricaocmb.DisplayMember = "nome";
            descricaocmb.ValueMember = "id_produto";

            codigotxt.DataBindings.Clear();
            codigotxt.DataBindings.Add("Text", dt, "id_produto");

            valorunittxt.DataBindings.Clear();
            valorunittxt.DataBindings.Add("Text", dt, "venda");

            estoquetxt.DataBindings.Clear();
            estoquetxt.DataBindings.Add("Text", dt, "estoque");

            custounittxt.DataBindings.Clear();
            custounittxt.DataBindings.Add("Text", dt, "custo");

            PreencherClientes("SELECT * FROM tabclientes;");
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (qntdtxt.Text.ToString() == '0'.ToString() || qntdtxt.Text == string.Empty)
            {
                MessageBox.Show("Por gentileza, insira uma quantidade diferente de '0'.");
                return;
            }

            DataRowView drv = descricaocmb.SelectedItem as DataRowView;
            string nome;// = string.Empty;

            if (drv != null)
            {
                nome = drv.Row["nome"] as string;
            }
            else
            {
                MessageBox.Show("Erro ao selecionar o produto.");
                return;
            }


            decimal valortotal = Convert.ToDecimal(valorunittxt.Text.Replace("R$ ", "")) * Convert.ToDecimal(qntdtxt.Value);
            decimal custototal = Convert.ToDecimal(custounittxt.Text.Replace("R$ ", "")) * Convert.ToDecimal(qntdtxt.Value);
            ItensGridView.Rows.Insert(ItensGridView.Rows.Count, codigotxt.Text, qntdtxt.Text, nome.ToString(), valorunittxt.Text.Replace(" ",""), valortotal.ToString("C"), custototal.ToString("C"));
            CalculaItens();
            qntdtxt.Value = 0;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            try
            {
                ItensGridView.Rows.Remove(ItensGridView.CurrentRow);
                CalculaItens();
            }
            catch (Exception)
            {
                MessageBox.Show("Selecione um produto na lista abaixo para remove-lo.");
            }
        }

        private void CalculaItens()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in ItensGridView.Rows)
            {
                string valor = row.Cells["valortotal"].Value.ToString();
                
                total += Convert.ToDecimal(valor.Replace("R$",""));
            }
            totaltxt.Text = Convert.ToDouble(total).ToString("C");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja limpar todos os itens da lista?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ItensGridView.Rows.Clear();
            }
            
        }

        private void btnLimparCampos_Click(object sender, EventArgs e)
        {
            cmbnomecliente.Text = "";
            
            codigoclientetxt.DataBindings.Clear();
            codigoclientetxt.Clear();

            cpftxt.DataBindings.Clear();
            cpftxt.Clear();

            logradourotxt.DataBindings.Clear();
            logradourotxt.Clear();

            ntxt.DataBindings.Clear();
            ntxt.Clear();

            complementotxt.DataBindings.Clear();
            complementotxt.Clear();

            ceptxt.DataBindings.Clear();
            ceptxt.Clear();

            bairrotxt.DataBindings.Clear();
            bairrotxt.Clear();

            cidadetxt.DataBindings.Clear();
            cidadetxt.Clear();

            uftxt.DataBindings.Clear();
            uftxt.Clear();

            celulartxt.DataBindings.Clear();
            celulartxt.Clear();

            telefonetxt.DataBindings.Clear();
            telefonetxt.Clear();

            emailtxt.DataBindings.Clear();
            emailtxt.Clear();
        }

        private void btnBuscarCPF_Click(object sender, EventArgs e)
        {
            PreencherClientes("SELECT * FROM tabclientes WHERE cpf='" + cpftxt.Text + "';");
        }

        private void PreencherClientes(string StringSelect)
        {
            Conexao con = new Conexao();
            DataTable dt = new DataTable();

            con.StringdeExecucao = StringSelect;
            dt = new DataTable();
            dt = con.RetornaDataTableparaComboBox();
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum cliente foi encontrado.");
                return;
            }

            cmbnomecliente.DataSource = dt;
            cmbnomecliente.DisplayMember = "nome";
            cmbnomecliente.ValueMember = "id_cliente";

            codigoclientetxt.DataBindings.Clear();
            codigoclientetxt.DataBindings.Add("Text", dt, "id_cliente");

            cpftxt.DataBindings.Clear();
            cpftxt.DataBindings.Add("Text", dt, "cpf");

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
        }

        private void btnSalvarCliente_Click(object sender, EventArgs e)
        {
            if (cmbnomecliente.Text is null)
            {
                MessageBox.Show("O Campo de 'Nome' do cliente é Obrigatório.");
                cmbnomecliente.Focus();
                return;
            }
            Conexao con = new Conexao();
            if (codigoclientetxt.Text == "")
            {
                con.StringdeExecucao = "INSERT INTO tabclientes SET nome='" + cmbnomecliente.Text + "', cpf='" + cpftxt.Text + "', telefone='" + telefonetxt.Text + "', celular='" + celulartxt.Text + "', cep='" + ceptxt.Text + "', uf='" + uftxt.Text + "', cidade='" + cidadetxt.Text + "', bairro='" + bairrotxt.Text + "', logradouro='" + logradourotxt.Text + "', numero='" + ntxt.Text + "', complemento='" + complementotxt.Text + "', email='" + emailtxt.Text + "'";
                con.ExecultaComando(con.StringdeExecucao);
                MessageBox.Show("Cliente cadastrado com sucesso.");
                PreencherClientes("SELECT * FROM tabclientes ORDER BY id_cliente DESC LIMIT 1;");
            }
            else
            {
                con.StringdeExecucao = "UPDATE tabclientes SET nome='" + cmbnomecliente.Text + "', cpf='" + cpftxt.Text + "', telefone='" + telefonetxt.Text + "', celular='" + celulartxt.Text + "', cep='" + ceptxt.Text + "', uf='" + uftxt.Text + "', cidade='" + cidadetxt.Text + "', bairro='" + bairrotxt.Text + "', logradouro='" + logradourotxt.Text + "', numero='" + ntxt.Text + "', complemento='" + complementotxt.Text + "', email='" + emailtxt.Text + "' WHERE id_cliente='" + codigoclientetxt.Text + "'";
                con.ExecultaComando(con.StringdeExecucao);
                MessageBox.Show("Cliente alterado com sucesso.");
                //PreencherClientes("SELECT * FROM tabclientes ORDER BY id_cliente DESC LIMIT 1;");
            }
        }

        private void btnFinalizarCompra_Click(object sender, EventArgs e)
        {
            if (codigoclientetxt.Text == "")
            {
                MessageBox.Show("Para finalizar a venda, por gentileza selecione um cliente.");
                return;
            }
            if (codigoVendedorlbl.Text == "-")
            {
                MessageBox.Show("Para finalizar a venda, por gentileza indique um funcionario com o código de acesso.");
                return;
            }
            if (Convert.ToDecimal(totaltxt.Text.Replace("R$", "").Replace(" ","")) == 0)
            {
                MessageBox.Show("Para finalizar a venda, por gentileza insira ao menos 1 produto.");
                return;
            }

            Conexao con = new Conexao();
            con.StringdeExecucao = "";
            con.StringdeExecucao += "INSERT INTO tabvendas SET id_cliente='" + codigoclientetxt.Text + "', id_vendedor='" + codigoVendedorlbl.Text + "', datadavenda=NOW(), observacoes='" + observacoestxt.Text + "', status='1';";

            int linha, tlinha;
            linha = 0;
            tlinha = ItensGridView.Rows.Count;
           
            while (linha < tlinha)
            {   
                con.StringdeExecucao += "INSERT INTO tab_prod_vendas SET id_venda=(SELECT MAX(id_venda) FROM tabvendas), id_produto='" + ItensGridView.Rows[linha].Cells["id_produto"].Value.ToString() + "', qntd='" + ItensGridView.Rows[linha].Cells["qntd"].Value.ToString() + "', custototal='" + ItensGridView.Rows[linha].Cells["custototal"].Value.ToString() + "', valortotal='" + ItensGridView.Rows[linha].Cells["valortotal"].Value.ToString() + "';";
                linha++;
            }

            con.ExecultaComando(con.StringdeExecucao);
            MessageBox.Show("Venda finalizada com sucesso.");
            Close();
            //execultar a query
        }

        private void qntdtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                btnInserir_Click(btnInserir, EventArgs.Empty);
                return;
            }
        }
        
        private void btnbuscavendedor_Click(object sender, EventArgs e)
        {
            Conexao con = new Conexao();
            con.StringdeExecucao = "SELECT id_funcionario, apelido FROM tabfuncionarios WHERE codigoacesso='" + codigoacessotxt.Text + "';";
            DataTable dt = con.RetornarDataTable();
            if (Convert.ToDecimal(dt.Rows.Count) == 0)
            {
                codigoVendedorlbl.Text = "-";
                lblnomefuncionario.Text = "-";
                return;
            }
            foreach (DataRow linha in dt.Rows)
            {
                codigoVendedorlbl.Text = Convert.ToString(linha["id_funcionario"]);
                lblnomefuncionario.Text = Convert.ToString(linha["apelido"]);
            }            
        }

        private void codigoacessotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                btnbuscavendedor_Click(btnbuscavendedor, EventArgs.Empty);
                return;
            }
        }

        private void cpftxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                btnBuscarCPF_Click(btnBuscarCPF, EventArgs.Empty);
                return;
            }
        }

        private void ceptxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                btnBuscarCPF_Click(btnBuscarCPF, EventArgs.Empty);
                return;
            }
        }

        private void btncep_Click(object sender, EventArgs e)
        {
            try
            {
                var ws = new WSCorreios.AtendeClienteClient();
                ceptxt.CutCopyMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                var resposta = ws.consultaCEP(ceptxt.Text);
                logradourotxt.Text = resposta.end;
                bairrotxt.Text = resposta.bairro;
                cidadetxt.Text = resposta.cidade;
                uftxt.Text = resposta.uf;
                complementotxt.Text = resposta.complemento2;
                ntxt.Focus();                
            }
            catch (Exception)
            {
                MessageBox.Show("Desculpe, mais não foi possivel encontrar este CEP.");
                logradourotxt.Focus();
            }            
        }
    }
}
