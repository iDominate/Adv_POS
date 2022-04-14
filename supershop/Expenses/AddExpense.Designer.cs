namespace supershop.Expenses
{
    partial class AddExpense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddExpense));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.txtReferNo = new System.Windows.Forms.TextBox();
            this.cmboCategory = new System.Windows.Forms.ComboBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtAttachmentFileName = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.btnaddexpense = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblfileID = new System.Windows.Forms.Label();
            this.lblcopyfile = new System.Windows.Forms.Label();
            this.lblFileExtension = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblfileinfo = new System.Windows.Forms.Label();
            this.lnkExpenses = new System.Windows.Forms.LinkLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.toolTip1.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.toolTip1.SetToolTip(this.label2, resources.GetString("label2.ToolTip"));
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            this.toolTip1.SetToolTip(this.label3, resources.GetString("label3.ToolTip"));
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            this.toolTip1.SetToolTip(this.label4, resources.GetString("label4.ToolTip"));
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            this.toolTip1.SetToolTip(this.label5, resources.GetString("label5.ToolTip"));
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            this.toolTip1.SetToolTip(this.label6, resources.GetString("label6.ToolTip"));
            // 
            // dtStartDate
            // 
            resources.ApplyResources(this.dtStartDate, "dtStartDate");
            this.dtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStartDate.Name = "dtStartDate";
            this.toolTip1.SetToolTip(this.dtStartDate, resources.GetString("dtStartDate.ToolTip"));
            // 
            // txtReferNo
            // 
            resources.ApplyResources(this.txtReferNo, "txtReferNo");
            this.txtReferNo.Name = "txtReferNo";
            this.toolTip1.SetToolTip(this.txtReferNo, resources.GetString("txtReferNo.ToolTip"));
            // 
            // cmboCategory
            // 
            resources.ApplyResources(this.cmboCategory, "cmboCategory");
            this.cmboCategory.FormattingEnabled = true;
            this.cmboCategory.Items.AddRange(new object[] {
            resources.GetString("cmboCategory.Items"),
            resources.GetString("cmboCategory.Items1"),
            resources.GetString("cmboCategory.Items2"),
            resources.GetString("cmboCategory.Items3"),
            resources.GetString("cmboCategory.Items4"),
            resources.GetString("cmboCategory.Items5"),
            resources.GetString("cmboCategory.Items6"),
            resources.GetString("cmboCategory.Items7"),
            resources.GetString("cmboCategory.Items8"),
            resources.GetString("cmboCategory.Items9"),
            resources.GetString("cmboCategory.Items10"),
            resources.GetString("cmboCategory.Items11")});
            this.cmboCategory.Name = "cmboCategory";
            this.toolTip1.SetToolTip(this.cmboCategory, resources.GetString("cmboCategory.ToolTip"));
            // 
            // txtAmount
            // 
            resources.ApplyResources(this.txtAmount, "txtAmount");
            this.txtAmount.Name = "txtAmount";
            this.toolTip1.SetToolTip(this.txtAmount, resources.GetString("txtAmount.ToolTip"));
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // txtAttachmentFileName
            // 
            resources.ApplyResources(this.txtAttachmentFileName, "txtAttachmentFileName");
            this.txtAttachmentFileName.Name = "txtAttachmentFileName";
            this.toolTip1.SetToolTip(this.txtAttachmentFileName, resources.GetString("txtAttachmentFileName.ToolTip"));
            this.txtAttachmentFileName.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnBrowse
            // 
            resources.ApplyResources(this.btnBrowse, "btnBrowse");
            this.btnBrowse.Name = "btnBrowse";
            this.toolTip1.SetToolTip(this.btnBrowse, resources.GetString("btnBrowse.ToolTip"));
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtNote
            // 
            resources.ApplyResources(this.txtNote, "txtNote");
            this.txtNote.Name = "txtNote";
            this.toolTip1.SetToolTip(this.txtNote, resources.GetString("txtNote.ToolTip"));
            // 
            // btnaddexpense
            // 
            resources.ApplyResources(this.btnaddexpense, "btnaddexpense");
            this.btnaddexpense.Name = "btnaddexpense";
            this.toolTip1.SetToolTip(this.btnaddexpense, resources.GetString("btnaddexpense.ToolTip"));
            this.btnaddexpense.UseVisualStyleBackColor = true;
            this.btnaddexpense.Click += new System.EventHandler(this.btnaddexpense_Click);
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
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainer1.Panel1.Controls.Add(this.lblfileID);
            this.splitContainer1.Panel1.Controls.Add(this.lblcopyfile);
            this.splitContainer1.Panel1.Controls.Add(this.lblFileExtension);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.dtStartDate);
            this.splitContainer1.Panel1.Controls.Add(this.btnaddexpense);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.txtNote);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.btnBrowse);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.txtAttachmentFileName);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.txtAmount);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.cmboCategory);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.txtReferNo);
            this.toolTip1.SetToolTip(this.splitContainer1.Panel1, resources.GetString("splitContainer1.Panel1.ToolTip"));
            // 
            // splitContainer1.Panel2
            // 
            resources.ApplyResources(this.splitContainer1.Panel2, "splitContainer1.Panel2");
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.lblfileinfo);
            this.splitContainer1.Panel2.Controls.Add(this.lnkExpenses);
            this.toolTip1.SetToolTip(this.splitContainer1.Panel2, resources.GetString("splitContainer1.Panel2.ToolTip"));
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.toolTip1.SetToolTip(this.splitContainer1, resources.GetString("splitContainer1.ToolTip"));
            // 
            // lblfileID
            // 
            resources.ApplyResources(this.lblfileID, "lblfileID");
            this.lblfileID.Name = "lblfileID";
            this.toolTip1.SetToolTip(this.lblfileID, resources.GetString("lblfileID.ToolTip"));
            // 
            // lblcopyfile
            // 
            resources.ApplyResources(this.lblcopyfile, "lblcopyfile");
            this.lblcopyfile.Name = "lblcopyfile";
            this.toolTip1.SetToolTip(this.lblcopyfile, resources.GetString("lblcopyfile.ToolTip"));
            // 
            // lblFileExtension
            // 
            resources.ApplyResources(this.lblFileExtension, "lblFileExtension");
            this.lblFileExtension.Name = "lblFileExtension";
            this.toolTip1.SetToolTip(this.lblFileExtension, resources.GetString("lblFileExtension.ToolTip"));
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            this.toolTip1.SetToolTip(this.label8, resources.GetString("label8.ToolTip"));
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            this.toolTip1.SetToolTip(this.label7, resources.GetString("label7.ToolTip"));
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            this.toolTip1.SetToolTip(this.label9, resources.GetString("label9.ToolTip"));
            // 
            // lblfileinfo
            // 
            resources.ApplyResources(this.lblfileinfo, "lblfileinfo");
            this.lblfileinfo.Name = "lblfileinfo";
            this.toolTip1.SetToolTip(this.lblfileinfo, resources.GetString("lblfileinfo.ToolTip"));
            // 
            // lnkExpenses
            // 
            resources.ApplyResources(this.lnkExpenses, "lnkExpenses");
            this.lnkExpenses.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkExpenses.LinkVisited = true;
            this.lnkExpenses.Name = "lnkExpenses";
            this.lnkExpenses.TabStop = true;
            this.toolTip1.SetToolTip(this.lnkExpenses, resources.GetString("lnkExpenses.ToolTip"));
            this.lnkExpenses.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkExpenses_LinkClicked);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 800;
            this.toolTip1.AutoPopDelay = 8000;
            this.toolTip1.InitialDelay = 10;
            this.toolTip1.ReshowDelay = 10;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            resources.ApplyResources(this.openFileDialog1, "openFileDialog1");
            // 
            // AddExpense
            // 
            this.AcceptButton = this.btnaddexpense;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddExpense";
            this.ShowIcon = false;
            this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.Load += new System.EventHandler(this.AddExpense_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtStartDate;
        private System.Windows.Forms.TextBox txtReferNo;
        private System.Windows.Forms.ComboBox cmboCategory;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtAttachmentFileName;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Button btnaddexpense;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.LinkLabel lnkExpenses;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblFileExtension;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblcopyfile;
        private System.Windows.Forms.Label lblfileinfo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblfileID;
    }
}