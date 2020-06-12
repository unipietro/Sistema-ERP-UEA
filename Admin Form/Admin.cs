using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.IO;


namespace WindowsFormsApp1.Admin_Form
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        string testepara;
        string nomeTabela;

        public void button1_Click(object sender, EventArgs e)
        {
            // parametros
            string Prompt = "Defina um nome para o novo banco.";
            string Titulo = "CRIAR BANCO";
            string Resultado = Interaction.InputBox(Prompt, Titulo, @"coloque o caminho aqui", 650, 350);
            testepara = Resultado;

            // verificação se o resultado é uma string vazia = cancelado
            if (Resultado != "")
            {
                if(!Resultado.Contains(".sdf"))
                {
                    MessageBox.Show("Informe a externsão .sdf no arquivo");
                    return;
                }
                try
                {
                    string connectionString;
                    string nomeArquivoBD = Resultado;
                    string senha = "";

                    if(File.Exists(nomeArquivoBD))
                    {
                        if(MessageBox.Show("O arquivo já existe!. Deseja excluir e criar novamente?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            File.Delete(nomeArquivoBD);
                        }
                        else
                        {
                            return;
                        }
                    }
                    // montando a string do bd

                    connectionString = string.Format("DataSource=\"{0}\";Password='{1}'", nomeArquivoBD, senha);
                    
                    if(MessageBox.Show("Será Criado arquivo " + connectionString +" Confirma?", "Criar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        SqlCeEngine cn = new SqlCeEngine(connectionString);
                        cn.CreateDatabase();
                        lblEncontrado.Text = "Banco de dados " + nomeArquivoBD + " criado com sucesso!";
                    }
                    else
                    {
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Operação cancelada.");
            }
        }

        private void dgvBanco_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCriaTabela_Click(object sender, EventArgs e)
        {
            // definindo paramentros
            string Prompt = "Defina um nome para a tabela.";
            string Titulo = "CRIAR TABELA";
            string Resultado = Interaction.InputBox(Prompt, Titulo, "Contatos", 650, 350);
            
            nomeTabela = Resultado;
            if(Resultado != "")
            { 
                    if (Resultado.Contains(".sdf"))
                    {
                        MessageBox.Show("Não informe a extensão .sdf no arquivo");
                        return;
                    }
                    // conexão criada so renomear
                    SqlCeConnection cn = new SqlCeConnection(stringConexao());
                    if (cn.State == ConnectionState.Closed)
                    {
                        cn.Open();
                    }
                
                SqlCeCommand cmd;

                string sql = "CREATE TABLE " + Resultado + "("
                    + "Nome NVARCHAR (60) NOT NULL, "
                    + "Sobrenome NVARCHAR (80), "
                    + "URL NVARCHAR (150))";

                cmd = new SqlCeCommand(sql, cn);

                if (MessageBox.Show("Confirma a criação da tabela?", "Criar Tabela", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                        lblEncontrado.Text = "Tabela " + Resultado + " criada com sucesso!";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Nossa senhora.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        cn.Close();
                    }
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("A operação foi cancelada");
            }
        }
        public string stringConexao()
        {
            string connectionString = "";
            try
            {
                string nomeArquivoBD = testepara;
                string senha = "";
                connectionString = string.Format("DataSource=\"{0}\"; Password='{1}'", nomeArquivoBD, senha);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return connectionString;
        }

        private void btnCarregaTabela_Click(object sender, EventArgs e)
        {
            try
            {
                CarregarLinha("PIETRO", "PIERRE", @"PIPI@GMAIL.COM");
                CarregarLinha("GUSTAVO", "BIOLCATTI", @"GUGU@GMAIL.COM");
                CarregarLinha("CAIO", "JANO", @"CACA@GMAIL.COM");
                CarregarLinha("RAFA", "CASOU", @"FAFA@GMAIL.COM");
                CarregarLinha("BARBARA", "BD", @"BABI@GMAIL.COM");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CarregarLinha(string nome, string sobrenome, string url)
        {

            SqlCeConnection cn = new SqlCeConnection(stringConexao());
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }

            SqlCeCommand cmd;
            string sql = "insert into " + nomeTabela
                        + "(sobrenome, nome, url) "
                        + "values (@sobrenome, @nome, @url)";
            try
            {
                cmd = new SqlCeCommand(sql, cn);
                cmd.Parameters.AddWithValue("@sobrenome", sobrenome);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@url", url);
                cmd.ExecuteNonQuery();
                lblEncontrado.Text = "Linha Incluída.";
            }
            catch (SqlCeException sqlexception)
            {
                MessageBox.Show(sqlexception.Message, "Erro.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cn.Close();
            }
        }

        private void btnCarregaGrid_Click(object sender, EventArgs e)
        {
            SqlCeConnection cn = new SqlCeConnection(stringConexao());
            if (cn.State == ConnectionState.Closed)
            {
                try
                {
                    cn.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            try
            {
                // define o command para usar a tabela e não a consulta
                SqlCeCommand cmd = new SqlCeCommand(nomeTabela, cn);
                cmd.CommandType = CommandType.TableDirect;

                // pega a tabela
                SqlCeResultSet rs = cmd.ExecuteResultSet(ResultSetOptions.Scrollable);

                // carrega o resultado no grid 
                dgvBanco.DataSource = rs;
            }
            catch (SqlCeException sqlexception)
            {
                MessageBox.Show(sqlexception.Message, "Erro.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLerRegis_Click(object sender, EventArgs e)
        {
            SqlCeConnection cn = new SqlCeConnection(stringConexao());
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
            // Monta a consulta SQL 
            string sql = "select sobrenome, nome from " + nomeTabela;
            try
            {
                SqlCeCommand cmd = new SqlCeCommand(sql, cn);
                cmd.CommandType = CommandType.Text;
                SqlCeResultSet rs = cmd.ExecuteResultSet(ResultSetOptions.Scrollable);
                // se você precisa atualizar o result set então use:
                // SqlCeResultSet rs = cmd.ExecuteResultSet(ResultSetOptions.Scrollable | ResultSetOptions.Updatable);
                if (rs.HasRows)
                {
                    int ordSobrenome = rs.GetOrdinal("sobrenome");
                    int ordNome = rs.GetOrdinal("nome");
                    // trata a saida
                    StringBuilder saida = new StringBuilder();
                    // le o primeiro registro e pega os dados
                    rs.ReadFirst();
                    saida.AppendLine(rs.GetString(ordNome) + " " + rs.GetString(ordSobrenome));
                    while (rs.Read())
                    {
                        saida.AppendLine(rs.GetString(ordNome) + " " + rs.GetString(ordSobrenome));
                    }
                    // defina a saida
                    lblEncontrado.Text = saida.ToString();
                }
                else
                {
                    lblEncontrado.Text = "Nenhum registro encontrado.";
                }
            }
            catch (SqlCeException sqlexception)
            {
                MessageBox.Show(sqlexception.Message, "Bah Tchê.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Bah Tchê.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cn.Close();
            }
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }
    }
}
