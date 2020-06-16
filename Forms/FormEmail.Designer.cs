namespace WindowsFormsApp1.Forms
{
    partial class FormEmail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmail));
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRemove = new FontAwesome.Sharp.IconButton();
            this.btnAnexo = new FontAwesome.Sharp.IconButton();
            this.paracmb = new System.Windows.Forms.TextBox();
            this.mensagemtxt = new System.Windows.Forms.RichTextBox();
            this.lblnomeidoso = new System.Windows.Forms.Label();
            this.Anexoslstview = new System.Windows.Forms.ListView();
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.servidortxt = new System.Windows.Forms.TextBox();
            this.assuntotxt = new System.Windows.Forms.TextBox();
            this.portatxt = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.listemail = new System.Windows.Forms.ListBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.btnatualizar = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.Label25 = new System.Windows.Forms.Label();
            this.Label24 = new System.Windows.Forms.Label();
            this.senhatxt = new System.Windows.Forms.TextBox();
            this.btnenviar = new System.Windows.Forms.Button();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.btnRemove);
            this.GroupBox2.Controls.Add(this.btnAnexo);
            this.GroupBox2.Controls.Add(this.paracmb);
            this.GroupBox2.Controls.Add(this.mensagemtxt);
            this.GroupBox2.Controls.Add(this.lblnomeidoso);
            this.GroupBox2.Controls.Add(this.Anexoslstview);
            this.GroupBox2.Controls.Add(this.Label1);
            this.GroupBox2.Controls.Add(this.Label2);
            this.GroupBox2.Controls.Add(this.servidortxt);
            this.GroupBox2.Controls.Add(this.assuntotxt);
            this.GroupBox2.Controls.Add(this.portatxt);
            this.GroupBox2.Controls.Add(this.Label3);
            this.GroupBox2.Controls.Add(this.listemail);
            this.GroupBox2.Controls.Add(this.Label4);
            this.GroupBox2.Controls.Add(this.btnatualizar);
            this.GroupBox2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.GroupBox2.Location = new System.Drawing.Point(12, 81);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(693, 450);
            this.GroupBox2.TabIndex = 290;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Dados para E-Mail:";
            // 
            // btnRemove
            // 
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnRemove.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnRemove.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnRemove.IconSize = 22;
            this.btnRemove.Location = new System.Drawing.Point(595, 150);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Rotation = 0D;
            this.btnRemove.Size = new System.Drawing.Size(88, 37);
            this.btnRemove.TabIndex = 294;
            this.btnRemove.Text = "Remover arquivo";
            this.btnRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAnexo
            // 
            this.btnAnexo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnexo.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAnexo.IconChar = FontAwesome.Sharp.IconChar.Paperclip;
            this.btnAnexo.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnAnexo.IconSize = 21;
            this.btnAnexo.Location = new System.Drawing.Point(594, 107);
            this.btnAnexo.Name = "btnAnexo";
            this.btnAnexo.Rotation = 0D;
            this.btnAnexo.Size = new System.Drawing.Size(90, 37);
            this.btnAnexo.TabIndex = 293;
            this.btnAnexo.Text = "Anexar Arquivo";
            this.btnAnexo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnexo.UseVisualStyleBackColor = true;
            this.btnAnexo.Click += new System.EventHandler(this.btnAnexo_Click);
            // 
            // paracmb
            // 
            this.paracmb.Location = new System.Drawing.Point(6, 31);
            this.paracmb.Name = "paracmb";
            this.paracmb.Size = new System.Drawing.Size(679, 20);
            this.paracmb.TabIndex = 292;
            this.paracmb.Text = "rafaelrodenasbrito@hotmail.com";
            // 
            // mensagemtxt
            // 
            this.mensagemtxt.Location = new System.Drawing.Point(6, 193);
            this.mensagemtxt.Name = "mensagemtxt";
            this.mensagemtxt.Size = new System.Drawing.Size(679, 251);
            this.mensagemtxt.TabIndex = 291;
            this.mensagemtxt.Text = "onfodnsasidnps";
            // 
            // lblnomeidoso
            // 
            this.lblnomeidoso.AutoSize = true;
            this.lblnomeidoso.Location = new System.Drawing.Point(200, 312);
            this.lblnomeidoso.Name = "lblnomeidoso";
            this.lblnomeidoso.Size = new System.Drawing.Size(0, 13);
            this.lblnomeidoso.TabIndex = 286;
            this.lblnomeidoso.Visible = false;
            // 
            // Anexoslstview
            // 
            this.Anexoslstview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.ColumnHeader2,
            this.ColumnHeader3,
            this.ColumnHeader4});
            this.Anexoslstview.HideSelection = false;
            this.Anexoslstview.LargeImageList = this.ImageList1;
            this.Anexoslstview.Location = new System.Drawing.Point(6, 107);
            this.Anexoslstview.MultiSelect = false;
            this.Anexoslstview.Name = "Anexoslstview";
            this.Anexoslstview.RightToLeftLayout = true;
            this.Anexoslstview.Size = new System.Drawing.Size(581, 80);
            this.Anexoslstview.TabIndex = 5;
            this.Anexoslstview.UseCompatibleStateImageBehavior = false;
            // 
            // ImageList1
            // 
            this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
            this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList1.Images.SetKeyName(0, "arquivodesconhecido.png");
            this.ImageList1.Images.SetKeyName(1, "logoexcel2003.png");
            this.ImageList1.Images.SetKeyName(2, "logoexcel2007.png");
            this.ImageList1.Images.SetKeyName(3, "logopdf.png");
            this.ImageList1.Images.SetKeyName(4, "logoword.png");
            this.ImageList1.Images.SetKeyName(5, "logoword2003.png");
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(3, 16);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(32, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Para:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(3, 56);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(48, 13);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "Assunto:";
            // 
            // servidortxt
            // 
            this.servidortxt.Location = new System.Drawing.Point(253, 333);
            this.servidortxt.Name = "servidortxt";
            this.servidortxt.PasswordChar = '*';
            this.servidortxt.Size = new System.Drawing.Size(10, 20);
            this.servidortxt.TabIndex = 285;
            // 
            // assuntotxt
            // 
            this.assuntotxt.Location = new System.Drawing.Point(6, 70);
            this.assuntotxt.Name = "assuntotxt";
            this.assuntotxt.Size = new System.Drawing.Size(679, 20);
            this.assuntotxt.TabIndex = 4;
            // 
            // portatxt
            // 
            this.portatxt.Location = new System.Drawing.Point(253, 333);
            this.portatxt.Name = "portatxt";
            this.portatxt.PasswordChar = '*';
            this.portatxt.Size = new System.Drawing.Size(10, 20);
            this.portatxt.TabIndex = 284;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(6, 137);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(62, 13);
            this.Label3.TabIndex = 5;
            this.Label3.Text = "Mensagem:";
            // 
            // listemail
            // 
            this.listemail.FormattingEnabled = true;
            this.listemail.Location = new System.Drawing.Point(253, 333);
            this.listemail.Name = "listemail";
            this.listemail.Size = new System.Drawing.Size(10, 4);
            this.listemail.TabIndex = 283;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(3, 93);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(40, 13);
            this.Label4.TabIndex = 7;
            this.Label4.Text = "Anexo:";
            // 
            // btnatualizar
            // 
            this.btnatualizar.Location = new System.Drawing.Point(253, 331);
            this.btnatualizar.Name = "btnatualizar";
            this.btnatualizar.Size = new System.Drawing.Size(10, 23);
            this.btnatualizar.TabIndex = 14;
            this.btnatualizar.Text = "Atualizar";
            this.btnatualizar.UseVisualStyleBackColor = true;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.emailtxt);
            this.GroupBox1.Controls.Add(this.Label25);
            this.GroupBox1.Controls.Add(this.Label24);
            this.GroupBox1.Controls.Add(this.senhatxt);
            this.GroupBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(693, 67);
            this.GroupBox1.TabIndex = 289;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Meus Dados:";
            // 
            // emailtxt
            // 
            this.emailtxt.Location = new System.Drawing.Point(6, 30);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(553, 20);
            this.emailtxt.TabIndex = 292;
            this.emailtxt.Text = "rafaelrodenasbrito@hotmail.com";
            // 
            // Label25
            // 
            this.Label25.AutoSize = true;
            this.Label25.Location = new System.Drawing.Point(3, 16);
            this.Label25.Name = "Label25";
            this.Label25.Size = new System.Drawing.Size(188, 13);
            this.Label25.TabIndex = 280;
            this.Label25.Text = "Digite seu E-mail: (Login do remetente)";
            // 
            // Label24
            // 
            this.Label24.AutoSize = true;
            this.Label24.Location = new System.Drawing.Point(562, 16);
            this.Label24.Name = "Label24";
            this.Label24.Size = new System.Drawing.Size(89, 13);
            this.Label24.TabIndex = 281;
            this.Label24.Text = "Digite sua senha:";
            // 
            // senhatxt
            // 
            this.senhatxt.Location = new System.Drawing.Point(565, 30);
            this.senhatxt.Name = "senhatxt";
            this.senhatxt.Size = new System.Drawing.Size(120, 20);
            this.senhatxt.TabIndex = 1;
            this.senhatxt.Text = "rj2526634";
            // 
            // btnenviar
            // 
            this.btnenviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnenviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenviar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnenviar.Location = new System.Drawing.Point(615, 537);
            this.btnenviar.Name = "btnenviar";
            this.btnenviar.Size = new System.Drawing.Size(90, 36);
            this.btnenviar.TabIndex = 291;
            this.btnenviar.Text = "Enviar";
            this.btnenviar.UseVisualStyleBackColor = true;
            this.btnenviar.Click += new System.EventHandler(this.btnenviar_Click);
            // 
            // FormEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(716, 579);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.btnenviar);
            this.Name = "FormEmail";
            this.Text = "FormEmail";
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox2;
        private System.Windows.Forms.RichTextBox mensagemtxt;
        internal System.Windows.Forms.Label lblnomeidoso;
        internal System.Windows.Forms.ListView Anexoslstview;
        internal System.Windows.Forms.ColumnHeader ColumnHeader1;
        internal System.Windows.Forms.ColumnHeader ColumnHeader2;
        internal System.Windows.Forms.ColumnHeader ColumnHeader3;
        internal System.Windows.Forms.ColumnHeader ColumnHeader4;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox servidortxt;
        internal System.Windows.Forms.TextBox assuntotxt;
        internal System.Windows.Forms.TextBox portatxt;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.ListBox listemail;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Button btnatualizar;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox emailtxt;
        internal System.Windows.Forms.Label Label25;
        internal System.Windows.Forms.Label Label24;
        internal System.Windows.Forms.TextBox senhatxt;
        internal System.Windows.Forms.Button btnenviar;
        internal System.Windows.Forms.TextBox paracmb;
        internal System.Windows.Forms.ImageList ImageList1;
        private FontAwesome.Sharp.IconButton btnAnexo;
        private FontAwesome.Sharp.IconButton btnRemove;
    }
}