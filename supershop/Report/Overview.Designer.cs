namespace supershop
{
    partial class Overview
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Overview));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button2 = new System.Windows.Forms.Button();
            this.dtyearmonth = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSalesview = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.chartbarProfit = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.chartPieProfit = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartPieSales = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartbarProfit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPieProfit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPieSales)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.dtyearmonth);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.btnSalesview);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dtyearmonth
            // 
            resources.ApplyResources(this.dtyearmonth, "dtyearmonth");
            this.dtyearmonth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtyearmonth.Name = "dtyearmonth";
            this.toolTip1.SetToolTip(this.dtyearmonth, resources.GetString("dtyearmonth.ToolTip"));
            this.dtyearmonth.ValueChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSalesview
            // 
            resources.ApplyResources(this.btnSalesview, "btnSalesview");
            this.btnSalesview.FlatAppearance.BorderSize = 0;
            this.btnSalesview.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSalesview.Name = "btnSalesview";
            this.btnSalesview.UseVisualStyleBackColor = true;
            this.btnSalesview.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // splitContainer2
            // 
            resources.ApplyResources(this.splitContainer2, "splitContainer2");
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.chartbarProfit);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            // 
            // chartbarProfit
            // 
            chartArea4.Name = "ChartArea1";
            this.chartbarProfit.ChartAreas.Add(chartArea4);
            resources.ApplyResources(this.chartbarProfit, "chartbarProfit");
            legend4.Name = "Legend2";
            this.chartbarProfit.Legends.Add(legend4);
            this.chartbarProfit.Name = "chartbarProfit";
            series4.ChartArea = "ChartArea1";
            series4.Label = "#VAL{00.00}";
            series4.LabelToolTip = "#VAL{00.00} \\n\\n #PERCENT Of Total  Profit\\n";
            series4.Legend = "Legend2";
            series4.MarkerSize = 1;
            series4.Name = "Profit";
            this.chartbarProfit.Series.Add(series4);
            this.toolTip1.SetToolTip(this.chartbarProfit, resources.GetString("chartbarProfit.ToolTip"));
            this.chartbarProfit.Click += new System.EventHandler(this.chartbarProfit_Click);
            this.chartbarProfit.MouseLeave += new System.EventHandler(this.chart1_MouseLeave);
            this.chartbarProfit.MouseHover += new System.EventHandler(this.chart1_MouseHover);
            // 
            // splitContainer3
            // 
            resources.ApplyResources(this.splitContainer3, "splitContainer3");
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.chartPieProfit);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.chartPieSales);
            // 
            // chartPieProfit
            // 
            this.chartPieProfit.AllowDrop = true;
            this.chartPieProfit.BorderlineWidth = 4;
            chartArea5.Name = "ChartArea1";
            this.chartPieProfit.ChartAreas.Add(chartArea5);
            resources.ApplyResources(this.chartPieProfit, "chartPieProfit");
            legend5.Name = "Legend2";
            this.chartPieProfit.Legends.Add(legend5);
            this.chartPieProfit.Name = "chartPieProfit";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series5.Label = "#VALX  \\nProfit = #VAL{00.00}  \\n#PERCENT   ";
            series5.LabelToolTip = "#VALX  \\n\\nProfit = #VAL{00.00} \\n\\n #PERCENT Of Total  Profit\\n";
            series5.Legend = "Legend2";
            series5.MarkerSize = 1;
            series5.Name = "Profit";
            series5.YValuesPerPoint = 4;
            this.chartPieProfit.Series.Add(series5);
            this.toolTip1.SetToolTip(this.chartPieProfit, resources.GetString("chartPieProfit.ToolTip"));
            this.chartPieProfit.Click += new System.EventHandler(this.chart2_Click);
            this.chartPieProfit.MouseLeave += new System.EventHandler(this.chart2_MouseLeave);
            this.chartPieProfit.MouseHover += new System.EventHandler(this.chart2_MouseHover);
            // 
            // chartPieSales
            // 
            this.chartPieSales.AllowDrop = true;
            this.chartPieSales.BorderlineWidth = 4;
            chartArea6.Name = "ChartArea1";
            this.chartPieSales.ChartAreas.Add(chartArea6);
            resources.ApplyResources(this.chartPieSales, "chartPieSales");
            legend6.Name = "Legend2";
            this.chartPieSales.Legends.Add(legend6);
            this.chartPieSales.Name = "chartPieSales";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series6.Label = "#VALX  \\nSale = #VAL{00.00}  \\n #PERCENT ";
            series6.LabelToolTip = "#VALX  \\n\\nSale = #VAL{00.00}  \\n\\n #PERCENT Of Total  Sales\\n";
            series6.Legend = "Legend2";
            series6.MarkerSize = 1;
            series6.Name = "Total";
            series6.YValuesPerPoint = 4;
            this.chartPieSales.Series.Add(series6);
            this.toolTip1.SetToolTip(this.chartPieSales, resources.GetString("chartPieSales.ToolTip"));
            this.chartPieSales.MouseLeave += new System.EventHandler(this.chart3_MouseLeave);
            this.chartPieSales.MouseHover += new System.EventHandler(this.chart3_MouseHover);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 800;
            this.toolTip1.AutoPopDelay = 80000;
            this.toolTip1.ForeColor = System.Drawing.Color.ForestGreen;
            this.toolTip1.InitialDelay = 10;
            this.toolTip1.ReshowDelay = 4;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // Overview
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Overview";
            this.ShowIcon = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Overview_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartbarProfit)).EndInit();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartPieProfit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPieSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartbarProfit;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPieProfit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPieSales;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSalesview;
        private System.Windows.Forms.DateTimePicker dtyearmonth;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
    }
}