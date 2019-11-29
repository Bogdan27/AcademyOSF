namespace RentC
{
    partial class ReportScreen
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
            this.labelLessRented = new System.Windows.Forms.Label();
            this.labelMostRented = new System.Windows.Forms.Label();
            this.labelMostRecentRented = new System.Windows.Forms.Label();
            this.labelVIP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelLessRented
            // 
            this.labelLessRented.AutoSize = true;
            this.labelLessRented.Font = new System.Drawing.Font("Arial", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLessRented.Location = new System.Drawing.Point(35, 320);
            this.labelLessRented.Name = "labelLessRented";
            this.labelLessRented.Size = new System.Drawing.Size(450, 28);
            this.labelLessRented.TabIndex = 7;
            this.labelLessRented.Text = "4. Less Rented Carts In A Given Month";
            // 
            // labelMostRented
            // 
            this.labelMostRented.AutoSize = true;
            this.labelMostRented.Font = new System.Drawing.Font("Arial", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMostRented.Location = new System.Drawing.Point(35, 240);
            this.labelMostRented.Name = "labelMostRented";
            this.labelMostRented.Size = new System.Drawing.Size(451, 28);
            this.labelMostRented.TabIndex = 6;
            this.labelMostRented.Text = "3. Most Rented Carts In A Given Month";
            // 
            // labelMostRecentRented
            // 
            this.labelMostRecentRented.AutoSize = true;
            this.labelMostRecentRented.Font = new System.Drawing.Font("Arial", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMostRecentRented.Location = new System.Drawing.Point(35, 160);
            this.labelMostRecentRented.Name = "labelMostRecentRented";
            this.labelMostRecentRented.Size = new System.Drawing.Size(327, 28);
            this.labelMostRecentRented.TabIndex = 5;
            this.labelMostRecentRented.Text = "2. Most Recent Rented Cars";
            // 
            // labelVIP
            // 
            this.labelVIP.AutoSize = true;
            this.labelVIP.Font = new System.Drawing.Font("Arial", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVIP.Location = new System.Drawing.Point(35, 80);
            this.labelVIP.Name = "labelVIP";
            this.labelVIP.Size = new System.Drawing.Size(253, 28);
            this.labelVIP.TabIndex = 4;
            this.labelVIP.Text = "1. Gold/Silver Clients";
            // 
            // ReportScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelLessRented);
            this.Controls.Add(this.labelMostRented);
            this.Controls.Add(this.labelMostRecentRented);
            this.Controls.Add(this.labelVIP);
            this.Name = "ReportScreen";
            this.Text = "ReportScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLessRented;
        private System.Windows.Forms.Label labelMostRented;
        private System.Windows.Forms.Label labelMostRecentRented;
        private System.Windows.Forms.Label labelVIP;
    }
}