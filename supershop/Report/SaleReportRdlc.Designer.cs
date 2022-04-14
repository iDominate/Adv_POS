namespace supershop.Report
{
    partial class SaleReportRdlc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaleReportRdlc));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.sales_paymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.psodbDataSet = new supershop.SalesRagister.psodbDataSet();
            this.salespaymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sales_paymentTableAdapter = new supershop.SalesRagister.psodbDataSetTableAdapters.sales_paymentTableAdapter();
            this.rptSalesreport = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.sales_paymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.psodbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salespaymentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sales_paymentBindingSource
            // 
            this.sales_paymentBindingSource.DataMember = "sales_payment";
            this.sales_paymentBindingSource.DataSource = this.psodbDataSet;
            // 
            // psodbDataSet
            // 
            this.psodbDataSet.DataSetName = "psodbDataSet";
            this.psodbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salespaymentBindingSource
            // 
            this.salespaymentBindingSource.DataMember = "sales_payment";
            this.salespaymentBindingSource.DataSource = this.psodbDataSet;
            // 
            // sales_paymentTableAdapter
            // 
            this.sales_paymentTableAdapter.ClearBeforeFill = true;
            // 
            // rptSalesreport
            // 
            resources.ApplyResources(this.rptSalesreport, "rptSalesreport");
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.sales_paymentBindingSource;
            this.rptSalesreport.LocalReport.DataSources.Add(reportDataSource2);
            this.rptSalesreport.LocalReport.ReportEmbeddedResource = "supershop.Report.ReportSales.rdlc";
            this.rptSalesreport.Name = "rptSalesreport";
            // 
            // SaleReportRdlc
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rptSalesreport);
            this.MinimizeBox = false;
            this.Name = "SaleReportRdlc";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.SaleReportRdlc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sales_paymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.psodbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salespaymentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SalesRagister.psodbDataSet psodbDataSet;
        private System.Windows.Forms.BindingSource salespaymentBindingSource;
        private SalesRagister.psodbDataSetTableAdapters.sales_paymentTableAdapter sales_paymentTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer rptSalesreport;
        private System.Windows.Forms.BindingSource sales_paymentBindingSource;
    }
}