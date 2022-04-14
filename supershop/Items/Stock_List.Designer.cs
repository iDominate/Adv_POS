namespace supershop
{
    partial class Stock_List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock_List));
            this.txtItemSearchBar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.picCloseEvent = new System.Windows.Forms.PictureBox();
            this.lblMinimized = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnChart = new System.Windows.Forms.Button();
            this.combCategory = new System.Windows.Forms.ComboBox();
            this.bntStock = new System.Windows.Forms.Button();
            this.btnpurchasehistory = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCreateBarcode = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanelUserList = new System.Windows.Forms.FlowLayoutPanel();
            this.label24 = new System.Windows.Forms.Label();
            this.lblRows = new System.Windows.Forms.Label();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCloseEvent)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtItemSearchBar
            // 
            resources.ApplyResources(this.txtItemSearchBar, "txtItemSearchBar");
            this.txtItemSearchBar.Name = "txtItemSearchBar";
            this.toolTip1.SetToolTip(this.txtItemSearchBar, resources.GetString("txtItemSearchBar.ToolTip"));
            this.txtItemSearchBar.TextChanged += new System.EventHandler(this.txtItemSearchBar_TextChanged);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            this.toolTip1.SetToolTip(this.label6, resources.GetString("label6.ToolTip"));
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.Violet;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.picCloseEvent);
            this.panel1.Controls.Add(this.lblMinimized);
            this.panel1.Name = "panel1";
            this.toolTip1.SetToolTip(this.panel1, resources.GetString("panel1.ToolTip"));
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.detail_info_MouseDown);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label5.Name = "label5";
            this.toolTip1.SetToolTip(this.label5, resources.GetString("label5.ToolTip"));
            // 
            // picCloseEvent
            // 
            resources.ApplyResources(this.picCloseEvent, "picCloseEvent");
            this.picCloseEvent.Cursor = System.Windows.Forms.Cursors.Cross;
            this.picCloseEvent.Name = "picCloseEvent";
            this.picCloseEvent.TabStop = false;
            this.toolTip1.SetToolTip(this.picCloseEvent, resources.GetString("picCloseEvent.ToolTip"));
            this.picCloseEvent.Click += new System.EventHandler(this.picCloseEvent_Click);
            // 
            // lblMinimized
            // 
            resources.ApplyResources(this.lblMinimized, "lblMinimized");
            this.lblMinimized.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMinimized.Name = "lblMinimized";
            this.toolTip1.SetToolTip(this.lblMinimized, resources.GetString("lblMinimized.ToolTip"));
            this.lblMinimized.Click += new System.EventHandler(this.lblMinimized_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 800;
            this.toolTip1.AutoPopDelay = 39000;
            this.toolTip1.InitialDelay = 9;
            this.toolTip1.ReshowDelay = 9;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // btnChart
            // 
            resources.ApplyResources(this.btnChart, "btnChart");
            this.btnChart.FlatAppearance.BorderSize = 0;
            this.btnChart.Name = "btnChart";
            this.toolTip1.SetToolTip(this.btnChart, resources.GetString("btnChart.ToolTip"));
            this.btnChart.UseVisualStyleBackColor = true;
            this.btnChart.Click += new System.EventHandler(this.btnChart_Click);
            // 
            // combCategory
            // 
            resources.ApplyResources(this.combCategory, "combCategory");
            this.combCategory.FormattingEnabled = true;
            this.combCategory.Name = "combCategory";
            this.toolTip1.SetToolTip(this.combCategory, resources.GetString("combCategory.ToolTip"));
            this.combCategory.SelectedIndexChanged += new System.EventHandler(this.combCategory_SelectedIndexChanged);
            // 
            // bntStock
            // 
            resources.ApplyResources(this.bntStock, "bntStock");
            this.bntStock.FlatAppearance.BorderSize = 0;
            this.bntStock.Name = "bntStock";
            this.toolTip1.SetToolTip(this.bntStock, resources.GetString("bntStock.ToolTip"));
            this.bntStock.UseVisualStyleBackColor = true;
            this.bntStock.Click += new System.EventHandler(this.bntStock_Click);
            // 
            // btnpurchasehistory
            // 
            resources.ApplyResources(this.btnpurchasehistory, "btnpurchasehistory");
            this.btnpurchasehistory.FlatAppearance.BorderSize = 0;
            this.btnpurchasehistory.Name = "btnpurchasehistory";
            this.toolTip1.SetToolTip(this.btnpurchasehistory, resources.GetString("btnpurchasehistory.ToolTip"));
            this.btnpurchasehistory.UseVisualStyleBackColor = true;
            this.btnpurchasehistory.Click += new System.EventHandler(this.btnpurchasehistory_Click);
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackColor = System.Drawing.Color.Green;
            this.panel2.Name = "panel2";
            this.toolTip1.SetToolTip(this.panel2, resources.GetString("panel2.ToolTip"));
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.detail_info_MouseDown);
            // 
            // btnCreateBarcode
            // 
            resources.ApplyResources(this.btnCreateBarcode, "btnCreateBarcode");
            this.btnCreateBarcode.FlatAppearance.BorderSize = 0;
            this.btnCreateBarcode.Name = "btnCreateBarcode";
            this.toolTip1.SetToolTip(this.btnCreateBarcode, resources.GetString("btnCreateBarcode.ToolTip"));
            this.btnCreateBarcode.UseVisualStyleBackColor = true;
            this.btnCreateBarcode.Click += new System.EventHandler(this.btnCreateBarcode_Click);
            // 
            // btnImport
            // 
            resources.ApplyResources(this.btnImport, "btnImport");
            this.btnImport.BackColor = System.Drawing.SystemColors.Control;
            this.btnImport.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btnImport.FlatAppearance.BorderSize = 0;
            this.btnImport.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnImport.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Desktop;
            this.btnImport.Name = "btnImport";
            this.toolTip1.SetToolTip(this.btnImport, resources.GetString("btnImport.ToolTip"));
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Controls.Add(this.flowLayoutPanelUserList);
            this.panel3.Name = "panel3";
            this.toolTip1.SetToolTip(this.panel3, resources.GetString("panel3.ToolTip"));
            // 
            // flowLayoutPanelUserList
            // 
            resources.ApplyResources(this.flowLayoutPanelUserList, "flowLayoutPanelUserList");
            this.flowLayoutPanelUserList.Name = "flowLayoutPanelUserList";
            this.toolTip1.SetToolTip(this.flowLayoutPanelUserList, resources.GetString("flowLayoutPanelUserList.ToolTip"));
            // 
            // label24
            // 
            resources.ApplyResources(this.label24, "label24");
            this.label24.Name = "label24";
            this.toolTip1.SetToolTip(this.label24, resources.GetString("label24.ToolTip"));
            // 
            // lblRows
            // 
            resources.ApplyResources(this.lblRows, "lblRows");
            this.lblRows.Name = "lblRows";
            this.toolTip1.SetToolTip(this.lblRows, resources.GetString("lblRows.ToolTip"));
            // 
            // btnAddNew
            // 
            resources.ApplyResources(this.btnAddNew, "btnAddNew");
            this.btnAddNew.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddNew.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btnAddNew.FlatAppearance.BorderSize = 0;
            this.btnAddNew.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAddNew.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Desktop;
            this.btnAddNew.Name = "btnAddNew";
            this.toolTip1.SetToolTip(this.btnAddNew, resources.GetString("btnAddNew.ToolTip"));
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // Stock_List
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btnpurchasehistory);
            this.Controls.Add(this.bntStock);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.lblRows);
            this.Controls.Add(this.combCategory);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnChart);
            this.Controls.Add(this.btnCreateBarcode);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtItemSearchBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Stock_List";
            this.ShowIcon = false;
            this.Tag = "";
            this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.Load += new System.EventHandler(this.detail_info_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.detail_info_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCloseEvent)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtItemSearchBar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMinimized;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCreateBarcode;
        private System.Windows.Forms.Button btnChart;
        private System.Windows.Forms.PictureBox picCloseEvent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelUserList;
        private System.Windows.Forms.ComboBox combCategory;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lblRows;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button bntStock;
        private System.Windows.Forms.Button btnpurchasehistory;
    }
}