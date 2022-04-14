using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace supershop.Report
{
    public partial class PLdialog : Form
    {
        public PLdialog()
        {
            InitializeComponent();
            dtStartDate.Text = dtStartDate.Value.AddDays(-30).ToShortDateString();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
                this.Close();
            return base.ProcessCmdKey(ref msg, keyData);
        } 

        private void btnContinue_Click(object sender, EventArgs e)
        {
            try
            {

                ReportValue.StartDate = dtStartDate.Text; // dtStartDate.Value.ToShortDateString();
                ReportValue.EndDate = dtEndDate.Text;

                Report.ProfitLossReport go = new Report.ProfitLossReport();
                go.ShowDialog();
            }
            catch
            {
            }
        }
        public override void Refresh()
        {
            this.Controls.Clear();
            InitializeComponent();
        }

        private void PLdialog_Load(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                c.Font = new System.Drawing.Font("Cairo", 9, System.Drawing.FontStyle.Regular);
                c.ForeColor = System.Drawing.Color.Black;

            }
            dtStartDate.Format = DateTimePickerFormat.Custom;
            dtStartDate.CustomFormat = "yyyy-MM-dd";

            dtEndDate.Format = DateTimePickerFormat.Custom;
            dtEndDate.CustomFormat = "yyyy-MM-dd";
        }
    }
}
