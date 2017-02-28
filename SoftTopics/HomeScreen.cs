using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace SoftTopics
{
    public partial class HomeScreen : Form
    {
       
        string name;
        private SqlConnection myConn;
        private SqlCommand myCmd;
        private SqlDataReader myReader;
        public HomeScreen(string name)
        {
            InitializeComponent();
            this.name = name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RentForm rentForm = new RentForm();
            rentForm.Show();

        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {

            getName(name);
            
            lblName.Text = name;
            updateOverdue();
        }

        private void updateOverdue()
        {
            string overdueFile = "..\\Files\\Overdue.txt";
            string checkedOutFile = "..\\Files\\CheckedOut.txt";
            string tempFile = "..\\Files\\Temp.txt";
            if (File.Exists(tempFile))
            {

            }
            else
            {
                var makefile = File.Create(tempFile);
                makefile.Close();
            }

            using (StreamReader sr = new StreamReader(checkedOutFile))
            {
                string line;
                

                while ((line = sr.ReadLine()) != null)
                {
                    System.DateTime date;
                    string[] lineInfo = line.Split(',');
                    int day;
                    int month;
                    int year;

                    int.TryParse(lineInfo[5].ToString(), out month);
                    int.TryParse(lineInfo[6].ToString(), out day);
                    int.TryParse(lineInfo[7].ToString(), out year);

                    date = new DateTime(year, month, day);
                    TimeSpan ts = DateTime.Today - date;
                    int yesterday = ts.Days;
                    if (yesterday == 1)
                    {
                        
                        using (StreamWriter swTemp = new StreamWriter(tempFile))
                        {
                            using (StreamReader srOverdue = new StreamReader(overdueFile))
                            {
                                string newLine;
                                Boolean match = false;
                                while ((newLine = srOverdue.ReadLine()) != null)
                                {
                                    if (newLine.Equals(line))
                                    {
                                        match = true;
                                        break;
                                    }
                                    
                                }

                                if (!match)
                                {
                                    swTemp.WriteLine(line);
                                }
                            }
                        }
                    }

                }
            }

            using (StreamWriter appendOverdue = File.AppendText(overdueFile))
            {
                using (StreamReader linesToAppend = new StreamReader(tempFile))
                {
                    string appendLine;
                    while ((appendLine = linesToAppend.ReadLine()) != null)
                    {
                        appendOverdue.WriteLine(appendLine);
                    }
                }
            }
        }

        private void getName(string ID)
        {
            myConn = new SqlConnection("Server=softwarecapproject.database.windows.net;Database=VideoStoreUsers;User ID = bcrumrin64; Password=!N14Jelrjvjvvcicl; Encrypt=True; TrustServerCertificate=False; Connection Timeout=30;");
            myConn.Open();
            myCmd = new SqlCommand("SELECT FName, Manager FROM UserTable WHERE IDNumber = @Uname", myConn);
            myCmd.Parameters.AddWithValue("@Uname", ID);

            
            myReader = myCmd.ExecuteReader();
            myReader.Read();
            string Fname = (string) myReader.GetValue(myReader.GetOrdinal("FName"));
            name = Fname;
            string Manager = (string)myReader.GetValue(myReader.GetOrdinal("Manager"));
            if (Manager.Equals("N"))
            {
                btnManagement.Enabled = false;
            }
        }

        private void btnManagement_Click(object sender, EventArgs e)
        {
            EmployeeManagement EMForm = new EmployeeManagement();
            EMForm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CustomerManagement CMForm = new CustomerManagement();
            CMForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MovieManagement movieMan = new MovieManagement();
            movieMan.Show();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Returns rtn = new Returns();
            rtn.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports();
            reports.Show();
        }

    }
}
