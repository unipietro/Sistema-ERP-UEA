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
using Microsoft.VisualBasic.Devices;

namespace WindowsFormsApp1.Forms
{
    public partial class FormEmail : Form
    {
        public FormEmail()
        {
            InitializeComponent();
        }

        private void btnanexar_Click(object sender, EventArgs e)
        {
            OpenFileDialog Dialogo = new OpenFileDialog();
            if (Dialogo.ShowDialog() == DialogResult.OK)
            {
                string extensao = Path.GetExtension(Dialogo.FileName);
                string nomedoarquivo = Path.GetFileNameWithoutExtension(Dialogo.FileName);
                string pasta = Path.GetDirectoryName(Dialogo.FileName);
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

                Anexoslstview.Items.Add(item);

            }
        }

        private void btnremoveranexo_Click(object sender, EventArgs e)
        {
            try
            {
                Anexoslstview.SelectedItems[0].Remove();
            }catch (Exception)
            {
                MessageBox.Show("Erro ao remover o anexo selecionado, por favor, selecione-o e tente novamente.");
            }
        }

        private void btnenviar_Click(object sender, EventArgs e)
        {
            //Vamos separar esta string
            string str = emailtxt.Text;
            //Separa string baseado em spaços
            char[] separadorChars = { '@' };
            string[] palavras = str.Split(separadorChars);
            //Percorremos as palavras da strings separadas exibindo-as no ListBox

            listemail.Items.Clear();
            foreach (var palavra in palavras)
            {            
                listemail.Items.Add($"{palavra}");
            }


            

        if (listemail.Items[1].ToString() == "hotmail.com")
        {
                portatxt.Text = "587";
                servidortxt.Text = "smtp.live.com";
        }else if (listemail.Items[1].ToString() == "gmail.com")
        {
                portatxt.Text = "587";
                servidortxt.Text = "smtp.gmail.com";
        }else if (listemail.Items[1].ToString() == "yahoo.com.br")
        {
                portatxt.Text = "465";
                servidortxt.Text = "smtp.mail.yahoo.com.br";
        }else if (listemail.Items[1].ToString() == "terra.com.br")
            {
                portatxt.Text = "587";
                servidortxt.Text = "smtp.terra.com.br";
        }else if (listemail.Items[1].ToString() == "outlook.com")
            {
                portatxt.Text = "587";
                servidortxt.Text = "SMTP.office365.com";
        }else {
                MessageBox.Show("Desculpe-nos, mas por enquanto só é possivel enviar e-mails com os endereços '@hotmail.com', '@gmail.com', '@yahoo.com.br', '@terra.com.br' e '@outlook.com'.");
                return;
        }
            ClassePDF pdf = new ClassePDF();
            pdf.EnviarEmail(paracmb.Text, assuntotxt.Text, mensagemtxt, emailtxt.Text, senhatxt.Text, Convert.ToInt32(portatxt.Text), servidortxt.Text, Anexoslstview);
        
        }
    }
}
