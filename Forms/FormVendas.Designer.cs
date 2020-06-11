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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnNovaVenda = new FontAwesome.Sharp.IconButton();
            this.btnSyncVenda = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(834, 501);
            this.dataGridView1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(633, 66);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(226, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // btnNovaVenda
            // 
            this.btnNovaVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(29)))));
            this.btnNovaVenda.FlatAppearance.BorderSize = 0;
            this.btnNovaVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovaVenda.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnNovaVenda.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovaVenda.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnNovaVenda.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.btnNovaVenda.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnNovaVenda.IconSize = 30;
            this.btnNovaVenda.Location = new System.Drawing.Point(25, 33);
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
            this.btnSyncVenda.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSyncVenda.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSyncVenda.IconChar = FontAwesome.Sharp.IconChar.SyncAlt;
            this.btnSyncVenda.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnSyncVenda.IconSize = 26;
            this.btnSyncVenda.Location = new System.Drawing.Point(192, 34);
            this.btnSyncVenda.Name = "btnSyncVenda";
            this.btnSyncVenda.Rotation = 0D;
            this.btnSyncVenda.Size = new System.Drawing.Size(118, 40);
            this.btnSyncVenda.TabIndex = 4;
            this.btnSyncVenda.Text = "Atualizar";
            this.btnSyncVenda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSyncVenda.UseVisualStyleBackColor = true;
            // 
            // FormVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(882, 614);
            this.Controls.Add(this.btnSyncVenda);
            this.Controls.Add(this.btnNovaVenda);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormVendas";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private FontAwesome.Sharp.IconButton btnNovaVenda;
        private FontAwesome.Sharp.IconButton btnSyncVenda;
    }
}