namespace SoftTopics
{
    partial class _2ndFactorSetup
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
            this.imgQRCode = new System.Windows.Forms.PictureBox();
            this.lblQRText = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPIN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblWrongPin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgQRCode)).BeginInit();
            this.SuspendLayout();
            // 
            // imgQRCode
            // 
            this.imgQRCode.Location = new System.Drawing.Point(632, 12);
            this.imgQRCode.Name = "imgQRCode";
            this.imgQRCode.Size = new System.Drawing.Size(150, 150);
            this.imgQRCode.TabIndex = 0;
            this.imgQRCode.TabStop = false;
            // 
            // lblQRText
            // 
            this.lblQRText.AutoSize = true;
            this.lblQRText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblQRText.Location = new System.Drawing.Point(504, 177);
            this.lblQRText.Name = "lblQRText";
            this.lblQRText.Size = new System.Drawing.Size(35, 13);
            this.lblQRText.TabIndex = 1;
            this.lblQRText.Text = "label1";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(699, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 79);
            this.button1.TabIndex = 2;
            this.button1.Text = "Finished";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPIN
            // 
            this.txtPIN.Location = new System.Drawing.Point(682, 256);
            this.txtPIN.MaxLength = 10;
            this.txtPIN.Name = "txtPIN";
            this.txtPIN.Size = new System.Drawing.Size(119, 20);
            this.txtPIN.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(578, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter PIN to Finish:";
            // 
            // lblWrongPin
            // 
            this.lblWrongPin.AutoSize = true;
            this.lblWrongPin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblWrongPin.Location = new System.Drawing.Point(746, 413);
            this.lblWrongPin.Name = "lblWrongPin";
            this.lblWrongPin.Size = new System.Drawing.Size(0, 13);
            this.lblWrongPin.TabIndex = 5;
            // 
            // _2ndFactorSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1366, 700);
            this.Controls.Add(this.lblWrongPin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPIN);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblQRText);
            this.Controls.Add(this.imgQRCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "_2ndFactorSetup";
            this.Text = "_2ndFactorSetup";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this._2ndFactorSetup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgQRCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgQRCode;
        private System.Windows.Forms.Label lblQRText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPIN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWrongPin;
    }
}