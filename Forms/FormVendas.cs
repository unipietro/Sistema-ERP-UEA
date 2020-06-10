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
    public partial class FormVendas : Form
    {
        public FormVendas()
        {
            InitializeComponent();
        }

        private void btnTesteInsercao_Click(object sender, EventArgs e)
        {
            Conexao con = new Conexao();
            con.StringdeExecucao = "INSERT INTO tabvendas SET datavenda=NOW(), observacoes='Teste numero 1', status='True';";
            con.ExecultaComando(con.StringdeExecucao.ToString());
            MessageBox.Show("Inserção realizada com sucesso.");
        }
    }
}
