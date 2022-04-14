namespace supershop
{
    partial class SalesRegisterQC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesRegisterQC));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnSuspend = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.lblTotalVAT = new System.Windows.Forms.Label();
            this.txtVATRate = new System.Windows.Forms.TextBox();
            this.currency_Shortcuts1 = new supershop.SalesRagister.Currency_Shortcuts();
            this.CombPayby = new System.Windows.Forms.ComboBox();
            this.txtSearchItem = new System.Windows.Forms.TextBox();
            this.txtBarcodeReaderBox = new System.Windows.Forms.TextBox();
            this.txtPaidAmount = new System.Windows.Forms.TextBox();
            this.txtChangeAmount = new System.Windows.Forms.TextBox();
            this.txtDueAmount = new System.Windows.Forms.TextBox();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.ComboCustID = new System.Windows.Forms.ComboBox();
            this.btnCompleteSalesAndPrint = new System.Windows.Forms.Button();
            this.btnSaveOnly = new System.Windows.Forms.Button();
            this.btnPrintDirect = new System.Windows.Forms.Button();
            this.tabSRcontrol = new System.Windows.Forms.TabControl();
            this.tabPageSR_Counter = new System.Windows.Forms.TabPage();
            this.lblCustID = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.txtInvoice = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtSalesDate = new System.Windows.Forms.DateTimePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblNotFound = new System.Windows.Forms.Label();
            this.lbluser = new System.Windows.Forms.Label();
            this.PanelStockList = new System.Windows.Forms.Panel();
            this.flowLayoutPanelItemList = new System.Windows.Forms.FlowLayoutPanel();
            this.ItemcartPanel = new System.Windows.Forms.Panel();
            this.dgrvSalesItemList = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalItems = new System.Windows.Forms.Label();
            this.lblsubtotal = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.lblTotalPayable = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.helplnk = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.label28 = new System.Windows.Forms.Label();
            this.lblTotalDisCount = new System.Windows.Forms.Label();
            this.txtDiscountRate = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lbloveralldiscount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabSRcontrol.SuspendLayout();
            this.tabPageSR_Counter.SuspendLayout();
            this.PanelStockList.SuspendLayout();
            this.ItemcartPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvSalesItemList)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 800;
            this.toolTip1.AutoPopDelay = 39000;
            this.toolTip1.BackColor = System.Drawing.Color.OliveDrab;
            this.toolTip1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolTip1.InitialDelay = 1;
            this.toolTip1.ReshowDelay = 1;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Info";
            // 
            // btnSuspend
            // 
            this.btnSuspend.BackColor = System.Drawing.Color.OrangeRed;
            resources.ApplyResources(this.btnSuspend, "btnSuspend");
            this.btnSuspend.FlatAppearance.BorderSize = 0;
            this.btnSuspend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSuspend.Name = "btnSuspend";
            this.toolTip1.SetToolTip(this.btnSuspend, resources.GetString("btnSuspend.ToolTip"));
            this.btnSuspend.UseVisualStyleBackColor = false;
            this.btnSuspend.Click += new System.EventHandler(this.btnSuspend_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.Goldenrod;
            resources.ApplyResources(this.btnPayment, "btnPayment");
            this.btnPayment.FlatAppearance.BorderSize = 0;
            this.btnPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPayment.Name = "btnPayment";
            this.toolTip1.SetToolTip(this.btnPayment, resources.GetString("btnPayment.ToolTip"));
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // lblTotalVAT
            // 
            resources.ApplyResources(this.lblTotalVAT, "lblTotalVAT");
            this.lblTotalVAT.Name = "lblTotalVAT";
            this.toolTip1.SetToolTip(this.lblTotalVAT, resources.GetString("lblTotalVAT.ToolTip"));
            // 
            // txtVATRate
            // 
            this.txtVATRate.BackColor = System.Drawing.SystemColors.Info;
            this.txtVATRate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtVATRate, "txtVATRate");
            this.txtVATRate.Name = "txtVATRate";
            this.txtVATRate.ReadOnly = true;
            this.toolTip2.SetToolTip(this.txtVATRate, resources.GetString("txtVATRate.ToolTip"));
            this.toolTip1.SetToolTip(this.txtVATRate, resources.GetString("txtVATRate.ToolTip1"));
            // 
            // currency_Shortcuts1
            // 
            this.currency_Shortcuts1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.currency_Shortcuts1, "currency_Shortcuts1");
            this.currency_Shortcuts1.Name = "currency_Shortcuts1";
            this.toolTip2.SetToolTip(this.currency_Shortcuts1, resources.GetString("currency_Shortcuts1.ToolTip"));
            this.toolTip1.SetToolTip(this.currency_Shortcuts1, resources.GetString("currency_Shortcuts1.ToolTip1"));
            // 
            // CombPayby
            // 
            resources.ApplyResources(this.CombPayby, "CombPayby");
            this.CombPayby.FormattingEnabled = true;
            this.CombPayby.Items.AddRange(new object[] {
            resources.GetString("CombPayby.Items"),
            resources.GetString("CombPayby.Items1"),
            resources.GetString("CombPayby.Items2"),
            resources.GetString("CombPayby.Items3"),
            resources.GetString("CombPayby.Items4"),
            resources.GetString("CombPayby.Items5"),
            resources.GetString("CombPayby.Items6"),
            resources.GetString("CombPayby.Items7"),
            resources.GetString("CombPayby.Items8"),
            resources.GetString("CombPayby.Items9"),
            resources.GetString("CombPayby.Items10"),
            resources.GetString("CombPayby.Items11"),
            resources.GetString("CombPayby.Items12"),
            resources.GetString("CombPayby.Items13"),
            resources.GetString("CombPayby.Items14"),
            resources.GetString("CombPayby.Items15"),
            resources.GetString("CombPayby.Items16"),
            resources.GetString("CombPayby.Items17"),
            resources.GetString("CombPayby.Items18")});
            this.CombPayby.Name = "CombPayby";
            this.toolTip2.SetToolTip(this.CombPayby, resources.GetString("CombPayby.ToolTip"));
            this.toolTip1.SetToolTip(this.CombPayby, resources.GetString("CombPayby.ToolTip1"));
            // 
            // txtSearchItem
            // 
            this.txtSearchItem.BackColor = System.Drawing.SystemColors.Control;
            this.txtSearchItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtSearchItem, "txtSearchItem");
            this.txtSearchItem.Name = "txtSearchItem";
            this.toolTip2.SetToolTip(this.txtSearchItem, resources.GetString("txtSearchItem.ToolTip"));
            this.toolTip1.SetToolTip(this.txtSearchItem, resources.GetString("txtSearchItem.ToolTip1"));
            this.txtSearchItem.TextChanged += new System.EventHandler(this.txtSearchItem_TextChanged);
            // 
            // txtBarcodeReaderBox
            // 
            this.txtBarcodeReaderBox.BackColor = System.Drawing.SystemColors.Control;
            this.txtBarcodeReaderBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtBarcodeReaderBox, "txtBarcodeReaderBox");
            this.txtBarcodeReaderBox.Name = "txtBarcodeReaderBox";
            this.toolTip2.SetToolTip(this.txtBarcodeReaderBox, resources.GetString("txtBarcodeReaderBox.ToolTip"));
            this.toolTip1.SetToolTip(this.txtBarcodeReaderBox, resources.GetString("txtBarcodeReaderBox.ToolTip1"));
            this.txtBarcodeReaderBox.TextChanged += new System.EventHandler(this.txtBarcodeReaderBox_TextChanged);
            // 
            // txtPaidAmount
            // 
            resources.ApplyResources(this.txtPaidAmount, "txtPaidAmount");
            this.txtPaidAmount.Name = "txtPaidAmount";
            this.toolTip2.SetToolTip(this.txtPaidAmount, resources.GetString("txtPaidAmount.ToolTip"));
            this.toolTip1.SetToolTip(this.txtPaidAmount, resources.GetString("txtPaidAmount.ToolTip1"));
            this.txtPaidAmount.TextChanged += new System.EventHandler(this.txtPaidAmount_TextChanged);
            this.txtPaidAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPaidAmount_KeyPress);
            // 
            // txtChangeAmount
            // 
            resources.ApplyResources(this.txtChangeAmount, "txtChangeAmount");
            this.txtChangeAmount.Name = "txtChangeAmount";
            this.toolTip2.SetToolTip(this.txtChangeAmount, resources.GetString("txtChangeAmount.ToolTip"));
            this.toolTip1.SetToolTip(this.txtChangeAmount, resources.GetString("txtChangeAmount.ToolTip1"));
            // 
            // txtDueAmount
            // 
            resources.ApplyResources(this.txtDueAmount, "txtDueAmount");
            this.txtDueAmount.Name = "txtDueAmount";
            this.toolTip2.SetToolTip(this.txtDueAmount, resources.GetString("txtDueAmount.ToolTip"));
            this.toolTip1.SetToolTip(this.txtDueAmount, resources.GetString("txtDueAmount.ToolTip1"));
            // 
            // txtCustName
            // 
            resources.ApplyResources(this.txtCustName, "txtCustName");
            this.txtCustName.Name = "txtCustName";
            this.toolTip2.SetToolTip(this.txtCustName, resources.GetString("txtCustName.ToolTip"));
            this.toolTip1.SetToolTip(this.txtCustName, resources.GetString("txtCustName.ToolTip1"));
            // 
            // ComboCustID
            // 
            resources.ApplyResources(this.ComboCustID, "ComboCustID");
            this.ComboCustID.FormattingEnabled = true;
            this.ComboCustID.Name = "ComboCustID";
            this.toolTip2.SetToolTip(this.ComboCustID, resources.GetString("ComboCustID.ToolTip"));
            this.toolTip1.SetToolTip(this.ComboCustID, resources.GetString("ComboCustID.ToolTip1"));
            this.ComboCustID.SelectedIndexChanged += new System.EventHandler(this.ComboCustID_SelectedIndexChanged);
            // 
            // btnCompleteSalesAndPrint
            // 
            this.btnCompleteSalesAndPrint.BackColor = System.Drawing.Color.SpringGreen;
            resources.ApplyResources(this.btnCompleteSalesAndPrint, "btnCompleteSalesAndPrint");
            this.btnCompleteSalesAndPrint.FlatAppearance.BorderSize = 0;
            this.btnCompleteSalesAndPrint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCompleteSalesAndPrint.Name = "btnCompleteSalesAndPrint";
            this.toolTip1.SetToolTip(this.btnCompleteSalesAndPrint, resources.GetString("btnCompleteSalesAndPrint.ToolTip"));
            this.btnCompleteSalesAndPrint.UseVisualStyleBackColor = false;
            this.btnCompleteSalesAndPrint.Click += new System.EventHandler(this.btnCompleteSalesAndPrint_Click);
            // 
            // btnSaveOnly
            // 
            this.btnSaveOnly.BackColor = System.Drawing.Color.SlateBlue;
            resources.ApplyResources(this.btnSaveOnly, "btnSaveOnly");
            this.btnSaveOnly.FlatAppearance.BorderSize = 0;
            this.btnSaveOnly.ForeColor = System.Drawing.Color.Tan;
            this.btnSaveOnly.Name = "btnSaveOnly";
            this.toolTip1.SetToolTip(this.btnSaveOnly, resources.GetString("btnSaveOnly.ToolTip"));
            this.btnSaveOnly.UseVisualStyleBackColor = false;
            this.btnSaveOnly.Click += new System.EventHandler(this.btnSaveOnly_Click);
            // 
            // btnPrintDirect
            // 
            this.btnPrintDirect.BackColor = System.Drawing.Color.SpringGreen;
            resources.ApplyResources(this.btnPrintDirect, "btnPrintDirect");
            this.btnPrintDirect.FlatAppearance.BorderSize = 0;
            this.btnPrintDirect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPrintDirect.Name = "btnPrintDirect";
            this.toolTip1.SetToolTip(this.btnPrintDirect, resources.GetString("btnPrintDirect.ToolTip"));
            this.btnPrintDirect.UseVisualStyleBackColor = false;
            this.btnPrintDirect.Click += new System.EventHandler(this.btnPrintDirect_Click);
            // 
            // tabSRcontrol
            // 
            this.tabSRcontrol.Controls.Add(this.tabPageSR_Counter);
            resources.ApplyResources(this.tabSRcontrol, "tabSRcontrol");
            this.tabSRcontrol.Name = "tabSRcontrol";
            this.tabSRcontrol.SelectedIndex = 0;
            // 
            // tabPageSR_Counter
            // 
            this.tabPageSR_Counter.Controls.Add(this.btnPrintDirect);
            this.tabPageSR_Counter.Controls.Add(this.btnSaveOnly);
            this.tabPageSR_Counter.Controls.Add(this.btnCompleteSalesAndPrint);
            this.tabPageSR_Counter.Controls.Add(this.lblCustID);
            this.tabPageSR_Counter.Controls.Add(this.ComboCustID);
            this.tabPageSR_Counter.Controls.Add(this.label36);
            this.tabPageSR_Counter.Controls.Add(this.label34);
            this.tabPageSR_Counter.Controls.Add(this.txtCustName);
            this.tabPageSR_Counter.Controls.Add(this.txtDueAmount);
            this.tabPageSR_Counter.Controls.Add(this.txtChangeAmount);
            this.tabPageSR_Counter.Controls.Add(this.txtPaidAmount);
            this.tabPageSR_Counter.Controls.Add(this.txtBarcodeReaderBox);
            this.tabPageSR_Counter.Controls.Add(this.txtInvoice);
            this.tabPageSR_Counter.Controls.Add(this.txtSearchItem);
            this.tabPageSR_Counter.Controls.Add(this.label26);
            this.tabPageSR_Counter.Controls.Add(this.label21);
            this.tabPageSR_Counter.Controls.Add(this.label20);
            this.tabPageSR_Counter.Controls.Add(this.label18);
            this.tabPageSR_Counter.Controls.Add(this.CombPayby);
            this.tabPageSR_Counter.Controls.Add(this.label6);
            this.tabPageSR_Counter.Controls.Add(this.dtSalesDate);
            this.tabPageSR_Counter.Controls.Add(this.label19);
            this.tabPageSR_Counter.Controls.Add(this.currency_Shortcuts1);
            this.tabPageSR_Counter.Controls.Add(this.label38);
            this.tabPageSR_Counter.Controls.Add(this.label7);
            this.tabPageSR_Counter.Controls.Add(this.label1);
            this.tabPageSR_Counter.Controls.Add(this.linkLabel1);
            this.tabPageSR_Counter.Controls.Add(this.lblNotFound);
            this.tabPageSR_Counter.Controls.Add(this.lbluser);
            this.tabPageSR_Counter.Controls.Add(this.PanelStockList);
            this.tabPageSR_Counter.Controls.Add(this.ItemcartPanel);
            this.tabPageSR_Counter.Controls.Add(this.panel3);
            this.tabPageSR_Counter.Controls.Add(this.btnPayment);
            this.tabPageSR_Counter.Controls.Add(this.label5);
            this.tabPageSR_Counter.Controls.Add(this.btnSuspend);
            this.tabPageSR_Counter.Controls.Add(this.helplnk);
            this.tabPageSR_Counter.Controls.Add(this.label4);
            resources.ApplyResources(this.tabPageSR_Counter, "tabPageSR_Counter");
            this.tabPageSR_Counter.Name = "tabPageSR_Counter";
            this.tabPageSR_Counter.UseVisualStyleBackColor = true;
            this.tabPageSR_Counter.Enter += new System.EventHandler(this.tabPageSR_Counter_Enter);
            // 
            // lblCustID
            // 
            resources.ApplyResources(this.lblCustID, "lblCustID");
            this.lblCustID.Name = "lblCustID";
            // 
            // label36
            // 
            resources.ApplyResources(this.label36, "label36");
            this.label36.Name = "label36";
            // 
            // label34
            // 
            resources.ApplyResources(this.label34, "label34");
            this.label34.Name = "label34";
            // 
            // txtInvoice
            // 
            this.txtInvoice.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtInvoice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtInvoice, "txtInvoice");
            this.txtInvoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtInvoice.Name = "txtInvoice";
            // 
            // label26
            // 
            resources.ApplyResources(this.label26, "label26");
            this.label26.Name = "label26";
            // 
            // label21
            // 
            resources.ApplyResources(this.label21, "label21");
            this.label21.Name = "label21";
            // 
            // label20
            // 
            resources.ApplyResources(this.label20, "label20");
            this.label20.Name = "label20";
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.Name = "label18";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // dtSalesDate
            // 
            resources.ApplyResources(this.dtSalesDate, "dtSalesDate");
            this.dtSalesDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtSalesDate.Name = "dtSalesDate";
            // 
            // label19
            // 
            resources.ApplyResources(this.label19, "label19");
            this.label19.Name = "label19";
            // 
            // label38
            // 
            resources.ApplyResources(this.label38, "label38");
            this.label38.Name = "label38";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label7.Name = "label7";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // linkLabel1
            // 
            resources.ApplyResources(this.linkLabel1, "linkLabel1");
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.TabStop = true;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblNotFound
            // 
            resources.ApplyResources(this.lblNotFound, "lblNotFound");
            this.lblNotFound.Name = "lblNotFound";
            // 
            // lbluser
            // 
            resources.ApplyResources(this.lbluser, "lbluser");
            this.lbluser.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbluser.Name = "lbluser";
            // 
            // PanelStockList
            // 
            this.PanelStockList.Controls.Add(this.flowLayoutPanelItemList);
            resources.ApplyResources(this.PanelStockList, "PanelStockList");
            this.PanelStockList.Name = "PanelStockList";
            // 
            // flowLayoutPanelItemList
            // 
            resources.ApplyResources(this.flowLayoutPanelItemList, "flowLayoutPanelItemList");
            this.flowLayoutPanelItemList.Name = "flowLayoutPanelItemList";
            // 
            // ItemcartPanel
            // 
            this.ItemcartPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ItemcartPanel.Controls.Add(this.dgrvSalesItemList);
            resources.ApplyResources(this.ItemcartPanel, "ItemcartPanel");
            this.ItemcartPanel.Name = "ItemcartPanel";
            // 
            // dgrvSalesItemList
            // 
            this.dgrvSalesItemList.AllowUserToAddRows = false;
            this.dgrvSalesItemList.AllowUserToResizeRows = false;
            this.dgrvSalesItemList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrvSalesItemList.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgrvSalesItemList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgrvSalesItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrvSalesItemList.DefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.dgrvSalesItemList, "dgrvSalesItemList");
            this.dgrvSalesItemList.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgrvSalesItemList.Name = "dgrvSalesItemList";
            this.dgrvSalesItemList.RowHeadersVisible = false;
            this.dgrvSalesItemList.RowTemplate.Height = 30;
            this.dgrvSalesItemList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrvSalesItemList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrvSalesItemList_CellClick);
            this.dgrvSalesItemList.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrvSalesItemList_CellEndEdit);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Info;
            this.panel3.Controls.Add(this.lbloveralldiscount);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.txtDiscountRate);
            this.panel3.Controls.Add(this.lblTotalDisCount);
            this.panel3.Controls.Add(this.label28);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lblTotalItems);
            this.panel3.Controls.Add(this.lblsubtotal);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label32);
            this.panel3.Controls.Add(this.lblTotalPayable);
            this.panel3.Controls.Add(this.label29);
            this.panel3.Controls.Add(this.label30);
            this.panel3.Controls.Add(this.txtVATRate);
            this.panel3.Controls.Add(this.lblTotal);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.lblTotalVAT);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // lblTotalItems
            // 
            resources.ApplyResources(this.lblTotalItems, "lblTotalItems");
            this.lblTotalItems.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblTotalItems.Name = "lblTotalItems";
            // 
            // lblsubtotal
            // 
            resources.ApplyResources(this.lblsubtotal, "lblsubtotal");
            this.lblsubtotal.Name = "lblsubtotal";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // label32
            // 
            resources.ApplyResources(this.label32, "label32");
            this.label32.Name = "label32";
            // 
            // lblTotalPayable
            // 
            resources.ApplyResources(this.lblTotalPayable, "lblTotalPayable");
            this.lblTotalPayable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTotalPayable.Name = "lblTotalPayable";
            // 
            // label29
            // 
            resources.ApplyResources(this.label29, "label29");
            this.label29.Name = "label29";
            // 
            // label30
            // 
            resources.ApplyResources(this.label30, "label30");
            this.label30.ForeColor = System.Drawing.Color.Red;
            this.label30.Name = "label30";
            // 
            // lblTotal
            // 
            resources.ApplyResources(this.lblTotal, "lblTotal");
            this.lblTotal.Name = "lblTotal";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // helplnk
            // 
            resources.ApplyResources(this.helplnk, "helplnk");
            this.helplnk.Name = "helplnk";
            this.helplnk.TabStop = true;
            this.helplnk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.helplnk_LinkClicked);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolTip2
            // 
            this.toolTip2.AutomaticDelay = 800;
            this.toolTip2.AutoPopDelay = 39000;
            this.toolTip2.BackColor = System.Drawing.Color.OliveDrab;
            this.toolTip2.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolTip2.InitialDelay = 1;
            this.toolTip2.ReshowDelay = 1;
            this.toolTip2.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // label28
            // 
            resources.ApplyResources(this.label28, "label28");
            this.label28.Name = "label28";
            // 
            // lblTotalDisCount
            // 
            resources.ApplyResources(this.lblTotalDisCount, "lblTotalDisCount");
            this.lblTotalDisCount.Name = "lblTotalDisCount";
            this.toolTip1.SetToolTip(this.lblTotalDisCount, resources.GetString("lblTotalDisCount.ToolTip"));
            // 
            // txtDiscountRate
            // 
            this.txtDiscountRate.BackColor = System.Drawing.SystemColors.Info;
            this.txtDiscountRate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtDiscountRate, "txtDiscountRate");
            this.txtDiscountRate.Name = "txtDiscountRate";
            this.toolTip1.SetToolTip(this.txtDiscountRate, resources.GetString("txtDiscountRate.ToolTip"));
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // lbloveralldiscount
            // 
            resources.ApplyResources(this.lbloveralldiscount, "lbloveralldiscount");
            this.lbloveralldiscount.Name = "lbloveralldiscount";
            this.toolTip1.SetToolTip(this.lbloveralldiscount, resources.GetString("lbloveralldiscount.ToolTip"));
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // SalesRegisterQC
            // 
            this.AcceptButton = this.btnPrintDirect;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.tabSRcontrol);
            this.MaximizeBox = false;
            this.Name = "SalesRegisterQC";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SalesRegister_Load);
            this.tabSRcontrol.ResumeLayout(false);
            this.tabPageSR_Counter.ResumeLayout(false);
            this.tabPageSR_Counter.PerformLayout();
            this.PanelStockList.ResumeLayout(false);
            this.ItemcartPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrvSalesItemList)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.TabControl tabSRcontrol;
        private System.Windows.Forms.TabPage tabPageSR_Counter;
        private System.Windows.Forms.Button btnPrintDirect;
        private System.Windows.Forms.Button btnSaveOnly;
        private System.Windows.Forms.Button btnCompleteSalesAndPrint;
        private System.Windows.Forms.Label lblCustID;
        private System.Windows.Forms.ComboBox ComboCustID;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.TextBox txtDueAmount;
        private System.Windows.Forms.TextBox txtChangeAmount;
        private System.Windows.Forms.TextBox txtPaidAmount;
        private System.Windows.Forms.TextBox txtBarcodeReaderBox;
        private System.Windows.Forms.TextBox txtInvoice;
        private System.Windows.Forms.TextBox txtSearchItem;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox CombPayby;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtSalesDate;
        private System.Windows.Forms.Label label19;
        private SalesRagister.Currency_Shortcuts currency_Shortcuts1;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lblNotFound;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.Panel PanelStockList;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelItemList;
        private System.Windows.Forms.Panel ItemcartPanel;
        private System.Windows.Forms.DataGridView dgrvSalesItemList;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalItems;
        private System.Windows.Forms.Label lblsubtotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label lblTotalPayable;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox txtVATRate;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTotalVAT;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSuspend;
        private System.Windows.Forms.LinkLabel helplnk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbloveralldiscount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDiscountRate;
        private System.Windows.Forms.Label lblTotalDisCount;
        private System.Windows.Forms.Label label28;
    }
}