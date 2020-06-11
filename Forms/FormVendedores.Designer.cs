namespace WindowsFormsApp1.Forms
{
    partial class FormVendedores
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
            this.FuncionariosGridView = new System.Windows.Forms.DataGridView();
            this.btnSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FuncionariosGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // FuncionariosGridView
            // 
            this.FuncionariosGridView.AllowUserToResizeColumns = false;
            this.FuncionariosGridView.AllowUserToResizeRows = false;
            this.FuncionariosGridView.BackgroundColor = System.Drawing.Color.White;
            this.FuncionariosGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FuncionariosGridView.GridColor = System.Drawing.Color.Black;
            this.FuncionariosGridView.Location = new System.Drawing.Point(22, 63);
            this.FuncionariosGridView.Name = "FuncionariosGridView";
            this.FuncionariosGridView.RowHeadersVisible = false;
            this.FuncionariosGridView.Size = new System.Drawing.Size(839, 520);
            this.FuncionariosGridView.TabIndex = 0;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(22, 13);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(158, 44);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar Alterações";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // FormVendedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(882, 614);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.FuncionariosGridView);
            this.Name = "FormVendedores";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormVendedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FuncionariosGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView FuncionariosGridView;
        private System.Windows.Forms.Button btnSalvar;
    }
}