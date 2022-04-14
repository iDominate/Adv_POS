using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace supershop.Customer
{
    public partial class CustomerDetails : Form
    {
        public CustomerDetails()
        {
            InitializeComponent();
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

        


        #region Databind
        private void CustomerDetails_Load(object sender, EventArgs e)
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
                dtGrdvCustomerDetails.EnableHeadersVisualStyles = false;
                dtGrdvCustomerDetails.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                dtGrdvCustomerDetails.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
                dtGrdvCustomerDetails.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                Databind();

                //Edit Button
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                dtGrdvCustomerDetails.Columns.Add(btn);
                if(Thread.CurrentThread.CurrentCulture.Parent.Name == "en")
                {
                    btn.HeaderText = "Edit";
                    btn.Text = "Edit";
                    btn.Name = "btn";
                    
                }else
                {
                    btn.HeaderText = "تعديل";
                    btn.Text = "تعديل";
                    btn.Name = "btn";
                    
                }
               // btn.Width = 2;
                btn.UseColumnTextForButtonValue = true;
              
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }

        public void Databind()
        {
            if (parameter.peopleid == "SUP")
            {
                string sqlCmd;
                if((Thread.CurrentThread.CurrentCulture.Parent.Name == "en"))
                {
                    sqlCmd = "Select * from  customercredit   where PeopleType  = 'Supplier' and id != '10000009' ";
                }else
                {

                    sqlCmd = "Select * from  customercredit   where PeopleType  = 'Supplier' and id != '10000009' ";
                    sqlCmd = "Select ID as 'الرقم التعريفي'," +
                        "Name as 'الاسم'," +
                        "Mobile as 'الهاتف',"+
                        " EmailAddress AS 'البريد الالكتروني'," +
                        " Address as 'العنوان'," +
                        " City AS 'المدينة', PeopleType as 'نوع الشخص'" +
                        
                        " from customercredit where PeopleType  = 'Supplier' and id != '10000009' ";
                }//From view combination of tbl_customer and custcredit
                DataAccess.ExecuteSQL(sqlCmd);
                DataTable dt1 = DataAccess.GetDataTable(sqlCmd);
                dtGrdvCustomerDetails.DataSource = dt1;
            }
            else
            {
                string sqlCmd;
                if((Thread.CurrentThread.CurrentCulture.Parent.Name == "en"))
                {
                    sqlCmd ="Select * from  customercredit where id != '10000009'";
                }else
                {
                    sqlCmd = "Select ID as 'الرقم التعريفي',  Name as 'الاسم'," +
                        
                        " Mobile as 'الهاتف'," +
                        "Address as 'العنوان'," +
                        " EmailAddress as 'البريد الالكتروني'," +
                        
                        " City as 'المدينة', PeopleType as 'نوع الشخص'" +
                        " from  customercredit  " + " where id != '10000009'";
                }//From view combination of tbl_customer and custcredit
                DataAccess.ExecuteSQL(sqlCmd);
                DataTable dt1 = DataAccess.GetDataTable(sqlCmd);
                dtGrdvCustomerDetails.DataSource = dt1;
            }

        }
        #endregion

        private void dtGrdvCustomerDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dtGrdvCustomerDetails.Rows[e.RowIndex];
               // label1.Text = row.Cells[0].Value.ToString();

                Customer.AddNewCustomer mkc = new Customer.AddNewCustomer();
                mkc.CustID      = row.Cells[1].Value.ToString();
                mkc.CustName    = row.Cells[2].Value.ToString();
                mkc.CustPhone   = row.Cells[3].Value.ToString();
                mkc.City        = row.Cells[6].Value.ToString();
                mkc.Email       = row.Cells[5].Value.ToString();
                mkc.CustAddress = row.Cells[4].Value.ToString();
                mkc.PeopleType  = row.Cells[7].Value.ToString();                 
                mkc.ShowDialog();

            }
            catch // (Exception exp)
            {
                // MessageBox.Show("Sorry" + exp.Message);
            }
        }

        #region Data serach
        private void txtCustomerSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {

                string sqlCmd = " Select * from  customercredit " +
                                " where Name  like  '%" + txtCustomerSearch.Text + "%' or " +
                                " ID like  '%" + txtCustomerSearch.Text + "%'  or " +
                                "  Mobile  like  '%" + txtCustomerSearch.Text + "%' or " +
                                "  City  like  '%" + txtCustomerSearch.Text + "%'  or " +
                                " EmailAddress  like  '%" + txtCustomerSearch.Text + "%'";
                // = txtCustomerSearch.Text ";// or Phone  like  '%" + txtCustomerSearch.Text + "%'  or City  like  '%" + txtCustomerSearch.Text + "%'  or emailAddress  like  '%" + txtCustomerSearch.Text + "%'";
                DataAccess.ExecuteSQL(sqlCmd);
                DataTable dt1 = DataAccess.GetDataTable(sqlCmd);
                dtGrdvCustomerDetails.DataSource = dt1;
            }
            catch
            {
            }
        }
                
        private void CombPeopleType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (CombPeopleType.Text == "All" || CombPeopleType.Text == "الكل")
                {
                    // string sqlCmd = "select  Name , Phone as [Contact],  EmailAddress as [Email], City, Address , PeopleType  from tbl_customer";
                    string sqlCmd;
                    if(Thread.CurrentThread.CurrentCulture.Parent.Name == "en")
                    {
                        sqlCmd = "SELECT * from  customercredit";

                    }
                    else
                    {
                        sqlCmd ="Select ID as 'الرقم التعريفي',  Name as 'الاسم'," +

                        " Mobile as 'الهاتف'," +
                        "Address as 'العنوان'," +
                        " EmailAddress as 'البريد الالكتروني'," +

                        " City as 'المدينة', PeopleType as 'نوع الشخص'" +

                        " from  customercredit";
                    }
                    DataAccess.ExecuteSQL(sqlCmd);
                    DataTable dt1 = DataAccess.GetDataTable(sqlCmd);
                    dtGrdvCustomerDetails.DataSource = dt1;

                    //DataGridViewColumn column = dtGrdvCustomerDetails.Columns[8];
                    //column.Width = 5;
                }
                else
                {
                    string sqlCmd;
                    if (Thread.CurrentThread.CurrentCulture.Parent.Name == "en")
                    {
                        sqlCmd = "Select * from  customercredit  where PeopleType  = '" + CombPeopleType.Text + "'"; ;

                    }
                    else
                    {
                        string peopleType;
                        if(Thread.CurrentThread.CurrentCulture.Parent.Name == "en")
                        {
                            peopleType = CombPeopleType.Text;
                        }else
                        {
                            if (CombPeopleType.Text == "مورد")
                            {
                                peopleType = "Supplier";
                            }
                            else
                            {
                                peopleType = "Customer";
                            }
                        }
                        sqlCmd = "Select ID as 'الرقم التعريفي',  Name as 'الاسم'," +

                        " Mobile as 'الهاتف'," +
                        "Address as 'العنوان'," +
                        " EmailAddress as 'البريد الالكتروني'," +

                        " City as 'المدينة', PeopleType as 'نوع الشخص'" +
                        
                        "from customercredit  where PeopleType  = '" + peopleType + "'";
                    }
                     
                    DataAccess.ExecuteSQL(sqlCmd);
                    DataTable dt1 = DataAccess.GetDataTable(sqlCmd);
                    dtGrdvCustomerDetails.DataSource = dt1;
                }
              
            }
            catch
            {
            }
        }
        #endregion


        #region Page link
        private void btnAddNewCustLink_Click(object sender, EventArgs e)
        {
            Customer.AddNewCustomer go = new Customer.AddNewCustomer();
            go.MdiParent = this.ParentForm;
            go.Show();
            this.Close();
        }

        private void btnStoreCreditRewards_Click(object sender, EventArgs e)
        {
            Customer.RewardsManagerReport go = new Customer.RewardsManagerReport();
            go.MdiParent = this.ParentForm;
            go.Show();
        }
        #endregion

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to Delete all records?", "Yes or No", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            { 
                try
                {
                    string sql = "delete from tbl_customer where  id != '10000009'";
                    DataAccess.ExecuteSQL(sql);                    

                    MessageBox.Show("Has been Deleted", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Databind();

                }
                catch (Exception exp)
                {
                    MessageBox.Show("Sorry\r\n You have to Check the Data" + exp.Message);
                }
               
            }
        }
    }
}
