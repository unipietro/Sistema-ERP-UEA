namespace WindowsFormsApp1.Forms
{
    partial class FormVendas
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
            this.VendasGridView = new System.Windows.Forms.DataGridView();
            this.Detalhes = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnNovaVenda = new FontAwesome.Sharp.IconButton();
            this.btnSyncVenda = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.VendasGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // VendasGridView
            // 
            this.VendasGridView.AllowUserToAddRows = false;
            this.VendasGridView.AllowUserToDeleteRows = false;
            this.VendasGridView.AllowUserToResizeColumns = false;
            this.VendasGridView.AllowUserToResizeRows = false;
            this.VendasGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VendasGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(27)))), ((int)(((byte)(54)))));
            this.VendasGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VendasGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Detalhes});
            this.VendasGridView.GridColor = System.Drawing.Color.Black;
            this.VendasGridView.Location = new System.Drawing.Point(25, 59);
            this.VendasGridView.MultiSelect = false;
            this.VendasGridView.Name = "VendasGridView";
            this.VendasGridView.ReadOnly = true;
            this.VendasGridView.RowHeadersVisible = false;
            this.VendasGridView.Size = new System.Drawing.Size(834, 543);
            this.VendasGridView.TabIndex = 0;
            this.VendasGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VendasGridView_CellContentClick);
            // 
            // Detalhes
            // 
            this.Detalhes.HeaderText = "Detalhes";
            this.Detalhes.Name = "Detalhes";
            this.Detalhes.ReadOnly = true;
            this.Detalhes.Text = "Detalhes";
            this.Detalhes.UseColumnTextForButtonValue = true;
            this.Detalhes.Width = 70;
            // 
            // btnNovaVenda
            // 
            this.btnNovaVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(29)))));
            this.btnNovaVenda.FlatAppearance.BorderSize = 0;
            this.btnNovaVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovaVenda.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnNovaVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovaVenda.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnNovaVenda.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.btnNovaVenda.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnNovaVenda.IconSize = 30;
            this.btnNovaVenda.Location = new System.Drawing.Point(25, 12);
            this.btnNovaVenda.Name = "btnNovaVenda";
            this.btnNovaVenda.Rotation = 0D;
            this.btnNovaVenda.Size = new System.Drawing.Size(150, 41);
            this.btnNovaVenda.TabIndex = 3;
            this.btnNovaVenda.Text = "Nova Venda";
            this.btnNovaVenda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovaVenda.UseVisualStyleBackColor = false;
            this.btnNovaVenda.Click += new System.EventHandler(this.btnNovaVenda_Click);
            // 
            // btnSyncVenda
            // 
            this.btnSyncVenda.CausesValidation = false;
            this.btnSyncVenda.FlatAppearance.BorderSize = 0;
            this.btnSyncVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSyncVenda.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSyncVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSyncVenda.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSyncVenda.IconChar = FontAwesome.Sharp.IconChar.SyncAlt;
            this.btnSyncVenda.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnSyncVenda.IconSize = 26;
            this.btnSyncVenda.Location = new System.Drawing.Point(192, 13);
            this.btnSyncVenda.Name = "btnSyncVenda";
            this.btnSyncVenda.Rotation = 0D;
            this.btnSyncVenda.Size = new System.Drawing.Size(118, 40);
            this.btnSyncVenda.TabIndex = 4;
            this.btnSyncVenda.Text = "Atualizar";
            this.btnSyncVenda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSyncVenda.UseVisualStyleBackColor = true;
            this.btnSyncVenda.Click += new System.EventHandler(this.btnSyncVenda_Click);
            // 
            // FormVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(882, 614);
            this.Controls.Add(this.btnSyncVenda);
            this.Controls.Add(this.btnNovaVenda);
            this.Controls.Add(this.VendasGridView);
            this.Name = "FormVendas";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FormVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VendasGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView VendasGridView;
        private FontAwesome.Sharp.IconButton btnNovaVenda;
        private FontAwesome.Sharp.IconButton btnSyncVenda;
        private System.Windows.Forms.DataGridViewButtonColumn Detalhes;
    }
}