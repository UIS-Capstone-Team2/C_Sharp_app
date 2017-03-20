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
using System.Configuration;
using Google.Authenticator;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.Timers;

namespace SoftTopics
{
  
    public partial class formLogin : Form
    {
        private HomeScreen HSForm;
        private SqlConnection myConn;
        private SqlCommand myCmd;
        private SqlDataReader myReader;
        private static Random rand = new Random();
        StreamReader fileToPrint;
        Font myFont;
        
        public formLogin()
        {
            InitializeComponent();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string UName = txtUsername.Text;
            string PWord = pass(txtPassword.Text);
            
            myConn = new SqlConnection();
            myConn.ConnectionString = ConfigurationManager.ConnectionStrings["DataServer"].ConnectionString;
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
                btnSubmit.Enabled = true;
                txtPIN.Enabled = true;
                
                string twoFactFile;
                twoFactFile = Properties.Settings.Default.twoFactorSetupPath;
                bool setup = true;
                using (StreamReader sr = new StreamReader(twoFactFile))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line.Equals(UName))
                        {
                            setup = false;
                        }
                    }
                }

                if (setup)
                {
                    login();
                }
            }

        }

        private void formLogin_Load(object sender, EventArgs e)
        {
            
            string quickLogin = Properties.Settings.Default.quickLoginPath;
            using (StreamWriter sw = new StreamWriter(quickLogin))
            {
                //Clear file each time program runs
            }
        }

        private void quickLogin(string ID)
        {
            loadFont();
            string credentials;
            using (StreamWriter sw = new StreamWriter(Properties.Settings.Default.temporaryFilePath))
            {
                int cred = rand.Next(10000000, 99999999);
                credentials = cred.ToString();
                sw.WriteLine(credentials);
            }
            print();
            using (StreamWriter sw = File.AppendText(Properties.Settings.Default.quickLoginPath))
            {
                sw.WriteLine(ID + "," + credentials);
            }
        }

        private void loadFont()
        {
            PrivateFontCollection font = new PrivateFontCollection();
            //Font myFont;

            font.AddFontFile("..\\Files\\BarcodeFont.ttf");
            myFont = new Font(font.Families[0], 85);
        }

        private void print()
        {
            fileToPrint = new StreamReader(Properties.Settings.Default.temporaryFilePath);

            PrintDocument print = new PrintDocument();
            print.PrintPage += new PrintPageEventHandler(this.print_PrintPage);
            print.Print();
            fileToPrint.Close();

        }

        private void print_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font printFont = myFont;
            float yPos = 0f;
            int count = 0;
            float leftMargin = e.MarginBounds.Left;
            float topMargin = e.MarginBounds.Top;
            string line = null;
            float linesPerPage = e.MarginBounds.Height / printFont.GetHeight(e.Graphics);
            while (count < linesPerPage)
            {
                line = fileToPrint.ReadLine();
                if (line == null)
                {
                    break;

                }
                yPos = topMargin + count * printFont.GetHeight(e.Graphics);
                e.Graphics.DrawString(line, printFont, Brushes.Black, leftMargin, yPos, new StringFormat());
                count++;
            }
            if (line != null)
            {
                e.HasMorePages = true;
            }
        }

        private string pass(string oldPass)
        {
            System.Security.Cryptography.MD5CryptoServiceProvider newPass = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] data = System.Text.Encoding.ASCII.GetBytes(oldPass);
            data = newPass.ComputeHash(data);
            return System.Text.Encoding.ASCII.GetString(data);
        }

        private void KeyPressed(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void KeyPressedAlphaNum(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void login()
        {

            Boolean valid = false;
            HSForm = new HomeScreen(txtUsername.Text);
            myConn.Close();
            btnQuickLogin.Enabled = true;

            string loginReport = Properties.Settings.Default.loginReportPath;
            using (StreamWriter sw = File.AppendText(loginReport))
            {
                System.DateTime dt = DateTime.Today;
                string day = dt.Day.ToString();
                string month = dt.Month.ToString();
                string year = dt.Year.ToString();

                string fullString = txtUsername.Text + "," + day + "," + month + "," + year;
                sw.WriteLine(fullString);
            }


            using (StreamReader sw = new StreamReader(Properties.Settings.Default.quickLoginPath))
            {
                string line;
                while ((line = sw.ReadLine()) != null)
                {
                    string[] lineInfo = line.Split(',');
                    string id = lineInfo[0];
                    if (id.Equals(txtUsername.Text))
                    {
                        valid = true;
                        break;
                    }
                }
            }

            if (!valid)
            {
                quickLogin(txtUsername.Text);
            }

            txtPassword.Text = "";
            txtUsername.Text = "";
            txtPIN.Text = "";
            lblSuccess.Text = "";
            txtCredentialBox.Text = "";
            txtPIN.Enabled = false;
            btnSubmit.Enabled = false;
            this.Hide();
            HSForm.ShowDialog();
            this.Show();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            bool checkPin = false;
            string pin = txtPIN.Text;
            TwoFactorAuthenticator tfa = new TwoFactorAuthenticator();
            checkPin = tfa.ValidateTwoFactorPIN(("!8R8Vrreugfifbtljuf" + txtUsername.Text), pin);
            
            if (!checkPin)
            {
                btnSubmit.Enabled = false;
                txtPIN.Enabled = false;
                lblSuccess.Text = "Invalid PIN";
                txtPIN.Text = "";
            }
            else
            {
                login();
            }
        }

        private void enterKeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(this, new EventArgs());
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            bool valid = false;
            using (StreamReader sr = new StreamReader(Properties.Settings.Default.quickLoginPath))
            {
                string line;
                
                string credentials = txtCredentialBox.Text;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] lineInfo = line.Split(',');
                    string idNum = lineInfo[0];
                    string cred = lineInfo[1];

                    if (credentials.Equals(cred))
                    {
                        txtUsername.Text = idNum;
                        valid = true;
                        break;
                    }
                }
            }
            if (valid)
            {
                login();
            }
            else
            {
                btnQuickLogin.Enabled = false;
            }
        }

        private void textChangeTimeLimit(object sender, EventArgs e)
        {
            if (txtCredentialBox.Text.Length == 8)
            {
                button1_Click_1(this, new EventArgs());
            }

            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 100;
            timer.Tick += timer_Tick;
            timer.Start();
            
        }

        void timer_Tick(object sender, EventArgs e)
        {
            txtCredentialBox.Text = "";
            ((System.Windows.Forms.Timer)sender).Stop();
            
        }

        
    }
}
