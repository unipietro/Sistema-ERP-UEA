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
    public partial class FormClientes : Form
    {
        private MySqlDataAdapter da = new MySqlDataAdapter();
        private BindingSource bindingSource = new BindingSource();

        public FormClientes()
        {
            InitializeComponent();
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            try
            {
                Conexao con = new Conexao();
                da = new MySqlDataAdapter("SELECT id_cliente, nome AS Nome, cpf AS CPF, telefone AS Telefone, celular AS Celular, cep AS CEP, uf AS UF, cidade AS Cidade, bairro AS Bairro, logradouro AS Logradouro, numero AS Numero, complemento AS Complemento FROM tabclientes", con.conec);
                MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(da);

                DataTable dt = new DataTable();
                da.Fill(dt);
                bindingSource.DataSource = dt;
                ClientesGridView.DataSource = bindingSource;
                ClientesGridView.Columns["id_cliente"].Visible = false;
                ClientesGridView.Columns["Nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                ClientesGridView.Columns["Nome"].MinimumWidth = 100;
                ClientesGridView.Columns["CPF"].Width = 100;
                ClientesGridView.Columns["Telefone"].Width = 90;
                ClientesGridView.Columns["Celular"].Width = 90;
                ClientesGridView.Columns["CEP"].Width = 70;
                ClientesGridView.Columns["UF"].Width = 30;
                ClientesGridView.Columns["Cidade"].Width = 100;
                ClientesGridView.Columns["Bairro"].Width = 100;
                ClientesGridView.Columns["Logradouro"].Width = 100;
                ClientesGridView.Columns["Numero"].Width = 100;
                ClientesGridView.Columns["Complemento"].Width = 100;
            }
            catch (Exception)
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

        private void btnSave_Click(object sender, EventArgs e)
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
