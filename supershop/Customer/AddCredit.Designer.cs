namespace supershop.Customer
{
    partial class AddCredit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCredit));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDesCription = new System.Windows.Forms.TextBox();
            this.NumUDcredit = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ComboCustID = new System.Windows.Forms.ComboBox();
            this.lblCustID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDcredit)).BeginInit();
            this.SuspendLayout();
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
            // txtDesCription
            // 
            resources.ApplyResources(this.txtDesCription, "txtDesCription");
            this.txtDesCription.Name = "txtDesCription";
            // 
            // NumUDcredit
            // 
            resources.ApplyResources(this.NumUDcredit, "NumUDcredit");
            this.NumUDcredit.Name = "NumUDcredit";
            this.NumUDcredit.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtDate
            // 
            resources.ApplyResources(this.dtDate, "dtDate");
            this.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDate.Name = "dtDate";
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
            // ComboCustID
            // 
            resources.ApplyResources(this.ComboCustID, "ComboCustID");
            this.ComboCustID.FormattingEnabled = true;
            this.ComboCustID.Name = "ComboCustID";
            this.ComboCustID.SelectedIndexChanged += new System.EventHandler(this.ComboCustID_SelectedIndexChanged);
            // 
            // lblCustID
            // 
            resources.ApplyResources(this.lblCustID, "lblCustID");
            this.lblCustID.Name = "lblCustID";
            // 
            // AddCredit
            // 
            this.AcceptButton = this.btnSave;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCustID);
            this.Controls.Add(this.ComboCustID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.NumUDcredit);
            this.Controls.Add(this.txtDesCription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddCredit";
            this.ShowIcon = false;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddCredit_FormClosed);
            this.Load += new System.EventHandler(this.AddCredit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumUDcredit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDesCription;
        private System.Windows.Forms.NumericUpDown NumUDcredit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ComboCustID;
        private System.Windows.Forms.Label lblCustID;
    }
}