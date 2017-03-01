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
  
    public partial class formLogin : Form
    {
        private HomeScreen HSForm;
        private SqlConnection myConn;
        private SqlCommand myCmd;
        private SqlDataReader myReader;
        
        public formLogin()
        {
            InitializeComponent();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string UName = txtUsername.Text;
            string PWord = txtPassword.Text;
            myConn = new SqlConnection("Server=softwarecapproject.database.windows.net;Database=VideoStoreUsers;User ID = bcrumrin64; Password=S0ftT0pix!; Encrypt=True; TrustServerCertificate=False; Connection Timeout=30;");
            myConn.Open();
            myCmd = new SqlCommand("SELECT IDNumber, PassPhrase FROM UserTable WHERE IDNumber = @Uname AND PassPhrase = @Pass", myConn);
            myCmd.Parameters.AddWithValue("@Uname", UName);
            myCmd.Parameters.AddWithValue("@Pass", PWord);

            var test = myCmd.ExecuteScalar();

            if (test == null)
            {
                lblSuccess.Text = "Invalid Username/Password";
                myConn.Close();
            }
            else
            {
                
                Boolean valid = true;
                HSForm = new HomeScreen(txtUsername.Text);
                myConn.Close();

                string loginReport = "..\\Files\\LoginReport.txt";
                using (StreamWriter sw = File.AppendText(loginReport))
                {
                    System.DateTime dt = DateTime.Today;
                    string day = dt.Day.ToString();
                    string month = dt.Month.ToString();
                    string year = dt.Year.ToString();

                    string fullString = txtUsername.Text + "," + day + "," + month + "," + year;
                    sw.WriteLine(fullString);
                }

                txtPassword.Text = "";
                txtUsername.Text = "";
                this.Hide();
                HSForm.ShowDialog();
                this.Show();
            }
        }

        private void formLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void KeyPressed(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        
    }
}
