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
    public partial class MovieManagement : Form
    {
        public MovieManagement()
        {
            InitializeComponent();
        }

        private void MovieManagement_Load(object sender, EventArgs e)
        {
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
            if (txtTitle.Text.Length != 0 && txtBarcode.Text.Length == 12)
            {
                
                string movieFile = "..\\Files\\MovieList.txt";
                using (StreamWriter sw = File.AppendText(movieFile))
                {
                    string title = txtTitle.Text;
                    string barcode = txtBarcode.Text;
                    string newLine = barcode + "," + title + "," + "3";
                    newLine = newLine.Replace(" ", "");
                    sw.WriteLine(newLine);

                    string[] newItem = { title, barcode };
                    lvMovies.View = View.Details;
                    lvMovies.FullRowSelect = true;
                    lvMovies.Items.Add(new ListViewItem(newItem));
                }
                
            }
        }
    }
}
