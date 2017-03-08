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
using Microsoft.VisualBasic;
using System.Configuration;

namespace SoftTopics
{
    public partial class HomeScreen : Form
    {

        string name;
        bool ManagerEnabled;
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
            RentForm rentForm = new RentForm(name, ManagerEnabled);

            rentForm.Show();

        }

        private void updateManger()
        {
            if (!ManagerEnabled)
            {
                lblName.ForeColor = Color.LimeGreen;
                btnManagement.Enabled = true;
                btnManagement.FlatAppearance.BorderColor = Color.LimeGreen;
                btnRent.FlatAppearance.BorderColor = Color.LimeGreen;
                btnReturn.FlatAppearance.BorderColor = Color.LimeGreen;
                btnReports.FlatAppearance.BorderColor = Color.LimeGreen;
                button1.FlatAppearance.BorderColor = Color.LimeGreen;
                button2.FlatAppearance.BorderColor = Color.LimeGreen;
            }
            else
            {
                btnManagement.Enabled = false;
                btnManagement.FlatAppearance.BorderColor = Color.Red;
            }

        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {

            getName(name);
            updateManger();

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
            myConn = new SqlConnection();
            myConn.ConnectionString = ConfigurationManager.ConnectionStrings["DataServer"].ConnectionString;
            myConn.Open();
            myCmd = new SqlCommand("SELECT FName, Manager FROM UserTable WHERE IDNumber = @Uname", myConn);
            myCmd.Parameters.AddWithValue("@Uname", ID);


            myReader = myCmd.ExecuteReader();
            myReader.Read();
            string Fname = (string)myReader.GetValue(myReader.GetOrdinal("FName"));
            name = Fname;
            string Manager = (string)myReader.GetValue(myReader.GetOrdinal("Manager"));
            if (Manager.Equals("N"))
            {
                btnManagement.Enabled = false;
                ManagerEnabled = true;
                tempPass(ID);
            }
            else
            {
                ManagerEnabled = false;
            }
        }

        private void tempPass(string ID)
        {
            bool change = false;
            string tempPassFile = "..\\Files\\TempPassword.txt";
            using (StreamReader sr = new StreamReader(tempPassFile))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Equals(ID))
                    {
                        change = true;
                        break;
                    }
                }
            }

            if (change)
            {
                changePass(ID);
            }

        }

        private void changePass(string ID)
        {


            string newPass = Microsoft.VisualBasic.Interaction.InputBox("Please enter a new password", "New Password");
            myConn = new SqlConnection();
            myConn.ConnectionString = ConfigurationManager.ConnectionStrings["DataServer"].ConnectionString;
            myConn.Open();
            myCmd = new SqlCommand("SELECT FName, Manager, LName, IDNumber FROM UserTable WHERE IDNumber = @Uname", myConn);
            myCmd.Parameters.AddWithValue("@Uname", ID);

            myReader = myCmd.ExecuteReader();
            myReader.Read();

            string FirstName = (string)myReader.GetValue(myReader.GetOrdinal("FName"));
            string LastName = (string)myReader.GetValue(myReader.GetOrdinal("LName"));
            int IDNumber = (int)myReader.GetValue(myReader.GetOrdinal("IDNumber"));
            string Manager = (string)myReader.GetValue(myReader.GetOrdinal("Manager"));

            


            DeleteEmployee(FirstName, LastName, IDNumber);
            AddEmployee(FirstName, LastName, IDNumber, Manager, newPass);


            string tempPassFile = "..\\Files\\TempPassword.txt";
            string tempFile = "..\\Files\\temp.txt";

            using (StreamReader sr = new StreamReader(tempPassFile))
            {
                using (StreamWriter sw = new StreamWriter(tempFile))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (!line.Equals(ID))
                        {
                            sw.WriteLine(line);
                        }
                    }
                }
            }

            File.Delete(tempPassFile);
            File.Move(tempFile, tempPassFile);
        }

        private void DeleteEmployee(string FName, string LName, int IDNumber)
        {
            myConn = new SqlConnection();
            myConn.ConnectionString = ConfigurationManager.ConnectionStrings["DataServer"].ConnectionString;
            myConn.Open();
            myCmd = new SqlCommand(@"DELETE FROM UserTable Where 
                FName = @FName
                AND LName = @LName 
                AND IDNumber = @IDNumber", myConn);
            myCmd.Parameters.AddWithValue("@FName", FName);
            myCmd.Parameters.AddWithValue("@LName", LName);
            myCmd.Parameters.AddWithValue("@IDNumber", IDNumber);
            myCmd.ExecuteNonQuery();
            myConn.Close();

        }


        private void AddEmployee(string FName, string LName, int ID, string Manager, string Pass)
        {
            myConn = new SqlConnection();
            myConn.ConnectionString = ConfigurationManager.ConnectionStrings["DataServer"].ConnectionString;
            myConn.Open();
            myCmd = new SqlCommand(@"INSERT INTO UserTable (FName, LName, IDNumber, Manager, PassPhrase)
                VALUES (@FName, @LName, @IDNumber, @Manager, @PassPhrase)", myConn);
            myCmd.Parameters.AddWithValue("@FName", FName);
            myCmd.Parameters.AddWithValue("@LName", LName);
            myCmd.Parameters.AddWithValue("@IDNumber", ID);
            myCmd.Parameters.AddWithValue("@Manager", Manager);
            myCmd.Parameters.AddWithValue("@PassPhrase", Pass);
            myCmd.ExecuteNonQuery();
            myConn.Close();
        }


        private void btnManagement_Click(object sender, EventArgs e)
        {
            EmployeeManagement EMForm = new EmployeeManagement(name, ManagerEnabled);
            EMForm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CustomerManagement CMForm = new CustomerManagement(name, ManagerEnabled);
            CMForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MovieManagement movieMan = new MovieManagement(name, ManagerEnabled);
            movieMan.Show();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Returns rtn = new Returns(name, ManagerEnabled);
            rtn.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports(name, ManagerEnabled);
            reports.Show();
        }

        private void lblLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void lblLogout_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

    }
}
