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
    public partial class Returns : Form
    {
        string name;
        public Returns(string name)
        {
            InitializeComponent();
            this.name = name;
            lblName.Text = name;
        }

        private void Returns_Load(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader("..\\Files\\CheckedOut.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] movie = line.Split(',');
                    string title = movie[0].ToString();
                    string upc = movie[1].ToString();
                    string firstName = movie[2].ToString();
                    string lastName = movie[3].ToString();
                    string phoneNumber = movie[4].ToString();
                    int month;
                    int day;
                    int year;

                    int.TryParse(movie[5].ToString(), out month);
                    int.TryParse(movie[6].ToString(), out day);
                    int.TryParse(movie[7].ToString(), out year);

                    

                    System.DateTime date = new DateTime(year,month,day);
                    string strDate = date.ToString("MMM dd yyyy");

                    lvRentedMovies.View = View.Details;
                    lvRentedMovies.FullRowSelect = true;

                    string[] addMovie = { title, upc, firstName, lastName, phoneNumber, strDate};
                    lvRentedMovies.Items.Add(new ListViewItem(addMovie));
                    lvRentedMovies.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                    
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtBarcode.TextLength == 12)
            {
                findMovie(txtBarcode.Text);
            }
        }

        private void findMovie(string barcode)
        {
            foreach (ListViewItem item in lvRentedMovies.Items)
            {
                string upc = item.SubItems[1].Text;
                if (upc.Equals(barcode))
                {
                    DateTime date = Convert.ToDateTime(item.SubItems[5].Text);
                    if (date.CompareTo(DateTime.Today) >= 0)
                    {
                        lvOnTimeReturns.View = View.Details;
                        lvOnTimeReturns.FullRowSelect = true;
                        ListViewItem temp = (ListViewItem)item.Clone();
                        lvOnTimeReturns.Items.Add(temp);
                        lvRentedMovies.Items.Remove(item);
                        lvOnTimeReturns.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                    }
                    else
                    {
                        lvLateReturns.View = View.Details;
                        lvLateReturns.FullRowSelect = true;
                        int daysLate;
                        TimeSpan ts = DateTime.Today - date;
                        daysLate = ts.Days;
                        string[] items = { item.SubItems[2].Text, item.SubItems[3].Text, item.SubItems[4].Text, daysLate.ToString(), item.SubItems[0].Text };
                        
                        lvLateReturns.Items.Add(new ListViewItem(items));
                        lvRentedMovies.Items.Remove(item);
                        lvLateReturns.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                    }
                }
            }
 
        }

        private void btnFinished_Click(object sender, EventArgs e)
        {
            string tempFile = "..\\Files\\temp.txt";
            string realFile = "..\\Files\\CheckedOut.txt";
            using (StreamWriter sw = new StreamWriter(tempFile))
            {

                foreach (ListViewItem item in lvRentedMovies.Items)
                {
                    DateTime date = Convert.ToDateTime(item.SubItems[5].Text);

                    string title = item.SubItems[0].Text;
                    string barcode = item.SubItems[1].Text;
                    string firstName = item.SubItems[2].Text;
                    string lastName = item.SubItems[3].Text;
                    string phoneNumber = item.SubItems[4].Text;
                    string day = date.Day.ToString();
                    string month = date.Month.ToString();
                    string year = date.Year.ToString();

                    string fullString = title + "," + barcode + "," + firstName + "," + lastName + "," + phoneNumber + "," + month + "," + day + "," + year;
                    fullString = fullString.Replace(" ", "");
                    sw.WriteLine(fullString);
                }
 
            }

            File.Delete(realFile);
            File.Move(tempFile, realFile);

            realFile = "..\\Files\\LateReturns.txt";
            using (StreamWriter sw = new StreamWriter(tempFile))
            {
                foreach (ListViewItem item in lvLateReturns.Items)
                {
                   

                    string title = item.SubItems[4].Text;
                    string firstName = item.SubItems[0].Text;
                    string lastName = item.SubItems[1].Text;
                    string phoneNumber = item.SubItems[2].Text;
                    string lateDays = item.SubItems[3].Text;
                    

                    string fullString = title + "," + firstName + "," + lastName + "," + phoneNumber + "," + lateDays;
                    fullString = fullString.Replace(" ", "");
                    sw.WriteLine(fullString);
                }
 
            }

            File.Delete(realFile);
            File.Move(tempFile, realFile);
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
            Reports reports = new Reports(name);
            reports.Show();
            this.Close();
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

        private void lblLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
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
