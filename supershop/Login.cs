using MySql.Data.MySqlClient;
using supershop.utils;
using System;

using System.Data;
using System.Threading;
using System.Windows.Forms;
using WK.Libraries.FontsInstallerNS;

namespace supershop
{

    /*
           Author :    Mohammad Tuaha
           Email:      citkar@live.Com
        * Advance POS 
        * http://codecanyon.net/item/advance-point-of-sale-system-pos/6317175
        * 
       */

    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            btnColse.Enabled = false;
          //  txtUserName.Text = "a";
           // txtPassword.Text = "a";
        }

        //Log in action 
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                //MessageBox.Show("");
                MessageBox.Show("Please insert User Name", "Not match", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Focus();
                
            }
            else if ( txtPassword.Text == "")
            {
                MessageBox.Show("Please  insert Password", "Not match", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();               
            }
            else
            {
                try
                {
                    string tkhan = "Select Username , password , usertype, Shopid  from  usermgt  " + 
                                    " where Username   = '" + txtUserName.Text + "' and password = '" + txtPassword.Text + "'";                    
                    DataTable dt = DataAccess.GetDataTable(tkhan);

                    string username = dt.Rows[0].ItemArray[0].ToString();
                    string password = dt.Rows[0].ItemArray[1].ToString();
                    string usertype = dt.Rows[0].ItemArray[2].ToString();
                    string Shopid = dt.Rows[0].ItemArray[3].ToString();

                    if (txtUserName.Text == username && txtPassword.Text == password)  
                    {
                        if (usertype == "1")   //usertype usertype
                        {
                            UserInfo.UserName = txtUserName.Text;
			                UserInfo.usertype = "1"; // 1= admin
                            UserInfo.Shopid = Shopid;
                            workRecords();
                            Home go = new Home();
                            go.Show();
                            this.Hide();
                            
                        }
                        if (usertype == "2")
                        {
                            UserInfo.UserName = txtUserName.Text;
		                    UserInfo.usertype = "2"; //2 = Manager
                            UserInfo.Shopid = Shopid;
                            workRecords();
                            Manager_Home go = new Manager_Home(); 
                            go.Show();
                            this.Hide();
                        }

                        if (usertype == "3")
                        {
                            UserInfo.UserName = txtUserName.Text;
                            UserInfo.usertype = "3"; //3 = salesman
                            UserInfo.Shopid = Shopid;
                            workRecords();
                            SalesMan_Home go = new SalesMan_Home();
                            go.Show();
                            this.Hide();
                        }
                        

                        if (usertype == "0") // Block user
                        {

                            MessageBox.Show("\n This user (" + txtUserName.Text + ") has been blocked. \n Please contact to administrator.", "Block - Inactive", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                    else
                    {
                       // MessageBox.Show("Username or Password not match", "Not match", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        lblmsg.Visible = true;
                        lblmsg.Text = "Username or Password does not match";

                    }
                }
                catch (Exception exe)
                {
                    
                   MessageBox.Show(exe.Message);
                   // MessageBox.Show("User ID not exist   \n\n " + exe.Message, "Not match", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   // MessageBox.Show("User ID or Password not match", "Not match", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblmsg.Visible = true;
                    lblmsg.Text = "Username or Password does not match";

                }
              
            }
            //pictureBox2.Visible = true;
            //prg();
            
        }


        public void workRecords()
        {
            string logdate = DateTime.Now.ToString("yyyy-MM-dd");
            string logtime = DateTime.Now.ToString("HH:mm:ss");
            string logdatetime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            string sqlLogIn = " insert into tbl_workrecords (Username, datatype, logdate, logtime, logdatetime) " +
                                 " values ('" + UserInfo.UserName + "' , 'IN' , '" + logdate + "' , " +
                                  " '" + logtime + "' , '" + logdatetime + "'  )";
            DataAccess.ExecuteSQL(sqlLogIn);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //this.Close();
          //  Application.Exit();
            Environment.Exit(0);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Login g = new Login();
            g.Show();
            this.Hide();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            prg(); //pictureBox2.Visible = true;
        }

        public void prg()
        { 

            progressBar1.Increment(5);
            lblprgbarCount.Text = " " + progressBar1.Value.ToString() + "%";
            if (progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Stop();
                // MessageBox.Show("Server has been connected");
                // this.Close();
                //timer1.Stop();
                btnColse.Enabled = true;
            }
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MoveForm.ReleaseCapture();
                MoveForm.SendMessage(Handle, MoveForm.WM_NCLBUTTONDOWN, MoveForm.HT_CAPTION, 0);
            }
        }

        private void btnColse_Click(object sender, EventArgs e)
        {
            
            Environment.Exit(0);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            var builder = new MySqlConnectionStringBuilder
            {
                Server = "194.163.164.140",
                UserID = "stack_ahmed",
                Password = "ahmed12345",
                Database = "stack_ahmed",
            };
            using(MySqlConnection sqlConnection = new MySqlConnection(builder.ConnectionString))
            {
                sqlConnection.Open();
                using (MySqlConnection conn = new MySqlConnection(builder.ConnectionString))
                {
                    string daysleft = MacAddressValidator.GetExpiryDate(MacAddressValidator.FetchMacAddress(), conn);
                    if(Thread.CurrentThread.CurrentCulture.Parent.Name == "en")
                    {
                        lblDaysLeft.Text = $"You have: {daysleft} days left until license renewal";
                    }
                    else
                    {
                        lblDaysLeft.Text = $"لديك {daysleft}  يوما حتي تجديد الرخصة";
                    }
                }
            }

            foreach (Control c in Controls)
            {
                c.Font = new System.Drawing.Font("Cairo", 10, System.Drawing.FontStyle.Regular);
                c.ForeColor = System.Drawing.Color.Black;

            }

            btnLogin.ForeColor = System.Drawing.Color.White;
            btnReset.ForeColor = System.Drawing.Color.White;
        }
    }
}
