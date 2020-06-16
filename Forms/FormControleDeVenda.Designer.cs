namespace WindowsFormsApp1.Forms
{
    partial class FormControleDeVenda
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
            this.ItensGridView = new System.Windows.Forms.DataGridView();
            this.btnbuscavendedor = new System.Windows.Forms.Button();
            this.observacoestxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblnomefuncionario = new System.Windows.Forms.Label();
            this.codigoVendedorlbl = new System.Windows.Forms.Label();
            this.codigoacessotxt = new System.Windows.Forms.TextBox();
            this.totaltxt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnFinalizarCompra = new System.Windows.Forms.Button();
            this.cpftxt = new System.Windows.Forms.MaskedTextBox();
            this.codigoclientetxt = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.nometxt = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.telefonetxt = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ceptxt = new System.Windows.Forms.MaskedTextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.complementotxt = new System.Windows.Forms.TextBox();
            this.bairrotxt = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.ntxt = new System.Windows.Forms.TextBox();
            this.uftxt = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.logradourotxt = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cidadetxt = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.celulartxt = new System.Windows.Forms.TextBox();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statustxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.datavendatxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.obstxt = new System.Windows.Forms.TextBox();
            this.vendedortxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.codigovendatxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.valortxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnEmail = new FontAwesome.Sharp.IconButton();
            this.btnPdf = new FontAwesome.Sharp.IconButton();
            this.btncCancelarVenda = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.ItensGridView)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItensGridView
            // 
            this.ItensGridView.AllowUserToAddRows = false;
            this.ItensGridView.AllowUserToDeleteRows = false;
            this.ItensGridView.AllowUserToResizeColumns = false;
            this.ItensGridView.AllowUserToResizeRows = false;
            this.ItensGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(27)))), ((int)(((byte)(54)))));
            this.ItensGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItensGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(27)))), ((int)(((byte)(54)))));
            this.ItensGridView.Location = new System.Drawing.Point(22, 258);
            this.ItensGridView.MultiSelect = false;
            this.ItensGridView.Name = "ItensGridView";
            this.ItensGridView.ReadOnly = true;
            this.ItensGridView.RowHeadersVisible = false;
            this.ItensGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ItensGridView.Size = new System.Drawing.Size(841, 338);
            this.ItensGridView.TabIndex = 0;
            // 
            // btnbuscavendedor
            // 
            this.btnbuscavendedor.Location = new System.Drawing.Point(191, 639);
            this.btnbuscavendedor.Name = "btnbuscavendedor";
            this.btnbuscavendedor.Size = new System.Drawing.Size(15, 22);
            this.btnbuscavendedor.TabIndex = 53;
            this.btnbuscavendedor.Text = ">";
            this.btnbuscavendedor.UseVisualStyleBackColor = true;
            // 
            // observacoestxt
            // 
            this.observacoestxt.Location = new System.Drawing.Point(314, 640);
            this.observacoestxt.Name = "observacoestxt";
            this.observacoestxt.Size = new System.Drawing.Size(126, 20);
            this.observacoestxt.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(311, 624);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 51;
            this.label7.Text = "Observações:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(120, 627);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 56;
            this.label6.Text = "Cód. Acesso:";
            // 
            // lblnomefuncionario
            // 
            this.lblnomefuncionario.AutoSize = true;
            this.lblnomefuncionario.Location = new System.Drawing.Point(232, 643);
            this.lblnomefuncionario.Name = "lblnomefuncionario";
            this.lblnomefuncionario.Size = new System.Drawing.Size(10, 13);
            this.lblnomefuncionario.TabIndex = 55;
            this.lblnomefuncionario.Text = "-";
            // 
            // codigoVendedorlbl
            // 
            this.codigoVendedorlbl.AutoSize = true;
            this.codigoVendedorlbl.Location = new System.Drawing.Point(208, 643);
            this.codigoVendedorlbl.Name = "codigoVendedorlbl";
            this.codigoVendedorlbl.Size = new System.Drawing.Size(10, 13);
            this.codigoVendedorlbl.TabIndex = 54;
            this.codigoVendedorlbl.Text = "-";
            // 
            // codigoacessotxt
            // 
            this.codigoacessotxt.Location = new System.Drawing.Point(123, 640);
            this.codigoacessotxt.Name = "codigoacessotxt";
            this.codigoacessotxt.Size = new System.Drawing.Size(67, 20);
            this.codigoacessotxt.TabIndex = 50;
            // 
            // totaltxt
            // 
            this.totaltxt.Enabled = false;
            this.totaltxt.Location = new System.Drawing.Point(446, 640);
            this.totaltxt.Name = "totaltxt";
            this.totaltxt.Size = new System.Drawing.Size(100, 20);
            this.totaltxt.TabIndex = 48;
            this.totaltxt.Text = "R$ 0,00";
            this.totaltxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(443, 626);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 13);
            this.label13.TabIndex = 46;
            this.label13.Text = "Valor Total:";
            // 
            // btnFinalizarCompra
            // 
            this.btnFinalizarCompra.Location = new System.Drawing.Point(555, 627);
            this.btnFinalizarCompra.Name = "btnFinalizarCompra";
            this.btnFinalizarCompra.Size = new System.Drawing.Size(122, 34);
            this.btnFinalizarCompra.TabIndex = 49;
            this.btnFinalizarCompra.Text = "Finalizar Compra";
            this.btnFinalizarCompra.UseVisualStyleBackColor = true;
            // 
            // cpftxt
            // 
            this.cpftxt.Enabled = false;
            this.cpftxt.Location = new System.Drawing.Point(335, 30);
            this.cpftxt.Mask = "000,000,000-00";
            this.cpftxt.Name = "cpftxt";
            this.cpftxt.Size = new System.Drawing.Size(93, 20);
            this.cpftxt.TabIndex = 40;
            // 
            // codigoclientetxt
            // 
            this.codigoclientetxt.Enabled = false;
            this.codigoclientetxt.Location = new System.Drawing.Point(8, 30);
            this.codigoclientetxt.Name = "codigoclientetxt";
            this.codigoclientetxt.Size = new System.Drawing.Size(64, 20);
            this.codigoclientetxt.TabIndex = 31;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.nometxt);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.telefonetxt);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.cpftxt);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Controls.Add(this.label28);
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Controls.Add(this.celulartxt);
            this.groupBox4.Controls.Add(this.emailtxt);
            this.groupBox4.Controls.Add(this.codigoclientetxt);
            this.groupBox4.Controls.Add(this.label26);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(22, 127);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(841, 124);
            this.groupBox4.TabIndex = 31;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cliente";
            // 
            // nometxt
            // 
            this.nometxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nometxt.Enabled = false;
            this.nometxt.Location = new System.Drawing.Point(78, 30);
            this.nometxt.Name = "nometxt";
            this.nometxt.Size = new System.Drawing.Size(251, 20);
            this.nometxt.TabIndex = 57;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(6, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Código:";
            // 
            // telefonetxt
            // 
            this.telefonetxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.telefonetxt.Enabled = false;
            this.telefonetxt.Location = new System.Drawing.Point(527, 30);
            this.telefonetxt.Name = "telefonetxt";
            this.telefonetxt.Size = new System.Drawing.Size(89, 20);
            this.telefonetxt.TabIndex = 35;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(332, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "CPF:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(75, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 13);
            this.label16.TabIndex = 4;
            this.label16.Text = "Nome:";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.ceptxt);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.complementotxt);
            this.groupBox3.Controls.Add(this.bairrotxt);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.ntxt);
            this.groupBox3.Controls.Add(this.uftxt);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.logradourotxt);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.cidadetxt);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(8, 56);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(826, 60);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Endereço";
            // 
            // ceptxt
            // 
            this.ceptxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ceptxt.Enabled = false;
            this.ceptxt.Location = new System.Drawing.Point(743, 31);
            this.ceptxt.Mask = "00000-000";
            this.ceptxt.Name = "ceptxt";
            this.ceptxt.Size = new System.Drawing.Size(75, 20);
            this.ceptxt.TabIndex = 41;
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label23.AutoSize = true;
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(396, 15);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(37, 13);
            this.label23.TabIndex = 30;
            this.label23.Text = "Bairro:";
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(740, 15);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(31, 13);
            this.label20.TabIndex = 24;
            this.label20.Text = "CEP:";
            // 
            // complementotxt
            // 
            this.complementotxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.complementotxt.Enabled = false;
            this.complementotxt.Location = new System.Drawing.Point(322, 31);
            this.complementotxt.Name = "complementotxt";
            this.complementotxt.Size = new System.Drawing.Size(71, 20);
            this.complementotxt.TabIndex = 23;
            // 
            // bairrotxt
            // 
            this.bairrotxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bairrotxt.Enabled = false;
            this.bairrotxt.Location = new System.Drawing.Point(399, 31);
            this.bairrotxt.Name = "bairrotxt";
            this.bairrotxt.Size = new System.Drawing.Size(153, 20);
            this.bairrotxt.TabIndex = 29;
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(319, 15);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(74, 13);
            this.label19.TabIndex = 4;
            this.label19.Text = "Complemento:";
            // 
            // ntxt
            // 
            this.ntxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ntxt.Enabled = false;
            this.ntxt.Location = new System.Drawing.Point(267, 31);
            this.ntxt.Name = "ntxt";
            this.ntxt.Size = new System.Drawing.Size(49, 20);
            this.ntxt.TabIndex = 3;
            // 
            // uftxt
            // 
            this.uftxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uftxt.Enabled = false;
            this.uftxt.Location = new System.Drawing.Point(703, 31);
            this.uftxt.Name = "uftxt";
            this.uftxt.Size = new System.Drawing.Size(34, 20);
            this.uftxt.TabIndex = 28;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(264, 15);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(22, 13);
            this.label18.TabIndex = 2;
            this.label18.Text = "Nº:";
            // 
            // logradourotxt
            // 
            this.logradourotxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logradourotxt.Enabled = false;
            this.logradourotxt.Location = new System.Drawing.Point(7, 31);
            this.logradourotxt.Name = "logradourotxt";
            this.logradourotxt.Size = new System.Drawing.Size(254, 20);
            this.logradourotxt.TabIndex = 1;
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(700, 15);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(24, 13);
            this.label22.TabIndex = 27;
            this.label22.Text = "UF:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(4, 15);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Logradouro:";
            // 
            // cidadetxt
            // 
            this.cidadetxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cidadetxt.Enabled = false;
            this.cidadetxt.Location = new System.Drawing.Point(558, 31);
            this.cidadetxt.Name = "cidadetxt";
            this.cidadetxt.Size = new System.Drawing.Size(139, 20);
            this.cidadetxt.TabIndex = 26;
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(555, 15);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(43, 13);
            this.label21.TabIndex = 9;
            this.label21.Text = "Cidade:";
            // 
            // label28
            // 
            this.label28.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label28.AutoSize = true;
            this.label28.ForeColor = System.Drawing.Color.White;
            this.label28.Location = new System.Drawing.Point(524, 14);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(52, 13);
            this.label28.TabIndex = 34;
            this.label28.Text = "Telefone:";
            // 
            // label24
            // 
            this.label24.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label24.AutoSize = true;
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(431, 14);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(42, 13);
            this.label24.TabIndex = 0;
            this.label24.Text = "Celular:";
            // 
            // celulartxt
            // 
            this.celulartxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.celulartxt.Enabled = false;
            this.celulartxt.Location = new System.Drawing.Point(434, 30);
            this.celulartxt.Name = "celulartxt";
            this.celulartxt.Size = new System.Drawing.Size(87, 20);
            this.celulartxt.TabIndex = 1;
            // 
            // emailtxt
            // 
            this.emailtxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.emailtxt.Enabled = false;
            this.emailtxt.Location = new System.Drawing.Point(622, 30);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(212, 20);
            this.emailtxt.TabIndex = 33;
            // 
            // label26
            // 
            this.label26.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label26.AutoSize = true;
            this.label26.ForeColor = System.Drawing.Color.White;
            this.label26.Location = new System.Drawing.Point(619, 14);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(38, 13);
            this.label26.TabIndex = 32;
            this.label26.Text = "E-mail:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.statustxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.datavendatxt);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.obstxt);
            this.groupBox1.Controls.Add(this.vendedortxt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.codigovendatxt);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.valortxt);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(22, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(841, 60);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações da Venda";
            // 
            // statustxt
            // 
            this.statustxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.statustxt.Enabled = false;
            this.statustxt.Location = new System.Drawing.Point(721, 31);
            this.statustxt.Name = "statustxt";
            this.statustxt.Size = new System.Drawing.Size(113, 20);
            this.statustxt.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(718, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Status:";
            // 
            // datavendatxt
            // 
            this.datavendatxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.datavendatxt.Enabled = false;
            this.datavendatxt.Location = new System.Drawing.Point(73, 31);
            this.datavendatxt.Name = "datavendatxt";
            this.datavendatxt.Size = new System.Drawing.Size(116, 20);
            this.datavendatxt.TabIndex = 43;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(70, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 42;
            this.label10.Text = "Data da Venda:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(308, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Observações:";
            // 
            // obstxt
            // 
            this.obstxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.obstxt.Enabled = false;
            this.obstxt.Location = new System.Drawing.Point(311, 31);
            this.obstxt.Name = "obstxt";
            this.obstxt.Size = new System.Drawing.Size(328, 20);
            this.obstxt.TabIndex = 29;
            // 
            // vendedortxt
            // 
            this.vendedortxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.vendedortxt.Enabled = false;
            this.vendedortxt.Location = new System.Drawing.Point(195, 31);
            this.vendedortxt.Name = "vendedortxt";
            this.vendedortxt.Size = new System.Drawing.Size(110, 20);
            this.vendedortxt.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(192, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Vendedor:";
            // 
            // codigovendatxt
            // 
            this.codigovendatxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.codigovendatxt.Enabled = false;
            this.codigovendatxt.Location = new System.Drawing.Point(7, 31);
            this.codigovendatxt.Name = "codigovendatxt";
            this.codigovendatxt.Size = new System.Drawing.Size(60, 20);
            this.codigovendatxt.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(4, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Cód. Venda";
            // 
            // valortxt
            // 
            this.valortxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.valortxt.Enabled = false;
            this.valortxt.Location = new System.Drawing.Point(645, 31);
            this.valortxt.Name = "valortxt";
            this.valortxt.Size = new System.Drawing.Size(70, 20);
            this.valortxt.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(642, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Valor Total:";
            // 
            // btnEmail
            // 
            this.btnEmail.FlatAppearance.BorderSize = 0;
            this.btnEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmail.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmail.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEmail.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            this.btnEmail.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnEmail.IconSize = 25;
            this.btnEmail.Location = new System.Drawing.Point(378, 12);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Rotation = 0D;
            this.btnEmail.Size = new System.Drawing.Size(172, 43);
            this.btnEmail.TabIndex = 59;
            this.btnEmail.Text = "Enviar por E-Mail";
            this.btnEmail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmail.UseVisualStyleBackColor = true;
            this.btnEmail.Click += new System.EventHandler(this.btnEmail_Click);
            // 
            // btnPdf
            // 
            this.btnPdf.FlatAppearance.BorderSize = 0;
            this.btnPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPdf.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnPdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPdf.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPdf.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            this.btnPdf.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnPdf.IconSize = 25;
            this.btnPdf.Location = new System.Drawing.Point(200, 12);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Rotation = 0D;
            this.btnPdf.Size = new System.Drawing.Size(172, 43);
            this.btnPdf.TabIndex = 58;
            this.btnPdf.Text = "Exportar para PDF";
            this.btnPdf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPdf.UseVisualStyleBackColor = true;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // btncCancelarVenda
            // 
            this.btncCancelarVenda.FlatAppearance.BorderSize = 0;
            this.btncCancelarVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncCancelarVenda.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btncCancelarVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncCancelarVenda.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btncCancelarVenda.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btncCancelarVenda.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btncCancelarVenda.IconSize = 25;
            this.btncCancelarVenda.Location = new System.Drawing.Point(22, 12);
            this.btncCancelarVenda.Name = "btncCancelarVenda";
            this.btncCancelarVenda.Rotation = 0D;
            this.btncCancelarVenda.Size = new System.Drawing.Size(172, 43);
            this.btncCancelarVenda.TabIndex = 57;
            this.btncCancelarVenda.Text = "Cancelar Venda";
            this.btncCancelarVenda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncCancelarVenda.UseVisualStyleBackColor = true;
            this.btncCancelarVenda.Click += new System.EventHandler(this.btncCancelarVenda_Click);
            // 
            // FormControleDeVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(882, 614);
            this.Controls.Add(this.btnEmail);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.btncCancelarVenda);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnbuscavendedor);
            this.Controls.Add(this.observacoestxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.lblnomefuncionario);
            this.Controls.Add(this.codigoVendedorlbl);
            this.Controls.Add(this.codigoacessotxt);
            this.Controls.Add(this.totaltxt);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnFinalizarCompra);
            this.Controls.Add(this.ItensGridView);
            this.Name = "FormControleDeVenda";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.FormControleDeVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ItensGridView)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ItensGridView;
        private System.Windows.Forms.Button btnbuscavendedor;
        private System.Windows.Forms.TextBox observacoestxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblnomefuncionario;
        private System.Windows.Forms.Label codigoVendedorlbl;
        private System.Windows.Forms.TextBox codigoacessotxt;
        private System.Windows.Forms.TextBox totaltxt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnFinalizarCompra;
        private System.Windows.Forms.MaskedTextBox cpftxt;
        private System.Windows.Forms.TextBox codigoclientetxt;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox nometxt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox telefonetxt;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MaskedTextBox ceptxt;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox complementotxt;
        private System.Windows.Forms.TextBox bairrotxt;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox ntxt;
        private System.Windows.Forms.TextBox uftxt;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox logradourotxt;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox cidadetxt;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox celulartxt;
        private System.Windows.Forms.TextBox emailtxt;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox obstxt;
        private System.Windows.Forms.TextBox vendedortxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox valortxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox datavendatxt;
        private System.Windows.Forms.Label label10;
        private FontAwesome.Sharp.IconButton btncCancelarVenda;
        private FontAwesome.Sharp.IconButton btnPdf;
        private FontAwesome.Sharp.IconButton btnEmail;
        public System.Windows.Forms.TextBox codigovendatxt;
        private System.Windows.Forms.TextBox statustxt;
        private System.Windows.Forms.Label label2;
    }
}