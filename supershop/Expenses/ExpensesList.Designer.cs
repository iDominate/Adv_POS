namespace supershop.Expenses
{
    partial class ExpensesList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpensesList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.datagridExpenses = new System.Windows.Forms.DataGridView();
            this.lblSum = new System.Windows.Forms.Label();
            this.lblRow = new System.Windows.Forms.Label();
            this.lnkAddExpense = new System.Windows.Forms.LinkLabel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridExpenses)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            resources.ApplyResources(this.splitContainer1.Panel1, "splitContainer1.Panel1");
            this.splitContainer1.Panel1.Controls.Add(this.datagridExpenses);
            // 
            // splitContainer1.Panel2
            // 
            resources.ApplyResources(this.splitContainer1.Panel2, "splitContainer1.Panel2");
            this.splitContainer1.Panel2.Controls.Add(this.lblSum);
            this.splitContainer1.Panel2.Controls.Add(this.lblRow);
            this.splitContainer1.Panel2.Controls.Add(this.lnkAddExpense);
            this.splitContainer1.Panel2.Controls.Add(this.txtSearch);
            // 
            // datagridExpenses
            // 
            resources.ApplyResources(this.datagridExpenses, "datagridExpenses");
            this.datagridExpenses.AllowUserToAddRows = false;
            this.datagridExpenses.AllowUserToDeleteRows = false;
            this.datagridExpenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridExpenses.BackgroundColor = System.Drawing.SystemColors.Info;
            this.datagridExpenses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridExpenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridExpenses.DefaultCellStyle = dataGridViewCellStyle2;
            this.datagridExpenses.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.datagridExpenses.Name = "datagridExpenses";
            this.datagridExpenses.ReadOnly = true;
            this.datagridExpenses.RowHeadersVisible = false;
            this.datagridExpenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridExpenses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridExpenses_CellClick);
            // 
            // lblSum
            // 
            resources.ApplyResources(this.lblSum, "lblSum");
            this.lblSum.Name = "lblSum";
            // 
            // lblRow
            // 
            resources.ApplyResources(this.lblRow, "lblRow");
            this.lblRow.Name = "lblRow";
            // 
            // lnkAddExpense
            // 
            resources.ApplyResources(this.lnkAddExpense, "lnkAddExpense");
            this.lnkAddExpense.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkAddExpense.Name = "lnkAddExpense";
            this.lnkAddExpense.TabStop = true;
            this.lnkAddExpense.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAddExpense_LinkClicked);
            // 
            // txtSearch
            // 
            resources.ApplyResources(this.txtSearch, "txtSearch");
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // ExpensesList
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.Name = "ExpensesList";
            this.ShowIcon = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ExpensesList_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridExpenses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView datagridExpenses;
        private System.Windows.Forms.LinkLabel lnkAddExpense;
        private System.Windows.Forms.Label lblRow;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSum;
    }
}