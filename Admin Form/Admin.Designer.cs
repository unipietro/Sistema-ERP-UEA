namespace WindowsFormsApp1.Admin_Form
{
    partial class Admin
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblEncontrado = new System.Windows.Forms.Label();
            this.btnCriarBD = new System.Windows.Forms.Button();
            this.btnCriaTabela = new System.Windows.Forms.Button();
            this.btnCarregaTabela = new System.Windows.Forms.Button();
            this.btnCarregaGrid = new System.Windows.Forms.Button();
            this.btnLerRegis = new System.Windows.Forms.Button();
            this.dgvBanco = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanco)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Encontrado:";
            // 
            // lblEncontrado
            // 
            this.lblEncontrado.Location = new System.Drawing.Point(13, 33);
            this.lblEncontrado.Name = "lblEncontrado";
            this.lblEncontrado.Size = new System.Drawing.Size(369, 178);
            this.lblEncontrado.TabIndex = 3;
            // 
            // btnCriarBD
            // 
            this.btnCriarBD.Location = new System.Drawing.Point(388, 33);
            this.btnCriarBD.Name = "btnCriarBD";
            this.btnCriarBD.Size = new System.Drawing.Size(134, 23);
            this.btnCriarBD.TabIndex = 2;
            this.btnCriarBD.Text = "Criar Banco de Dados";
            this.btnCriarBD.UseVisualStyleBackColor = true;
            this.btnCriarBD.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCriaTabela
            // 
            this.btnCriaTabela.Location = new System.Drawing.Point(388, 62);
            this.btnCriaTabela.Name = "btnCriaTabela";
            this.btnCriaTabela.Size = new System.Drawing.Size(134, 23);
            this.btnCriaTabela.TabIndex = 3;
            this.btnCriaTabela.Text = "Criar Tabela";
            this.btnCriaTabela.UseVisualStyleBackColor = true;
            this.btnCriaTabela.Click += new System.EventHandler(this.btnCriaTabela_Click);
            // 
            // btnCarregaTabela
            // 
            this.btnCarregaTabela.Location = new System.Drawing.Point(388, 91);
            this.btnCarregaTabela.Name = "btnCarregaTabela";
            this.btnCarregaTabela.Size = new System.Drawing.Size(134, 23);
            this.btnCarregaTabela.TabIndex = 4;
            this.btnCarregaTabela.Text = "Carregar Tabela";
            this.btnCarregaTabela.UseVisualStyleBackColor = true;
            this.btnCarregaTabela.Click += new System.EventHandler(this.btnCarregaTabela_Click);
            // 
            // btnCarregaGrid
            // 
            this.btnCarregaGrid.Location = new System.Drawing.Point(388, 120);
            this.btnCarregaGrid.Name = "btnCarregaGrid";
            this.btnCarregaGrid.Size = new System.Drawing.Size(134, 23);
            this.btnCarregaGrid.TabIndex = 5;
            this.btnCarregaGrid.Text = "Carregar Grid";
            this.btnCarregaGrid.UseVisualStyleBackColor = true;
            this.btnCarregaGrid.Click += new System.EventHandler(this.btnCarregaGrid_Click);
            // 
            // btnLerRegis
            // 
            this.btnLerRegis.Location = new System.Drawing.Point(388, 149);
            this.btnLerRegis.Name = "btnLerRegis";
            this.btnLerRegis.Size = new System.Drawing.Size(134, 23);
            this.btnLerRegis.TabIndex = 6;
            this.btnLerRegis.Text = "Ler Registros";
            this.btnLerRegis.UseVisualStyleBackColor = true;
            this.btnLerRegis.Click += new System.EventHandler(this.btnLerRegis_Click);
            // 
            // dgvBanco
            // 
            this.dgvBanco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBanco.Location = new System.Drawing.Point(16, 228);
            this.dgvBanco.Name = "dgvBanco";
            this.dgvBanco.Size = new System.Drawing.Size(506, 320);
            this.dgvBanco.TabIndex = 7;
            this.dgvBanco.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBanco_CellContentClick);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 560);
            this.Controls.Add(this.dgvBanco);
            this.Controls.Add(this.btnLerRegis);
            this.Controls.Add(this.btnCarregaGrid);
            this.Controls.Add(this.btnCarregaTabela);
            this.Controls.Add(this.btnCriaTabela);
            this.Controls.Add(this.btnCriarBD);
            this.Controls.Add(this.lblEncontrado);
            this.Controls.Add(this.label1);
            this.Name = "Admin";
            this.Text = "Admin";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEncontrado;
        private System.Windows.Forms.DataGridView dgvBanco;
        public System.Windows.Forms.Button btnCriarBD;
        public System.Windows.Forms.Button btnCriaTabela;
        public System.Windows.Forms.Button btnCarregaTabela;
        public System.Windows.Forms.Button btnCarregaGrid;
        public System.Windows.Forms.Button btnLerRegis;
    }
}