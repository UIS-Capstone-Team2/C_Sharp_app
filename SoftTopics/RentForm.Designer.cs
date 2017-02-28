namespace SoftTopics
{
    partial class RentForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDVDID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRentalDays = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCustomerNumber = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.btnSubmitPayment = new System.Windows.Forms.Button();
            this.txtPaidAmount = new System.Windows.Forms.NumericUpDown();
            this.lblMovieTitle = new System.Windows.Forms.Label();
            this.lblRentalRate = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lvSearchResults = new System.Windows.Forms.ListView();
            this.FName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PhoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSelect = new System.Windows.Forms.Button();
            this.lvOverview = new System.Windows.Forms.ListView();
            this.label6 = new System.Windows.Forms.Label();
            this.MovieTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Days = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRemoveMovie = new System.Windows.Forms.Button();
            this.UPC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.txtRentalDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPaidAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Movie Title: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rental Rate:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(445, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "DVD ID: ";
            // 
            // txtDVDID
            // 
            this.txtDVDID.Location = new System.Drawing.Point(501, 98);
            this.txtDVDID.MaxLength = 12;
            this.txtDVDID.Name = "txtDVDID";
            this.txtDVDID.Size = new System.Drawing.Size(100, 20);
            this.txtDVDID.TabIndex = 3;
            this.txtDVDID.TextChanged += new System.EventHandler(this.txtDVDID_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(424, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Rental Days: ";
            // 
            // txtRentalDays
            // 
            this.txtRentalDays.Location = new System.Drawing.Point(502, 142);
            this.txtRentalDays.Name = "txtRentalDays";
            this.txtRentalDays.Size = new System.Drawing.Size(99, 20);
            this.txtRentalDays.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(427, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Customer ID:";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(502, 49);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(0, 13);
            this.lblCustomerName.TabIndex = 7;
            // 
            // lblCustomerNumber
            // 
            this.lblCustomerNumber.AutoSize = true;
            this.lblCustomerNumber.Location = new System.Drawing.Point(502, 66);
            this.lblCustomerNumber.Name = "lblCustomerNumber";
            this.lblCustomerNumber.Size = new System.Drawing.Size(0, 13);
            this.lblCustomerNumber.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(420, 383);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Total Price:  $";
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.Location = new System.Drawing.Point(526, 174);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(75, 23);
            this.btnAddMovie.TabIndex = 11;
            this.btnAddMovie.Text = "Add Movie";
            this.btnAddMovie.UseVisualStyleBackColor = true;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(489, 383);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(28, 13);
            this.lblTotalPrice.TabIndex = 12;
            this.lblTotalPrice.Text = "3.00";
            // 
            // btnSubmitPayment
            // 
            this.btnSubmitPayment.Location = new System.Drawing.Point(552, 403);
            this.btnSubmitPayment.Name = "btnSubmitPayment";
            this.btnSubmitPayment.Size = new System.Drawing.Size(95, 23);
            this.btnSubmitPayment.TabIndex = 13;
            this.btnSubmitPayment.Text = "Submit Payment";
            this.btnSubmitPayment.UseVisualStyleBackColor = true;
            this.btnSubmitPayment.Click += new System.EventHandler(this.btnSubmitPayment_Click);
            // 
            // txtPaidAmount
            // 
            this.txtPaidAmount.DecimalPlaces = 2;
            this.txtPaidAmount.Location = new System.Drawing.Point(426, 406);
            this.txtPaidAmount.Name = "txtPaidAmount";
            this.txtPaidAmount.Size = new System.Drawing.Size(120, 20);
            this.txtPaidAmount.TabIndex = 14;
            // 
            // lblMovieTitle
            // 
            this.lblMovieTitle.AutoSize = true;
            this.lblMovieTitle.Location = new System.Drawing.Point(169, 51);
            this.lblMovieTitle.Name = "lblMovieTitle";
            this.lblMovieTitle.Size = new System.Drawing.Size(0, 13);
            this.lblMovieTitle.TabIndex = 15;
            // 
            // lblRentalRate
            // 
            this.lblRentalRate.AutoSize = true;
            this.lblRentalRate.Location = new System.Drawing.Point(172, 161);
            this.lblRentalRate.Name = "lblRentalRate";
            this.lblRentalRate.Size = new System.Drawing.Size(28, 13);
            this.lblRentalRate.TabIndex = 16;
            this.lblRentalRate.Text = "3.00";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(195, 350);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 17;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(86, 324);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 18;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            this.txtFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(86, 350);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 327);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "First Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(2, 353);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Last Name";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(86, 376);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.txtPhoneNumber.TabIndex = 22;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(2, 379);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "Phone Number";
            // 
            // lvSearchResults
            // 
            this.lvSearchResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FName,
            this.LName,
            this.PhoneNumber});
            this.lvSearchResults.Location = new System.Drawing.Point(12, 402);
            this.lvSearchResults.MultiSelect = false;
            this.lvSearchResults.Name = "lvSearchResults";
            this.lvSearchResults.Size = new System.Drawing.Size(285, 115);
            this.lvSearchResults.TabIndex = 24;
            this.lvSearchResults.UseCompatibleStateImageBehavior = false;
            // 
            // FName
            // 
            this.FName.Text = "First Name";
            this.FName.Width = 80;
            // 
            // LName
            // 
            this.LName.Text = "Last Name";
            this.LName.Width = 100;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Text = "Phone Number";
            this.PhoneNumber.Width = 100;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(313, 455);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 25;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // lvOverview
            // 
            this.lvOverview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MovieTitle,
            this.Days,
            this.UPC});
            this.lvOverview.Location = new System.Drawing.Point(427, 216);
            this.lvOverview.MultiSelect = false;
            this.lvOverview.Name = "lvOverview";
            this.lvOverview.Size = new System.Drawing.Size(201, 124);
            this.lvOverview.TabIndex = 26;
            this.lvOverview.UseCompatibleStateImageBehavior = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(423, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Order Overview:";
            // 
            // MovieTitle
            // 
            this.MovieTitle.Text = "Title";
            this.MovieTitle.Width = 90;
            // 
            // Days
            // 
            this.Days.Text = "Days";
            // 
            // btnRemoveMovie
            // 
            this.btnRemoveMovie.Location = new System.Drawing.Point(534, 343);
            this.btnRemoveMovie.Name = "btnRemoveMovie";
            this.btnRemoveMovie.Size = new System.Drawing.Size(94, 23);
            this.btnRemoveMovie.TabIndex = 28;
            this.btnRemoveMovie.Text = "Remove Movie";
            this.btnRemoveMovie.UseVisualStyleBackColor = true;
            this.btnRemoveMovie.Click += new System.EventHandler(this.btnRemoveMovie_Click);
            // 
            // UPC
            // 
            this.UPC.Text = "UPC";
            // 
            // RentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 529);
            this.Controls.Add(this.btnRemoveMovie);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lvOverview);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.lvSearchResults);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.lblRentalRate);
            this.Controls.Add(this.lblMovieTitle);
            this.Controls.Add(this.txtPaidAmount);
            this.Controls.Add(this.btnSubmitPayment);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.btnAddMovie);
            this.Controls.Add(this.lblCustomerNumber);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRentalDays);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDVDID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Name = "RentForm";
            this.Text = "RentForm";
            ((System.ComponentModel.ISupportInitialize)(this.txtRentalDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPaidAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDVDID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown txtRentalDays;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblCustomerNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Button btnSubmitPayment;
        private System.Windows.Forms.NumericUpDown txtPaidAmount;
        private System.Windows.Forms.Label lblMovieTitle;
        private System.Windows.Forms.Label lblRentalRate;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListView lvSearchResults;
        private System.Windows.Forms.ColumnHeader FName;
        private System.Windows.Forms.ColumnHeader LName;
        private System.Windows.Forms.ColumnHeader PhoneNumber;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.ListView lvOverview;
        private System.Windows.Forms.ColumnHeader MovieTitle;
        private System.Windows.Forms.ColumnHeader Days;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRemoveMovie;
        private System.Windows.Forms.ColumnHeader UPC;
    }
}