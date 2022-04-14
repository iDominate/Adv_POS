namespace supershop
{
    partial class Chart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chart));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.combCategory = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.printGrid = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            resources.ApplyResources(this.splitContainer1.Panel1, "splitContainer1.Panel1");
            this.splitContainer1.Panel1.Controls.Add(this.combCategory);
            this.splitContainer1.Panel1.Controls.Add(this.label24);
            this.splitContainer1.Panel1.Controls.Add(this.printGrid);
            // 
            // splitContainer1.Panel2
            // 
            resources.ApplyResources(this.splitContainer1.Panel2, "splitContainer1.Panel2");
            this.splitContainer1.Panel2.Controls.Add(this.chart1);
            // 
            // combCategory
            // 
            resources.ApplyResources(this.combCategory, "combCategory");
            this.combCategory.FormattingEnabled = true;
            this.combCategory.Name = "combCategory";
            this.combCategory.SelectedIndexChanged += new System.EventHandler(this.combCategory_SelectedIndexChanged);
            // 
            // label24
            // 
            resources.ApplyResources(this.label24, "label24");
            this.label24.Name = "label24";
            // 
            // printGrid
            // 
            resources.ApplyResources(this.printGrid, "printGrid");
            this.printGrid.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.printGrid.FlatAppearance.BorderSize = 0;
            this.printGrid.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.printGrid.Name = "printGrid";
            this.printGrid.UseVisualStyleBackColor = false;
            this.printGrid.Click += new System.EventHandler(this.printGrid_Click);
            // 
            // chart1
            // 
            resources.ApplyResources(this.chart1, "chart1");
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend2";
            this.chart1.Legends.Add(legend1);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Label = "#VAL";
            series1.LabelToolTip = "#VAL";
            series1.Legend = "Legend2";
            series1.MarkerSize = 1;
            series1.Name = "Cost_price";
            series1.YValuesPerPoint = 4;
            series2.ChartArea = "ChartArea1";
            series2.Label = "#VAL";
            series2.LabelToolTip = "#VAL";
            series2.Legend = "Legend2";
            series2.Name = "Retail_price";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            // 
            // Chart
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "Chart";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Chart_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button printGrid;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox combCategory;
        private System.Windows.Forms.Label label24;

    }
}