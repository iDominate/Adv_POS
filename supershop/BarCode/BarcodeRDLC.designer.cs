namespace supershop
{
    partial class BarcodeRDLC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BarcodeRDLC));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnlink = new System.Windows.Forms.Button();
            this.btnSql = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.cmbitems = new System.Windows.Forms.ComboBox();
            this.bntSearch = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.purchaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.psodbDataSet1 = new supershop.SalesRagister.psodbDataSet();
            this.purchaseTableAdapter1 = new supershop.SalesRagister.psodbDataSetTableAdapters.purchaseTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.psodbDataSet = new supershop.psodbDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.psodbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.psodbDataSet)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.btnlink);
            this.splitContainer1.Panel1.Controls.Add(this.btnSql);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.txtQuantity);
            this.splitContainer1.Panel1.Controls.Add(this.cmbitems);
            this.splitContainer1.Panel1.Controls.Add(this.bntSearch);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.reportViewer1);
            // 
            // btnlink
            // 
            resources.ApplyResources(this.btnlink, "btnlink");
            this.btnlink.Name = "btnlink";
            this.btnlink.UseVisualStyleBackColor = true;
            this.btnlink.Click += new System.EventHandler(this.btnlink_Click);
            // 
            // btnSql
            // 
            resources.ApplyResources(this.btnSql, "btnSql");
            this.btnSql.Name = "btnSql";
            this.btnSql.UseVisualStyleBackColor = true;
            this.btnSql.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txtQuantity
            // 
            resources.ApplyResources(this.txtQuantity, "txtQuantity");
            this.txtQuantity.Name = "txtQuantity";
            this.toolTip1.SetToolTip(this.txtQuantity, resources.GetString("txtQuantity.ToolTip"));
            // 
            // cmbitems
            // 
            this.cmbitems.FormattingEnabled = true;
            resources.ApplyResources(this.cmbitems, "cmbitems");
            this.cmbitems.Name = "cmbitems";
            this.toolTip1.SetToolTip(this.cmbitems, resources.GetString("cmbitems.ToolTip"));
            // 
            // bntSearch
            // 
            resources.ApplyResources(this.bntSearch, "bntSearch");
            this.bntSearch.Name = "bntSearch";
            this.bntSearch.UseVisualStyleBackColor = true;
            this.bntSearch.Click += new System.EventHandler(this.bntSearch_Click);
            // 
            // reportViewer1
            // 
            resources.ApplyResources(this.reportViewer1, "reportViewer1");
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.purchaseBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "supershop.BarCode.RptBarcode.rdlc";
            this.reportViewer1.Name = "reportViewer1";
            // 
            // purchaseBindingSource
            // 
            this.purchaseBindingSource.DataMember = "purchase";
            this.purchaseBindingSource.DataSource = this.psodbDataSet1;
            // 
            // psodbDataSet1
            // 
            this.psodbDataSet1.DataSetName = "psodbDataSet";
            this.psodbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // purchaseTableAdapter1
            // 
            this.purchaseTableAdapter1.ClearBeforeFill = true;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 800;
            this.toolTip1.AutoPopDelay = 80000;
            this.toolTip1.BackColor = System.Drawing.Color.OliveDrab;
            this.toolTip1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolTip1.InitialDelay = 1;
            this.toolTip1.ReshowDelay = 1;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // psodbDataSet
            // 
            this.psodbDataSet.DataSetName = "psodbDataSet";
            this.psodbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BarcodeRDLC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.Name = "BarcodeRDLC";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BarcodeRDLC_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.purchaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.psodbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.psodbDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        //  private psodbDataSet psodbDataSet;
       // private psodbDataSetTableAdapters.purchaseTableAdapter purchaseTableAdapter;
        private SalesRagister.psodbDataSet psodbDataSet1;
        private System.Windows.Forms.BindingSource purchaseBindingSource;
        private SalesRagister.psodbDataSetTableAdapters.purchaseTableAdapter purchaseTableAdapter1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox cmbitems;
        private System.Windows.Forms.Button bntSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnSql;
        private System.Windows.Forms.Button btnlink;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private psodbDataSet psodbDataSet;

    }
}