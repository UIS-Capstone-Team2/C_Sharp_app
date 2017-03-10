using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Authenticator;
using System.IO;

namespace SoftTopics
{
    public partial class _2ndFactorSetup : Form
    {
        string ID;
        public _2ndFactorSetup(string ID)
        {
            InitializeComponent();
            this.ID = ID;
        }

        private void _2ndFactorSetup_Load(object sender, EventArgs e)
        {
            TwoFactorAuthenticator tfa = new TwoFactorAuthenticator();
            var setup = tfa.GenerateSetupCode("Video Store", ID, ("!8R8Vrreugfifbtljuf" + ID), 150, 150);
            string pictureURL = setup.QrCodeSetupImageUrl;

            imgQRCode.Load(pictureURL);
            lblQRText.Text = setup.ManualEntryKey;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (verify())
            {
                string twoFactFile = "..\\Files\\TwoFactorSetup.txt";
                using (StreamWriter sw = File.AppendText(twoFactFile))
                {
                    sw.WriteLine(ID);
                }
                this.Close();
            }
            else
            {
                lblWrongPin.Text = "Incorrect Pin, Please try again";
            }
            
        }

        private bool verify()
        {
            string pin = txtPIN.Text;
            TwoFactorAuthenticator tfa = new TwoFactorAuthenticator();
            bool validPIN = tfa.ValidateTwoFactorPIN("!8R8Vrreugfifbtljuf" + ID,pin);
            if (validPIN)
            {
                return true;
            }
            return false;
        }
    }
}
