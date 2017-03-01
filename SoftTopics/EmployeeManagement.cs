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
    public partial class EmployeeManagement : Form
    {
        private SqlConnection myConn;
        private SqlCommand myCmd;
        private SqlDataReader myReader;
        public EmployeeManagement()
        {
            InitializeComponent();
        }

        private void EmployeeManagement_Load(object sender, EventArgs e)
        {
            updateTable();
        }

        private void updateTable()
        {
            lvEmployees.Items.Clear();
            myConn = new SqlConnection("Server=softwarecapproject.database.windows.net;Database=VideoStoreUsers;User ID = bcrumrin64; Password=S0ftT0pix!; Encrypt=True; TrustServerCertificate=False; Connection Timeout=30;");
            myConn.Open();
            myCmd = new SqlCommand("SELECT FName, LName, IDNumber, Manager FROM UserTable", myConn);
            myReader = myCmd.ExecuteReader();
            while (myReader.Read())
            {
                string FirstName;
                string LastName;
                string ID;
                string Manager;

                FirstName = (string)myReader.GetValue(myReader.GetOrdinal("FName"));
                LastName = (string)myReader.GetValue(myReader.GetOrdinal("LName"));
                ID = myReader.GetValue(myReader.GetOrdinal("IDNumber")).ToString();
                Manager = (string)myReader.GetValue(myReader.GetOrdinal("Manager"));


                lvEmployees.View = View.Details;
                lvEmployees.FullRowSelect = true;
                string[] result = { FirstName, LastName, ID, Manager };
                lvEmployees.Items.Add(new ListViewItem(result));
            }
            myConn.Close();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ListViewItem selected = lvEmployees.SelectedItems[0];
            string FName = selected.SubItems[0].Text;
            string LName = selected.SubItems[1].Text;
            string ID = selected.SubItems[2].Text;
            int IDNum;
            int.TryParse(ID, out IDNum);

            DialogResult result = MessageBox.Show("Are you sure you want to delete " + FName + "?", "Delete Employee", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                DeleteEmployee(FName, LName, IDNum);
                updateTable();
            }
        }

        private void DeleteEmployee(string FName, string LName, int IDNumber)
        {
            myConn = new SqlConnection("Server=softwarecapproject.database.windows.net;Database=VideoStoreUsers;User ID = bcrumrin64; Password=S0ftT0pix!; Encrypt=True; TrustServerCertificate=False; Connection Timeout=30;");
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
            myConn = new SqlConnection("Server=softwarecapproject.database.windows.net;Database=VideoStoreUsers;User ID = bcrumrin64; Password=S0ftT0pix!; Encrypt=True; TrustServerCertificate=False; Connection Timeout=30;");
            myConn.Open();
            myCmd = new SqlCommand(@"INSERT INTO UserTable (FName, LName, IDNumber, Manager, PassPhrase)
                VALUES (@FName, @LName, @IDNumber, @Manager, @Pass)", myConn);
            myCmd.Parameters.AddWithValue("@FName", FName);
            myCmd.Parameters.AddWithValue("@LName", LName);
            myCmd.Parameters.AddWithValue("@IDNumber", IDNumber);
            myCmd.Parameters.AddWithValue("@Manager", Manager);
            myCmd.Parameters.AddWithValue("@PassPhrase", Pass);
            myCmd.ExecuteNonQuery();
            myConn.Close();
            updateTable();
        }

        private void txtBoxTextChanged(object sender, EventArgs e)
        {
            if (txtFName.Text != "" && txtLName.Text != "" && txtIDNum.Text != "" && txtPassword.Text != "" && txtManager.Text != "")
            {
                btnUpdateEmployee.Enabled = true;
            }
            else
            {
                btnUpdateEmployee.Enabled = false;
            }
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            int ID;
            int.TryParse(txtIDNum.Text, out ID);
            string FName = txtFName.Text;
            string LName = txtLName.Text;
            string Pass = txtPassword.Text;
            string Manager = txtManager.Text;
            myConn = new SqlConnection("Server=softwarecapproject.database.windows.net;Database=VideoStoreUsers;User ID = bcrumrin64; Password=S0ftT0pix!; Encrypt=True; TrustServerCertificate=False; Connection Timeout=30;");
            myConn.Open();
            myCmd = new SqlCommand("SELECT IDNumber, FName FROM UserTable WHERE IDNumber = @Uname AND FName = @FName", myConn);
            myCmd.Parameters.AddWithValue("@Uname", ID);
            myCmd.Parameters.AddWithValue("@FName", FName);

            var test = myCmd.ExecuteScalar();

            if (test == null)
            {
                AddEmployee(FName, LName, ID, Manager, Pass);
            }
            else
            {
                DeleteEmployee(FName, LName, ID);
                AddEmployee(FName, LName, ID, Manager, Pass);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ListViewItem selected = lvEmployees.SelectedItems[0];
            string FName = selected.SubItems[0].Text;
            string LName = selected.SubItems[1].Text;
            string ID = selected.SubItems[2].Text;
            string Manager = selected.SubItems[3].Text;

            txtFName.Text = FName;
            txtLName.Text = LName;
            txtIDNum.Text = ID;
            txtManager.Text = Manager;

        }

        private void btnUpdateList_Click(object sender, EventArgs e)
        {
            updateTable();
        }
    }

}
