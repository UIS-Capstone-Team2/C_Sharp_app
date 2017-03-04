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

namespace SoftTopics
{
    public partial class CustomerManagement : Form
    {
        string name;
        private SqlConnection myConn;
        private SqlCommand myCmd;
        private SqlDataReader myReader;
        public CustomerManagement(string name)
        {
            InitializeComponent();
            this.name = name;
            lblName.Text = name;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string FName;
            string LName;
            string PhoneNumber;
            FName = txtFirstName.Text;
            LName = txtLastName.Text;
            PhoneNumber = txtPhoneNumber.Text;
            findCust(FName, LName, PhoneNumber);
            if (lvCustomers.Items.Count != 0)
            {
                btnEdit.Enabled = true;
            }
            else
            {
                btnEdit.Enabled = false;
            }
        }

        private void findCust(string FName, string LName, string PNumber)
        {
            lvCustomers.Items.Clear();
            myConn = new SqlConnection("Server=softwarecapproject.database.windows.net;Database=VideoStoreUsers;User ID = bcrumrin64; Password=xxxxxx; Encrypt=True; TrustServerCertificate=False; Connection Timeout=30;");
            myConn.Open();
            myCmd = new SqlCommand(@"SELECT FName, LName, PhoneNumber FROM Customers WHERE 
            (FName = @Fname AND LName = @Lname)
            OR (FName = @Fname AND PhoneNumber = @PNumber)
            OR (LName = @Lname AND PhoneNumber = @PNumber)
            OR (LName = @Lname)
            OR (FName = @Fname)
            OR (PhoneNumber = @Pnumber)", myConn);
            myCmd.Parameters.AddWithValue("@Fname", FName);
            myCmd.Parameters.AddWithValue("@Lname", LName);
            myCmd.Parameters.AddWithValue("@PNumber", PNumber);



            myReader = myCmd.ExecuteReader();
            while (myReader.Read())
            {
                string FirstName;
                string LastName;
                string PhoneNumber;

                FirstName = (string)myReader.GetValue(myReader.GetOrdinal("FName"));
                LastName = (string)myReader.GetValue(myReader.GetOrdinal("LName"));
                PhoneNumber = (string)myReader.GetValue(myReader.GetOrdinal("PhoneNumber"));

                lvCustomers.View = View.Details;
                lvCustomers.FullRowSelect = true;
                string[] result = { FirstName, LastName, PhoneNumber };
                lvCustomers.Items.Add(new ListViewItem(result));

            }


        }

        private void txtTextBoxTextChange(object sender, EventArgs e)
        {
            if (txtFirstName.Text != "" && txtLastName.Text != "" && txtPhoneNumber.Text != "")
            {

                btnUpdate.Enabled = true;
            }
            else
            {
                btnUpdate.Enabled = false;

            }

            if (txtFirstName.Text != "" || txtLastName.Text != "" || txtPhoneNumber.Text != "")
            {

                btnSearch.Enabled = true;
            }
        }

        private Boolean exactMatch(string FName, string LName, string PhoneNumber)
        {
            myConn = new SqlConnection("Server=softwarecapproject.database.windows.net;Database=VideoStoreUsers;User ID = bcrumrin64; Password=xxxxxx; Encrypt=True; TrustServerCertificate=False; Connection Timeout=30;");
            myConn.Open();
            myCmd = new SqlCommand(@"SELECT FName, LName, PhoneNumber FROM Customers WHERE 
            (FName = @Fname AND LName = @Lname AND PhoneNumber = @PNumber)", myConn);
            myCmd.Parameters.AddWithValue("@Fname", FName);
            myCmd.Parameters.AddWithValue("@Lname", LName);
            myCmd.Parameters.AddWithValue("@PNumber", PhoneNumber);

            var test = myCmd.ExecuteScalar();
            if (test == null)
            {
                return false;
            }
            return true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string FName;
            string LName;
            string PhoneNumber;
            FName = txtFirstName.Text;
            LName = txtLastName.Text;
            PhoneNumber = txtPhoneNumber.Text;
            Boolean findCustomer = exactMatch(FName, LName, PhoneNumber);
            if (findCustomer)
            {
                MessageBox.Show("Customer already exists", "Update Customer");
            }
            else
            {
                if (txtCustomerCard.Text.Length != 12)
                {
                    MessageBox.Show("Please enter a valid customer card number");
                }
                else
                {
                    addCustomer(FName, LName, PhoneNumber);
                }

            }

        }

        private void addCustomer(string FName, string LName, string PhoneNumber)
        {
            string customerCard = txtCustomerCard.Text;
            myConn = new SqlConnection("Server=softwarecapproject.database.windows.net;Database=VideoStoreUsers;User ID = bcrumrin64; Password=XXXXX; Encrypt=True; TrustServerCertificate=False; Connection Timeout=30;");
            myConn.Open();
            myCmd = new SqlCommand(@"INSERT INTO Customers (FName, LName, PhoneNumber)
                VALUES (@FName, @LName, @PhoneNumber)", myConn);
            myCmd.Parameters.AddWithValue("@FName", FName);
            myCmd.Parameters.AddWithValue("@LName", LName);
            myCmd.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
            myCmd.Parameters.AddWithValue("@CustomerCard", customerCard);
            myCmd.ExecuteNonQuery();
            myConn.Close();
            MessageBox.Show("Customer Updated", "Update Customer");

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Failure to hit 'Update' will result in customer data to be deleted
                even if no data has been changed");
            ListViewItem selected = lvCustomers.SelectedItems[0];
            string FName = selected.SubItems[0].Text;
            string LName = selected.SubItems[1].Text;
            string PhoneNumber = selected.SubItems[2].Text;

            txtFirstName.Text = FName;
            txtLastName.Text = LName;
            txtPhoneNumber.Text = PhoneNumber;

            deleteCustomer(FName, LName, PhoneNumber);


        }

        private void deleteCustomer(string FName, string LName, string PNumber)
        {
            myConn = new SqlConnection("Server=softwarecapproject.database.windows.net;Database=VideoStoreUsers;User ID = bcrumrin64; Password=S0ftT0pix!; Encrypt=True; TrustServerCertificate=False; Connection Timeout=30;");
            myConn.Open();
            myCmd = new SqlCommand(@"DELETE FROM Customers Where 
                FName = @FName
                AND LastName = @LName 
                AND PhoneNumber = @PNumber", myConn);
            myCmd.Parameters.AddWithValue("@FName", FName);
            myCmd.Parameters.AddWithValue("@LName", LName);
            myCmd.Parameters.AddWithValue("@PNumber", PNumber);
            myCmd.ExecuteNonQuery();
            myConn.Close();
        }

        private void txtCustomerCard_TextChanged(object sender, EventArgs e)
        {

        }

        private void CustomerManagement_Load(object sender, EventArgs e)
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
            Reports reports = new Reports(name);
            reports.Show();
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
