using MySql.Data.MySqlClient;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace supershop.utils
{
    public static class MacAddressValidator
    {

        private static void SaveUserNameAndId(string id, string name)
        {
            
            //Check if user  is registered in settings
           
                //register Userid
                Properties.Settings.Default.UserID = id;
                Properties.Settings.Default.UserName = name;
                
                //MessageBox.Show(Properties.Settings.Default.UserID + " " + Properties.Settings.Default.UserName);
            
        }

        public static bool CheckIfMacAddressInDatabase(string mac, MySql.Data.MySqlClient.MySqlConnection sqlClient)
        {
            //SqlConnection sqlClient = new SqlConnection(@"Data Source=DESKTOP-JUU05B5\SQLEXPRESS;Initial Catalog=APOSDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            bool IsMacInDataBaseAndDatIsValid = false;

            using (sqlClient)
            {
                sqlClient.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM mac_address WHERE mac = @mac ", sqlClient);
                cmd.Parameters.AddWithValue("@mac", mac);
                MySql.Data.MySqlClient.MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    SaveUserNameAndId(reader["id"].ToString(), reader["name"].ToString());


                    if (DateTime.Parse(reader["date"].ToString()) > DateTime.Now)
                    {
                        IsMacInDataBaseAndDatIsValid = true;
                    }

                }
                
            }
            

            return IsMacInDataBaseAndDatIsValid;
        }

        public static string FetchMacAddress()
        {


            return NetworkInterface.GetAllNetworkInterfaces()
                .Where(item => item.OperationalStatus == OperationalStatus.Up &&
                item.NetworkInterfaceType != NetworkInterfaceType.Loopback &&
                item.GetPhysicalAddress().ToString().Length > 0)
                .Select(item => item.GetPhysicalAddress().ToString())
                .First();

        }

        public static string GetExpiryDate(string mac, MySql.Data.MySqlClient.MySqlConnection sqlClient)
        {
            using (sqlClient)
            {
                sqlClient.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM mac_address WHERE mac = @mac ", sqlClient);
                cmd.Parameters.AddWithValue("@mac", mac);
                MySql.Data.MySqlClient.MySqlDataReader reader = cmd.ExecuteReader();
                int daysLeft = 0;
                if (reader.Read())
                {
                     daysLeft = (int)DateTime.Parse(reader["date"].ToString()).Subtract(DateTime.Now).TotalDays;
                }
                
                return daysLeft.ToString();
            }
        }
    }
}
