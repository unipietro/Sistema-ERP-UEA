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
    public partial class FormVendedores : Form
    {
        public FormVendedores()
        {
            InitializeComponent();
        }

        private MySqlDataAdapter da = new MySqlDataAdapter(); //Aqui declaramos uma Dataadapter que vai armazenar os dados do banco temporariamente
        private BindingSource bindingSource1 = new BindingSource(); //Esse método é usado para fazer a ponte entre o DataAdapter e o DataGridView, caso não fossemos usar o parametro .Update, não seria necessário essa ponte.

        private void FormVendedores_Load(object sender, EventArgs e)
        {
            Conexao con = new Conexao(); //Instanciamos a classe Con
            try
            {
                da = new MySqlDataAdapter("SELECT id_funcionario, status AS Status, nome AS Nome, apelido AS Apelido, codigoacesso AS codigoacesso FROM tabfuncionarios;", con.conec);//Aqui declaramos que a private 'da' é uma nova DataAdapter, e dentro passamos a query de seleção eee a string de conexão
                //da = new MySqlDataAdapter("SELECT * FROM tabfuncionarios;", con.conec);//Aqui declaramos que a private 'da' é uma nova DataAdapter, e dentro passamos a query de seleção eee a string de conexão
                MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(da); //Aqui efetuamos o comando

                DataTable table = new DataTable(); //Aqui declaramos uma nova DataTable
                da.Fill(table);//Aqui preenchemos a DataTable com o DataAdapter para vincularmos com o BindingSource
                bindingSource1.DataSource = table; //Aqui vinculamos o BindingSource com a Data Table
                FuncionariosGridView.DataSource = table; //Aqui preenchemos o GridView de acordo com o BindingSource
                //Daqui pra baixo trata do visual do datagrid após a inserção das colunas...
                FuncionariosGridView.Columns["id_funcionario"].Visible = false;
                FuncionariosGridView.Columns["Status"].Width = 50;
                FuncionariosGridView.Columns["Nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                FuncionariosGridView.Columns["Apelido"].Width = 150;
                FuncionariosGridView.Columns["codigoacesso"].Width = 150;
                FuncionariosGridView.Columns["codigoacesso"].HeaderText = "Cód Acesso";

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
                da.Update((DataTable)bindingSource1.DataSource);
                MessageBox.Show("As alterações foram salvas com sucesso.");
            }
            catch (Exception)
            {
                MessageBox.Show("Desculpe, mas ocorreu um erro ao salvar os dados no banco de dados.");
            }
        }
    }
}
