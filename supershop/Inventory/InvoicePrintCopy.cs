using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace supershop.Inventory
{
    public partial class InvoicePrintCopy : Form
    {
        public InvoicePrintCopy()
        {
            InitializeComponent();
        }
        public override void Refresh()
        {
            this.Controls.Clear();
            InitializeComponent();
        }
        

        private void InvoicePrintCopy_Load(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                c.Font = new System.Drawing.Font("Cairo", 9, System.Drawing.FontStyle.Regular);
                c.ForeColor = System.Drawing.Color.Black;

            }
            string path = Application.StartupPath + @"\InvoicePdf\SalesInvoice.pdf";           
            this.webBrowser1.Navigate(path);
            this.webBrowser1.Dock = DockStyle.Fill;
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
                this.Close();
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
