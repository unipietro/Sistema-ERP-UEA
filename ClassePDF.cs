using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net.Mail;

namespace WindowsFormsApp1
{
    class ClassePDF
    {
        //private String MeusDocumentos = MySql.Computer.FileSystem.SpecialDirectories.MyDocuments.ToString;
        private String SalvarEm;
        private Double LarguradaFolhaSub = 627 - 32;
        private Double AlturadaFolhaSub = 840;
        private XRect retangulopelafolha = new XRect(10, 10, 573, 840 - 20);
        private XRect retanguloparatexto = new XRect(10, 10, 583, 20);
        private Double MargemNormal = 12;

        public void SalvarPedidoemPDF(PdfDocument DocumentoPDF, string SalvarEm)
        {
            try
            {
                DocumentoPDF.Save(SalvarEm);
            } catch (Exception)
            {
                MessageBox.Show("Desculpe, mais não foi possivel salvar o arquivo em PDF.");
            }
        }
        private Boolean CriarPDF(string NomedoArquivo, PdfDocument DocumentoPDF)
        {
            var NomePastaeArquivo = string.Empty;

            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Salvar Venda";
                sfd.FileName = NomedoArquivo;
                sfd.Filter = "PDF|*.pdf";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    SalvarEm = sfd.FileName + ".pdf";
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Desculpe, mais não foi possivel salvar o PDF.");
                return false;
            }

            if (File.Exists(SalvarEm) == true) {
                File.Delete(SalvarEm);
            }

            DocumentoPDF.Info.Author = "U.E.A";
            DocumentoPDF.Info.Keywords = "Pedido U.E.A";
            DocumentoPDF.Info.CreationDate = DateTime.Now;
            DocumentoPDF.Info.Subject = "Pedido U.E.A";
            return true;
        }

