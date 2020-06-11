using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using WindowsFormsApp1.Forms;
using System.Windows.Forms;
using System.Globalization;

namespace WindowsFormsApp1
{
    public class Conexao
    {
        public string conec = "SERVER=sitegambino.mysql.dbaas.com.br; DATABASE=sitegambino; UID=sitegambino; PWD=ProjetoCC6Sem; PORT=3306;";
        public MySqlConnection con = null;
        public string StringdeExecucao;
        public MySqlCommand comandomysql;
        public MySqlDataReader myAdapterPadrão;
        public DataTable TabelaPadrao1;
        public string Login;

        public Boolean AbrirCon()
        {
            try
            {
                con = new MySqlConnection(conec);
                con.Open(); //Aqui precisei inserir uma referencia System.Data por causa do Open();                

                //Caso seja verdadeiro, a execulção foi bem sucedida.
                return true;
            }
            catch (Exception ex)
            {
                MensagemdeErro("Não foi possivel se conectar ao Banco de Dados.\n\n Servidor não encontrado." + ex.ToString());
                return false;
            }
        }

        public void FecharCon()
        {
            try
            {
                con = new MySqlConnection(conec);
                con.Close();
            }
            catch (Exception ex)
            {
                MensagemdeErro("Não foi possivel fechar a conexão com o Banco de Dados.\n" + ex.ToString());
            }
        }

        //Execultar Comando MySQL
        public void ExecultaComando(string StringparafazeraExecucao)
        {
            //Chamo o metodo pra abrir conexão com o Banco de Dados.
            if (AbrirCon() == false)
            { 
                return; //Caso haja um erro na conexão, para aqui.
            }

            try
            {
                //Comando do mysql com seus devidos parametros
                comandomysql = new MySqlCommand(StringparafazeraExecucao, con);

                //Executa o comando
                //comandomysql.CommandType = System.Data.CommandType.Text;
                comandomysql.ExecuteNonQuery();
            }
            catch (Exception ex)
            {                
                MensagemdeErro("Erro ao execultar o comando no banco de dados. \n\n" + ex.ToString());
            }
            finally
            {
                //Fecha Conexao
                FecharCon();
            }
        }

        public void BuscarTabelaPadrao()
        {
            //Chamo o metodo pra abrir conexão com o Banco de Dados.
            if (AbrirCon() == false)
            {
                return; //Caso haja um erro na conexão, para aqui.
            }
            
            try
            {
                //Execulta a string no banco de dados
                comandomysql = new MySql.Data.MySqlClient.MySqlCommand(StringdeExecucao, con);
                myAdapterPadrão = comandomysql.ExecuteReader();
                myAdapterPadrão.Read();
                //Fim Execulta a string no banco de dados
            }
            catch (Exception ex)
            {
                MensagemdeErro("Erro ao buscar ou preencher a tabela padrão. \n" + ex.ToString());
            }
            finally
            {
                FecharCon();
            }
        }

        public DataTable RetornarDataTable() {
            DataTable dt = new DataTable();
            //Chamo o metodo pra abrir conexão com o Banco de Dados.
            AbrirCon();
            try
            {                
                new MySqlDataAdapter(StringdeExecucao, con).Fill(dt);
            }
            catch (Exception ex)
            {
                MensagemdeErro("Erro ao preencher a DataTable. \n" + ex.ToString());
            }
            finally
            {
                FecharCon();
            }
            return dt; //Caso haja um erro na conexão, para aqui.
        }

        public Boolean VerificarLogin(string Usuario, string Senha)
        {
            StringdeExecucao = "SELECT COUNT(login) AS Contagem FROM tabLogin WHERE login='" + Usuario + "' AND senha='" + Senha + "';";
            BuscarTabelaPadrao();

            try
            {
                Int32 ContagemLogin = myAdapterPadrão.GetInt32("Contagem");
                if (ContagemLogin == 1)
                {
                    //Retorna o Login e Senha como Verdadeiro
                    return true;
                }
                else if (ContagemLogin == 0)
                {
                    MensagemdeErro("Usuário e/ou Senha incorretos.");
                    //Retorna o Login e Senha como Verdadeiro
                    return false;
                }
                else
                {
                    MensagemdeErro("Desculpe, mais ocorreu um erro pois existe mais de 1 usuário com o mesmo Login e Senha.");
                    //Retorna o Login e Senha como Verdadeiro
                    return false;
                };
            }
            catch (Exception)
            {
                return false;
            }
        }
                
        private void MensagemdeErro(string MensagemdeErro)
        {
            MessageBox.Show(MensagemdeErro.ToString());
        }

    }
}

