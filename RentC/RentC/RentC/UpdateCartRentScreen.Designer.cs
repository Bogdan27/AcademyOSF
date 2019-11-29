namespace RentC
{
    partial class UpdateCartRentScreen
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
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxClientID = new System.Windows.Forms.TextBox();
            this.textBoxCartPlate = new System.Windows.Forms.TextBox();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.labelClientId = new System.Windows.Forms.Label();
            this.labelCartPlate = new System.Windows.Forms.Label();
            this.textBoxReservationToUpdate = new System.Windows.Forms.TextBox();
            this.labelUpdate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(181, 398);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(159, 31);
            this.buttonUpdate.TabIndex = 23;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(216, 251);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerEndDate.TabIndex = 22;
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(216, 191);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerStartDate.TabIndex = 21;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(216, 308);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(200, 22);
            this.textBoxCity.TabIndex = 20;
            // 
            // textBoxClientID
            // 
            this.textBoxClientID.Location = new System.Drawing.Point(216, 128);
            this.textBoxClientID.Name = "textBoxClientID";
            this.textBoxClientID.Size = new System.Drawing.Size(200, 22);
            this.textBoxClientID.TabIndex = 19;
            // 
            // textBoxCartPlate
            // 
            this.textBoxCartPlate.Location = new System.Drawing.Point(216, 68);
            this.textBoxCartPlate.Name = "textBoxCartPlate";
            this.textBoxCartPlate.Size = new System.Drawing.Size(200, 22);
            this.textBoxCartPlate.TabIndex = 18;
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Font = new System.Drawing.Font("Arial", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCity.Location = new System.Drawing.Point(46, 308);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(57, 28);
            this.labelCity.TabIndex = 17;
            this.labelCity.Text = "City";
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Font = new System.Drawing.Font("Arial", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEndDate.Location = new System.Drawing.Point(46, 248);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(116, 28);
            this.labelEndDate.TabIndex = 16;
            this.labelEndDate.Text = "End Date";
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Font = new System.Drawing.Font("Arial", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStartDate.Location = new System.Drawing.Point(45, 188);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(124, 28);
            this.labelStartDate.TabIndex = 15;
            this.labelStartDate.Text = "Start Date";
            // 
            // labelClientId
            // 
            this.labelClientId.AutoSize = true;
            this.labelClientId.Font = new System.Drawing.Font("Arial", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientId.Location = new System.Drawing.Point(46, 128);
            this.labelClientId.Name = "labelClientId";
            this.labelClientId.Size = new System.Drawing.Size(109, 28);
            this.labelClientId.TabIndex = 14;
            this.labelClientId.Text = "Client ID";
            // 
            // labelCartPlate
            // 
            this.labelCartPlate.AutoSize = true;
            this.labelCartPlate.Font = new System.Drawing.Font("Arial", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCartPlate.Location = new System.Drawing.Point(46, 68);
            this.labelCartPlate.Name = "labelCartPlate";
            this.labelCartPlate.Size = new System.Drawing.Size(123, 28);
            this.labelCartPlate.TabIndex = 13;
            this.labelCartPlate.Text = "Cart Plate";
            // 
            // textBoxReservationToUpdate
            // 
            this.textBoxReservationToUpdate.Location = new System.Drawing.Point(316, 18);
            this.textBoxReservationToUpdate.Name = "textBoxReservationToUpdate";
            this.textBoxReservationToUpdate.Size = new System.Drawing.Size(100, 22);
            this.textBoxReservationToUpdate.TabIndex = 25;
            // 
            // labelUpdate
            // 
            this.labelUpdate.AutoSize = true;
            this.labelUpdate.Font = new System.Drawing.Font("Arial", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUpdate.Location = new System.Drawing.Point(12, 13);
            this.labelUpdate.Name = "labelUpdate";
            this.labelUpdate.Size = new System.Drawing.Size(298, 28);
            this.labelUpdate.TabIndex = 24;
            this.labelUpdate.Text = "Reservation Id To Update";
            // 
            // UpdateCartRentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.Controls.Add(this.textBoxReservationToUpdate);
            this.Controls.Add(this.labelUpdate);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.dateTimePickerEndDate);
            this.Controls.Add(this.dateTimePickerStartDate);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.textBoxClientID);
            this.Controls.Add(this.textBoxCartPlate);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.labelEndDate);
            this.Controls.Add(this.labelStartDate);
            this.Controls.Add(this.labelClientId);
            this.Controls.Add(this.labelCartPlate);
            this.Name = "UpdateCartRentScreen";
            this.Text = "UpdateCartRentScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxClientID;
        private System.Windows.Forms.TextBox textBoxCartPlate;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.Label labelClientId;
        private System.Windows.Forms.Label labelCartPlate;
        private System.Windows.Forms.TextBox textBoxReservationToUpdate;
        private System.Windows.Forms.Label labelUpdate;
    }
}