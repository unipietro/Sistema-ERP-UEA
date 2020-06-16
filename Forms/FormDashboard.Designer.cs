using System;

namespace WindowsFormsApp1.Forms
{
    partial class FormDashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartVendas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartProdutos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartCustoxVendas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartVendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCustoxVendas)).BeginInit();
            this.SuspendLayout();
            // 
            // chartVendas
            // 
            this.chartVendas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            chartArea1.Name = "ChartArea1";
            this.chartVendas.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartVendas.Legends.Add(legend1);
            this.chartVendas.Location = new System.Drawing.Point(12, 25);
            this.chartVendas.Name = "chartVendas";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Vendas";
            this.chartVendas.Series.Add(series1);
            this.chartVendas.Size = new System.Drawing.Size(428, 353);
            this.chartVendas.TabIndex = 0;
            this.chartVendas.Text = "chart1";
            // 
            // chartProdutos
            // 
            this.chartProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chartProdutos.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartProdutos.Legends.Add(legend2);
            this.chartProdutos.Location = new System.Drawing.Point(457, 25);
            this.chartProdutos.Name = "chartProdutos";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Legend = "Legend1";
            series2.MarkerBorderColor = System.Drawing.Color.Transparent;
            series2.Name = "TopProdutos";
            this.chartProdutos.Series.Add(series2);
            this.chartProdutos.Size = new System.Drawing.Size(403, 353);
            this.chartProdutos.TabIndex = 1;
            this.chartProdutos.Text = "chart2";
            // 
            // chartCustoxVendas
            // 
            this.chartCustoxVendas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.Name = "ChartArea1";
            this.chartCustoxVendas.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartCustoxVendas.Legends.Add(legend3);
            this.chartCustoxVendas.Location = new System.Drawing.Point(12, 396);
            this.chartCustoxVendas.Name = "chartCustoxVendas";
            series3.BorderWidth = 5;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Vendas";
            series4.BorderWidth = 5;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Custo";
            this.chartCustoxVendas.Series.Add(series3);
            this.chartCustoxVendas.Series.Add(series4);
            this.chartCustoxVendas.Size = new System.Drawing.Size(848, 196);
            this.chartCustoxVendas.TabIndex = 2;
            this.chartCustoxVendas.Text = "chart3";
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(882, 614);
            this.Controls.Add(this.chartCustoxVendas);
            this.Controls.Add(this.chartProdutos);
            this.Controls.Add(this.chartVendas);
            this.Name = "FormDashboard";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartVendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCustoxVendas)).EndInit();
            this.ResumeLayout(false);

        }

      
       

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartVendas;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProdutos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCustoxVendas;
    }
}