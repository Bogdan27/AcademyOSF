namespace RentC
{
    partial class MenuScreen
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
            this.labelRegisterCar = new System.Windows.Forms.Label();
            this.labelUpdateCar = new System.Windows.Forms.Label();
            this.labelListRents = new System.Windows.Forms.Label();
            this.labelListAvailable = new System.Windows.Forms.Label();
            this.labelRegisterCustomer = new System.Windows.Forms.Label();
            this.labelUpdateCustomer = new System.Windows.Forms.Label();
            this.labelListCustomers = new System.Windows.Forms.Label();
            this.labelQuit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelRegisterCar
            // 
            this.labelRegisterCar.AutoSize = true;
            this.labelRegisterCar.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegisterCar.Location = new System.Drawing.Point(72, 100);
            this.labelRegisterCar.Name = "labelRegisterCar";
            this.labelRegisterCar.Size = new System.Drawing.Size(378, 34);
            this.labelRegisterCar.TabIndex = 0;
            this.labelRegisterCar.Text = "1. Register new Cart Rent";
            // 
            // labelUpdateCar
            // 
            this.labelUpdateCar.AutoSize = true;
            this.labelUpdateCar.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUpdateCar.Location = new System.Drawing.Point(72, 180);
            this.labelUpdateCar.Name = "labelUpdateCar";
            this.labelUpdateCar.Size = new System.Drawing.Size(283, 34);
            this.labelUpdateCar.TabIndex = 1;
            this.labelUpdateCar.Text = "2. Update Car Rent";
            // 
            // labelListRents
            // 
            this.labelListRents.AutoSize = true;
            this.labelListRents.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListRents.Location = new System.Drawing.Point(72, 260);
            this.labelListRents.Name = "labelListRents";
            this.labelListRents.Size = new System.Drawing.Size(193, 34);
            this.labelListRents.TabIndex = 2;
            this.labelListRents.Text = "3. List Rents";
            // 
            // labelListAvailable
            // 
            this.labelListAvailable.AutoSize = true;
            this.labelListAvailable.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListAvailable.Location = new System.Drawing.Point(72, 340);
            this.labelListAvailable.Name = "labelListAvailable";
            this.labelListAvailable.Size = new System.Drawing.Size(314, 34);
            this.labelListAvailable.TabIndex = 3;
            this.labelListAvailable.Text = "4. List Available Cars";
            // 
            // labelRegisterCustomer
            // 
            this.labelRegisterCustomer.AutoSize = true;
            this.labelRegisterCustomer.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegisterCustomer.Location = new System.Drawing.Point(72, 420);
            this.labelRegisterCustomer.Name = "labelRegisterCustomer";
            this.labelRegisterCustomer.Size = new System.Drawing.Size(382, 34);
            this.labelRegisterCustomer.TabIndex = 4;
            this.labelRegisterCustomer.Text = "5. Register new Customer";
            // 
            // labelUpdateCustomer
            // 
            this.labelUpdateCustomer.AutoSize = true;
            this.labelUpdateCustomer.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUpdateCustomer.Location = new System.Drawing.Point(72, 500);
            this.labelUpdateCustomer.Name = "labelUpdateCustomer";
            this.labelUpdateCustomer.Size = new System.Drawing.Size(297, 34);
            this.labelUpdateCustomer.TabIndex = 5;
            this.labelUpdateCustomer.Text = "6. Update Customer";
            // 
            // labelListCustomers
            // 
            this.labelListCustomers.AutoSize = true;
            this.labelListCustomers.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListCustomers.Location = new System.Drawing.Point(72, 580);
            this.labelListCustomers.Name = "labelListCustomers";
            this.labelListCustomers.Size = new System.Drawing.Size(265, 34);
            this.labelListCustomers.TabIndex = 6;
            this.labelListCustomers.Text = "7. List Customers";
            // 
            // labelQuit
            // 
            this.labelQuit.AutoSize = true;
            this.labelQuit.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuit.Location = new System.Drawing.Point(72, 660);
            this.labelQuit.Name = "labelQuit";
            this.labelQuit.Size = new System.Drawing.Size(107, 34);
            this.labelQuit.TabIndex = 7;
            this.labelQuit.Text = "8. Quit";
            // 
            // MenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1040, 815);
            this.Controls.Add(this.labelQuit);
            this.Controls.Add(this.labelListCustomers);
            this.Controls.Add(this.labelUpdateCustomer);
            this.Controls.Add(this.labelRegisterCustomer);
            this.Controls.Add(this.labelListAvailable);
            this.Controls.Add(this.labelListRents);
            this.Controls.Add(this.labelUpdateCar);
            this.Controls.Add(this.labelRegisterCar);
            this.Name = "MenuScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Label labelRegisterCar;
        private System.Windows.Forms.Label labelUpdateCar;
        private System.Windows.Forms.Label labelListRents;
        private System.Windows.Forms.Label labelListAvailable;
        private System.Windows.Forms.Label labelRegisterCustomer;
        private System.Windows.Forms.Label labelUpdateCustomer;
        private System.Windows.Forms.Label labelListCustomers;
        private System.Windows.Forms.Label labelQuit;
    }
}