        public string ImpressaoPDFdaVenda(string CodigodaVenda, DataGridView dgItens)
        {
            PdfDocument pdf = new PdfDocument();
            PdfPage pdfPage = pdf.AddPage();
            XGraphics objImpressao = XGraphics.FromPdfPage(pdfPage);

            string nomedoarquivo = "Venda " + CodigodaVenda.ToString() + ".pdf";
            if (CriarPDF(nomedoarquivo, pdf) == false)
            {
                return "";
            };

            XFont font = new XFont("Verdana", 15, XFontStyle.Bold);

            //Cabeçário
            MargemNormal = 20;

            XFont fonteLogo = new XFont("Arial", 13, XFontStyle.Bold);
            XFont fonteEndereco = new XFont("Arial", 10);

            retanguloparatexto.Width = LarguradaFolhaSub - 20;
            retanguloparatexto.Height = 20;
            retanguloparatexto.Y = 20;
            retanguloparatexto.X = 20;

            retangulopelafolha.Height = AlturadaFolhaSub - 40;
            retangulopelafolha.Width = LarguradaFolhaSub - 20;
            //Faz um retangulo em volta de toda a Folha
            objImpressao.DrawRectangle(XPens.Black, retangulopelafolha);
            //FIM Faz um retangulo em volta de toda a Folha


            XStringFormat centro = new XStringFormat();
            XStringFormat normal = new XStringFormat();
            XStringFormat invertido = new XStringFormat();
            centro.Alignment = XStringAlignment.Center;
            normal.Alignment = XStringAlignment.Near;
            invertido.Alignment = XStringAlignment.Far;
            objImpressao.DrawString("NOME DA EMPRESA", fonteLogo, XBrushes.Black, retanguloparatexto, centro);
            retanguloparatexto.Y = retanguloparatexto.Y + retanguloparatexto.Height;
            retanguloparatexto.Height = 40;
            objImpressao.DrawString("Endereço da Empresa" +
                " - " + "Telefone da Empresa", fonteEndereco, XBrushes.Black, retanguloparatexto, centro);
            retanguloparatexto.Y = retanguloparatexto.Y + retanguloparatexto.Height;

            Conexao con = new Conexao();
            con.StringdeExecucao = "SELECT tabvendas.status AS Status, tabvendas.id_venda AS Venda, tabvendas.datadavenda AS Data, " +
                "tabclientes.id_cliente AS id_cliente, tabclientes.cpf AS CPF, tabclientes.nome as Nome, CONCAT(tabclientes.logradouro, ', '," +
                "tabclientes.numero, ' ', tabclientes.complemento, ' - ', tabclientes.bairro, ', ', tabclientes.cidade, ' - ', tabclientes.uf, ' - ', " +
                "tabclientes.cep) AS Endereco, IF(tabvendas.status='0', 'Cancelado', 'Venda') AS sta, tabclientes.celular AS celular, tabclientes.telefone AS telefone, tabclientes.email AS email, tabclientes.complemento AS complemento, tabfuncionarios.apelido AS Vendedor, tabvendas.observacoes AS Obs FROM tabvendas INNER JOIN tabclientes ON tabclientes.id_cliente=tabvendas.id_cliente INNER JOIN tabfuncionarios ON tabfuncionarios.id_funcionario=tabvendas.id_vendedor WHERE id_venda='" + CodigodaVenda + "' ORDER BY tabvendas.id_venda DESC;";
            DataTable dtvenda = new DataTable();
            dtvenda = con.RetornarDataTable();
            string Cliente = string.Empty;
            string Vendedor = string.Empty;
            string Status = string.Empty;
            string Data = string.Empty;
            string CPF = string.Empty;
            string Fone = string.Empty;
            string Celular = string.Empty;
            string Endereco = string.Empty;

            foreach (DataRow dw in dtvenda.Rows)
            {
                Cliente = dw["Nome"].ToString();
                Vendedor = dw["Vendedor"].ToString();
                Status = dw["sta"].ToString();
                Data = dw["Data"].ToString();
                CPF = dw["CPF"].ToString();
                Fone = dw["telefone"].ToString();
                Celular = dw["celular"].ToString();
                Endereco = dw["Endereco"].ToString();
            }

            int TamanhoFonte = 12;
            string Fonte = "Arial";
            XFont fontesepradora = new XFont(Fonte, 2, XFontStyle.Regular);
            XFont fontevalortotalitens = new XFont(Fonte, TamanhoFonte, XFontStyle.Regular);
            XFont fontevalortotalitensdestaque = new XFont(Fonte, TamanhoFonte, XFontStyle.Bold);
            XFont fonteseparador = new XFont(Fonte, TamanhoFonte, XFontStyle.Regular);
            XFont fonteseparadordestaque = new XFont(Fonte, TamanhoFonte, XFontStyle.Bold);
            XFont fontepagamentos = new XFont(Fonte, TamanhoFonte, XFontStyle.Regular);
            XFont fontepagamentosdestaque = new XFont(Fonte, TamanhoFonte, XFontStyle.Bold);
            XFont fontedadositens = new XFont(Fonte, TamanhoFonte, XFontStyle.Regular);
            XFont fontedadositensdestaque = new XFont(Fonte, TamanhoFonte, XFontStyle.Bold);
            XFont fontegeral = new XFont(Fonte, TamanhoFonte, XFontStyle.Regular);
            XFont fontedadoscliente = new XFont(Fonte, TamanhoFonte, XFontStyle.Regular);
            XFont fontedadosclientedestaque = new XFont(Fonte, TamanhoFonte, XFontStyle.Bold);
            XFont fontedestaque = new XFont(Fonte, TamanhoFonte, XFontStyle.Bold);
            LarguradaFolhaSub -= 15;

            if (Status == "Cancelado")
            {
                objImpressao.DrawString("Pedido " + CodigodaVenda + " - Cancelado", fonteLogo, XBrushes.Black, retanguloparatexto, centro);
            }
            else
            {
                objImpressao.DrawString("Pedido " + CodigodaVenda, fonteLogo, XBrushes.Black, retanguloparatexto, centro);
            }
            MargemNormal = 10;
            retanguloparatexto.Height = 10;
            objImpressao.DrawLine(XPens.Black, MargemNormal, retanguloparatexto.Y, LarguradaFolhaSub + 5, retanguloparatexto.Y);
            retanguloparatexto.Y = retanguloparatexto.Y + retanguloparatexto.Height;

            MargemNormal = 15;
            retanguloparatexto.Y += 5;

            retanguloparatexto.Height = 15;

            retanguloparatexto.X = MargemNormal;
            retanguloparatexto.Width = 70;
            objImpressao.DrawString("Vendedor: ", fontedestaque, XBrushes.Black, retanguloparatexto, normal);
            retanguloparatexto.X += retanguloparatexto.Width;
            retanguloparatexto.Width = LarguradaFolhaSub - 135 - retanguloparatexto.X;
            objImpressao.DrawString(Vendedor, fontegeral, XBrushes.Black, retanguloparatexto, normal);
            retanguloparatexto.X += retanguloparatexto.Width;

            retanguloparatexto.Width = 42;
            objImpressao.DrawString("Data:", fontedestaque, XBrushes.Black, retanguloparatexto, normal);
            retanguloparatexto.X += retanguloparatexto.Width;
            retanguloparatexto.Width = LarguradaFolhaSub - retanguloparatexto.X;
            objImpressao.DrawString(Convert.ToDateTime(Data).ToString("dd/MM/yyyy HH:mm"), fontegeral, XBrushes.Black, retanguloparatexto, invertido);
            retanguloparatexto.X += retanguloparatexto.Width;

            retanguloparatexto.Y += retanguloparatexto.Height;
            retanguloparatexto.X = MargemNormal;

            retanguloparatexto.Width = LarguradaFolhaSub - MargemNormal - MargemNormal;
            objImpressao.DrawString("Informações do Cliente", fonteseparadordestaque, XBrushes.Black, retanguloparatexto, centro);
            retanguloparatexto.Y += 10;
            objImpressao.DrawLine(XPens.Black, MargemNormal, retanguloparatexto.Y - 12, LarguradaFolhaSub, retanguloparatexto.Y - 12);
            objImpressao.DrawLine(XPens.Black, MargemNormal, retanguloparatexto.Y + 5, LarguradaFolhaSub, retanguloparatexto.Y + 5);
            retanguloparatexto.X += retanguloparatexto.Width;

            retanguloparatexto.Y += 10;
            retanguloparatexto.X = MargemNormal;

            retanguloparatexto.Height = fontedadosclientedestaque.Height;


            retanguloparatexto.Width = 45;
            objImpressao.DrawString("Nome:", fontedadosclientedestaque, XBrushes.Black, retanguloparatexto, normal);
            retanguloparatexto.X += retanguloparatexto.Width;
            retanguloparatexto.Width = 150;
            objImpressao.DrawString(Cliente, fontedadosclientedestaque, XBrushes.Black, retanguloparatexto, normal);
            retanguloparatexto.X += retanguloparatexto.Width;

            retanguloparatexto.Y += retanguloparatexto.Height + 2;
            retanguloparatexto.X = MargemNormal;

            retanguloparatexto.Width = 40;
            objImpressao.DrawString("CPF:", fontedadosclientedestaque, XBrushes.Black, retanguloparatexto, normal);
            retanguloparatexto.X += retanguloparatexto.Width;
            retanguloparatexto.Width = 70;
            objImpressao.DrawString(CPF, fontedadoscliente, XBrushes.Black, retanguloparatexto, normal);
            retanguloparatexto.X = MargemNormal;
            retanguloparatexto.Y += retanguloparatexto.Height + 2;



            retanguloparatexto.Width = 40;
            objImpressao.DrawString("Fone:", fontedestaque, XBrushes.Black, retanguloparatexto, normal);
            retanguloparatexto.X += retanguloparatexto.Width;
            retanguloparatexto.Width = 95;
            objImpressao.DrawString(Fone, fontegeral, XBrushes.Black, retanguloparatexto, normal);
            retanguloparatexto.X += retanguloparatexto.Width;

            retanguloparatexto.Width = 54;
            objImpressao.DrawString("Celular:", fontedestaque, XBrushes.Black, retanguloparatexto, normal);
            retanguloparatexto.X += retanguloparatexto.Width;
            retanguloparatexto.Width = 85;
            objImpressao.DrawString(Celular, fontegeral, XBrushes.Black, retanguloparatexto, normal);
            retanguloparatexto.X += retanguloparatexto.Width;

            retanguloparatexto.Y += retanguloparatexto.Height + 3;
            retanguloparatexto.X = MargemNormal;

            retanguloparatexto.Width = 90;
            objImpressao.DrawString("End. Principal:", fontedadosclientedestaque, XBrushes.Black, retanguloparatexto, normal);
            retanguloparatexto.Width = LarguradaFolhaSub - retanguloparatexto.X;
            retanguloparatexto.Y += retanguloparatexto.Height + 1;
            retanguloparatexto.X = MargemNormal;
            objImpressao.DrawString(Endereco, fontedadoscliente, XBrushes.Black, retanguloparatexto, normal);
            retanguloparatexto.X += retanguloparatexto.Width;

            retanguloparatexto.Y += retanguloparatexto.Height + 1;
            retanguloparatexto.X = MargemNormal;

            retanguloparatexto.Y += retanguloparatexto.Height;

            //Inicio Itens
            retanguloparatexto.X = MargemNormal;

            retanguloparatexto.Width = LarguradaFolhaSub - MargemNormal - MargemNormal;
            objImpressao.DrawString("Informações dos Itens", fonteseparadordestaque, XBrushes.Black, retanguloparatexto, centro);
            retanguloparatexto.Y += 10;
            objImpressao.DrawLine(XPens.Black, MargemNormal, retanguloparatexto.Y - 12, LarguradaFolhaSub, retanguloparatexto.Y - 12);
            objImpressao.DrawLine(XPens.Black, MargemNormal, retanguloparatexto.Y + 5, LarguradaFolhaSub, retanguloparatexto.Y + 5);
            retanguloparatexto.X += retanguloparatexto.Width;

            retanguloparatexto.Y += 10;
            retanguloparatexto.X = MargemNormal;

            retanguloparatexto.Height = fontedadositensdestaque.Height + 2;

            Double LarguraColunaDescricao, LarguraColunaQntd, LarguraColunaValorUnit, LarguraColunaValorTotal;
            LarguraColunaQntd = 45;
            LarguraColunaValorUnit = 85;
            LarguraColunaValorTotal = 85;
            LarguraColunaDescricao = LarguradaFolhaSub - MargemNormal - LarguraColunaQntd - LarguraColunaValorUnit - LarguraColunaValorTotal;

            retanguloparatexto.Width = LarguraColunaQntd;
            objImpressao.DrawRectangle(XPens.Black, retanguloparatexto);
            objImpressao.DrawString("Qntd", fontedadositensdestaque, XBrushes.Black, retanguloparatexto, centro);
            retanguloparatexto.X += retanguloparatexto.Width;

            retanguloparatexto.Width = LarguraColunaDescricao;
            objImpressao.DrawRectangle(XPens.Black, retanguloparatexto);
            objImpressao.DrawString("Descrição", fontedadositensdestaque, XBrushes.Black, retanguloparatexto, centro);
            retanguloparatexto.X += retanguloparatexto.Width;

            retanguloparatexto.Width = LarguraColunaValorUnit;
            objImpressao.DrawRectangle(XPens.Black, retanguloparatexto);
            objImpressao.DrawString("V. Unit.", fontedadositensdestaque, XBrushes.Black, retanguloparatexto, centro);
            retanguloparatexto.X += retanguloparatexto.Width;

            retanguloparatexto.Width = LarguraColunaValorTotal;
            objImpressao.DrawRectangle(XPens.Black, retanguloparatexto);
            objImpressao.DrawString("V. Total", fontedadositensdestaque, XBrushes.Black, retanguloparatexto, centro);
            retanguloparatexto.X += retanguloparatexto.Width;

            retanguloparatexto.Y += retanguloparatexto.Height;

            decimal ValorTotal = 0;
            for (int i = 0; i < dgItens.Rows.Count; i++)
            {
                retanguloparatexto.X = MargemNormal;
                retanguloparatexto.Height = fontedadositens.Height + 0;

                retanguloparatexto.Width = LarguraColunaQntd;
                objImpressao.DrawRectangle(XPens.Black, retanguloparatexto);
                objImpressao.DrawString(dgItens.Rows[i].Cells["Qntd"].Value.ToString(), fontedadositens, XBrushes.Black, retanguloparatexto, centro);
                retanguloparatexto.X += retanguloparatexto.Width;

                retanguloparatexto.Width = LarguraColunaDescricao;
                objImpressao.DrawRectangle(XPens.Black, retanguloparatexto);
                objImpressao.DrawString(dgItens.Rows[i].Cells["Produto"].Value.ToString(), fontedadositens, XBrushes.Black, retanguloparatexto, centro);
                retanguloparatexto.X += retanguloparatexto.Width;

                retanguloparatexto.Width = LarguraColunaValorUnit;
                objImpressao.DrawRectangle(XPens.Black, retanguloparatexto);
                objImpressao.DrawString(dgItens.Rows[i].Cells["ValorUnit"].Value.ToString(), fontedadositens, XBrushes.Black, retanguloparatexto, centro);
                retanguloparatexto.X += retanguloparatexto.Width;

                retanguloparatexto.Width = LarguraColunaValorTotal;
                objImpressao.DrawRectangle(XPens.Black, retanguloparatexto);
                objImpressao.DrawString(dgItens.Rows[i].Cells["Total"].Value.ToString(), fontedadositens, XBrushes.Black, retanguloparatexto, centro);
                retanguloparatexto.X += retanguloparatexto.Width;

                ValorTotal += Convert.ToDecimal(dgItens.Rows[i].Cells["Total"].Value.ToString().Replace("R$", "").Replace(" ", ""));

                retanguloparatexto.Y += retanguloparatexto.Height;
            }

            retanguloparatexto.Y += 4;
            //FIM Itens

            retanguloparatexto.X = MargemNormal;

            retanguloparatexto.Height = fontevalortotalitensdestaque.Height;

            retanguloparatexto.Width = LarguradaFolhaSub - MargemNormal - LarguraColunaValorUnit - LarguraColunaValorTotal;
            objImpressao.DrawString("TOTAL EM PRODUTOS", fontevalortotalitensdestaque, XBrushes.Black, retanguloparatexto, normal);
            retanguloparatexto.X += retanguloparatexto.Width;

            retanguloparatexto.Width = LarguradaFolhaSub - retanguloparatexto.X;
            objImpressao.DrawString("R$ " + Convert.ToString(ValorTotal), fontevalortotalitens, XBrushes.Black, retanguloparatexto, invertido);
            retanguloparatexto.X += retanguloparatexto.Width;

            retanguloparatexto.Y += retanguloparatexto.Height;
            retanguloparatexto.X = MargemNormal;
            //Fim Informações da Venda

            SalvarPedidoemPDF(pdf, SalvarEm);
                      
            if (MessageBox.Show("Arquivo convertido com sucesso. Deseja visualizar o arquivo salvo?", "Criar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Process.Start(SalvarEm);
            }

            return SalvarEm;
        }

        public void EnviarEmail(string enviarpara, string assunto, RichTextBox mensagem, string email, string senha, int porta, string hostsub, ListView lstAnexo)
        {

            if (senha.ToString() == "")
            {
                MessageBox.Show("O campo 'Senha' é obrigatório.");
                return;
            }

            if (email.ToString() == "")
            {
                MessageBox.Show("O campo 'Login (E-mail)' é obrigatório.");
                return;
            }

            if (enviarpara.ToString() == "")
            {
                MessageBox.Show("O campo 'Destinatário' é obrigatório.");
                return;
            }


            //Eviar E-Mail
            MailMessage mail = new MailMessage();

            //E-mail de pra quem vai ser enviado...
            string Para = enviarpara;
            SmtpClient SmtpServer = new SmtpClient();
            SmtpServer.Credentials = new System.Net.NetworkCredential(email, senha);
            SmtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
            mail.Priority = MailPriority.High;
            SmtpServer.Port = porta;
            SmtpServer.Host = hostsub;
            mail = new MailMessage();

            mail.From = new MailAddress(Para, "U.E.A Solutions Uninove");
            mail.Bcc.Add(Para);
            mail.IsBodyHtml = true;
            mail.Subject = assunto;
            mail.Body = mensagem.Text;

            int l, tl;
            l = 0;
            tl = lstAnexo.Items.Count;

            while (l < tl)
            {

                try
                {                    
                    mail.Attachments.Add(new System.Net.Mail.Attachment(lstAnexo.Items[l].SubItems[1].Text.ToString()));
                }
                catch (Exception)
                {
                    MessageBox.Show("O Arquivo " + lstAnexo.Items[l].Text.ToString() + " não foi encontrado no computador, por isso não é possivel envia-lo como Anexo.");
                }
                l++;
            }

            try
            {
                SmtpServer.EnableSsl = true;
                mail.DeliveryNotificationOptions = System.Net.Mail.DeliveryNotificationOptions.OnFailure;
                SmtpServer.Send(mail);
                mail.Attachments.Clear();
                MessageBox.Show("E-mail Enviado com sucesso! Peça sempre para que o cliente verifique se o e-mail não está na caixa de Spam.");
            }
            catch (Exception)
            {
              MessageBox.Show("Verifique se o E-mail foi enviado.");
            }
        }

    }
}



