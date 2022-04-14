namespace supershop.User_mgt
{
    partial class Manage_user
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manage_user));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lnkWorkingHours = new System.Windows.Forms.LinkLabel();
            this.txtsearchUser = new System.Windows.Forms.TextBox();
            this.btnCreateLink = new System.Windows.Forms.Button();
            this.flowLayoutPanelUserList = new System.Windows.Forms.FlowLayoutPanel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.lnkWorkingHours);
            this.splitContainer1.Panel1.Controls.Add(this.txtsearchUser);
            this.splitContainer1.Panel1.Controls.Add(this.btnCreateLink);
            this.toolTip1.SetToolTip(this.splitContainer1.Panel1, resources.GetString("splitContainer1.Panel1.ToolTip"));
            // 
            // splitContainer1.Panel2
            // 
            resources.ApplyResources(this.splitContainer1.Panel2, "splitContainer1.Panel2");
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanelUserList);
            this.toolTip1.SetToolTip(this.splitContainer1.Panel2, resources.GetString("splitContainer1.Panel2.ToolTip"));
            this.toolTip1.SetToolTip(this.splitContainer1, resources.GetString("splitContainer1.ToolTip"));
            // 
            // lnkWorkingHours
            // 
            resources.ApplyResources(this.lnkWorkingHours, "lnkWorkingHours");
            this.lnkWorkingHours.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkWorkingHours.Name = "lnkWorkingHours";
            this.lnkWorkingHours.TabStop = true;
            this.toolTip1.SetToolTip(this.lnkWorkingHours, resources.GetString("lnkWorkingHours.ToolTip"));
            this.lnkWorkingHours.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkWorkingHours_LinkClicked);
            // 
            // txtsearchUser
            // 
            resources.ApplyResources(this.txtsearchUser, "txtsearchUser");
            this.txtsearchUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtsearchUser.Name = "txtsearchUser";
            this.toolTip1.SetToolTip(this.txtsearchUser, resources.GetString("txtsearchUser.ToolTip"));
            this.txtsearchUser.TextChanged += new System.EventHandler(this.txtsearchUser_TextChanged);
            // 
            // btnCreateLink
            // 
            resources.ApplyResources(this.btnCreateLink, "btnCreateLink");
            this.btnCreateLink.BackColor = System.Drawing.SystemColors.Control;
            this.btnCreateLink.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCreateLink.FlatAppearance.BorderSize = 0;
            this.btnCreateLink.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCreateLink.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chartreuse;
            this.btnCreateLink.Name = "btnCreateLink";
            this.toolTip1.SetToolTip(this.btnCreateLink, resources.GetString("btnCreateLink.ToolTip"));
            this.btnCreateLink.UseVisualStyleBackColor = false;
            this.btnCreateLink.Click += new System.EventHandler(this.btnCreateLink_Click);
            // 
            // flowLayoutPanelUserList
            // 
            resources.ApplyResources(this.flowLayoutPanelUserList, "flowLayoutPanelUserList");
            this.flowLayoutPanelUserList.Name = "flowLayoutPanelUserList";
            this.toolTip1.SetToolTip(this.flowLayoutPanelUserList, resources.GetString("flowLayoutPanelUserList.ToolTip"));
            this.flowLayoutPanelUserList.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanelUserList_Paint);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 800;
            this.toolTip1.AutoPopDelay = 8000;
            this.toolTip1.InitialDelay = 9;
            this.toolTip1.ReshowDelay = 9;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // Manage_user
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.Name = "Manage_user";
            this.ShowIcon = false;
            this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.Load += new System.EventHandler(this.Manage_user_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Manage_user_MouseDown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateLink;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelUserList;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtsearchUser;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.LinkLabel lnkWorkingHours;
    }
}