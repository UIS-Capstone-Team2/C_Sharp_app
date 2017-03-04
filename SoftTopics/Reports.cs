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
        string name;
        public Reports(string name)
        {
            InitializeComponent();
            this.name = name;
            lblName.Text = name;
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

        private void btnRent_Click(object sender, EventArgs e)
        {
            RentForm rent = new RentForm(name);
            rent.Show();
            this.Close();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Returns returnForm = new Returns(name);
            returnForm.Show();
            this.Close();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {

        }

        private void btnCustomerMan_Click(object sender, EventArgs e)
        {
            CustomerManagement cm = new CustomerManagement(name);
            cm.Show();
            this.Close();
        }

        private void btnManagement_Click(object sender, EventArgs e)
        {
            EmployeeManagement em = new EmployeeManagement(name);
            em.Show();
            this.Close();
        }

        private void btnMovieMan_Click(object sender, EventArgs e)
        {
            MovieManagement mm = new MovieManagement(name);
            mm.Show();
            this.Close();
        }
    }
}
