namespace supershop.Data_Manage
{
    partial class DataReset
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataReset));
            this.btntruncate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbsqlite = new System.Windows.Forms.RadioButton();
            this.bdbMySQL = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btntruncate
            // 
            resources.ApplyResources(this.btntruncate, "btntruncate");
            this.btntruncate.Name = "btntruncate";
            this.btntruncate.UseVisualStyleBackColor = true;
            this.btntruncate.Click += new System.EventHandler(this.btntruncate_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // rdbsqlite
            // 
            resources.ApplyResources(this.rdbsqlite, "rdbsqlite");
            this.rdbsqlite.Name = "rdbsqlite";
            this.rdbsqlite.UseVisualStyleBackColor = true;
            // 
            // bdbMySQL
            // 
            resources.ApplyResources(this.bdbMySQL, "bdbMySQL");
            this.bdbMySQL.Name = "bdbMySQL";
            this.bdbMySQL.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // DataReset
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bdbMySQL);
            this.Controls.Add(this.rdbsqlite);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btntruncate);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DataReset";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.DataReset_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btntruncate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbsqlite;
        private System.Windows.Forms.RadioButton bdbMySQL;
        private System.Windows.Forms.Label label4;
    }
}