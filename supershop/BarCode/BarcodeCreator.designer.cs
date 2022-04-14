namespace supershop.BarCode
{
    partial class BarcodeCreator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BarcodeCreator));
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnPreview = new System.Windows.Forms.Button();
            this.nudPages = new System.Windows.Forms.NumericUpDown();
            this.chbShowCheckSum = new System.Windows.Forms.CheckBox();
            this.chbShowText = new System.Windows.Forms.CheckBox();
            this.btnforecolor = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.PrintDialog1 = new System.Windows.Forms.PrintDialog();
            this.ColorDialog1 = new System.Windows.Forms.ColorDialog();
            this.PrintPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.PrintDocument1 = new System.Drawing.Printing.PrintDocument();
            this.EaN13Barcode1 = new MyBarcode.EAN13Barcode();
            this.label8 = new System.Windows.Forms.Label();
            this.cmboProductCode = new System.Windows.Forms.ComboBox();
            this.toolTipInfo = new System.Windows.Forms.ToolTip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lnkAdvanceBC = new System.Windows.Forms.LinkLabel();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPages)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.btnPrint);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.btnPreview);
            this.GroupBox1.Controls.Add(this.nudPages);
            resources.ApplyResources(this.GroupBox1, "GroupBox1");
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.TabStop = false;
            // 
            // btnPrint
            // 
            resources.ApplyResources(this.btnPrint, "btnPrint");
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // Label1
            // 
            resources.ApplyResources(this.Label1, "Label1");
            this.Label1.Name = "Label1";
            // 
            // btnPreview
            // 
            resources.ApplyResources(this.btnPreview, "btnPreview");
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // nudPages
            // 
            resources.ApplyResources(this.nudPages, "nudPages");
            this.nudPages.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPages.Name = "nudPages";
            this.nudPages.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // chbShowCheckSum
            // 
            resources.ApplyResources(this.chbShowCheckSum, "chbShowCheckSum");
            this.chbShowCheckSum.Name = "chbShowCheckSum";
            this.chbShowCheckSum.UseVisualStyleBackColor = true;
            this.chbShowCheckSum.CheckedChanged += new System.EventHandler(this.chbShowCheckSum_CheckedChanged);
            // 
            // chbShowText
            // 
            resources.ApplyResources(this.chbShowText, "chbShowText");
            this.chbShowText.Name = "chbShowText";
            this.chbShowText.UseVisualStyleBackColor = true;
            this.chbShowText.CheckedChanged += new System.EventHandler(this.chbShowText_CheckedChanged);
            // 
            // btnforecolor
            // 
            this.btnforecolor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnforecolor.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnforecolor.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnforecolor, "btnforecolor");
            this.btnforecolor.ForeColor = System.Drawing.Color.Black;
            this.btnforecolor.Name = "btnforecolor";
            this.btnforecolor.UseVisualStyleBackColor = false;
            this.btnforecolor.Click += new System.EventHandler(this.btnforecolor_Click);
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnColor.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnColor, "btnColor");
            this.btnColor.Name = "btnColor";
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCreate.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnCreate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.btnCreate, "btnCreate");
            this.btnCreate.Name = "btnCreate";
            this.toolTipInfo.SetToolTip(this.btnCreate, resources.GetString("btnCreate.ToolTip"));
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // PrintDialog1
            // 
            this.PrintDialog1.AllowCurrentPage = true;
            this.PrintDialog1.UseEXDialog = true;
            // 
            // PrintPreviewDialog1
            // 
            resources.ApplyResources(this.PrintPreviewDialog1, "PrintPreviewDialog1");
            this.PrintPreviewDialog1.Name = "PrintPreviewDialog1";
            // 
            // PrintDocument1
            // 
            this.PrintDocument1.DocumentName = "BacodePrint";
            this.PrintDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage);
            // 
            // EaN13Barcode1
            // 
            this.EaN13Barcode1.BackColor = System.Drawing.Color.White;
            this.EaN13Barcode1.BarHeight = 0D;
            this.EaN13Barcode1.BarWidth = 0.33D;
            this.EaN13Barcode1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.EaN13Barcode1, "EaN13Barcode1");
            this.EaN13Barcode1.ForeColor = System.Drawing.Color.Black;
            this.EaN13Barcode1.Name = "EaN13Barcode1";
            this.EaN13Barcode1.ShowBarcodeText = false;
            this.EaN13Barcode1.ShowCheckSum = false;
            this.EaN13Barcode1.Value = "000000000000";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // cmboProductCode
            // 
            this.cmboProductCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmboProductCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmboProductCode.FormattingEnabled = true;
            resources.ApplyResources(this.cmboProductCode, "cmboProductCode");
            this.cmboProductCode.Name = "cmboProductCode";
            this.toolTipInfo.SetToolTip(this.cmboProductCode, resources.GetString("cmboProductCode.ToolTip"));
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
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // lnkAdvanceBC
            // 
            resources.ApplyResources(this.lnkAdvanceBC, "lnkAdvanceBC");
            this.lnkAdvanceBC.Name = "lnkAdvanceBC";
            this.lnkAdvanceBC.TabStop = true;
            this.lnkAdvanceBC.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAdvanceBC_LinkClicked);
            // 
            // BarcodeCreator
            // 
            this.AcceptButton = this.btnCreate;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lnkAdvanceBC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmboProductCode);
            this.Controls.Add(this.EaN13Barcode1);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.chbShowCheckSum);
            this.Controls.Add(this.chbShowText);
            this.Controls.Add(this.btnforecolor);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.btnCreate);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BarcodeCreator";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.BarcodeCreator_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Button btnPrint;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button btnPreview;
        internal System.Windows.Forms.NumericUpDown nudPages;
        internal System.Windows.Forms.CheckBox chbShowCheckSum;
        internal System.Windows.Forms.CheckBox chbShowText;
        internal System.Windows.Forms.Button btnforecolor;
        internal System.Windows.Forms.Button btnColor;
        internal System.Windows.Forms.Button btnCreate;
        internal System.Windows.Forms.PrintDialog PrintDialog1;
        internal System.Windows.Forms.ColorDialog ColorDialog1;
        internal System.Windows.Forms.PrintPreviewDialog PrintPreviewDialog1;
        internal System.Drawing.Printing.PrintDocument PrintDocument1;
        internal MyBarcode.EAN13Barcode EaN13Barcode1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmboProductCode;
        private System.Windows.Forms.ToolTip toolTipInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel lnkAdvanceBC;
    }
}

