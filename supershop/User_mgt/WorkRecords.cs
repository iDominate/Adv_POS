using System;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace supershop.User_mgt
{
    public partial class WorkRecords : Form
    {
        public WorkRecords()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
                this.Close();
            return base.ProcessCmdKey(ref msg, keyData);
        }

        #region Data load
        public void Databind(string dtstart, string dtend)
        {
            //    string sql = " select  username , logdate as 'Date' ,  min( logtime) as 'IN' , max( logtime)  as 'OUT', " +
            //                    " CAST(((strftime('%s', max(logtime)  ) - strftime('%s',  min(logtime) )) % (60 * 60 * 24)) / (60 * 60) AS TEXT) || ':' || " +
            //                    " CAST((((strftime('%s', max(logtime)  ) - strftime('%s',  min(logtime) )) % (60 * 60 * 24)) % (60 * 60)) / 60 AS TEXT) as 'HOURS - HH:MM'  " +
            //                    " from tbl_workrecords where logdate BETWEEN '" + dtstart + "' AND    '" + dtend + "'  and " +
            //                    " username = '" + UserInfo.usernamWK + "'   group by username , logdate order by  logdate ";

            string sql = " SELECT * FROM vw_workrecords " +
                         " where Date BETWEEN '" + dtstart + "' AND    '" + dtend + "'  and " +
                         " username = '" + UserInfo.usernamWK + "'    order by  Date ";
            DataAccess.ExecuteSQL(sql);
            DataTable dt1 = DataAccess.GetDataTable(sql);
            dtgrdWorkingHoursList.DataSource = dt1;

            dtEndDate.Value.Date.ToString("d", new CultureInfo("en-US"));
        }



        public string ConvertDateCalendar(DateTime DateConv, string Calendar, string DateLangCulture, bool hash = false)
        {
            System.Globalization.DateTimeFormatInfo DTFormat;
            DateLangCulture = DateLangCulture.ToLower();
            /// We can't have the hijri date writen in English. We will get a runtime error - LAITH - 11/13/2005 1:01:45 PM -

            if (Calendar == "Hijri" && DateLangCulture.StartsWith("en-"))
            {
                DateLangCulture = "ar-sa";
            }

            /// Set the date time format to the given culture - LAITH - 11/13/2005 1:04:22 PM -
            DTFormat = new System.Globalization.CultureInfo(DateLangCulture, false).DateTimeFormat;

            /// Set the calendar property of the date time format to the given calendar - LAITH - 11/13/2005 1:04:52 PM -
            switch (Calendar)
            {
                case "Hijri":
                    DTFormat.Calendar = new System.Globalization.HijriCalendar();
                    break;

                case "Gregorian":
                    DTFormat.Calendar = new System.Globalization.GregorianCalendar();
                    break;

                default:
                    return "";
            }

            /// We format the date structure to whatever we want - LAITH - 11/13/2005 1:05:39 PM -
           if(hash)
            {
                DTFormat.ShortDatePattern = "yyyy-MM-dd";
            }
            else
            {
                DTFormat.ShortDatePattern = "MM/dd/yyyy";
            }
            return (DateConv.Date.ToString("d", DTFormat));
        }



        private void WorkRecords_Load(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                c.Font = new System.Drawing.Font("Cairo", 9, System.Drawing.FontStyle.Regular);
                c.ForeColor = System.Drawing.Color.Black;

            }
            try
            {
                Calendar calendar = new GregorianCalendar();
                
                Databind(ConvertDateCalendar(DateTime.Now.AddDays(-30), "Gregorian", "en-US"), ConvertDateCalendar(DateTime.Now, "Gregorian", "en-US", true));
            }
            catch
            {

            }
        }

        private void dtEndDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                Databind(dtStartDate.Text, dtEndDate.Text);
            }
            catch
            {

            }
        }

        private void btn30days_Click(object sender, EventArgs e)
        {
            try
            {
                Databind(DateTime.Now.AddDays(-30).ToString(), DateTime.Now.ToString("yyyy-MM-dd"));
            }
            catch { }
        }

        #endregion

        #region Export to CSV
        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                //Exporting to xls.     
                saveFileDialog1.FileName = "WorkedHours_" + UserInfo.usernamWK + "_" + DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + ".csv";
                saveFileDialog1.ShowDialog();
            }
            catch
            {

            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            //Build the CSV file data as a Comma separated string.
            string csv = string.Empty;

            //Add the Header row for CSV file.
            foreach (DataGridViewColumn column in dtgrdWorkingHoursList.Columns)
            {
                csv += column.HeaderText + ',';
            }

            //Add new line.
            csv += "\r\n";

            //Adding the Rows
            foreach (DataGridViewRow row in dtgrdWorkingHoursList.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    //Add the Data rows.
                    csv += cell.Value.ToString().Replace(",", ";") + ',';
                }

                //Add new line.
                csv += "\r\n";
            }

            //Exporting to CSV.
            //  string targetPath = "D:\\";
            string fileName = "SalesReport_" + DateTime.Now.ToString("yyyy-MM-dd_hh-mm-ss") + ".csv";
            string targetPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string destFile = System.IO.Path.Combine(targetPath, fileName);

            // To copy a folder's contents to a new location: 
            // Create a new target folder, if necessary. 
            if (!System.IO.Directory.Exists(targetPath))
            {
                System.IO.Directory.CreateDirectory(targetPath);

            }

            // Get file name.
            string name = saveFileDialog1.FileName;
            System.IO.File.WriteAllText(name, csv);

        }
        #endregion
    }
}
