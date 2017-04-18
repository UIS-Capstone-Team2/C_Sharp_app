using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace SoftTopics
{
    public partial class MovieManagement : Form
    {
        Font myFont;
        StreamReader fileToPrint;
        string name;
        bool ManagerEnabled;
        public MovieManagement(string name, bool mangerEnabled)
        {
            InitializeComponent();
            this.name = name;
            lblName.Text = name;
            this.ManagerEnabled = mangerEnabled;
        }

        private void MovieManagement_Load(object sender, EventArgs e)
        {
            if (!ManagerEnabled)
            {
                lblName.ForeColor = Color.LimeGreen;
                btnManagement.Enabled = true;
                btnManagement.FlatAppearance.BorderColor = Color.LimeGreen;
                btnRent.FlatAppearance.BorderColor = Color.LimeGreen;
                btnReturn.FlatAppearance.BorderColor = Color.LimeGreen;
                btnReports.FlatAppearance.BorderColor = Color.LimeGreen;
                btnCustomerMan.FlatAppearance.BorderColor = Color.LimeGreen;
                btnMovieMan.FlatAppearance.BorderColor = Color.LimeGreen;
            }
            else
            {
                btnManagement.Enabled = false;
                btnManagement.FlatAppearance.BorderColor = Color.Red;
            }



            loadFont();
            string movieFile = Properties.Settings.Default.movieListPath;
            using (StreamReader sr = new StreamReader(movieFile))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] movieLine = line.Split(',');
                    string movie = movieLine[1].ToString();
                    string barcode = movieLine[0].ToString();

                    string[] newItem = { movie, barcode };
                    lvMovies.View = View.Details;
                    lvMovies.FullRowSelect = true;
                    lvMovies.Items.Add(new ListViewItem(newItem));
                }
            }
        }

        private void loadFont()
        {
            PrivateFontCollection font = new PrivateFontCollection();
            //Font myFont;

            font.AddFontFile("..\\Files\\BarcodeFont.ttf");
            myFont = new Font(font.Families[0], 85);
            lblBarcode.Font = myFont;
        }

        private void AlphaOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void NumericOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {

            foreach (ListViewItem item in lvMovies.Items)
            {
                if (item.SubItems[1].Text.Equals(txtBarcode.Text + "01"))
                {
                    txtBarcode.Text = "";
                    MessageBox.Show("There is already a movie with that barcode", "error");
                }
            }
            if (txtTitle.Text.Length != 0 && txtBarcode.Text.Length == 10 && txtCopyNumber.Value > 0)
            {
                int count = (int)txtCopyNumber.Value;
                string movieFile = Properties.Settings.Default.movieListPath;
                using (StreamWriter sw = File.AppendText(movieFile))
                {
                    using (StreamWriter swTemp = new StreamWriter("..\\Files\\temp.txt"))
                    {


                        while (count > 0)
                        {
                            string copyNumber = count.ToString("D2");

                            string title = txtTitle.Text;
                            string barcode = txtBarcode.Text + copyNumber;
                            string newLine = barcode + "," + title;
                            newLine = newLine.Replace(" ", "");
                            sw.WriteLine(newLine);

                            string[] newItem = { title, barcode };
                            lvMovies.View = View.Details;
                            lvMovies.FullRowSelect = true;
                            lvMovies.Items.Add(new ListViewItem(newItem));

                            swTemp.WriteLine(barcode);
                            swTemp.WriteLine(" ");

                            count--;
                        }
                    }
                }


                print();
            }
        }

        private void print()
        {
            fileToPrint = new StreamReader("..\\Files\\temp.txt");

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

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {
            if (txtBarcode.Text.Length == 10)
            {
                lblBarcode.Text = txtBarcode.Text;
            }
        }

        private void btnManagement_Click(object sender, EventArgs e)
        {
            EmployeeManagement em = new EmployeeManagement(name, ManagerEnabled);
            em.Show();
            this.Close();
        }

        private void btnCustomerMan_Click(object sender, EventArgs e)
        {
            CustomerManagement cm = new CustomerManagement(name, ManagerEnabled);
            cm.Show();
            this.Close();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports(name, ManagerEnabled);
            reports.Show();
            this.Close();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Returns returns = new Returns(name, ManagerEnabled);
            returns.Show();
            this.Close();
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            RentForm rentForm = new RentForm(name, ManagerEnabled);
            rentForm.Show();
            this.Close();
        }

        private void lblLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
