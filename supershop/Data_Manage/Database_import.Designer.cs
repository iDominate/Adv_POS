namespace supershop
{
    partial class Database_import
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Database_import));
            this.btnimport = new System.Windows.Forms.Button();
            this.txtfilepath = new System.Windows.Forms.TextBox();
            this.btnbrowse = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.toolTipInfo = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnimport
            // 
            resources.ApplyResources(this.btnimport, "btnimport");
            this.btnimport.Name = "btnimport";
            this.toolTipInfo.SetToolTip(this.btnimport, resources.GetString("btnimport.ToolTip"));
            this.btnimport.UseVisualStyleBackColor = true;
            this.btnimport.Click += new System.EventHandler(this.btnimport_Click);
            // 
            // txtfilepath
            // 
            resources.ApplyResources(this.txtfilepath, "txtfilepath");
            this.txtfilepath.Name = "txtfilepath";
            this.txtfilepath.ReadOnly = true;
            this.toolTipInfo.SetToolTip(this.txtfilepath, resources.GetString("txtfilepath.ToolTip"));
            this.txtfilepath.Click += new System.EventHandler(this.btnbrowse_Click);
            // 
            // btnbrowse
            // 
            resources.ApplyResources(this.btnbrowse, "btnbrowse");
            this.btnbrowse.Name = "btnbrowse";
            this.toolTipInfo.SetToolTip(this.btnbrowse, resources.GetString("btnbrowse.ToolTip"));
            this.btnbrowse.UseVisualStyleBackColor = true;
            this.btnbrowse.Click += new System.EventHandler(this.btnbrowse_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            resources.ApplyResources(this.openFileDialog1, "openFileDialog1");
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.toolTipInfo.SetToolTip(this.button3, resources.GetString("button3.ToolTip"));
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // toolTipInfo
            // 
            this.toolTipInfo.AutomaticDelay = 800;
            this.toolTipInfo.AutoPopDelay = 80000;
            this.toolTipInfo.BackColor = System.Drawing.Color.OliveDrab;
            this.toolTipInfo.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolTipInfo.InitialDelay = 1;
            this.toolTipInfo.ReshowDelay = 1;
            this.toolTipInfo.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.toolTipInfo.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.toolTipInfo.SetToolTip(this.label2, resources.GetString("label2.ToolTip"));
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            this.toolTipInfo.SetToolTip(this.label3, resources.GetString("label3.ToolTip"));
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            this.toolTipInfo.SetToolTip(this.label4, resources.GetString("label4.ToolTip"));
            // 
            // Database_import
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnbrowse);
            this.Controls.Add(this.txtfilepath);
            this.Controls.Add(this.btnimport);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Database_import";
            this.ShowIcon = false;
            this.toolTipInfo.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.Load += new System.EventHandler(this.Database_import_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnimport;
        private System.Windows.Forms.TextBox txtfilepath;
        private System.Windows.Forms.Button btnbrowse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolTip toolTipInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}