namespace WindowsFormsApp1.Forms
{
    partial class FormEstoque
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
            this.ProdutosGridView = new System.Windows.Forms.DataGridView();
            this.btnSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProdutosGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ProdutosGridView
            // 
            this.ProdutosGridView.AllowUserToResizeColumns = false;
            this.ProdutosGridView.AllowUserToResizeRows = false;
            this.ProdutosGridView.BackgroundColor = System.Drawing.Color.White;
            this.ProdutosGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProdutosGridView.Enabled = false;
            this.ProdutosGridView.GridColor = System.Drawing.Color.Black;
            this.ProdutosGridView.Location = new System.Drawing.Point(22, 50);
            this.ProdutosGridView.MultiSelect = false;
            this.ProdutosGridView.Name = "ProdutosGridView";
            this.ProdutosGridView.RowHeadersVisible = false;
            this.ProdutosGridView.Size = new System.Drawing.Size(841, 546);
            this.ProdutosGridView.TabIndex = 0;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(22, 12);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(148, 32);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar Alterações";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // FormEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(882, 614);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.ProdutosGridView);
            this.Name = "FormEstoque";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.FormEstoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProdutosGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ProdutosGridView;
        private System.Windows.Forms.Button btnSalvar;
    }
}