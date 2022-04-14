namespace supershop 
{
    partial class Import_Items
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Import_Items));
            this.dtgridviewImportPreview = new System.Windows.Forms.DataGridView();
            this.btnImportPreview = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSave = new System.Windows.Forms.Button();
            this.rbHeaderYes = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblmsg = new System.Windows.Forms.Label();
            this.lblRows = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblwaiting = new System.Windows.Forms.Label();
            this.picItemimage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridviewImportPreview)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picItemimage)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgridviewImportPreview
            // 
            this.dtgridviewImportPreview.AllowUserToAddRows = false;
            this.dtgridviewImportPreview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgridviewImportPreview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dtgridviewImportPreview, "dtgridviewImportPreview");
            this.dtgridviewImportPreview.Name = "dtgridviewImportPreview";
            this.dtgridviewImportPreview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // btnImportPreview
            // 
            resources.ApplyResources(this.btnImportPreview, "btnImportPreview");
            this.btnImportPreview.Name = "btnImportPreview";
            this.btnImportPreview.UseVisualStyleBackColor = true;
            this.btnImportPreview.Click += new System.EventHandler(this.btnImportPreview_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            resources.ApplyResources(this.openFileDialog1, "openFileDialog1");
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rbHeaderYes
            // 
            resources.ApplyResources(this.rbHeaderYes, "rbHeaderYes");
            this.rbHeaderYes.Checked = true;
            this.rbHeaderYes.Name = "rbHeaderYes";
            this.rbHeaderYes.TabStop = true;
            this.rbHeaderYes.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgridviewImportPreview);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // lblmsg
            // 
            resources.ApplyResources(this.lblmsg, "lblmsg");
            this.lblmsg.ForeColor = System.Drawing.Color.Red;
            this.lblmsg.Name = "lblmsg";
            // 
            // lblRows
            // 
            resources.ApplyResources(this.lblRows, "lblRows");
            this.lblRows.ForeColor = System.Drawing.Color.Red;
            this.lblRows.Name = "lblRows";
            // 
            // linkLabel1
            // 
            resources.ApplyResources(this.linkLabel1, "linkLabel1");
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.TabStop = true;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblwaiting
            // 
            resources.ApplyResources(this.lblwaiting, "lblwaiting");
            this.lblwaiting.ForeColor = System.Drawing.Color.Red;
            this.lblwaiting.Name = "lblwaiting";
            // 
            // picItemimage
            // 
            resources.ApplyResources(this.picItemimage, "picItemimage");
            this.picItemimage.Name = "picItemimage";
            this.picItemimage.TabStop = false;
            // 
            // Import_Items
            // 
            this.AcceptButton = this.btnImportPreview;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picItemimage);
            this.Controls.Add(this.lblwaiting);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lblRows);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rbHeaderYes);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnImportPreview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Import_Items";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Import_Items_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgridviewImportPreview)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picItemimage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgridviewImportPreview;
        private System.Windows.Forms.Button btnImportPreview;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RadioButton rbHeaderYes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblmsg;
        private System.Windows.Forms.Label lblRows;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lblwaiting;
        private System.Windows.Forms.PictureBox picItemimage;
    }
}