﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1.Forms
{
    public partial class FormVendas : Form
    {
        private MySqlDataAdapter da = new MySqlDataAdapter();
        private BindingSource bindingSource = new BindingSource();

        public FormVendas()
        {
            InitializeComponent();
        }

        private void btnNovaVenda_Click(object sender, EventArgs e)
        {
            FormEfetuarVenda formEfetuar = new FormEfetuarVenda();
            formEfetuar.Show();
        }

        private void btnSyncVenda_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao con = new Conexao();
                da = new MySqlDataAdapter("SELECT tabvendas.status AS Status, tabvendas.id_venda AS Venda, tabvendas.datadavenda AS Data, tabclientes.nome as Nome, CONCAT(tabclientes.logradouro, ', ', tabclientes.numero, ' - ', tabclientes.bairro, ', ', tabclientes.cidade, ' - ', tabclientes.uf, ', ', tabclientes.cep) AS Endereco, tabfuncionarios.apelido AS Vendedor, tabvendas.observacoes AS Observacoes FROM tabvendas INNER JOIN tabclientes ON tabclientes.id_cliente=tabvendas.id_cliente INNER JOIN tabfuncionarios ON tabfuncionarios.id_funcionario=tabvendas.id_vendedor ORDER BY tabvendas.id_venda DESC;", con.conec);
                MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(da);

                DataTable dt = new DataTable();
                da.Fill(dt);
                bindingSource.DataSource = dt;
                VendasGridView.DataSource = bindingSource;
                VendasGridView.Columns["Status"].Width = 50;
                VendasGridView.Columns["Venda"].Width = 65;
                VendasGridView.Columns["Data"].Width = 100;
                VendasGridView.Columns["Nome"].MinimumWidth = 100;
                VendasGridView.Columns["Nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                VendasGridView.Columns["Endereco"].Width = 200;
                VendasGridView.Columns["Vendedor"].Width = 100;
                VendasGridView.Columns["Observacoes"].Width = 100;
                
            }
            catch (Exception)
            {
                MessageBox.Show("Desculpe, mas ocorreu um erro ao buscar as informações no banco de dados.");
            }                        
        }

        private void FormVendas_Load(object sender, EventArgs e)
        {
            btnSyncVenda_Click(btnSyncVenda, EventArgs.Empty);
        }
    }
}
