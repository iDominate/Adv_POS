using MySql.Data.MySqlClient;
using supershop.utils;
using System;
using System.Globalization;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading;
using System.Windows.Forms;
using WK.Libraries.FontsInstallerNS;

//using howto_control_print_preview;

namespace supershop
{
    static class Program
    {
        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (var stream = client.OpenRead("http://www.google.com"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public static object Environmet { get; private set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);



            int selectedLang = Properties.Settings.Default.Language;
            switch (selectedLang)
            {
                case 0:
                    Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("ar");
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ar");
                    var DTFormatAr = new System.Globalization.CultureInfo("ar", false).DateTimeFormat;
                    DTFormatAr.Calendar = new GregorianCalendar();
                    break;
                case 1:
                    Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
                    var DTFormatEn = new System.Globalization.CultureInfo("en", false).DateTimeFormat;
                    DTFormatEn.Calendar = new GregorianCalendar();
                    break;
            }

            







                if (!CheckForInternetConnection())
                {
                    MessageBox.Show("Please check your internet connection");
                    Application.Exit();
                    return;
                }

                var builder = new MySqlConnectionStringBuilder
                {
                    Server = "194.163.164.140",
                    UserID = "stack_ahmed",
                    Password = "ahmed12345",
                    Database = "stack_ahmed",
                };

                using (MySqlConnection conn = new MySqlConnection(builder.ConnectionString))
                {
                    bool isMacValid = MacAddressValidator.CheckIfMacAddressInDatabase(MacAddressValidator.FetchMacAddress(), conn);
                    if (!isMacValid)
                    {
                        MessageBox.Show("Your Mac address isn't registered in our database or your license has expired");
                        Application.Exit();
                        return;
                    }
                }

                try
                {
                    var fontsInstaller = new FontsInstaller();



                    if (!fontsInstaller.
                        IsFontInstalled($@"{Application.StartupPath}\Cairo.ttf"))
                    {
                        fontsInstaller.InstallFont($@"{Application.StartupPath}\Cairo.ttf");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

                void Upload(string sourcefile, string desFile)
                {

                    //$@"{Application.StartupPath}\TextFile_.txt"
                    using (var client = new WebClient())
                    {
                        client.Credentials = new NetworkCredential("ahmed12345@stackdeans.com", "XJPlHXoRO0d7");
                        byte[] response = client.UploadFile(desFile,
                            WebRequestMethods.Ftp.UploadFile,
                            sourcefile);
                       
                    }
                    /*
                                FtpWebRequest request =
                        (FtpWebRequest)WebRequest.Create("ftp://194.163.164.140/TextFile1.txt");
                                request.Credentials = new NetworkCredential("username", "password");
                                request.Method = WebRequestMethods.Ftp.UploadFile;

                                using (Stream fileStream = File.OpenRead(@"C:\local\path\file.zip"))
                                using (Stream ftpStream = request.GetRequestStream())
                                {
                                    fileStream.CopyTo(ftpStream);
                                }


                            }*/
                }


                void InitTimer()
                {

                    //3 * 60 * 60 * 1000
                    var timer1 = new System.Windows.Forms.Timer();
                    timer1.Tick += new EventHandler(timer1_Tick);
                    timer1.Interval = 3 * 60 * 60 * 1000; // in miliseconds
                    timer1.Start();
                }
                
                void timer1_Tick(object sender, EventArgs e)
                {
                    
                    if(!DoesFtpDirectoryExist())
                {
                    MakeADirectoryOnFTP();
                }

                Upload($@"{Application.StartupPath}\InvoicePdf\psodb.db", $"ftp://194.163.164.140/backup_pos/{Properties.Settings.Default.UserName}_{Properties.Settings.Default.UserID}/psodbInvoicePdf.db");
                Upload($@"{Application.StartupPath}\ExpenseAttachment\psodb.db", $"ftp://194.163.164.140/backup_pos/{Properties.Settings.Default.UserName}_{Properties.Settings.Default.UserID}/psodbExpenseAttachment.db");
                Upload($@"{Application.StartupPath}\psodb.db", $"ftp://194.163.164.140/backup_pos/{Properties.Settings.Default.UserName}_{Properties.Settings.Default.UserID}/psodb.db");







            }

            bool DoesFtpDirectoryExist()
            {
                try
                {
                    FtpWebRequest request = (FtpWebRequest)WebRequest.Create($"ftp://194.163.164.140/backup_pos/{Properties.Settings.Default.UserName}_{Properties.Settings.Default.UserID}");
                    request.Method = WebRequestMethods.Ftp.ListDirectory;
                    request.Credentials = new NetworkCredential("ahmed12345@stackdeans.com", "XJPlHXoRO0d7");
                    FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                    return true;
                }
                catch (WebException ex)
                {
                    return false;
                }
            }

            void MakeADirectoryOnFTP()
            {
                WebRequest request = WebRequest.Create($"ftp://194.163.164.140/backup_pos/{Properties.Settings.Default.UserName}_{Properties.Settings.Default.UserID}");
                request.Method = WebRequestMethods.Ftp.MakeDirectory;
                request.Credentials = new NetworkCredential("ahmed12345@stackdeans.com", "XJPlHXoRO0d7");
                using (var resp = (FtpWebResponse)request.GetResponse())
                {
                    MessageBox.Show(resp.StatusCode.ToString());
                }
            }

             bool CheckIfFileExistsOnServer(string filePath)
            {
                var request = (FtpWebRequest)WebRequest.Create(filePath);
                request.Credentials = new NetworkCredential("ahmed12345@stackdeans.com", "XJPlHXoRO0d7");
                request.Method = WebRequestMethods.Ftp.GetFileSize;

                try
                {
                    FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                    return true;
                }
                catch (WebException ex)
                {
                    FtpWebResponse response = (FtpWebResponse)ex.Response;
                    if (response.StatusCode == FtpStatusCode.ActionNotTakenFileUnavailable)
                        return false;
                }
                return false;
            }



            
            //Upload($@"{Application.StartupPath}\InvoicePdf\psodb.db", $"ftp://194.163.164.140/backup_pos/{Properties.Settings.Default.UserName}_{Properties.Settings.Default.UserID}/psodbInvoicePdf.db");
            //Upload($@"{Application.StartupPath}\ExpenseAttachment\psodb.db", $"ftp://194.163.164.140/backup_pos/{Properties.Settings.Default.UserName}_{Properties.Settings.Default.UserID}/psodbExpenseAttachment.db");
            //Upload($@"{Application.StartupPath}\psodb.db", $"ftp://194.163.164.140/backup_pos/{Properties.Settings.Default.UserName}_{Properties.Settings.Default.UserID}/psodb.db");
            //MessageBox.Show(CheckIfFileExistsOnServer($"ftp://194.163.164.140/backup_pos/{Properties.Settings.Default.UserName}_{Properties.Settings.Default.UserID}/psodbInvoicePdf.db").ToString());
            //MessageBox.Show(CheckIfFileExistsOnServer($"ftp://194.163.164.140/backup_pos/{Properties.Settings.Default.UserName}_{Properties.Settings.Default.UserID}/psodbExpenseAttachment.db").ToString());
            //MessageBox.Show(CheckIfFileExistsOnServer($"ftp://194.163.164.140/backup_pos/{Properties.Settings.Default.UserName}_{Properties.Settings.Default.UserID}/psodb.db").ToString());



















            Application.Run(new Login());



                // // Application.Run(new BarCode.Barcode_machine());
                ////  Application.Run(new  Items.SRtaxcalc());
                //     UserInfo.UserName = "a";
                //     UserInfo.usertype = "1"; // 1= admin
                //     UserInfo.Shopid = "MTQC02";
                //     Application.Run(new SalesRegister());
                // Application.Run(new Home());
            }
        }
    }

