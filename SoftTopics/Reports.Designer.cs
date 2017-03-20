namespace SoftTopics
{
    partial class Reports
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
            this.lvReports = new System.Windows.Forms.ListView();
            this.ColumnOne = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnTwo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnThree = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbReportType = new System.Windows.Forms.ComboBox();
            this.btnRunReport = new System.Windows.Forms.Button();
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
            // lvReports
            // 
            this.lvReports.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnOne,
            this.ColumnTwo,
            this.ColumnThree});
            this.lvReports.Location = new System.Drawing.Point(12, 351);
            this.lvReports.Name = "lvReports";
            this.lvReports.Size = new System.Drawing.Size(626, 298);
            this.lvReports.TabIndex = 0;
            this.lvReports.UseCompatibleStateImageBehavior = false;
            // 
            // ColumnOne
            // 
            this.ColumnOne.Text = "Column";
            // 
            // ColumnTwo
            // 
            this.ColumnTwo.Text = "Column";
            // 
            // ColumnThree
            // 
            this.ColumnThree.Text = "Column";
            // 
            // cbReportType
            // 
            this.cbReportType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbReportType.FormattingEnabled = true;
            this.cbReportType.Items.AddRange(new object[] {
            "Login Report",
            "Rental Report",
            "Return Report",
            "Late Report"});
            this.cbReportType.Location = new System.Drawing.Point(703, 356);
            this.cbReportType.Name = "cbReportType";
            this.cbReportType.Size = new System.Drawing.Size(177, 28);
            this.cbReportType.TabIndex = 1;
            // 
            // btnRunReport
            // 
            this.btnRunReport.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRunReport.FlatAppearance.BorderSize = 3;
            this.btnRunReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRunReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRunReport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRunReport.Location = new System.Drawing.Point(719, 413);
            this.btnRunReport.Name = "btnRunReport";
            this.btnRunReport.Size = new System.Drawing.Size(144, 108);
            this.btnRunReport.TabIndex = 2;
            this.btnRunReport.Text = "Run Report";
            this.btnRunReport.UseVisualStyleBackColor = true;
            this.btnRunReport.Click += new System.EventHandler(this.btnRunReport_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblName.Location = new System.Drawing.Point(159, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(81, 31);
            this.lblName.TabIndex = 65;
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
            this.label10.TabIndex = 64;
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
            this.btnMovieMan.TabIndex = 63;
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
            this.btnCustomerMan.TabIndex = 62;
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
            this.btnManagement.TabIndex = 61;
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
            this.btnReturn.TabIndex = 60;
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
            this.btnReports.TabIndex = 59;
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
            this.btnRent.TabIndex = 58;
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
            this.lblLogout.TabIndex = 57;
            this.lblLogout.TabStop = true;
            this.lblLogout.Text = "Clear Screen";
            this.lblLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLogout_LinkClicked);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1366, 661);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnMovieMan);
            this.Controls.Add(this.btnCustomerMan);
            this.Controls.Add(this.btnManagement);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnRent);
            this.Controls.Add(this.lblLogout);
            this.Controls.Add(this.btnRunReport);
            this.Controls.Add(this.cbReportType);
            this.Controls.Add(this.lvReports);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reports";
            this.Text = "Reports";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Reports_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvReports;
        private System.Windows.Forms.ColumnHeader ColumnOne;
        private System.Windows.Forms.ColumnHeader ColumnTwo;
        private System.Windows.Forms.ColumnHeader ColumnThree;
        private System.Windows.Forms.ComboBox cbReportType;
        private System.Windows.Forms.Button btnRunReport;
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