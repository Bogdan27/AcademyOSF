namespace RentC
{
    partial class UpdateCustomerScreen
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
            this.dateTimePickerBirthDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textBoxClientName = new System.Windows.Forms.TextBox();
            this.labelLocation = new System.Windows.Forms.Label();
            this.labelBirthDate = new System.Windows.Forms.Label();
            this.labelClientName = new System.Windows.Forms.Label();
            this.textBoxUpdateCustomer = new System.Windows.Forms.TextBox();
            this.labelClientUpdate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePickerBirthDate
            // 
            this.dateTimePickerBirthDate.Location = new System.Drawing.Point(252, 191);
            this.dateTimePickerBirthDate.Name = "dateTimePickerBirthDate";
            this.dateTimePickerBirthDate.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerBirthDate.TabIndex = 34;
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.Location = new System.Drawing.Point(252, 253);
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.Size = new System.Drawing.Size(200, 22);
            this.textBoxLocation.TabIndex = 33;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(211, 338);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(159, 31);
            this.buttonUpdate.TabIndex = 32;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // textBoxClientName
            // 
            this.textBoxClientName.Location = new System.Drawing.Point(252, 128);
            this.textBoxClientName.Name = "textBoxClientName";
            this.textBoxClientName.Size = new System.Drawing.Size(200, 22);
            this.textBoxClientName.TabIndex = 31;
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Font = new System.Drawing.Font("Arial", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocation.Location = new System.Drawing.Point(82, 248);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(111, 28);
            this.labelLocation.TabIndex = 29;
            this.labelLocation.Text = "Location";
            // 
            // labelBirthDate
            // 
            this.labelBirthDate.AutoSize = true;
            this.labelBirthDate.Font = new System.Drawing.Font("Arial", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBirthDate.Location = new System.Drawing.Point(81, 188);
            this.labelBirthDate.Name = "labelBirthDate";
            this.labelBirthDate.Size = new System.Drawing.Size(125, 28);
            this.labelBirthDate.TabIndex = 28;
            this.labelBirthDate.Text = "Birth Date";
            // 
            // labelClientName
            // 
            this.labelClientName.AutoSize = true;
            this.labelClientName.Font = new System.Drawing.Font("Arial", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientName.Location = new System.Drawing.Point(82, 128);
            this.labelClientName.Name = "labelClientName";
            this.labelClientName.Size = new System.Drawing.Size(150, 28);
            this.labelClientName.TabIndex = 27;
            this.labelClientName.Text = "Client Name";
            // 
            // textBoxUpdateCustomer
            // 
            this.textBoxUpdateCustomer.Location = new System.Drawing.Point(314, 57);
            this.textBoxUpdateCustomer.Name = "textBoxUpdateCustomer";
            this.textBoxUpdateCustomer.Size = new System.Drawing.Size(138, 22);
            this.textBoxUpdateCustomer.TabIndex = 36;
            // 
            // labelClientUpdate
            // 
            this.labelClientUpdate.AutoSize = true;
            this.labelClientUpdate.Font = new System.Drawing.Font("Arial", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientUpdate.Location = new System.Drawing.Point(40, 52);
            this.labelClientUpdate.Name = "labelClientUpdate";
            this.labelClientUpdate.Size = new System.Drawing.Size(226, 28);
            this.labelClientUpdate.TabIndex = 35;
            this.labelClientUpdate.Text = "Client ID to Update";
            // 
            // UpdateCustomerScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxUpdateCustomer);
            this.Controls.Add(this.labelClientUpdate);
            this.Controls.Add(this.dateTimePickerBirthDate);
            this.Controls.Add(this.textBoxLocation);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.textBoxClientName);
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.labelBirthDate);
            this.Controls.Add(this.labelClientName);
            this.Name = "UpdateCustomerScreen";
            this.Text = "UpdateCustomerScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerBirthDate;
        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox textBoxClientName;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Label labelBirthDate;
        private System.Windows.Forms.Label labelClientName;
        private System.Windows.Forms.TextBox textBoxUpdateCustomer;
        private System.Windows.Forms.Label labelClientUpdate;
    }
}