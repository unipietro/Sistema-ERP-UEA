namespace WindowsFormsApp1.Forms
{
    partial class FormEfetuarVenda
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
            this.tabProduto = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.codigotxt = new System.Windows.Forms.TextBox();
            this.valorunittxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.estoquetxt = new System.Windows.Forms.TextBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.descricaocmb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Produto = new System.Windows.Forms.TabControl();
            this.tabCliente = new System.Windows.Forms.TabPage();
            this.cpftxt = new System.Windows.Forms.MaskedTextBox();
            this.btnLimparCampos = new System.Windows.Forms.Button();
            this.codigoclientetxt = new System.Windows.Forms.TextBox();
            this.cmbnomecliente = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.telefonetxt = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.celulartxt = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ceptxt = new System.Windows.Forms.MaskedTextBox();
            this.btncep = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.bairrotxt = new System.Windows.Forms.TextBox();
            this.uftxt = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.cidadetxt = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.complementotxt = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.ntxt = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.logradourotxt = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnSalvarCliente = new System.Windows.Forms.Button();
            this.btnBuscarCPF = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.totaltxt = new System.Windows.Forms.TextBox();
            this.btnFinalizarCompra = new System.Windows.Forms.Button();
            this.codigoacessotxt = new System.Windows.Forms.TextBox();
            this.codigoVendedorlbl = new System.Windows.Forms.Label();
            this.lblnomefuncionario = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ItensGridView = new System.Windows.Forms.DataGridView();
            this.observacoestxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnbuscavendedor = new System.Windows.Forms.Button();
            this.id_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qntd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorunit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valortotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custototal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custounittxt = new System.Windows.Forms.TextBox();
            this.qntdtxt = new System.Windows.Forms.NumericUpDown();
            this.tabProduto.SuspendLayout();
            this.Produto.SuspendLayout();
            this.tabCliente.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItensGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qntdtxt)).BeginInit();
            this.SuspendLayout();
            // 
            // tabProduto
            // 
            this.tabProduto.Controls.Add(this.descricaocmb);
            this.tabProduto.Controls.Add(this.qntdtxt);
            this.tabProduto.Controls.Add(this.custounittxt);
            this.tabProduto.Controls.Add(this.label4);
            this.tabProduto.Controls.Add(this.codigotxt);
            this.tabProduto.Controls.Add(this.valorunittxt);
            this.tabProduto.Controls.Add(this.label5);
            this.tabProduto.Controls.Add(this.btnLimpar);
            this.tabProduto.Controls.Add(this.estoquetxt);
            this.tabProduto.Controls.Add(this.btnRemover);
            this.tabProduto.Controls.Add(this.btnInserir);
            this.tabProduto.Controls.Add(this.label3);
            this.tabProduto.Controls.Add(this.label2);
            this.tabProduto.Controls.Add(this.label1);
            this.tabProduto.Location = new System.Drawing.Point(4, 22);
            this.tabProduto.Name = "tabProduto";
            this.tabProduto.Padding = new System.Windows.Forms.Padding(3);
            this.tabProduto.Size = new System.Drawing.Size(556, 268);
            this.tabProduto.TabIndex = 0;
            this.tabProduto.Text = "Produto";
            this.tabProduto.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(397, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Valor Un.:";
            // 
            // codigotxt
            // 
            this.codigotxt.Enabled = false;
            this.codigotxt.Location = new System.Drawing.Point(9, 19);
            this.codigotxt.Name = "codigotxt";
            this.codigotxt.Size = new System.Drawing.Size(70, 20);
            this.codigotxt.TabIndex = 15;
            // 
            // valorunittxt
            // 
            this.valorunittxt.BackColor = System.Drawing.Color.White;
            this.valorunittxt.Enabled = false;
            this.valorunittxt.ForeColor = System.Drawing.Color.Black;
            this.valorunittxt.Location = new System.Drawing.Point(400, 19);
            this.valorunittxt.Name = "valorunittxt";
            this.valorunittxt.Size = new System.Drawing.Size(70, 20);
            this.valorunittxt.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(473, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Estoque:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(300, 45);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(246, 33);
            this.btnLimpar.TabIndex = 14;
            this.btnLimpar.Text = "Limpar Lista";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // estoquetxt
            // 
            this.estoquetxt.BackColor = System.Drawing.Color.White;
            this.estoquetxt.Enabled = false;
            this.estoquetxt.ForeColor = System.Drawing.Color.Black;
            this.estoquetxt.Location = new System.Drawing.Point(476, 19);
            this.estoquetxt.Name = "estoquetxt";
            this.estoquetxt.Size = new System.Drawing.Size(70, 20);
            this.estoquetxt.TabIndex = 8;
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(174, 44);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(120, 33);
            this.btnRemover.TabIndex = 13;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(9, 44);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(120, 33);
            this.btnInserir.TabIndex = 12;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quantidade:";
            // 
            // descricaocmb
            // 
            this.descricaocmb.FormattingEnabled = true;
            this.descricaocmb.Location = new System.Drawing.Point(84, 18);
            this.descricaocmb.Name = "descricaocmb";
            this.descricaocmb.Size = new System.Drawing.Size(245, 21);
            this.descricaocmb.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descrição:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // Produto
            // 
            this.Produto.Controls.Add(this.tabProduto);
            this.Produto.Controls.Add(this.tabCliente);
            this.Produto.Location = new System.Drawing.Point(0, 0);
            this.Produto.Name = "Produto";
            this.Produto.SelectedIndex = 0;
            this.Produto.Size = new System.Drawing.Size(564, 294);
            this.Produto.TabIndex = 0;
            this.Produto.SelectedIndexChanged += new System.EventHandler(this.Produto_SelectedIndexChanged);
            // 
            // tabCliente
            // 
            this.tabCliente.Controls.Add(this.cpftxt);
            this.tabCliente.Controls.Add(this.btnLimparCampos);
            this.tabCliente.Controls.Add(this.codigoclientetxt);
            this.tabCliente.Controls.Add(this.cmbnomecliente);
            this.tabCliente.Controls.Add(this.groupBox4);
            this.tabCliente.Controls.Add(this.groupBox3);
            this.tabCliente.Controls.Add(this.btnSalvarCliente);
            this.tabCliente.Controls.Add(this.btnBuscarCPF);
            this.tabCliente.Controls.Add(this.label16);
            this.tabCliente.Controls.Add(this.label15);
            this.tabCliente.Controls.Add(this.label14);
            this.tabCliente.Location = new System.Drawing.Point(4, 22);
            this.tabCliente.Name = "tabCliente";
            this.tabCliente.Padding = new System.Windows.Forms.Padding(3);
            this.tabCliente.Size = new System.Drawing.Size(556, 268);
            this.tabCliente.TabIndex = 1;
            this.tabCliente.Text = "Cliente";
            this.tabCliente.UseVisualStyleBackColor = true;
            // 
            // cpftxt
            // 
            this.cpftxt.Location = new System.Drawing.Point(78, 19);
            this.cpftxt.Mask = "000,000,000-00";
            this.cpftxt.Name = "cpftxt";
            this.cpftxt.Size = new System.Drawing.Size(93, 20);
            this.cpftxt.TabIndex = 40;
            this.cpftxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cpftxt_KeyPress);
            // 
            // btnLimparCampos
            // 
            this.btnLimparCampos.Location = new System.Drawing.Point(9, 228);
            this.btnLimparCampos.Name = "btnLimparCampos";
            this.btnLimparCampos.Size = new System.Drawing.Size(266, 30);
            this.btnLimparCampos.TabIndex = 39;
            this.btnLimparCampos.Text = "Limpar Campos para Cadastro";
            this.btnLimparCampos.UseVisualStyleBackColor = true;
            this.btnLimparCampos.Click += new System.EventHandler(this.btnLimparCampos_Click);
            // 
            // codigoclientetxt
            // 
            this.codigoclientetxt.Enabled = false;
            this.codigoclientetxt.Location = new System.Drawing.Point(8, 19);
            this.codigoclientetxt.Name = "codigoclientetxt";
            this.codigoclientetxt.Size = new System.Drawing.Size(64, 20);
            this.codigoclientetxt.TabIndex = 31;
            // 
            // cmbnomecliente
            // 
            this.cmbnomecliente.FormattingEnabled = true;
            this.cmbnomecliente.Location = new System.Drawing.Point(191, 18);
            this.cmbnomecliente.Name = "cmbnomecliente";
            this.cmbnomecliente.Size = new System.Drawing.Size(355, 21);
            this.cmbnomecliente.TabIndex = 38;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.telefonetxt);
            this.groupBox4.Controls.Add(this.label28);
            this.groupBox4.Controls.Add(this.emailtxt);
            this.groupBox4.Controls.Add(this.label26);
            this.groupBox4.Controls.Add(this.celulartxt);
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Location = new System.Drawing.Point(8, 154);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(538, 68);
            this.groupBox4.TabIndex = 31;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Contato";
            // 
            // telefonetxt
            // 
            this.telefonetxt.Location = new System.Drawing.Point(103, 32);
            this.telefonetxt.Name = "telefonetxt";
            this.telefonetxt.Size = new System.Drawing.Size(89, 20);
            this.telefonetxt.TabIndex = 35;
            this.telefonetxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(100, 16);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(52, 13);
            this.label28.TabIndex = 34;
            this.label28.Text = "Telefone:";
            // 
            // emailtxt
            // 
            this.emailtxt.Location = new System.Drawing.Point(198, 32);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(332, 20);
            this.emailtxt.TabIndex = 33;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(195, 16);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(38, 13);
            this.label26.TabIndex = 32;
            this.label26.Text = "E-mail:";
            // 
            // celulartxt
            // 
            this.celulartxt.Location = new System.Drawing.Point(10, 32);
            this.celulartxt.Name = "celulartxt";
            this.celulartxt.Size = new System.Drawing.Size(87, 20);
            this.celulartxt.TabIndex = 1;
            this.celulartxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(7, 16);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(42, 13);
            this.label24.TabIndex = 0;
            this.label24.Text = "Celular:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ceptxt);
            this.groupBox3.Controls.Add(this.btncep);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.bairrotxt);
            this.groupBox3.Controls.Add(this.uftxt);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.cidadetxt);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.complementotxt);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.ntxt);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.logradourotxt);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Location = new System.Drawing.Point(9, 46);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(537, 102);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Endereço";
            // 
            // ceptxt
            // 
            this.ceptxt.Location = new System.Drawing.Point(9, 71);
            this.ceptxt.Mask = "00000-000";
            this.ceptxt.Name = "ceptxt";
            this.ceptxt.Size = new System.Drawing.Size(61, 20);
            this.ceptxt.TabIndex = 41;
            this.ceptxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ceptxt_KeyPress);
            // 
            // btncep
            // 
            this.btncep.Location = new System.Drawing.Point(71, 70);
            this.btncep.Name = "btncep";
            this.btncep.Size = new System.Drawing.Size(15, 22);
            this.btncep.TabIndex = 39;
            this.btncep.Text = ">";
            this.btncep.UseVisualStyleBackColor = true;
            this.btncep.Click += new System.EventHandler(this.btncep_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(248, 55);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(37, 13);
            this.label23.TabIndex = 30;
            this.label23.Text = "Bairro:";
            // 
            // bairrotxt
            // 
            this.bairrotxt.Location = new System.Drawing.Point(251, 71);
            this.bairrotxt.Name = "bairrotxt";
            this.bairrotxt.Size = new System.Drawing.Size(278, 20);
            this.bairrotxt.TabIndex = 29;
            // 
            // uftxt
            // 
            this.uftxt.Location = new System.Drawing.Point(211, 71);
            this.uftxt.Name = "uftxt";
            this.uftxt.Size = new System.Drawing.Size(34, 20);
            this.uftxt.TabIndex = 28;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(208, 55);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(24, 13);
            this.label22.TabIndex = 27;
            this.label22.Text = "UF:";
            // 
            // cidadetxt
            // 
            this.cidadetxt.Location = new System.Drawing.Point(90, 71);
            this.cidadetxt.Name = "cidadetxt";
            this.cidadetxt.Size = new System.Drawing.Size(115, 20);
            this.cidadetxt.TabIndex = 26;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(87, 55);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(43, 13);
            this.label21.TabIndex = 9;
            this.label21.Text = "Cidade:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 55);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(31, 13);
            this.label20.TabIndex = 24;
            this.label20.Text = "CEP:";
            // 
            // complementotxt
            // 
            this.complementotxt.Location = new System.Drawing.Point(362, 32);
            this.complementotxt.Name = "complementotxt";
            this.complementotxt.Size = new System.Drawing.Size(167, 20);
            this.complementotxt.TabIndex = 23;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(359, 16);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(74, 13);
            this.label19.TabIndex = 4;
            this.label19.Text = "Complemento:";
            // 
            // ntxt
            // 
            this.ntxt.Location = new System.Drawing.Point(308, 32);
            this.ntxt.Name = "ntxt";
            this.ntxt.Size = new System.Drawing.Size(48, 20);
            this.ntxt.TabIndex = 3;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(305, 16);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(22, 13);
            this.label18.TabIndex = 2;
            this.label18.Text = "Nº:";
            // 
            // logradourotxt
            // 
            this.logradourotxt.Location = new System.Drawing.Point(9, 32);
            this.logradourotxt.Name = "logradourotxt";
            this.logradourotxt.Size = new System.Drawing.Size(290, 20);
            this.logradourotxt.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 16);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Logradouro:";
            // 
            // btnSalvarCliente
            // 
            this.btnSalvarCliente.Location = new System.Drawing.Point(280, 228);
            this.btnSalvarCliente.Name = "btnSalvarCliente";
            this.btnSalvarCliente.Size = new System.Drawing.Size(266, 30);
            this.btnSalvarCliente.TabIndex = 7;
            this.btnSalvarCliente.Text = "Salvar Alterações do Cliente";
            this.btnSalvarCliente.UseVisualStyleBackColor = true;
            this.btnSalvarCliente.Click += new System.EventHandler(this.btnSalvarCliente_Click);
            // 
            // btnBuscarCPF
            // 
            this.btnBuscarCPF.Location = new System.Drawing.Point(172, 18);
            this.btnBuscarCPF.Name = "btnBuscarCPF";
            this.btnBuscarCPF.Size = new System.Drawing.Size(15, 22);
            this.btnBuscarCPF.TabIndex = 6;
            this.btnBuscarCPF.Text = ">";
            this.btnBuscarCPF.UseVisualStyleBackColor = true;
            this.btnBuscarCPF.Click += new System.EventHandler(this.btnBuscarCPF_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(188, 5);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 13);
            this.label16.TabIndex = 4;
            this.label16.Text = "Nome:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(75, 5);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "CPF:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 5);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Código:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(324, 564);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "Valor Total:";
            // 
            // totaltxt
            // 
            this.totaltxt.Enabled = false;
            this.totaltxt.Location = new System.Drawing.Point(327, 578);
            this.totaltxt.Name = "totaltxt";
            this.totaltxt.Size = new System.Drawing.Size(100, 20);
            this.totaltxt.TabIndex = 22;
            this.totaltxt.Text = "R$ 0,00";
            this.totaltxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnFinalizarCompra
            // 
            this.btnFinalizarCompra.Location = new System.Drawing.Point(436, 565);
            this.btnFinalizarCompra.Name = "btnFinalizarCompra";
            this.btnFinalizarCompra.Size = new System.Drawing.Size(122, 34);
            this.btnFinalizarCompra.TabIndex = 23;
            this.btnFinalizarCompra.Text = "Finalizar Compra";
            this.btnFinalizarCompra.UseVisualStyleBackColor = true;
            this.btnFinalizarCompra.Click += new System.EventHandler(this.btnFinalizarCompra_Click);
            // 
            // codigoacessotxt
            // 
            this.codigoacessotxt.Location = new System.Drawing.Point(4, 578);
            this.codigoacessotxt.Name = "codigoacessotxt";
            this.codigoacessotxt.Size = new System.Drawing.Size(67, 20);
            this.codigoacessotxt.TabIndex = 29;
            this.codigoacessotxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.codigoacessotxt_KeyPress);
            // 
            // codigoVendedorlbl
            // 
            this.codigoVendedorlbl.AutoSize = true;
            this.codigoVendedorlbl.Location = new System.Drawing.Point(89, 581);
            this.codigoVendedorlbl.Name = "codigoVendedorlbl";
            this.codigoVendedorlbl.Size = new System.Drawing.Size(10, 13);
            this.codigoVendedorlbl.TabIndex = 42;
            this.codigoVendedorlbl.Text = "-";
            // 
            // lblnomefuncionario
            // 
            this.lblnomefuncionario.AutoSize = true;
            this.lblnomefuncionario.Location = new System.Drawing.Point(113, 581);
            this.lblnomefuncionario.Name = "lblnomefuncionario";
            this.lblnomefuncionario.Size = new System.Drawing.Size(10, 13);
            this.lblnomefuncionario.TabIndex = 43;
            this.lblnomefuncionario.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 565);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Cód. Acesso:";
            // 
            // ItensGridView
            // 
            this.ItensGridView.AllowUserToAddRows = false;
            this.ItensGridView.AllowUserToDeleteRows = false;
            this.ItensGridView.BackgroundColor = System.Drawing.Color.White;
            this.ItensGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItensGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_produto,
            this.qntd,
            this.prod,
            this.valorunit,
            this.valortotal,
            this.custototal});
            this.ItensGridView.GridColor = System.Drawing.Color.Black;
            this.ItensGridView.Location = new System.Drawing.Point(0, 300);
            this.ItensGridView.MultiSelect = false;
            this.ItensGridView.Name = "ItensGridView";
            this.ItensGridView.ReadOnly = true;
            this.ItensGridView.RowHeadersVisible = false;
            this.ItensGridView.RowHeadersWidth = 12;
            this.ItensGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ItensGridView.Size = new System.Drawing.Size(562, 256);
            this.ItensGridView.TabIndex = 15;
            // 
            // observacoestxt
            // 
            this.observacoestxt.Location = new System.Drawing.Point(195, 578);
            this.observacoestxt.Name = "observacoestxt";
            this.observacoestxt.Size = new System.Drawing.Size(126, 20);
            this.observacoestxt.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(192, 562);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Observações:";
            // 
            // btnbuscavendedor
            // 
            this.btnbuscavendedor.Location = new System.Drawing.Point(72, 577);
            this.btnbuscavendedor.Name = "btnbuscavendedor";
            this.btnbuscavendedor.Size = new System.Drawing.Size(15, 22);
            this.btnbuscavendedor.TabIndex = 41;
            this.btnbuscavendedor.Text = ">";
            this.btnbuscavendedor.UseVisualStyleBackColor = true;
            this.btnbuscavendedor.Click += new System.EventHandler(this.btnbuscavendedor_Click);
            // 
            // id_produto
            // 
            this.id_produto.HeaderText = "id_produto";
            this.id_produto.Name = "id_produto";
            this.id_produto.ReadOnly = true;
            this.id_produto.Visible = false;
            // 
            // qntd
            // 
            this.qntd.HeaderText = "Qtd.";
            this.qntd.Name = "qntd";
            this.qntd.ReadOnly = true;
            this.qntd.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.qntd.Width = 50;
            // 
            // prod
            // 
            this.prod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prod.HeaderText = "Produto";
            this.prod.Name = "prod";
            this.prod.ReadOnly = true;
            this.prod.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // valorunit
            // 
            this.valorunit.HeaderText = "Valor Unitário";
            this.valorunit.Name = "valorunit";
            this.valorunit.ReadOnly = true;
            this.valorunit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.valorunit.Width = 80;
            // 
            // valortotal
            // 
            this.valortotal.HeaderText = "Valor Total";
            this.valortotal.Name = "valortotal";
            this.valortotal.ReadOnly = true;
            this.valortotal.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.valortotal.Width = 80;
            // 
            // custototal
            // 
            this.custototal.HeaderText = "custototal";
            this.custototal.Name = "custototal";
            this.custototal.ReadOnly = true;
            this.custototal.Visible = false;
            // 
            // custounittxt
            // 
            this.custounittxt.BackColor = System.Drawing.Color.White;
            this.custounittxt.Enabled = false;
            this.custounittxt.ForeColor = System.Drawing.Color.Black;
            this.custounittxt.Location = new System.Drawing.Point(88, 19);
            this.custounittxt.Name = "custounittxt";
            this.custounittxt.Size = new System.Drawing.Size(10, 20);
            this.custounittxt.TabIndex = 16;
            // 
            // qntdtxt
            // 
            this.qntdtxt.Location = new System.Drawing.Point(334, 19);
            this.qntdtxt.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.qntdtxt.Name = "qntdtxt";
            this.qntdtxt.Size = new System.Drawing.Size(60, 20);
            this.qntdtxt.TabIndex = 18;
            this.qntdtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.qntdtxt_KeyPress);
            // 
            // FormEfetuarVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 611);
            this.Controls.Add(this.btnbuscavendedor);
            this.Controls.Add(this.observacoestxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblnomefuncionario);
            this.Controls.Add(this.codigoVendedorlbl);
            this.Controls.Add(this.codigoacessotxt);
            this.Controls.Add(this.totaltxt);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnFinalizarCompra);
            this.Controls.Add(this.Produto);
            this.Controls.Add(this.ItensGridView);
            this.Name = "FormEfetuarVenda";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormEfetuarVenda_Load);
            this.tabProduto.ResumeLayout(false);
            this.tabProduto.PerformLayout();
            this.Produto.ResumeLayout(false);
            this.tabCliente.ResumeLayout(false);
            this.tabCliente.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItensGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qntdtxt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage tabProduto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox descricaocmb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl Produto;
        private System.Windows.Forms.TextBox estoquetxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox valorunittxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabCliente;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox totaltxt;
        private System.Windows.Forms.Button btnFinalizarCompra;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox telefonetxt;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox emailtxt;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox celulartxt;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox bairrotxt;
        private System.Windows.Forms.TextBox uftxt;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox cidadetxt;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox complementotxt;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox ntxt;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox logradourotxt;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnSalvarCliente;
        private System.Windows.Forms.Button btnBuscarCPF;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbnomecliente;
        private System.Windows.Forms.TextBox codigotxt;
        private System.Windows.Forms.TextBox codigoclientetxt;
        private System.Windows.Forms.Button btncep;
        private System.Windows.Forms.Button btnLimparCampos;
        private System.Windows.Forms.MaskedTextBox cpftxt;
        private System.Windows.Forms.MaskedTextBox ceptxt;
        private System.Windows.Forms.TextBox codigoacessotxt;
        private System.Windows.Forms.Label codigoVendedorlbl;
        private System.Windows.Forms.Label lblnomefuncionario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView ItensGridView;
        private System.Windows.Forms.TextBox observacoestxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnbuscavendedor;
        private System.Windows.Forms.TextBox custounittxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn qntd;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorunit;
        private System.Windows.Forms.DataGridViewTextBoxColumn valortotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn custototal;
        private System.Windows.Forms.NumericUpDown qntdtxt;
    }
}