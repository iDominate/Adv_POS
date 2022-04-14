using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace supershop.Items
{
    public partial class Categories : Form
    {
        public Categories()
        {
            InitializeComponent();
        }

        private void lnkAddcategory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Items.Add_Category go = new Items.Add_Category();
            go.MdiParent = this.ParentForm;
            go.Show();
        }

        private void lnkSupplier_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            parameter.peopleid = "SUP";
            Customer.CustomerDetails go = new Customer.CustomerDetails();
            go.MdiParent = this.ParentForm;
            go.Show();
        }

        public void categorybind()
        {
            string sql;
            if(Thread.CurrentThread.CurrentCulture.Parent.Name.Equals("en", StringComparison.OrdinalIgnoreCase))
            {
                 sql = " select ID AS id , category_name As  'Category' from tbl_category ";
                
            }
            else
            {
                sql = " select ID AS رقم , category_name AS  'صنف' from tbl_category ";
                

            }
            DataAccess.ExecuteSQL(sql);
            DataTable dt1 = DataAccess.GetDataTable(sql);
            datagridcategories.DataSource = dt1;


        }
        
        private void Categories_Load(object sender, EventArgs e)
        {
            foreach (Control c in splitContainer1.Panel1.Controls)
            {
                c.Font = new System.Drawing.Font("Cairo", 8, System.Drawing.FontStyle.Regular);
                c.ForeColor = System.Drawing.Color.Black;

            }

            foreach (Control c in splitContainer1.Panel2.Controls)
            {
                c.Font = new System.Drawing.Font("Cairo", 8, System.Drawing.FontStyle.Regular);
                c.ForeColor = System.Drawing.Color.Black;

            }
            try
            {
                string localizableEdit;
                string localizableDel = "del";
                if(Thread.CurrentThread.CurrentCulture.Parent.Name.Equals("en", StringComparison.OrdinalIgnoreCase))
                {
                    localizableEdit = "Edit";
                }else
                {
                    localizableEdit = "تعديل";
                }
                categorybind();  
                DataGridViewButtonColumn Edit = new DataGridViewButtonColumn();
                Edit.Width = 100;
                
                
                datagridcategories.Columns.Add(Edit);
                Edit.HeaderText = localizableEdit;
                Edit.Text = localizableEdit;
                Edit.Name = localizableEdit;
                Edit.ToolTipText = "Edit this category";
                Edit.UseColumnTextForButtonValue = true;

                DataGridViewButtonColumn del = new DataGridViewButtonColumn();
                
                datagridcategories.Columns.Add(del);
                if(Thread.CurrentThread.CurrentCulture.Parent.Name.Equals("en"))
                {
                    del.HeaderText = Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(localizableDel);
                    del.Text = Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(localizableDel);
                    del.Name = localizableDel;
                    del.ToolTipText = "Delete this category";
                    del.UseColumnTextForButtonValue = true;
                } else
                {
                    localizableDel = "حذف";
                    del.HeaderText = localizableDel;
                    del.Text = localizableDel;
                    del.Name = localizableDel;
                    del.ToolTipText = "Delete this category";
                    del.UseColumnTextForButtonValue = true;
                }

                DataGridViewColumn ColID = datagridcategories.Columns[0];
                ColID.Width = 31;
                DataGridViewColumn ColName = datagridcategories.Columns[1];
                ColName.Width = 100;
            }
            catch
            {
            }
        }

        private void datagridcategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Delete category  
                if (e.ColumnIndex == datagridcategories.Columns["del"].Index && e.RowIndex >= 0)
                {
                    foreach (DataGridViewRow rowdel in datagridcategories.SelectedRows)
                    {
                        DialogResult result = MessageBox.Show("Do you want to Delete?", "Yes or No", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                        if (result == DialogResult.Yes)
                        {

                            string sqldel = " delete from tbl_category     where ID = '" + rowdel.Cells[2].Value.ToString() + "'";
                            DataAccess.ExecuteSQL(sqldel);                           
                            MessageBox.Show("Deleted");
                            categorybind();
                        }
                    }
                }

                // Delete items From Gridview
                if (e.ColumnIndex == datagridcategories.Columns["Edit"].Index && e.RowIndex >= 0)
                {
                    foreach (DataGridViewRow row in datagridcategories.SelectedRows)
                    {
                        this.Hide();
                        Items.Add_Category mkc = new Items.Add_Category();
                        mkc.categoryID = row.Cells[2].Value.ToString();
                        mkc.categoryName = row.Cells[3].Value.ToString();
                        mkc.MdiParent = this.ParentForm;
                        mkc.Show();
                    }
                }           

            }
            catch  
            {
               
            }
        }
    }
}
