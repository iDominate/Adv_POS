namespace supershop.Customer
{
    partial class AddNewCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewCustomer));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lnkCustomers = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCustID = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.txtCustomerAddress = new System.Windows.Forms.TextBox();
            this.CombPeopleType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lbltoplabel = new System.Windows.Forms.Label();
            this.lblcuthistorylabel = new System.Windows.Forms.Label();
            this.grboxCusthistory = new System.Windows.Forms.Panel();
            this.dtgviewCusttrxHistory = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.grboxCusthistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgviewCusttrxHistory)).BeginInit();
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
            this.splitContainer1.Panel1.AllowDrop = true;
            this.splitContainer1.Panel1.Controls.Add(this.btnPrint);
            this.splitContainer1.Panel1.Controls.Add(this.lnkCustomers);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.lblCustID);
            this.splitContainer1.Panel1.Controls.Add(this.txtCustomerName);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.lblMsg);
            this.splitContainer1.Panel1.Controls.Add(this.txtCustomerAddress);
            this.splitContainer1.Panel1.Controls.Add(this.CombPeopleType);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.btnSave);
            this.splitContainer1.Panel1.Controls.Add(this.txtEmailAddress);
            this.splitContainer1.Panel1.Controls.Add(this.txtCity);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.txtPhone);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.toolTip1.SetToolTip(this.splitContainer1.Panel1, resources.GetString("splitContainer1.Panel1.ToolTip"));
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            resources.ApplyResources(this.splitContainer1.Panel2, "splitContainer1.Panel2");
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.toolTip1.SetToolTip(this.splitContainer1.Panel2, resources.GetString("splitContainer1.Panel2.ToolTip"));
            this.toolTip1.SetToolTip(this.splitContainer1, resources.GetString("splitContainer1.ToolTip"));
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
            // lnkCustomers
            // 
            resources.ApplyResources(this.lnkCustomers, "lnkCustomers");
            this.lnkCustomers.Name = "lnkCustomers";
            this.lnkCustomers.TabStop = true;
            this.toolTip1.SetToolTip(this.lnkCustomers, resources.GetString("lnkCustomers.ToolTip"));
            this.lnkCustomers.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCustomers_LinkClicked);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.toolTip1.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
            // 
            // lblCustID
            // 
            resources.ApplyResources(this.lblCustID, "lblCustID");
            this.lblCustID.Name = "lblCustID";
            this.toolTip1.SetToolTip(this.lblCustID, resources.GetString("lblCustID.ToolTip"));
            // 
            // txtCustomerName
            // 
            resources.ApplyResources(this.txtCustomerName, "txtCustomerName");
            this.txtCustomerName.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtCustomerName.Name = "txtCustomerName";
            this.toolTip1.SetToolTip(this.txtCustomerName, resources.GetString("txtCustomerName.ToolTip"));
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            this.toolTip1.SetToolTip(this.label6, resources.GetString("label6.ToolTip"));
            // 
            // lblMsg
            // 
            resources.ApplyResources(this.lblMsg, "lblMsg");
            this.lblMsg.ForeColor = System.Drawing.Color.Red;
            this.lblMsg.Name = "lblMsg";
            this.toolTip1.SetToolTip(this.lblMsg, resources.GetString("lblMsg.ToolTip"));
            // 
            // txtCustomerAddress
            // 
            resources.ApplyResources(this.txtCustomerAddress, "txtCustomerAddress");
            this.txtCustomerAddress.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.toolTip1.SetToolTip(this.txtCustomerAddress, resources.GetString("txtCustomerAddress.ToolTip"));
            // 
            // CombPeopleType
            // 
            resources.ApplyResources(this.CombPeopleType, "CombPeopleType");
            this.CombPeopleType.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.CombPeopleType.FormattingEnabled = true;
            this.CombPeopleType.Items.AddRange(new object[] {
            resources.GetString("CombPeopleType.Items"),
            resources.GetString("CombPeopleType.Items1")});
            this.CombPeopleType.Name = "CombPeopleType";
            this.toolTip1.SetToolTip(this.CombPeopleType, resources.GetString("CombPeopleType.ToolTip"));
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            this.toolTip1.SetToolTip(this.label5, resources.GetString("label5.ToolTip"));
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.toolTip1.SetToolTip(this.label2, resources.GetString("label2.ToolTip"));
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSave.ForeColor = System.Drawing.Color.YellowGreen;
            this.btnSave.Name = "btnSave";
            this.toolTip1.SetToolTip(this.btnSave, resources.GetString("btnSave.ToolTip"));
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtEmailAddress
            // 
            resources.ApplyResources(this.txtEmailAddress, "txtEmailAddress");
            this.txtEmailAddress.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.toolTip1.SetToolTip(this.txtEmailAddress, resources.GetString("txtEmailAddress.ToolTip"));
            // 
            // txtCity
            // 
            resources.ApplyResources(this.txtCity, "txtCity");
            this.txtCity.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtCity.Name = "txtCity";
            this.toolTip1.SetToolTip(this.txtCity, resources.GetString("txtCity.ToolTip"));
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            this.toolTip1.SetToolTip(this.label3, resources.GetString("label3.ToolTip"));
            // 
            // txtPhone
            // 
            resources.ApplyResources(this.txtPhone, "txtPhone");
            this.txtPhone.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtPhone.Name = "txtPhone";
            this.toolTip1.SetToolTip(this.txtPhone, resources.GetString("txtPhone.ToolTip"));
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            this.toolTip1.SetToolTip(this.label8, resources.GetString("label8.ToolTip"));
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
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer2.Panel1.Controls.Add(this.lbltoplabel);
            this.splitContainer2.Panel1.Controls.Add(this.lblcuthistorylabel);
            this.toolTip1.SetToolTip(this.splitContainer2.Panel1, resources.GetString("splitContainer2.Panel1.ToolTip"));
            // 
            // splitContainer2.Panel2
            // 
            resources.ApplyResources(this.splitContainer2.Panel2, "splitContainer2.Panel2");
            this.splitContainer2.Panel2.Controls.Add(this.grboxCusthistory);
            this.toolTip1.SetToolTip(this.splitContainer2.Panel2, resources.GetString("splitContainer2.Panel2.ToolTip"));
            this.toolTip1.SetToolTip(this.splitContainer2, resources.GetString("splitContainer2.ToolTip"));
            // 
            // lbltoplabel
            // 
            resources.ApplyResources(this.lbltoplabel, "lbltoplabel");
            this.lbltoplabel.Name = "lbltoplabel";
            this.toolTip1.SetToolTip(this.lbltoplabel, resources.GetString("lbltoplabel.ToolTip"));
            // 
            // lblcuthistorylabel
            // 
            resources.ApplyResources(this.lblcuthistorylabel, "lblcuthistorylabel");
            this.lblcuthistorylabel.Name = "lblcuthistorylabel";
            this.toolTip1.SetToolTip(this.lblcuthistorylabel, resources.GetString("lblcuthistorylabel.ToolTip"));
            // 
            // grboxCusthistory
            // 
            resources.ApplyResources(this.grboxCusthistory, "grboxCusthistory");
            this.grboxCusthistory.Controls.Add(this.dtgviewCusttrxHistory);
            this.grboxCusthistory.Name = "grboxCusthistory";
            this.toolTip1.SetToolTip(this.grboxCusthistory, resources.GetString("grboxCusthistory.ToolTip"));
            // 
            // dtgviewCusttrxHistory
            // 
            resources.ApplyResources(this.dtgviewCusttrxHistory, "dtgviewCusttrxHistory");
            this.dtgviewCusttrxHistory.AllowUserToAddRows = false;
            this.dtgviewCusttrxHistory.AllowUserToDeleteRows = false;
            this.dtgviewCusttrxHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgviewCusttrxHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgviewCusttrxHistory.Name = "dtgviewCusttrxHistory";
            this.dtgviewCusttrxHistory.ReadOnly = true;
            this.dtgviewCusttrxHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.toolTip1.SetToolTip(this.dtgviewCusttrxHistory, resources.GetString("dtgviewCusttrxHistory.ToolTip"));
            this.dtgviewCusttrxHistory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgviewCusttrxHistory_CellClick);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 800;
            this.toolTip1.AutoPopDelay = 8000;
            this.toolTip1.InitialDelay = 9;
            this.toolTip1.ReshowDelay = 9;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // AddNewCustomer
            // 
            this.AcceptButton = this.btnSave;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddNewCustomer";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddNewCustomer_FormClosed);
            this.Load += new System.EventHandler(this.AddNewCustomer_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.grboxCusthistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgviewCusttrxHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtCustomerAddress;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CombPeopleType;
        private System.Windows.Forms.Label lblCustID;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.LinkLabel lnkCustomers;
        private System.Windows.Forms.DataGridView dtgviewCusttrxHistory;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label lblcuthistorylabel;
        private System.Windows.Forms.Panel grboxCusthistory;
        private System.Windows.Forms.Label lbltoplabel;
        private System.Windows.Forms.Button btnPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}