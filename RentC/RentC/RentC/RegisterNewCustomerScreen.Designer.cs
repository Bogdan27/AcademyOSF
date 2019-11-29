namespace RentC
{
    partial class RegisterNewCustomerScreen
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
            this.buttonRegister = new System.Windows.Forms.Button();
            this.textBoxClientName = new System.Windows.Forms.TextBox();
            this.labelLocation = new System.Windows.Forms.Label();
            this.labelBirthDate = new System.Windows.Forms.Label();
            this.labelClientName = new System.Windows.Forms.Label();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.dateTimePickerBirthDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(199, 366);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(159, 31);
            this.buttonRegister.TabIndex = 23;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // textBoxClientName
            // 
            this.textBoxClientName.Location = new System.Drawing.Point(219, 57);
            this.textBoxClientName.Name = "textBoxClientName";
            this.textBoxClientName.Size = new System.Drawing.Size(200, 22);
            this.textBoxClientName.TabIndex = 19;
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Font = new System.Drawing.Font("Arial", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocation.Location = new System.Drawing.Point(49, 177);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(111, 28);
            this.labelLocation.TabIndex = 16;
            this.labelLocation.Text = "Location";
            // 
            // labelBirthDate
            // 
            this.labelBirthDate.AutoSize = true;
            this.labelBirthDate.Font = new System.Drawing.Font("Arial", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBirthDate.Location = new System.Drawing.Point(48, 117);
            this.labelBirthDate.Name = "labelBirthDate";
            this.labelBirthDate.Size = new System.Drawing.Size(125, 28);
            this.labelBirthDate.TabIndex = 15;
            this.labelBirthDate.Text = "Birth Date";
            // 
            // labelClientName
            // 
            this.labelClientName.AutoSize = true;
            this.labelClientName.Font = new System.Drawing.Font("Arial", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientName.Location = new System.Drawing.Point(49, 57);
            this.labelClientName.Name = "labelClientName";
            this.labelClientName.Size = new System.Drawing.Size(150, 28);
            this.labelClientName.TabIndex = 14;
            this.labelClientName.Text = "Client Name";
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.Location = new System.Drawing.Point(219, 182);
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.Size = new System.Drawing.Size(200, 22);
            this.textBoxLocation.TabIndex = 24;
            // 
            // dateTimePickerBirthDate
            // 
            this.dateTimePickerBirthDate.Location = new System.Drawing.Point(219, 120);
            this.dateTimePickerBirthDate.Name = "dateTimePickerBirthDate";
            this.dateTimePickerBirthDate.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerBirthDate.TabIndex = 25;
            // 
            // RegisterNewCustomerScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePickerBirthDate);
            this.Controls.Add(this.textBoxLocation);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.textBoxClientName);
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.labelBirthDate);
            this.Controls.Add(this.labelClientName);
            this.Name = "RegisterNewCustomerScreen";
            this.Text = "RegisterNewCustomerScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.TextBox textBoxClientName;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Label labelBirthDate;
        private System.Windows.Forms.Label labelClientName;
        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthDate;
    }
}