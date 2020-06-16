using System;
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
    //atualização form responsivo com banco de dados
    public partial class FormDashboard : Form
    {
        private MySqlDataAdapter da = new MySqlDataAdapter();
        private BindingSource bindingSource = new BindingSource();

        public FormDashboard()
        {
            InitializeComponent();
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            fillChartsVendas();
            fillChartsProdutos();
            fillChartsCustoVendas();
        }

       private void fillChartsVendas()
       {
            Conexao con = new Conexao();
            DataTable dtVendas = new DataTable();
            con.StringdeExecucao = "SELECT DATE_FORMAT(tabvendas.datadavenda, '%d/%m/%Y') AS DataVenda, SUM(tab_prod_vendas.valortotal) AS Valor FROM tabvendas INNER JOIN tab_prod_vendas ON tab_prod_vendas.id_venda=tabvendas.id_venda GROUP BY DataVenda";
            dtVendas = con.RetornarDataTable();
            chartVendas.DataSource = dtVendas;
            
            chartVendas.Series["Vendas"].XValueMember = "DataVenda";
            chartVendas.Series["Vendas"].YValueMembers = "Valor";
            chartVendas.Titles.Add("Ticket Diarío");

       }

        private void fillChartsProdutos()
        {
            Conexao con = new Conexao();
            DataTable dtVendas = new DataTable();
            con.StringdeExecucao = "SELECT tabprodutos.nome AS Produto, SUM(tab_prod_vendas.qntd) AS Qntd FROM tab_prod_vendas INNER JOIN tabprodutos ON tabprodutos.id_produto=tab_prod_vendas.id_produto GROUP BY tab_prod_vendas.id_produto";
            dtVendas = con.RetornarDataTable();
            chartProdutos.DataSource = dtVendas;

            chartProdutos.Series["TopProdutos"].XValueMember = "Produto";
            chartProdutos.Series["TopProdutos"].YValueMembers = "Qntd";
            chartProdutos.Titles.Add("Produtos mais vendidos");

        }

        private void fillChartsCustoVendas()
        {
            Conexao con = new Conexao();
            DataTable dtVendas = new DataTable();
            con.StringdeExecucao = "SELECT DATE_FORMAT(tabvendas.datadavenda, '%d/%m/%Y') AS DataVenda, SUM(tab_prod_vendas.valortotal) AS Venda, SUM(tab_prod_vendas.custototal) AS Custo FROM tabvendas INNER JOIN tab_prod_vendas ON tab_prod_vendas.id_venda=tabvendas.id_venda GROUP BY DataVenda";
            dtVendas = con.RetornarDataTable();
            chartCustoxVendas.DataSource = dtVendas;

            chartCustoxVendas.Series["Vendas"].XValueMember = "DataVenda";
            chartCustoxVendas.Series["Vendas"].YValueMembers = "Venda";
            chartCustoxVendas.Series["Custo"].XValueMember = "DataVenda";
            chartCustoxVendas.Series["Custo"].YValueMembers = "Custo";
            chartCustoxVendas.Titles.Add("Vendas x Custo");

        }
    }
}
