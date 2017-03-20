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
using System.Configuration;

namespace SoftTopics
{
    public partial class CustomerManagement : Form
    {
        string name;
        bool ManagerEnabled;
        private SqlConnection myConn;
        private SqlCommand myCmd;
        private SqlDataReader myReader;
        public CustomerManagement(string name, bool managerEnabled)
        {
            InitializeComponent();
            this.name = name;
            lblName.Text = name;
            this.ManagerEnabled = managerEnabled;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string FName;
            string LName;
            string PhoneNumber;
            FName = txtFirstName.Text;
            LName = txtLastName.Text;
            PhoneNumber = txtPhoneNumber.Text;
            findCust(FName, LName, PhoneNumber, "");
            if (lvCustomers.Items.Count != 0)
            {
                btnEdit.Enabled = true;
            }
            else
            {
                btnEdit.Enabled = false;
            }
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

        private void findCust(string FName, string LName, string PNumber, string CustomerCard)
        {
            lvCustomers.Items.Clear();
            myConn = new SqlConnection();
            myConn.ConnectionString = ConfigurationManager.ConnectionStrings["DataServer"].ConnectionString; myConn.Open();
            myCmd = new SqlCommand(@"SELECT FName, LName, PhoneNumber, CustomerCard FROM Customers WHERE 
            (FName = @Fname AND LName = @Lname)
            OR (FName = @Fname AND PhoneNumber = @PNumber)
            OR (LName = @Lname AND PhoneNumber = @PNumber)
            OR (LName = @Lname)
            OR (FName = @Fname)
            OR (PhoneNumber = @Pnumber)
            OR (CustomerCard = @CustomerCard)", myConn);
            myCmd.Parameters.AddWithValue("@Fname", FName);
            myCmd.Parameters.AddWithValue("@Lname", LName);
            myCmd.Parameters.AddWithValue("@PNumber", PNumber);
            myCmd.Parameters.AddWithValue("@CustomerCard",CustomerCard);



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
            myConn = new SqlConnection();
            myConn.ConnectionString = ConfigurationManager.ConnectionStrings["DataServer"].ConnectionString; myConn.Open();
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
            myConn = new SqlConnection();
            myConn.ConnectionString = ConfigurationManager.ConnectionStrings["DataServer"].ConnectionString; 
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



            myConn = new SqlConnection();
            myConn.ConnectionString = ConfigurationManager.ConnectionStrings["DataServer"].ConnectionString;
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
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            RentForm rent = new RentForm(name, ManagerEnabled);
            rent.Show();
            this.Close();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Returns returnForm = new Returns(name, ManagerEnabled);
            returnForm.Show();
            this.Close();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports(name, ManagerEnabled);
            reports.Show();
            this.Close();
        }

        private void btnManagement_Click(object sender, EventArgs e)
        {
            EmployeeManagement em = new EmployeeManagement(name, ManagerEnabled);
            em.Show();
            this.Close();
        }

        private void btnMovieMan_Click(object sender, EventArgs e)
        {
            MovieManagement mm = new MovieManagement(name, ManagerEnabled);
            mm.Show();
            this.Close();
        }

        private void lblLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void txtCustomerCard_TextChanged_1(object sender, EventArgs e)
        {
            if (txtCustomerCard.Text.Length == 13)
            {
                string CustomerCard = txtCustomerCard.Text;
                findCust("", "", "", CustomerCard);
            }
        }
    }
}
