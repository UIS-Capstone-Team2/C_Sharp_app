namespace SoftTopics
{
    partial class Returns
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvRentedMovies = new System.Windows.Forms.ListView();
            this.MovieTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UPC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CustomerFName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CustomerLName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PhoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateRented = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvOnTimeReturns = new System.Windows.Forms.ListView();
            this.MovieTitleScanned = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BarcodeScanned = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvLateReturns = new System.Windows.Forms.ListView();
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LateCharge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Movie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFinished = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnMovieMan = new System.Windows.Forms.Button();
            this.btnCustomerMan = new System.Windows.Forms.Button();
            this.btnManagement = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnRent = new System.Windows.Forms.Button();
            this.lblLogout = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lvRentedMovies
            // 
            this.lvRentedMovies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MovieTitle,
            this.UPC,
            this.CustomerFName,
            this.CustomerLName,
            this.PhoneNumber,
            this.DateRented});
            this.lvRentedMovies.Location = new System.Drawing.Point(12, 286);
            this.lvRentedMovies.Name = "lvRentedMovies";
            this.lvRentedMovies.Size = new System.Drawing.Size(544, 392);
            this.lvRentedMovies.TabIndex = 0;
            this.lvRentedMovies.UseCompatibleStateImageBehavior = false;
            // 
            // MovieTitle
            // 
            this.MovieTitle.Text = "Movie Title";
            // 
            // UPC
            // 
            this.UPC.Text = "Barcode";
            // 
            // CustomerFName
            // 
            this.CustomerFName.Text = "First Name";
            // 
            // CustomerLName
            // 
            this.CustomerLName.Text = "Last Name";
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Text = "Phone Number";
            // 
            // DateRented
            // 
            this.DateRented.Text = "Date Rented";
            // 
            // lvOnTimeReturns
            // 
            this.lvOnTimeReturns.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MovieTitleScanned,
            this.BarcodeScanned});
            this.lvOnTimeReturns.Location = new System.Drawing.Point(839, 286);
            this.lvOnTimeReturns.Name = "lvOnTimeReturns";
            this.lvOnTimeReturns.Size = new System.Drawing.Size(515, 241);
            this.lvOnTimeReturns.TabIndex = 2;
            this.lvOnTimeReturns.UseCompatibleStateImageBehavior = false;
            // 
            // MovieTitleScanned
            // 
            this.MovieTitleScanned.Text = "Movie Title";
            // 
            // BarcodeScanned
            // 
            this.BarcodeScanned.Text = "Barcode";
            // 
            // lvLateReturns
            // 
            this.lvLateReturns.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FirstName,
            this.LastName,
            this.Phone,
            this.LateCharge,
            this.Movie});
            this.lvLateReturns.Location = new System.Drawing.Point(839, 533);
            this.lvLateReturns.Name = "lvLateReturns";
            this.lvLateReturns.Size = new System.Drawing.Size(515, 145);
            this.lvLateReturns.TabIndex = 3;
            this.lvLateReturns.UseCompatibleStateImageBehavior = false;
            // 
            // FirstName
            // 
            this.FirstName.Text = "First Name";
            // 
            // LastName
            // 
            this.LastName.Text = "Last Name";
            // 
            // Phone
            // 
            this.Phone.Text = "Phone Number";
            // 
            // LateCharge
            // 
            this.LateCharge.Text = "Late Charge";
            // 
            // Movie
            // 
            this.Movie.Text = "Movie Title";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarcode.Location = new System.Drawing.Point(616, 407);
            this.txtBarcode.MaxLength = 12;
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(189, 27);
            this.txtBarcode.TabIndex = 5;
            this.txtBarcode.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtBarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericOnly);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(613, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter Movie Barcode";
            // 
            // btnFinished
            // 
            this.btnFinished.FlatAppearance.BorderSize = 3;
            this.btnFinished.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinished.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinished.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFinished.Location = new System.Drawing.Point(638, 554);
            this.btnFinished.Name = "btnFinished";
            this.btnFinished.Size = new System.Drawing.Size(130, 101);
            this.btnFinished.TabIndex = 7;
            this.btnFinished.Text = "Finish";
            this.btnFinished.UseVisualStyleBackColor = true;
            this.btnFinished.Click += new System.EventHandler(this.btnFinished_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblName.Location = new System.Drawing.Point(159, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(81, 31);
            this.lblName.TabIndex = 56;
            this.lblName.Text = "name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label10.Location = new System.Drawing.Point(12, 9);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(141, 31);
            this.label10.TabIndex = 55;
            this.label10.Text = "Welcome: ";
            // 
            // btnMovieMan
            // 
            this.btnMovieMan.FlatAppearance.BorderSize = 3;
            this.btnMovieMan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMovieMan.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovieMan.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnMovieMan.Location = new System.Drawing.Point(1179, 97);
            this.btnMovieMan.Name = "btnMovieMan";
            this.btnMovieMan.Size = new System.Drawing.Size(158, 134);
            this.btnMovieMan.TabIndex = 54;
            this.btnMovieMan.Text = "Movie Management";
            this.btnMovieMan.UseVisualStyleBackColor = true;
            this.btnMovieMan.Click += new System.EventHandler(this.btnMovieMan_Click);
            // 
            // btnCustomerMan
            // 
            this.btnCustomerMan.FlatAppearance.BorderSize = 3;
            this.btnCustomerMan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerMan.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerMan.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCustomerMan.Location = new System.Drawing.Point(719, 96);
            this.btnCustomerMan.Name = "btnCustomerMan";
            this.btnCustomerMan.Size = new System.Drawing.Size(158, 134);
            this.btnCustomerMan.TabIndex = 53;
            this.btnCustomerMan.Text = "Customer Management";
            this.btnCustomerMan.UseVisualStyleBackColor = true;
            this.btnCustomerMan.Click += new System.EventHandler(this.btnCustomerMan_Click);
            // 
            // btnManagement
            // 
            this.btnManagement.FlatAppearance.BorderSize = 3;
            this.btnManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManagement.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagement.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnManagement.Location = new System.Drawing.Point(949, 97);
            this.btnManagement.Name = "btnManagement";
            this.btnManagement.Size = new System.Drawing.Size(158, 134);
            this.btnManagement.TabIndex = 52;
            this.btnManagement.Text = "Employee Management";
            this.btnManagement.UseVisualStyleBackColor = true;
            this.btnManagement.Click += new System.EventHandler(this.btnManagement_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.FlatAppearance.BorderSize = 3;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnReturn.Location = new System.Drawing.Point(259, 97);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(158, 134);
            this.btnReturn.TabIndex = 51;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnReports
            // 
            this.btnReports.FlatAppearance.BorderSize = 3;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnReports.Location = new System.Drawing.Point(489, 97);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(158, 134);
            this.btnReports.TabIndex = 50;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnRent
            // 
            this.btnRent.BackColor = System.Drawing.Color.Teal;
            this.btnRent.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRent.FlatAppearance.BorderSize = 3;
            this.btnRent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRent.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRent.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnRent.Location = new System.Drawing.Point(29, 97);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(158, 134);
            this.btnRent.TabIndex = 49;
            this.btnRent.Text = "Rent";
            this.btnRent.UseVisualStyleBackColor = true;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // lblLogout
            // 
            this.lblLogout.AutoSize = true;
            this.lblLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogout.LinkColor = System.Drawing.Color.White;
            this.lblLogout.Location = new System.Drawing.Point(1234, 9);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(120, 24);
            this.lblLogout.TabIndex = 48;
            this.lblLogout.TabStop = true;
            this.lblLogout.Text = "Clear Screen";
            this.lblLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLogout_LinkClicked);
            // 
            // Returns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1366, 690);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnMovieMan);
            this.Controls.Add(this.btnCustomerMan);
            this.Controls.Add(this.btnManagement);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnRent);
            this.Controls.Add(this.lblLogout);
            this.Controls.Add(this.btnFinished);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.lvLateReturns);
            this.Controls.Add(this.lvOnTimeReturns);
            this.Controls.Add(this.lvRentedMovies);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Returns";
            this.Text = "Returns";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Returns_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvRentedMovies;
        private System.Windows.Forms.ColumnHeader MovieTitle;
        private System.Windows.Forms.ColumnHeader UPC;
        private System.Windows.Forms.ColumnHeader CustomerFName;
        private System.Windows.Forms.ColumnHeader CustomerLName;
        private System.Windows.Forms.ColumnHeader PhoneNumber;
        private System.Windows.Forms.ColumnHeader DateRented;
        private System.Windows.Forms.ListView lvOnTimeReturns;
        private System.Windows.Forms.ColumnHeader MovieTitleScanned;
        private System.Windows.Forms.ColumnHeader BarcodeScanned;
        private System.Windows.Forms.ListView lvLateReturns;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.ColumnHeader LateCharge;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader Movie;
        private System.Windows.Forms.ColumnHeader Phone;
        private System.Windows.Forms.Button btnFinished;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnMovieMan;
        private System.Windows.Forms.Button btnCustomerMan;
        private System.Windows.Forms.Button btnManagement;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.LinkLabel lblLogout;
    }
}