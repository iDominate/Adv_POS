namespace supershop.Report
{
    partial class ReportDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportDialog));
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtEndDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.btnContinue = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbEmp = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmboterminal = new System.Windows.Forms.ComboBox();
            this.btnMoredtl = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtStartDate
            // 
            resources.ApplyResources(this.dtStartDate, "dtStartDate");
            this.dtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStartDate.Name = "dtStartDate";
            // 
            // dtEndDate
            // 
            resources.ApplyResources(this.dtEndDate, "dtEndDate");
            this.dtEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEndDate.Name = "dtEndDate";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // btnContinue
            // 
            this.btnContinue.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btnContinue.FlatAppearance.BorderSize = 0;
            this.btnContinue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnContinue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.btnContinue, "btnContinue");
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // cmbEmp
            // 
            this.cmbEmp.FormattingEnabled = true;
            resources.ApplyResources(this.cmbEmp, "cmbEmp");
            this.cmbEmp.Name = "cmbEmp";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // cmboterminal
            // 
            this.cmboterminal.FormattingEnabled = true;
            resources.ApplyResources(this.cmboterminal, "cmboterminal");
            this.cmboterminal.Name = "cmboterminal";
            // 
            // btnMoredtl
            // 
            this.btnMoredtl.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btnMoredtl.FlatAppearance.BorderSize = 0;
            this.btnMoredtl.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnMoredtl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.btnMoredtl, "btnMoredtl");
            this.btnMoredtl.Name = "btnMoredtl";
            this.btnMoredtl.UseVisualStyleBackColor = true;
            this.btnMoredtl.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReset
            // 
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.btnReset, "btnReset");
            this.btnReset.Name = "btnReset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // ReportDialog
            // 
            this.AcceptButton = this.btnContinue;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmboterminal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbEmp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMoredtl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.dtStartDate);
            this.Controls.Add(this.dtEndDate);
            this.Controls.Add(this.label9);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReportDialog";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.ReportDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtStartDate;
        private System.Windows.Forms.DateTimePicker dtEndDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbEmp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmboterminal;
        private System.Windows.Forms.Button btnMoredtl;
        private System.Windows.Forms.Button btnReset;
    }
}