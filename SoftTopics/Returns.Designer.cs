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
            this.LateCharge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Movie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnFinished = new System.Windows.Forms.Button();
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
            this.lvRentedMovies.Location = new System.Drawing.Point(12, 12);
            this.lvRentedMovies.Name = "lvRentedMovies";
            this.lvRentedMovies.Size = new System.Drawing.Size(284, 392);
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
            this.lvOnTimeReturns.Location = new System.Drawing.Point(433, 12);
            this.lvOnTimeReturns.Name = "lvOnTimeReturns";
            this.lvOnTimeReturns.Size = new System.Drawing.Size(284, 241);
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
            this.lvLateReturns.Location = new System.Drawing.Point(433, 259);
            this.lvLateReturns.Name = "lvLateReturns";
            this.lvLateReturns.Size = new System.Drawing.Size(284, 145);
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
            // LateCharge
            // 
            this.LateCharge.DisplayIndex = 2;
            this.LateCharge.Text = "Late Charge";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(313, 152);
            this.txtBarcode.MaxLength = 12;
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(100, 20);
            this.txtBarcode.TabIndex = 5;
            this.txtBarcode.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter Movie Barcode";
            // 
            // Movie
            // 
            this.Movie.DisplayIndex = 3;
            this.Movie.Text = "Movie Title";
            // 
            // Phone
            // 
            this.Phone.Text = "Phone Number";
            // 
            // btnFinished
            // 
            this.btnFinished.Location = new System.Drawing.Point(327, 362);
            this.btnFinished.Name = "btnFinished";
            this.btnFinished.Size = new System.Drawing.Size(75, 23);
            this.btnFinished.TabIndex = 7;
            this.btnFinished.Text = "Finish";
            this.btnFinished.UseVisualStyleBackColor = true;
            this.btnFinished.Click += new System.EventHandler(this.btnFinished_Click);
            // 
            // Returns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 416);
            this.Controls.Add(this.btnFinished);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.lvLateReturns);
            this.Controls.Add(this.lvOnTimeReturns);
            this.Controls.Add(this.lvRentedMovies);
            this.Name = "Returns";
            this.Text = "Returns";
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
    }
}