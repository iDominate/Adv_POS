namespace supershop.Inventory
{
    partial class Add_Sales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Sales));
            this.dgrvSalesItemList = new System.Windows.Forms.DataGridView();
            this.txtBarcodeReaderBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtSalesDate = new System.Windows.Forms.DateTimePicker();
            this.txtinvoiceNo = new System.Windows.Forms.TextBox();
            this.CmbWarehouse = new System.Windows.Forms.ComboBox();
            this.CmbBilling = new System.Windows.Forms.ComboBox();
            this.CmbCustomer = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalDisCount = new System.Windows.Forms.Label();
            this.lblTotalVAT = new System.Windows.Forms.Label();
            this.txtShippingFee = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.lblTotalPayable = new System.Windows.Forms.Label();
            this.lblAddStockItem = new System.Windows.Forms.LinkLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnIncreaseDisCount = new System.Windows.Forms.Button();
            this.btnDecreaseDiscount = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.txtDiscountRate = new System.Windows.Forms.TextBox();
            this.btnIncreaseVAT = new System.Windows.Forms.Button();
            this.btnDeCreaseVAT = new System.Windows.Forms.Button();
            this.txtVATRate = new System.Windows.Forms.TextBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.lnkAddCust = new System.Windows.Forms.LinkLabel();
            this.txtSearchItem = new System.Windows.Forms.TextBox();
            this.lbloveralldiscount = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.lblsubtotal = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblTotalItems = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblCustID = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.PanelStockList = new System.Windows.Forms.Panel();
            this.flowLayoutPanelUserList = new System.Windows.Forms.FlowLayoutPanel();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.btnSuspend = new System.Windows.Forms.Button();
            this.timer_InvoiceNoRefresh = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgrvSalesItemList)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.PanelStockList.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgrvSalesItemList
            // 
            this.dgrvSalesItemList.AllowUserToAddRows = false;
            this.dgrvSalesItemList.AllowUserToResizeColumns = false;
            this.dgrvSalesItemList.AllowUserToResizeRows = false;
            this.dgrvSalesItemList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrvSalesItemList.BackgroundColor = System.Drawing.Color.White;
            this.dgrvSalesItemList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrvSalesItemList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgrvSalesItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrvSalesItemList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgrvSalesItemList.GridColor = System.Drawing.SystemColors.ActiveBorder;
            resources.ApplyResources(this.dgrvSalesItemList, "dgrvSalesItemList");
            this.dgrvSalesItemList.Name = "dgrvSalesItemList";
            this.dgrvSalesItemList.RowHeadersVisible = false;
            this.dgrvSalesItemList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrvSalesItemList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrvSalesItemList_CellClick);
            this.dgrvSalesItemList.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrvSalesItemList_CellEndEdit);
            // 
            // txtBarcodeReaderBox
            // 
            this.txtBarcodeReaderBox.BackColor = System.Drawing.SystemColors.Menu;
            resources.ApplyResources(this.txtBarcodeReaderBox, "txtBarcodeReaderBox");
            this.txtBarcodeReaderBox.Name = "txtBarcodeReaderBox";
            this.toolTip1.SetToolTip(this.txtBarcodeReaderBox, resources.GetString("txtBarcodeReaderBox.ToolTip"));
            this.txtBarcodeReaderBox.Click += new System.EventHandler(this.txtBarcodeReaderBox_Click);
            this.txtBarcodeReaderBox.TextChanged += new System.EventHandler(this.txtBarcodeReaderBox_TextChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
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
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // dtSalesDate
            // 
            resources.ApplyResources(this.dtSalesDate, "dtSalesDate");
            this.dtSalesDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtSalesDate.Name = "dtSalesDate";
            // 
            // txtinvoiceNo
            // 
            resources.ApplyResources(this.txtinvoiceNo, "txtinvoiceNo");
            this.txtinvoiceNo.Name = "txtinvoiceNo";
            this.txtinvoiceNo.ReadOnly = true;
            // 
            // CmbWarehouse
            // 
            this.CmbWarehouse.FormattingEnabled = true;
            this.CmbWarehouse.Items.AddRange(new object[] {
            resources.GetString("CmbWarehouse.Items"),
            resources.GetString("CmbWarehouse.Items1")});
            resources.ApplyResources(this.CmbWarehouse, "CmbWarehouse");
            this.CmbWarehouse.Name = "CmbWarehouse";
            this.toolTip1.SetToolTip(this.CmbWarehouse, resources.GetString("CmbWarehouse.ToolTip"));
            // 
            // CmbBilling
            // 
            this.CmbBilling.FormattingEnabled = true;
            resources.ApplyResources(this.CmbBilling, "CmbBilling");
            this.CmbBilling.Name = "CmbBilling";
            // 
            // CmbCustomer
            // 
            this.CmbCustomer.FormattingEnabled = true;
            resources.ApplyResources(this.CmbCustomer, "CmbCustomer");
            this.CmbCustomer.Name = "CmbCustomer";
            this.CmbCustomer.SelectedIndexChanged += new System.EventHandler(this.CmbCustomer_SelectedIndexChanged);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            this.toolTip1.SetToolTip(this.label12, resources.GetString("label12.ToolTip"));
            // 
            // lblTotal
            // 
            resources.ApplyResources(this.lblTotal, "lblTotal");
            this.lblTotal.ForeColor = System.Drawing.Color.Black;
            this.lblTotal.Name = "lblTotal";
            // 
            // lblTotalDisCount
            // 
            resources.ApplyResources(this.lblTotalDisCount, "lblTotalDisCount");
            this.lblTotalDisCount.ForeColor = System.Drawing.Color.Black;
            this.lblTotalDisCount.Name = "lblTotalDisCount";
            // 
            // lblTotalVAT
            // 
            resources.ApplyResources(this.lblTotalVAT, "lblTotalVAT");
            this.lblTotalVAT.ForeColor = System.Drawing.Color.Black;
            this.lblTotalVAT.Name = "lblTotalVAT";
            // 
            // txtShippingFee
            // 
            this.txtShippingFee.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtShippingFee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtShippingFee, "txtShippingFee");
            this.txtShippingFee.ForeColor = System.Drawing.Color.Black;
            this.txtShippingFee.Name = "txtShippingFee";
            this.txtShippingFee.TextChanged += new System.EventHandler(this.txtShippingFee_TextChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.btnSubmit, "btnSubmit");
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.Name = "label16";
            // 
            // lblTotalPayable
            // 
            resources.ApplyResources(this.lblTotalPayable, "lblTotalPayable");
            this.lblTotalPayable.ForeColor = System.Drawing.Color.Black;
            this.lblTotalPayable.Name = "lblTotalPayable";
            // 
            // lblAddStockItem
            // 
            resources.ApplyResources(this.lblAddStockItem, "lblAddStockItem");
            this.lblAddStockItem.Name = "lblAddStockItem";
            this.lblAddStockItem.TabStop = true;
            this.lblAddStockItem.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblAddStockItem_LinkClicked);
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
            // btnIncreaseDisCount
            // 
            this.btnIncreaseDisCount.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnIncreaseDisCount, "btnIncreaseDisCount");
            this.btnIncreaseDisCount.ForeColor = System.Drawing.Color.Black;
            this.btnIncreaseDisCount.Name = "btnIncreaseDisCount";
            this.toolTip1.SetToolTip(this.btnIncreaseDisCount, resources.GetString("btnIncreaseDisCount.ToolTip"));
            this.btnIncreaseDisCount.UseVisualStyleBackColor = true;
            this.btnIncreaseDisCount.Click += new System.EventHandler(this.btnIncreaseDisCount_Click);
            // 
            // btnDecreaseDiscount
            // 
            this.btnDecreaseDiscount.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnDecreaseDiscount, "btnDecreaseDiscount");
            this.btnDecreaseDiscount.ForeColor = System.Drawing.Color.Black;
            this.btnDecreaseDiscount.Name = "btnDecreaseDiscount";
            this.toolTip1.SetToolTip(this.btnDecreaseDiscount, resources.GetString("btnDecreaseDiscount.ToolTip"));
            this.btnDecreaseDiscount.UseVisualStyleBackColor = true;
            this.btnDecreaseDiscount.Click += new System.EventHandler(this.btnDecreaseDiscount_Click);
            // 
            // label28
            // 
            resources.ApplyResources(this.label28, "label28");
            this.label28.Name = "label28";
            this.toolTip1.SetToolTip(this.label28, resources.GetString("label28.ToolTip"));
            // 
            // txtDiscountRate
            // 
            this.txtDiscountRate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtDiscountRate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtDiscountRate, "txtDiscountRate");
            this.txtDiscountRate.ForeColor = System.Drawing.Color.Black;
            this.txtDiscountRate.Name = "txtDiscountRate";
            this.toolTip1.SetToolTip(this.txtDiscountRate, resources.GetString("txtDiscountRate.ToolTip"));
            this.txtDiscountRate.TextChanged += new System.EventHandler(this.btnIncreaseDisCount_Click);
            this.txtDiscountRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiscountRate_KeyPress);
            // 
            // btnIncreaseVAT
            // 
            this.btnIncreaseVAT.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnIncreaseVAT, "btnIncreaseVAT");
            this.btnIncreaseVAT.ForeColor = System.Drawing.Color.Black;
            this.btnIncreaseVAT.Name = "btnIncreaseVAT";
            this.toolTip1.SetToolTip(this.btnIncreaseVAT, resources.GetString("btnIncreaseVAT.ToolTip"));
            this.btnIncreaseVAT.UseVisualStyleBackColor = true;
            this.btnIncreaseVAT.Click += new System.EventHandler(this.btnIncreaseVAT_Click);
            // 
            // btnDeCreaseVAT
            // 
            this.btnDeCreaseVAT.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnDeCreaseVAT, "btnDeCreaseVAT");
            this.btnDeCreaseVAT.ForeColor = System.Drawing.Color.Black;
            this.btnDeCreaseVAT.Name = "btnDeCreaseVAT";
            this.toolTip1.SetToolTip(this.btnDeCreaseVAT, resources.GetString("btnDeCreaseVAT.ToolTip"));
            this.btnDeCreaseVAT.UseVisualStyleBackColor = true;
            this.btnDeCreaseVAT.Click += new System.EventHandler(this.btnDeCreaseVAT_Click);
            // 
            // txtVATRate
            // 
            this.txtVATRate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtVATRate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtVATRate, "txtVATRate");
            this.txtVATRate.ForeColor = System.Drawing.Color.Black;
            this.txtVATRate.Name = "txtVATRate";
            this.txtVATRate.ReadOnly = true;
            this.toolTip1.SetToolTip(this.txtVATRate, resources.GetString("txtVATRate.ToolTip"));
            // 
            // txtNote
            // 
            resources.ApplyResources(this.txtNote, "txtNote");
            this.txtNote.Name = "txtNote";
            this.toolTip1.SetToolTip(this.txtNote, resources.GetString("txtNote.ToolTip"));
            // 
            // lnkAddCust
            // 
            resources.ApplyResources(this.lnkAddCust, "lnkAddCust");
            this.lnkAddCust.Name = "lnkAddCust";
            this.lnkAddCust.TabStop = true;
            this.toolTip1.SetToolTip(this.lnkAddCust, resources.GetString("lnkAddCust.ToolTip"));
            this.lnkAddCust.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAddCust_LinkClicked);
            // 
            // txtSearchItem
            // 
            resources.ApplyResources(this.txtSearchItem, "txtSearchItem");
            this.txtSearchItem.Name = "txtSearchItem";
            this.toolTip1.SetToolTip(this.txtSearchItem, resources.GetString("txtSearchItem.ToolTip"));
            this.txtSearchItem.TextChanged += new System.EventHandler(this.txtSearchItem_TextChanged);
            // 
            // lbloveralldiscount
            // 
            resources.ApplyResources(this.lbloveralldiscount, "lbloveralldiscount");
            this.lbloveralldiscount.Name = "lbloveralldiscount";
            this.toolTip1.SetToolTip(this.lbloveralldiscount, resources.GetString("lbloveralldiscount.ToolTip"));
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Name = "label13";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Name = "label10";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.lblsubtotal);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.btnDecreaseDiscount);
            this.panel1.Controls.Add(this.btnIncreaseDisCount);
            this.panel1.Controls.Add(this.lblTotalItems);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btnIncreaseVAT);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.btnDeCreaseVAT);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtVATRate);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.lblTotalDisCount);
            this.panel1.Controls.Add(this.lblTotalVAT);
            this.panel1.Controls.Add(this.txtShippingFee);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label28);
            this.panel1.Controls.Add(this.lblTotalPayable);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDiscountRate);
            this.groupBox1.Controls.Add(this.lbloveralldiscount);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label21);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // label21
            // 
            resources.ApplyResources(this.label21, "label21");
            this.label21.Name = "label21";
            // 
            // lblsubtotal
            // 
            resources.ApplyResources(this.lblsubtotal, "lblsubtotal");
            this.lblsubtotal.Name = "lblsubtotal";
            // 
            // label20
            // 
            resources.ApplyResources(this.label20, "label20");
            this.label20.Name = "label20";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // lblTotalItems
            // 
            resources.ApplyResources(this.lblTotalItems, "lblTotalItems");
            this.lblTotalItems.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblTotalItems.Name = "lblTotalItems";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // lblUserID
            // 
            resources.ApplyResources(this.lblUserID, "lblUserID");
            this.lblUserID.Name = "lblUserID";
            // 
            // lblCustID
            // 
            resources.ApplyResources(this.lblCustID, "lblCustID");
            this.lblCustID.Name = "lblCustID";
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // PanelStockList
            // 
            this.PanelStockList.Controls.Add(this.flowLayoutPanelUserList);
            resources.ApplyResources(this.PanelStockList, "PanelStockList");
            this.PanelStockList.Name = "PanelStockList";
            // 
            // flowLayoutPanelUserList
            // 
            resources.ApplyResources(this.flowLayoutPanelUserList, "flowLayoutPanelUserList");
            this.flowLayoutPanelUserList.Name = "flowLayoutPanelUserList";
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.Name = "label17";
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.Name = "label18";
            // 
            // label19
            // 
            resources.ApplyResources(this.label19, "label19");
            this.label19.Name = "label19";
            // 
            // btnSuspend
            // 
            this.btnSuspend.BackColor = System.Drawing.Color.OrangeRed;
            this.btnSuspend.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnSuspend, "btnSuspend");
            this.btnSuspend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSuspend.Name = "btnSuspend";
            this.btnSuspend.UseVisualStyleBackColor = false;
            this.btnSuspend.Click += new System.EventHandler(this.btnSuspend_Click);
            // 
            // timer_InvoiceNoRefresh
            // 
            this.timer_InvoiceNoRefresh.Enabled = true;
            this.timer_InvoiceNoRefresh.Interval = 1000;
            this.timer_InvoiceNoRefresh.Tick += new System.EventHandler(this.timer_InvoiceNoRefresh_Tick);
            // 
            // Add_Sales
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.btnSuspend);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtSearchItem);
            this.Controls.Add(this.PanelStockList);
            this.Controls.Add(this.lblCustID);
            this.Controls.Add(this.lnkAddCust);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblAddStockItem);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CmbCustomer);
            this.Controls.Add(this.CmbBilling);
            this.Controls.Add(this.CmbWarehouse);
            this.Controls.Add(this.txtinvoiceNo);
            this.Controls.Add(this.dtSalesDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgrvSalesItemList);
            this.Controls.Add(this.txtBarcodeReaderBox);
            this.Name = "Add_Sales";
            this.ShowIcon = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Add_Sales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrvSalesItemList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.PanelStockList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrvSalesItemList;
        private System.Windows.Forms.TextBox txtBarcodeReaderBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtSalesDate;
        private System.Windows.Forms.TextBox txtinvoiceNo;
        private System.Windows.Forms.ComboBox CmbWarehouse;
        private System.Windows.Forms.ComboBox CmbBilling;
        private System.Windows.Forms.ComboBox CmbCustomer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalDisCount;
        private System.Windows.Forms.Label lblTotalVAT;
        private System.Windows.Forms.TextBox txtShippingFee;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblTotalPayable;
        private System.Windows.Forms.LinkLabel lblAddStockItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnIncreaseDisCount;
        private System.Windows.Forms.Button btnDecreaseDiscount;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtDiscountRate;
        private System.Windows.Forms.Button btnIncreaseVAT;
        private System.Windows.Forms.Button btnDeCreaseVAT;
        private System.Windows.Forms.TextBox txtVATRate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Timer timer_InvoiceNoRefresh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.LinkLabel lnkAddCust;
        private System.Windows.Forms.Label lblCustID;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblTotalItems;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtSearchItem;
        private System.Windows.Forms.Panel PanelStockList;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelUserList;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblsubtotal;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lbloveralldiscount;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSuspend;
    }
}