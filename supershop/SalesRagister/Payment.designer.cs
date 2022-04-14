namespace supershop
{
    partial class Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgrvSalesItemList = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCustID = new System.Windows.Forms.Label();
            this.ComboCustID = new System.Windows.Forms.ComboBox();
            this.label39 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.txtDueAmount = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtPaidAmount = new System.Windows.Forms.TextBox();
            this.txtChangeAmount = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.CombPayby = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalItems = new System.Windows.Forms.Label();
            this.lblsubtotal = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.lblTotalPayable = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.txtVATRate = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.lblTotalVAT = new System.Windows.Forms.Label();
            this.lblTotalDisCount = new System.Windows.Forms.Label();
            this.txtDiscountRate = new System.Windows.Forms.TextBox();
            this.btnCompleteSalesAndPrint = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtSalesDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtInvoice = new System.Windows.Forms.TextBox();
            this.lbluser = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnSaveOnly = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvSalesItemList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgrvSalesItemList
            // 
            resources.ApplyResources(this.dgrvSalesItemList, "dgrvSalesItemList");
            this.dgrvSalesItemList.AllowUserToAddRows = false;
            this.dgrvSalesItemList.AllowUserToResizeColumns = false;
            this.dgrvSalesItemList.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.dgrvSalesItemList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgrvSalesItemList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrvSalesItemList.BackgroundColor = System.Drawing.Color.White;
            this.dgrvSalesItemList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrvSalesItemList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgrvSalesItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrvSalesItemList.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgrvSalesItemList.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgrvSalesItemList.Name = "dgrvSalesItemList";
            this.dgrvSalesItemList.ReadOnly = true;
            this.dgrvSalesItemList.RowHeadersVisible = false;
            this.dgrvSalesItemList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.toolTip1.SetToolTip(this.dgrvSalesItemList, resources.GetString("dgrvSalesItemList.ToolTip"));
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.BackColor = System.Drawing.Color.Gold;
            this.groupBox1.Controls.Add(this.lblCustID);
            this.groupBox1.Controls.Add(this.ComboCustID);
            this.groupBox1.Controls.Add(this.label39);
            this.groupBox1.Controls.Add(this.label36);
            this.groupBox1.Controls.Add(this.label35);
            this.groupBox1.Controls.Add(this.label34);
            this.groupBox1.Controls.Add(this.txtCustName);
            this.groupBox1.Controls.Add(this.txtDueAmount);
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.txtPaidAmount);
            this.groupBox1.Controls.Add(this.txtChangeAmount);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.CombPayby);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBox1, resources.GetString("groupBox1.ToolTip"));
            // 
            // lblCustID
            // 
            resources.ApplyResources(this.lblCustID, "lblCustID");
            this.lblCustID.Name = "lblCustID";
            this.toolTip1.SetToolTip(this.lblCustID, resources.GetString("lblCustID.ToolTip"));
            // 
            // ComboCustID
            // 
            resources.ApplyResources(this.ComboCustID, "ComboCustID");
            this.ComboCustID.FormattingEnabled = true;
            this.ComboCustID.Name = "ComboCustID";
            this.toolTip1.SetToolTip(this.ComboCustID, resources.GetString("ComboCustID.ToolTip"));
            this.ComboCustID.SelectedIndexChanged += new System.EventHandler(this.ComboCustID_SelectedIndexChanged);
            // 
            // label39
            // 
            resources.ApplyResources(this.label39, "label39");
            this.label39.Name = "label39";
            this.toolTip1.SetToolTip(this.label39, resources.GetString("label39.ToolTip"));
            // 
            // label36
            // 
            resources.ApplyResources(this.label36, "label36");
            this.label36.Name = "label36";
            this.toolTip1.SetToolTip(this.label36, resources.GetString("label36.ToolTip"));
            // 
            // label35
            // 
            resources.ApplyResources(this.label35, "label35");
            this.label35.Name = "label35";
            this.toolTip1.SetToolTip(this.label35, resources.GetString("label35.ToolTip"));
            this.label35.Click += new System.EventHandler(this.label35_Click);
            // 
            // label34
            // 
            resources.ApplyResources(this.label34, "label34");
            this.label34.Name = "label34";
            this.toolTip1.SetToolTip(this.label34, resources.GetString("label34.ToolTip"));
            // 
            // txtCustName
            // 
            resources.ApplyResources(this.txtCustName, "txtCustName");
            this.txtCustName.Name = "txtCustName";
            this.toolTip1.SetToolTip(this.txtCustName, resources.GetString("txtCustName.ToolTip"));
            // 
            // txtDueAmount
            // 
            resources.ApplyResources(this.txtDueAmount, "txtDueAmount");
            this.txtDueAmount.Name = "txtDueAmount";
            this.toolTip1.SetToolTip(this.txtDueAmount, resources.GetString("txtDueAmount.ToolTip"));
            // 
            // label26
            // 
            resources.ApplyResources(this.label26, "label26");
            this.label26.Name = "label26";
            this.toolTip1.SetToolTip(this.label26, resources.GetString("label26.ToolTip"));
            // 
            // txtPaidAmount
            // 
            resources.ApplyResources(this.txtPaidAmount, "txtPaidAmount");
            this.txtPaidAmount.Name = "txtPaidAmount";
            this.toolTip1.SetToolTip(this.txtPaidAmount, resources.GetString("txtPaidAmount.ToolTip"));
            this.txtPaidAmount.TextChanged += new System.EventHandler(this.txtPaidAmount_TextChanged);
            this.txtPaidAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPaidAmount_KeyPress);
            // 
            // txtChangeAmount
            // 
            resources.ApplyResources(this.txtChangeAmount, "txtChangeAmount");
            this.txtChangeAmount.Name = "txtChangeAmount";
            this.toolTip1.SetToolTip(this.txtChangeAmount, resources.GetString("txtChangeAmount.ToolTip"));
            // 
            // label21
            // 
            resources.ApplyResources(this.label21, "label21");
            this.label21.Name = "label21";
            this.toolTip1.SetToolTip(this.label21, resources.GetString("label21.ToolTip"));
            // 
            // label20
            // 
            resources.ApplyResources(this.label20, "label20");
            this.label20.Name = "label20";
            this.toolTip1.SetToolTip(this.label20, resources.GetString("label20.ToolTip"));
            // 
            // label19
            // 
            resources.ApplyResources(this.label19, "label19");
            this.label19.Name = "label19";
            this.toolTip1.SetToolTip(this.label19, resources.GetString("label19.ToolTip"));
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.Name = "label18";
            this.toolTip1.SetToolTip(this.label18, resources.GetString("label18.ToolTip"));
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
            resources.GetString("CombPayby.Items13")});
            this.CombPayby.Name = "CombPayby";
            this.toolTip1.SetToolTip(this.CombPayby, resources.GetString("CombPayby.ToolTip"));
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.label1);
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
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label28);
            this.panel3.Controls.Add(this.lblTotalVAT);
            this.panel3.Controls.Add(this.lblTotalDisCount);
            this.panel3.Controls.Add(this.txtDiscountRate);
            this.panel3.Name = "panel3";
            this.toolTip1.SetToolTip(this.panel3, resources.GetString("panel3.ToolTip"));
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.toolTip1.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
            // 
            // lblTotalItems
            // 
            resources.ApplyResources(this.lblTotalItems, "lblTotalItems");
            this.lblTotalItems.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblTotalItems.Name = "lblTotalItems";
            this.toolTip1.SetToolTip(this.lblTotalItems, resources.GetString("lblTotalItems.ToolTip"));
            // 
            // lblsubtotal
            // 
            resources.ApplyResources(this.lblsubtotal, "lblsubtotal");
            this.lblsubtotal.Name = "lblsubtotal";
            this.toolTip1.SetToolTip(this.lblsubtotal, resources.GetString("lblsubtotal.ToolTip"));
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            this.toolTip1.SetToolTip(this.label10, resources.GetString("label10.ToolTip"));
            // 
            // label32
            // 
            resources.ApplyResources(this.label32, "label32");
            this.label32.Name = "label32";
            this.toolTip1.SetToolTip(this.label32, resources.GetString("label32.ToolTip"));
            // 
            // lblTotalPayable
            // 
            resources.ApplyResources(this.lblTotalPayable, "lblTotalPayable");
            this.lblTotalPayable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTotalPayable.Name = "lblTotalPayable";
            this.toolTip1.SetToolTip(this.lblTotalPayable, resources.GetString("lblTotalPayable.ToolTip"));
            // 
            // label29
            // 
            resources.ApplyResources(this.label29, "label29");
            this.label29.Name = "label29";
            this.toolTip1.SetToolTip(this.label29, resources.GetString("label29.ToolTip"));
            // 
            // label30
            // 
            resources.ApplyResources(this.label30, "label30");
            this.label30.ForeColor = System.Drawing.Color.Red;
            this.label30.Name = "label30";
            this.toolTip1.SetToolTip(this.label30, resources.GetString("label30.ToolTip"));
            // 
            // txtVATRate
            // 
            resources.ApplyResources(this.txtVATRate, "txtVATRate");
            this.txtVATRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtVATRate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVATRate.Name = "txtVATRate";
            this.toolTip1.SetToolTip(this.txtVATRate, resources.GetString("txtVATRate.ToolTip"));
            // 
            // lblTotal
            // 
            resources.ApplyResources(this.lblTotal, "lblTotal");
            this.lblTotal.Name = "lblTotal";
            this.toolTip1.SetToolTip(this.lblTotal, resources.GetString("lblTotal.ToolTip"));
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            this.toolTip1.SetToolTip(this.label12, resources.GetString("label12.ToolTip"));
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            this.toolTip1.SetToolTip(this.label11, resources.GetString("label11.ToolTip"));
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            this.toolTip1.SetToolTip(this.label13, resources.GetString("label13.ToolTip"));
            // 
            // label28
            // 
            resources.ApplyResources(this.label28, "label28");
            this.label28.Name = "label28";
            this.toolTip1.SetToolTip(this.label28, resources.GetString("label28.ToolTip"));
            // 
            // lblTotalVAT
            // 
            resources.ApplyResources(this.lblTotalVAT, "lblTotalVAT");
            this.lblTotalVAT.Name = "lblTotalVAT";
            this.toolTip1.SetToolTip(this.lblTotalVAT, resources.GetString("lblTotalVAT.ToolTip"));
            // 
            // lblTotalDisCount
            // 
            resources.ApplyResources(this.lblTotalDisCount, "lblTotalDisCount");
            this.lblTotalDisCount.Name = "lblTotalDisCount";
            this.toolTip1.SetToolTip(this.lblTotalDisCount, resources.GetString("lblTotalDisCount.ToolTip"));
            // 
            // txtDiscountRate
            // 
            resources.ApplyResources(this.txtDiscountRate, "txtDiscountRate");
            this.txtDiscountRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtDiscountRate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiscountRate.Name = "txtDiscountRate";
            this.toolTip1.SetToolTip(this.txtDiscountRate, resources.GetString("txtDiscountRate.ToolTip"));
            // 
            // btnCompleteSalesAndPrint
            // 
            resources.ApplyResources(this.btnCompleteSalesAndPrint, "btnCompleteSalesAndPrint");
            this.btnCompleteSalesAndPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCompleteSalesAndPrint.FlatAppearance.BorderSize = 0;
            this.btnCompleteSalesAndPrint.ForeColor = System.Drawing.Color.Linen;
            this.btnCompleteSalesAndPrint.Name = "btnCompleteSalesAndPrint";
            this.toolTip1.SetToolTip(this.btnCompleteSalesAndPrint, resources.GetString("btnCompleteSalesAndPrint.ToolTip"));
            this.btnCompleteSalesAndPrint.UseVisualStyleBackColor = false;
            this.btnCompleteSalesAndPrint.Click += new System.EventHandler(this.btnCompleteSalesAndPrint_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.toolTip1.SetToolTip(this.label2, resources.GetString("label2.ToolTip"));
            // 
            // dtSalesDate
            // 
            resources.ApplyResources(this.dtSalesDate, "dtSalesDate");
            this.dtSalesDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtSalesDate.Name = "dtSalesDate";
            this.toolTip1.SetToolTip(this.dtSalesDate, resources.GetString("dtSalesDate.ToolTip"));
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Name = "label8";
            this.toolTip1.SetToolTip(this.label8, resources.GetString("label8.ToolTip"));
            // 
            // txtInvoice
            // 
            resources.ApplyResources(this.txtInvoice, "txtInvoice");
            this.txtInvoice.Name = "txtInvoice";
            this.toolTip1.SetToolTip(this.txtInvoice, resources.GetString("txtInvoice.ToolTip"));
            // 
            // lbluser
            // 
            resources.ApplyResources(this.lbluser, "lbluser");
            this.lbluser.Name = "lbluser";
            this.toolTip1.SetToolTip(this.lbluser, resources.GetString("lbluser.ToolTip"));
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            // btnSaveOnly
            // 
            resources.ApplyResources(this.btnSaveOnly, "btnSaveOnly");
            this.btnSaveOnly.BackColor = System.Drawing.Color.Navy;
            this.btnSaveOnly.FlatAppearance.BorderSize = 0;
            this.btnSaveOnly.ForeColor = System.Drawing.Color.Linen;
            this.btnSaveOnly.Name = "btnSaveOnly";
            this.toolTip1.SetToolTip(this.btnSaveOnly, resources.GetString("btnSaveOnly.ToolTip"));
            this.btnSaveOnly.UseVisualStyleBackColor = false;
            this.btnSaveOnly.Click += new System.EventHandler(this.btnSaveOnly_Click);
            // 
            // Payment
            // 
            this.AcceptButton = this.btnCompleteSalesAndPrint;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSaveOnly);
            this.Controls.Add(this.lbluser);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtInvoice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtSalesDate);
            this.Controls.Add(this.btnCompleteSalesAndPrint);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgrvSalesItemList);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Payment";
            this.ShowIcon = false;
            this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.Load += new System.EventHandler(this.Payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrvSalesItemList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrvSalesItemList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCustID;
        private System.Windows.Forms.ComboBox ComboCustID;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.TextBox txtDueAmount;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtPaidAmount;
        private System.Windows.Forms.TextBox txtChangeAmount;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox CombPayby;
        private System.Windows.Forms.Panel panel3;
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
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label lblTotalVAT;
        private System.Windows.Forms.Label lblTotalDisCount;
        private System.Windows.Forms.TextBox txtDiscountRate;
        private System.Windows.Forms.Button btnCompleteSalesAndPrint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtSalesDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtInvoice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalItems;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnSaveOnly;
    }
}