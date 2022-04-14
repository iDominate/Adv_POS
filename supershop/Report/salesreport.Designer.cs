namespace supershop
{
    partial class salesreport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(salesreport));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnSaveAs = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnGLprint = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtDailyPaymentReport = new System.Windows.Forms.DateTimePicker();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtEndDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDuelink = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtSalesItemStart = new System.Windows.Forms.DateTimePicker();
            this.dtSalesItemEND = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtReturnStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtReturnEndDate = new System.Windows.Forms.DateTimePicker();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtItemSearchBox = new System.Windows.Forms.TextBox();
            this.dtgrdViewSalesReport = new System.Windows.Forms.DataGridView();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.MyPrintPreviewDialog = new System.Windows.Forms.PageSetupDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdViewSalesReport)).BeginInit();
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
            resources.ApplyResources(this.splitContainer1.Panel1, "splitContainer1.Panel1");
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.splitContainer1.Panel1.Controls.Add(this.btnSaveAs);
            this.splitContainer1.Panel1.Controls.Add(this.btnExport);
            this.splitContainer1.Panel1.Controls.Add(this.btnGLprint);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.btnDuelink);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox4);
            this.splitContainer1.Panel1.Controls.Add(this.btnPrint);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.ForeColor = System.Drawing.Color.Black;
            this.toolTip1.SetToolTip(this.splitContainer1.Panel1, resources.GetString("splitContainer1.Panel1.ToolTip"));
            // 
            // splitContainer1.Panel2
            // 
            resources.ApplyResources(this.splitContainer1.Panel2, "splitContainer1.Panel2");
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.toolTip1.SetToolTip(this.splitContainer1.Panel2, resources.GetString("splitContainer1.Panel2.ToolTip"));
            this.toolTip1.SetToolTip(this.splitContainer1, resources.GetString("splitContainer1.ToolTip"));
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // btnSaveAs
            // 
            resources.ApplyResources(this.btnSaveAs, "btnSaveAs");
            this.btnSaveAs.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSaveAs.FlatAppearance.BorderSize = 0;
            this.btnSaveAs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSaveAs.ForeColor = System.Drawing.Color.Black;
            this.btnSaveAs.Name = "btnSaveAs";
            this.toolTip1.SetToolTip(this.btnSaveAs, resources.GetString("btnSaveAs.ToolTip"));
            this.btnSaveAs.UseVisualStyleBackColor = true;
            this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
            // 
            // btnExport
            // 
            resources.ApplyResources(this.btnExport, "btnExport");
            this.btnExport.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnExport.ForeColor = System.Drawing.Color.Black;
            this.btnExport.Name = "btnExport";
            this.toolTip1.SetToolTip(this.btnExport, resources.GetString("btnExport.ToolTip"));
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnGLprint
            // 
            resources.ApplyResources(this.btnGLprint, "btnGLprint");
            this.btnGLprint.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGLprint.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGLprint.FlatAppearance.BorderSize = 0;
            this.btnGLprint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGLprint.Name = "btnGLprint";
            this.toolTip1.SetToolTip(this.btnGLprint, resources.GetString("btnGLprint.ToolTip"));
            this.btnGLprint.UseVisualStyleBackColor = false;
            this.btnGLprint.Click += new System.EventHandler(this.btnGLprint_Click);
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Controls.Add(this.dtDailyPaymentReport);
            this.groupBox3.Controls.Add(this.dtStartDate);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.dtEndDate);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBox3, resources.GetString("groupBox3.ToolTip"));
            // 
            // dtDailyPaymentReport
            // 
            resources.ApplyResources(this.dtDailyPaymentReport, "dtDailyPaymentReport");
            this.dtDailyPaymentReport.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDailyPaymentReport.Name = "dtDailyPaymentReport";
            this.toolTip1.SetToolTip(this.dtDailyPaymentReport, resources.GetString("dtDailyPaymentReport.ToolTip"));
            this.dtDailyPaymentReport.ValueChanged += new System.EventHandler(this.dtDailyPaymentReport_ValueChanged);
            // 
            // dtStartDate
            // 
            resources.ApplyResources(this.dtStartDate, "dtStartDate");
            this.dtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStartDate.Name = "dtStartDate";
            this.toolTip1.SetToolTip(this.dtStartDate, resources.GetString("dtStartDate.ToolTip"));
            this.dtStartDate.ValueChanged += new System.EventHandler(this.dtEndDate_ValueChanged);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBox1, resources.GetString("groupBox1.ToolTip"));
            // 
            // dtEndDate
            // 
            resources.ApplyResources(this.dtEndDate, "dtEndDate");
            this.dtEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEndDate.Name = "dtEndDate";
            this.toolTip1.SetToolTip(this.dtEndDate, resources.GetString("dtEndDate.ToolTip"));
            this.dtEndDate.ValueChanged += new System.EventHandler(this.dtEndDate_ValueChanged);
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Name = "label9";
            this.toolTip1.SetToolTip(this.label9, resources.GetString("label9.ToolTip"));
            // 
            // btnDuelink
            // 
            resources.ApplyResources(this.btnDuelink, "btnDuelink");
            this.btnDuelink.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDuelink.FlatAppearance.BorderSize = 0;
            this.btnDuelink.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDuelink.ForeColor = System.Drawing.Color.Black;
            this.btnDuelink.Name = "btnDuelink";
            this.toolTip1.SetToolTip(this.btnDuelink, resources.GetString("btnDuelink.ToolTip"));
            this.btnDuelink.UseVisualStyleBackColor = true;
            this.btnDuelink.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox4
            // 
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Controls.Add(this.dtSalesItemStart);
            this.groupBox4.Controls.Add(this.dtSalesItemEND);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBox4, resources.GetString("groupBox4.ToolTip"));
            // 
            // dtSalesItemStart
            // 
            resources.ApplyResources(this.dtSalesItemStart, "dtSalesItemStart");
            this.dtSalesItemStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtSalesItemStart.Name = "dtSalesItemStart";
            this.toolTip1.SetToolTip(this.dtSalesItemStart, resources.GetString("dtSalesItemStart.ToolTip"));
            this.dtSalesItemStart.ValueChanged += new System.EventHandler(this.dtSalesItemStart_TextChanged);
            // 
            // dtSalesItemEND
            // 
            resources.ApplyResources(this.dtSalesItemEND, "dtSalesItemEND");
            this.dtSalesItemEND.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtSalesItemEND.Name = "dtSalesItemEND";
            this.toolTip1.SetToolTip(this.dtSalesItemEND, resources.GetString("dtSalesItemEND.ToolTip"));
            this.dtSalesItemEND.ValueChanged += new System.EventHandler(this.dtSalesItemStart_TextChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Name = "label2";
            this.toolTip1.SetToolTip(this.label2, resources.GetString("label2.ToolTip"));
            // 
            // btnPrint
            // 
            resources.ApplyResources(this.btnPrint, "btnPrint");
            this.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPrint.ForeColor = System.Drawing.Color.Black;
            this.btnPrint.Name = "btnPrint";
            this.toolTip1.SetToolTip(this.btnPrint, resources.GetString("btnPrint.ToolTip"));
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.dtReturnStartDate);
            this.groupBox2.Controls.Add(this.dtReturnEndDate);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBox2, resources.GetString("groupBox2.ToolTip"));
            // 
            // dtReturnStartDate
            // 
            resources.ApplyResources(this.dtReturnStartDate, "dtReturnStartDate");
            this.dtReturnStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtReturnStartDate.Name = "dtReturnStartDate";
            this.toolTip1.SetToolTip(this.dtReturnStartDate, resources.GetString("dtReturnStartDate.ToolTip"));
            this.dtReturnStartDate.ValueChanged += new System.EventHandler(this.dateTimePicker6Return_ValueChanged);
            // 
            // dtReturnEndDate
            // 
            resources.ApplyResources(this.dtReturnEndDate, "dtReturnEndDate");
            this.dtReturnEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtReturnEndDate.Name = "dtReturnEndDate";
            this.toolTip1.SetToolTip(this.dtReturnEndDate, resources.GetString("dtReturnEndDate.ToolTip"));
            this.dtReturnEndDate.ValueChanged += new System.EventHandler(this.dateTimePicker6Return_ValueChanged);
            // 
            // splitContainer2
            // 
            resources.ApplyResources(this.splitContainer2, "splitContainer2");
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            resources.ApplyResources(this.splitContainer2.Panel1, "splitContainer2.Panel1");
            this.splitContainer2.Panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.splitContainer2.Panel1.Controls.Add(this.label6);
            this.splitContainer2.Panel1.Controls.Add(this.label8);
            this.splitContainer2.Panel1.Controls.Add(this.label4);
            this.splitContainer2.Panel1.Controls.Add(this.txtItemSearchBox);
            this.toolTip1.SetToolTip(this.splitContainer2.Panel1, resources.GetString("splitContainer2.Panel1.ToolTip"));
            // 
            // splitContainer2.Panel2
            // 
            resources.ApplyResources(this.splitContainer2.Panel2, "splitContainer2.Panel2");
            this.splitContainer2.Panel2.Controls.Add(this.dtgrdViewSalesReport);
            this.toolTip1.SetToolTip(this.splitContainer2.Panel2, resources.GetString("splitContainer2.Panel2.ToolTip"));
            this.toolTip1.SetToolTip(this.splitContainer2, resources.GetString("splitContainer2.ToolTip"));
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Name = "label6";
            this.toolTip1.SetToolTip(this.label6, resources.GetString("label6.ToolTip"));
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            this.toolTip1.SetToolTip(this.label8, resources.GetString("label8.ToolTip"));
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            this.toolTip1.SetToolTip(this.label4, resources.GetString("label4.ToolTip"));
            // 
            // txtItemSearchBox
            // 
            resources.ApplyResources(this.txtItemSearchBox, "txtItemSearchBox");
            this.txtItemSearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemSearchBox.Name = "txtItemSearchBox";
            this.toolTip1.SetToolTip(this.txtItemSearchBox, resources.GetString("txtItemSearchBox.ToolTip"));
            this.txtItemSearchBox.TextChanged += new System.EventHandler(this.txtItemSearchBox_TextChanged);
            // 
            // dtgrdViewSalesReport
            // 
            resources.ApplyResources(this.dtgrdViewSalesReport, "dtgrdViewSalesReport");
            this.dtgrdViewSalesReport.AllowUserToAddRows = false;
            this.dtgrdViewSalesReport.AllowUserToDeleteRows = false;
            this.dtgrdViewSalesReport.AllowUserToResizeColumns = false;
            this.dtgrdViewSalesReport.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dtgrdViewSalesReport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgrdViewSalesReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrdViewSalesReport.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dtgrdViewSalesReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrdViewSalesReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgrdViewSalesReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 13F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgrdViewSalesReport.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgrdViewSalesReport.Name = "dtgrdViewSalesReport";
            this.dtgrdViewSalesReport.ReadOnly = true;
            this.dtgrdViewSalesReport.RowHeadersVisible = false;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dtgrdViewSalesReport.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgrdViewSalesReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.toolTip1.SetToolTip(this.dtgrdViewSalesReport, resources.GetString("dtgrdViewSalesReport.ToolTip"));
            this.dtgrdViewSalesReport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrdViewSalesReport_CellContentClick);
            this.dtgrdViewSalesReport.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridView1_ColumnAdded);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 8000;
            this.toolTip1.InitialDelay = 10;
            this.toolTip1.ReshowDelay = 10;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "csv";
            this.saveFileDialog1.FileName = "SalesReport.csv";
            resources.ApplyResources(this.saveFileDialog1, "saveFileDialog1");
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // salesreport
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.Name = "salesreport";
            this.ShowIcon = false;
            this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.salesreport_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdViewSalesReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtDailyPaymentReport;
        private System.Windows.Forms.DataGridView dtgrdViewSalesReport;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtItemSearchBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.PageSetupDialog MyPrintPreviewDialog;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtEndDate;
        private System.Windows.Forms.DateTimePicker dtSalesItemStart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtSalesItemEND;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dtStartDate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtReturnStartDate;
        private System.Windows.Forms.DateTimePicker dtReturnEndDate;
        private System.Windows.Forms.Button btnDuelink;
        private System.Windows.Forms.Button btnGLprint;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnSaveAs;
    }
}