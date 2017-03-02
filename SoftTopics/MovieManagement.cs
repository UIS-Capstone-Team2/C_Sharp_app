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
        public MovieManagement()
        {

            InitializeComponent();
        }

        private void MovieManagement_Load(object sender, EventArgs e)
        {
            loadFont();
            string movieFile = "..\\Files\\MovieList.txt";
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

        private void btnAddMovie_Click(object sender, EventArgs e)
        {

            foreach (ListViewItem item in lvMovies.Items)
            {
                if (item.SubItems[1].Text.Equals(txtBarcode.Text))
                {
                    txtBarcode.Text = "";
                    MessageBox.Show("There is already a movie with that barcode", "error");
                }
            }
            if (txtTitle.Text.Length != 0 && txtBarcode.Text.Length == 10 && txtCopyNumber.Value > 0)
            {
                int count = (int)txtCopyNumber.Value;
                string movieFile = "..\\Files\\MovieList.txt";
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
    }
}
