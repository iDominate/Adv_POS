using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace supershop.Customer
{
    public partial class Due_payment_History : Form
    {
        public Due_payment_History(string custid, string sales_id)
        {
            InitializeComponent();
            lblcustid.Text = custid;
            lblinvoNo.Text = sales_id;
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
                this.Close();
            return base.ProcessCmdKey(ref msg, keyData);
        }
        public override void Refresh()
        {
            this.Controls.Clear();
            InitializeComponent();
        }

        private void Due_payment_History_Load(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                c.Font = new System.Drawing.Font("Cairo", 9, System.Drawing.FontStyle.Regular);
                c.ForeColor = System.Drawing.Color.Black;

            }
            try
            {
                string sql = "  select  sales_id as 'Invo No' , receivedate as Date , receiveamt as 'Receive Amount'  " +
                            "  from tbl_duepayment where custid = '" + lblcustid.Text + "' and sales_id = '" + lblinvoNo.Text + "'  order by  id desc ";
                             
                DataAccess.ExecuteSQL(sql);
                DataTable dt1 = DataAccess.GetDataTable(sql);
                dtgviewCustDueHistory.DataSource = dt1;
            }
            catch
            {
            }
        }
    }
}
