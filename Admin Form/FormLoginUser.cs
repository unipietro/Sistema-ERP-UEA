using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Admin_Form
{
    public partial class FormLoginUser : Form
    {
        public FormLoginUser()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Conexao con = new Conexao();
            if (con.VerificarLogin(logintxt.Text, senhatxt.Text) == true)
            {
                //this.Hide();

                Admin FormAdmin = new Admin();
                if (logintxt.Text == "admin")
                {
                    FormAdmin.btnCriarBD.Visible = false;
                    FormAdmin.btnCriaTabela.Visible = false;
                    FormAdmin.btnCarregaGrid.Visible = true;
                    FormAdmin.btnCarregaTabela.Visible = true;
                    FormAdmin.btnLerRegis.Visible = true;
                }
                else
                {
                    FormAdmin.btnCriarBD.Visible = true;
                    FormAdmin.btnCriaTabela.Visible = true;
                    FormAdmin.btnCarregaGrid.Visible = true;
                    FormAdmin.btnCarregaTabela.Visible = true;
                    FormAdmin.btnLerRegis.Visible = true;
                }
                FormAdmin.Show();
                this.Close();
            }

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
