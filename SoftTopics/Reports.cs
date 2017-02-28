using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SoftTopics
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void btnRunReport_Click(object sender, EventArgs e)
        {
            string reportType = cbReportType.Text;
            if (reportType.Equals("Login Report"))
            {
                loginReport();
            }

        }

        private void returnReport()
        {
 
        }

        private void rentalReport()
        {
 
        }

        private void loginReport()
        {
            lvReports.Items.Clear();
            string loginfile = "..\\Files\\LoginReport.txt";
            using (StreamReader sr = new StreamReader(loginfile))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] lineInfo = line.Split(',');

                    int day;
                    int month;
                    int year;

                    int.TryParse(lineInfo[1], out day);
                    int.TryParse(lineInfo[2], out month);
                    int.TryParse(lineInfo[3], out year);

                    System.DateTime date = new DateTime(year, month, day);

                    string strDate = date.ToString("MMM/dd/yyyy");

                    string[] item = { lineInfo[0], strDate };
                    lvReports.View = View.Details;
                    lvReports.FullRowSelect = true;
                    lvReports.Items.Add(new ListViewItem(item));
                }
            }
        }

        private void lateReport()
        {
 
        }
    }
}
