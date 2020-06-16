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
            this.btnSave = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.FuncionariosGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // FuncionariosGridView
            // 
            this.FuncionariosGridView.AllowUserToResizeColumns = false;
            this.FuncionariosGridView.AllowUserToResizeRows = false;
            this.FuncionariosGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FuncionariosGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(27)))), ((int)(((byte)(54)))));
            this.FuncionariosGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FuncionariosGridView.GridColor = System.Drawing.Color.Black;
            this.FuncionariosGridView.Location = new System.Drawing.Point(22, 63);
            this.FuncionariosGridView.Name = "FuncionariosGridView";
            this.FuncionariosGridView.RowHeadersVisible = false;
            this.FuncionariosGridView.Size = new System.Drawing.Size(839, 520);
            this.FuncionariosGridView.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSave.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnSave.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave.IconSize = 22;
            this.btnSave.Location = new System.Drawing.Point(22, 16);
            this.btnSave.Name = "btnSave";
            this.btnSave.Rotation = 0D;
            this.btnSave.Size = new System.Drawing.Size(164, 41);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Salvar Alterações";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FormVendedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(882, 614);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.FuncionariosGridView);
            this.Name = "FormVendedores";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormVendedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FuncionariosGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView FuncionariosGridView;
        private FontAwesome.Sharp.IconButton btnSave;
    }
}