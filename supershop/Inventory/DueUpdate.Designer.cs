namespace supershop
{
    partial class DueUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DueUpdate));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbsalesid = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbpaidamt = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbtotalamt = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbdate = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbcontact = new System.Windows.Forms.Label();
            this.lbDueAmount = new System.Windows.Forms.Label();
            this.lbreceiveamt = new System.Windows.Forms.Label();
            this.txtReceive = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtReceiveDate = new System.Windows.Forms.DateTimePicker();
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
            // lbsalesid
            // 
            resources.ApplyResources(this.lbsalesid, "lbsalesid");
            this.lbsalesid.Name = "lbsalesid";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // lbpaidamt
            // 
            resources.ApplyResources(this.lbpaidamt, "lbpaidamt");
            this.lbpaidamt.Name = "lbpaidamt";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // lbtotalamt
            // 
            resources.ApplyResources(this.lbtotalamt, "lbtotalamt");
            this.lbtotalamt.Name = "lbtotalamt";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // lbdate
            // 
            resources.ApplyResources(this.lbdate, "lbdate");
            this.lbdate.Name = "lbdate";
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbcontact
            // 
            resources.ApplyResources(this.lbcontact, "lbcontact");
            this.lbcontact.Name = "lbcontact";
            // 
            // lbDueAmount
            // 
            resources.ApplyResources(this.lbDueAmount, "lbDueAmount");
            this.lbDueAmount.Name = "lbDueAmount";
            // 
            // lbreceiveamt
            // 
            resources.ApplyResources(this.lbreceiveamt, "lbreceiveamt");
            this.lbreceiveamt.Name = "lbreceiveamt";
            // 
            // txtReceive
            // 
            resources.ApplyResources(this.txtReceive, "txtReceive");
            this.txtReceive.Name = "txtReceive";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // linkLabel1
            // 
            resources.ApplyResources(this.linkLabel1, "linkLabel1");
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.TabStop = true;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // dtReceiveDate
            // 
            resources.ApplyResources(this.dtReceiveDate, "dtReceiveDate");
            this.dtReceiveDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtReceiveDate.Name = "dtReceiveDate";
            // 
            // DueUpdate
            // 
            this.AcceptButton = this.btnSave;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtReceiveDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtReceive);
            this.Controls.Add(this.lbreceiveamt);
            this.Controls.Add(this.lbDueAmount);
            this.Controls.Add(this.lbcontact);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbdate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbtotalamt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbpaidamt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbsalesid);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DueUpdate";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.DueUpdate_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DueUpdate_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbsalesid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbpaidamt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbtotalamt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbcontact;
        private System.Windows.Forms.Label lbDueAmount;
        private System.Windows.Forms.Label lbreceiveamt;
        private System.Windows.Forms.TextBox txtReceive;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtReceiveDate;
    }
}