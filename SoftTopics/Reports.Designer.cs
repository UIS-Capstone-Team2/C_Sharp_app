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
            this.cbReportType = new System.Windows.Forms.ComboBox();
            this.btnRunReport = new System.Windows.Forms.Button();
            this.ColumnOne = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnTwo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnThree = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvReports
            // 
            this.lvReports.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnOne,
            this.ColumnTwo,
            this.ColumnThree});
            this.lvReports.Location = new System.Drawing.Point(12, 22);
            this.lvReports.Name = "lvReports";
            this.lvReports.Size = new System.Drawing.Size(241, 399);
            this.lvReports.TabIndex = 0;
            this.lvReports.UseCompatibleStateImageBehavior = false;
            // 
            // cbReportType
            // 
            this.cbReportType.FormattingEnabled = true;
            this.cbReportType.Items.AddRange(new object[] {
            "Login Report",
            "Rental Report",
            "Return Report",
            "Late Report"});
            this.cbReportType.Location = new System.Drawing.Point(259, 183);
            this.cbReportType.Name = "cbReportType";
            this.cbReportType.Size = new System.Drawing.Size(121, 21);
            this.cbReportType.TabIndex = 1;
            // 
            // btnRunReport
            // 
            this.btnRunReport.Location = new System.Drawing.Point(259, 219);
            this.btnRunReport.Name = "btnRunReport";
            this.btnRunReport.Size = new System.Drawing.Size(121, 23);
            this.btnRunReport.TabIndex = 2;
            this.btnRunReport.Text = "Run Report";
            this.btnRunReport.UseVisualStyleBackColor = true;
            this.btnRunReport.Click += new System.EventHandler(this.btnRunReport_Click);
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
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 433);
            this.Controls.Add(this.btnRunReport);
            this.Controls.Add(this.cbReportType);
            this.Controls.Add(this.lvReports);
            this.Name = "Reports";
            this.Text = "Reports";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvReports;
        private System.Windows.Forms.ColumnHeader ColumnOne;
        private System.Windows.Forms.ColumnHeader ColumnTwo;
        private System.Windows.Forms.ColumnHeader ColumnThree;
        private System.Windows.Forms.ComboBox cbReportType;
        private System.Windows.Forms.Button btnRunReport;
    }
}