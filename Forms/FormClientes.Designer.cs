﻿namespace WindowsFormsApp1.Forms
{
    partial class FormClientes
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
            this.ClientesGridView = new System.Windows.Forms.DataGridView();
            this.btnSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientesGridView
            // 
            this.ClientesGridView.AllowUserToResizeColumns = false;
            this.ClientesGridView.AllowUserToResizeRows = false;
            this.ClientesGridView.BackgroundColor = System.Drawing.Color.White;
            this.ClientesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientesGridView.GridColor = System.Drawing.Color.Black;
            this.ClientesGridView.Location = new System.Drawing.Point(22, 62);
            this.ClientesGridView.MultiSelect = false;
            this.ClientesGridView.Name = "ClientesGridView";
            this.ClientesGridView.RowHeadersVisible = false;
            this.ClientesGridView.Size = new System.Drawing.Size(841, 534);
            this.ClientesGridView.TabIndex = 0;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(22, 12);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(158, 44);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar Alterações";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(882, 614);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.ClientesGridView);
            this.Name = "FormClientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.FormClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClientesGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ClientesGridView;
        private System.Windows.Forms.Button btnSalvar;
    }
}