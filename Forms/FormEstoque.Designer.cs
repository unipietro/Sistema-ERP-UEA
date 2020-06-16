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
            this.btnSave = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.ProdutosGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ProdutosGridView
            // 
            this.ProdutosGridView.AllowUserToResizeColumns = false;
            this.ProdutosGridView.AllowUserToResizeRows = false;
            this.ProdutosGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProdutosGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(27)))), ((int)(((byte)(54)))));
            this.ProdutosGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProdutosGridView.GridColor = System.Drawing.Color.Black;
            this.ProdutosGridView.Location = new System.Drawing.Point(22, 62);
            this.ProdutosGridView.MultiSelect = false;
            this.ProdutosGridView.Name = "ProdutosGridView";
            this.ProdutosGridView.RowHeadersVisible = false;
            this.ProdutosGridView.Size = new System.Drawing.Size(841, 534);
            this.ProdutosGridView.TabIndex = 0;
            this.ProdutosGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProdutosGridView_CellContentClick);
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSave.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSave.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave.IconSize = 23;
            this.btnSave.Location = new System.Drawing.Point(22, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Rotation = 0D;
            this.btnSave.Size = new System.Drawing.Size(156, 42);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Salvar Alterações";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FormEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(882, 614);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ProdutosGridView);
            this.Name = "FormEstoque";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.FormEstoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProdutosGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ProdutosGridView;
        private FontAwesome.Sharp.IconButton btnSave;
    }
}