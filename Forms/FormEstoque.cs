using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1.Forms
{
    public partial class FormEstoque : Form
    {
        private MySqlDataAdapter da = new MySqlDataAdapter();
        private BindingSource bindingSource = new BindingSource();

        public FormEstoque()
        {
            InitializeComponent();
        }

        private void FormEstoque_Load(object sender, EventArgs e)
        {
            try
            {
                Conexao con = new Conexao();
                da = new MySqlDataAdapter("SELECT id_produto, status AS Status, nome AS Nome, estoque AS Estoque, custo AS Custo, venda AS Venda FROM tabprodutos", con.conec);
                MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(da);

                DataTable dt = new DataTable();
                da.Fill(dt);
                bindingSource.DataSource = dt;
                ProdutosGridView.DataSource = bindingSource;
                ProdutosGridView.Columns["Status"].Width = 50;
                ProdutosGridView.Columns["id_produto"].Visible = false;
                ProdutosGridView.Columns["Nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                ProdutosGridView.Columns["Estoque"].Width = 100;
                ProdutosGridView.Columns["Custo"].Width = 100;
                ProdutosGridView.Columns["Venda"].Width = 100;
            }
            catch(Exception)
            {
                MessageBox.Show("Desculpe, mas ocorreu um erro ao buscar as informações no banco de dados.");
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                da.Update((DataTable)bindingSource.DataSource);
                MessageBox.Show("As alterações foram salvas com sucesso.");
            }
            catch (Exception)
            {
                MessageBox.Show("Desculpe, mas ocorreu um erro ao salvar os dados no banco de dados.");
            }

        }
    }
}
