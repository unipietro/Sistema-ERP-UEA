namespace WindowsFormsApp1.Admin_Form
{
    partial class FormLoginUser
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
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.senhatxt = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.logintxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.iconLogin = new FontAwesome.Sharp.IconPictureBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblacesso = new System.Windows.Forms.Label();
            this.lblvenda = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iconLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // btncancelar
            // 
            this.btncancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancelar.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btncancelar.Location = new System.Drawing.Point(292, 217);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(67, 30);
            this.btncancelar.TabIndex = 11;
            this.btncancelar.Text = "&Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnOk.Location = new System.Drawing.Point(12, 217);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(67, 30);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "&OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // senhatxt
            // 
            this.senhatxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(27)))), ((int)(((byte)(140)))));
            this.senhatxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.senhatxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senhatxt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.senhatxt.Location = new System.Drawing.Point(12, 180);
            this.senhatxt.Name = "senhatxt";
            this.senhatxt.PasswordChar = '*';
            this.senhatxt.Size = new System.Drawing.Size(347, 19);
            this.senhatxt.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Senha:";
            // 
            // logintxt
            // 
            this.logintxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(27)))), ((int)(((byte)(140)))));
            this.logintxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logintxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.logintxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logintxt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.logintxt.Location = new System.Drawing.Point(12, 120);
            this.logintxt.Name = "logintxt";
            this.logintxt.Size = new System.Drawing.Size(347, 19);
            this.logintxt.TabIndex = 7;
            this.logintxt.TextChanged += new System.EventHandler(this.logintxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Login:";
            // 
            // iconLogin
            // 
            this.iconLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(27)))), ((int)(((byte)(54)))));
            this.iconLogin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.iconLogin.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.iconLogin.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconLogin.IconSize = 57;
            this.iconLogin.Location = new System.Drawing.Point(12, 21);
            this.iconLogin.Name = "iconLogin";
            this.iconLogin.Size = new System.Drawing.Size(60, 57);
            this.iconLogin.TabIndex = 12;
            this.iconLogin.TabStop = false;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblLogin.Location = new System.Drawing.Point(78, 32);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(198, 25);
            this.lblLogin.TabIndex = 13;
            this.lblLogin.Text = "Entre em sua conta";
            // 
            // lblacesso
            // 
            this.lblacesso.AutoSize = true;
            this.lblacesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblacesso.ForeColor = System.Drawing.Color.White;
            this.lblacesso.Location = new System.Drawing.Point(95, 41);
            this.lblacesso.Name = "lblacesso";
            this.lblacesso.Size = new System.Drawing.Size(10, 13);
            this.lblacesso.TabIndex = 14;
            this.lblacesso.Text = "-";
            this.lblacesso.Visible = false;
            // 
            // lblvenda
            // 
            this.lblvenda.AutoSize = true;
            this.lblvenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvenda.ForeColor = System.Drawing.Color.White;
            this.lblvenda.Location = new System.Drawing.Point(199, 41);
            this.lblvenda.Name = "lblvenda";
            this.lblvenda.Size = new System.Drawing.Size(10, 13);
            this.lblvenda.TabIndex = 15;
            this.lblvenda.Text = "-";
            this.lblvenda.Visible = false;
            // 
            // FormLoginUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(27)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(371, 259);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.iconLogin);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.senhatxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.logintxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblvenda);
            this.Controls.Add(this.lblacesso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLoginUser";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLoginUser";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.iconLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.MaskedTextBox senhatxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconLogin;
        private System.Windows.Forms.Label lblLogin;
        public System.Windows.Forms.TextBox logintxt;
        public System.Windows.Forms.Label lblacesso;
        public System.Windows.Forms.Label lblvenda;
    }
}