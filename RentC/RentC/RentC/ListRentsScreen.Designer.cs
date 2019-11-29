namespace RentC
{
    partial class ListRentsScreen
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
            this.dataGridViewRents = new System.Windows.Forms.DataGridView();
            this.comboBoxSortBy = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRents)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRents
            // 
            this.dataGridViewRents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRents.Location = new System.Drawing.Point(47, 46);
            this.dataGridViewRents.Name = "dataGridViewRents";
            this.dataGridViewRents.RowTemplate.Height = 24;
            this.dataGridViewRents.Size = new System.Drawing.Size(826, 640);
            this.dataGridViewRents.TabIndex = 0;
            // 
            // comboBoxSortBy
            // 
            this.comboBoxSortBy.FormattingEnabled = true;
            this.comboBoxSortBy.Items.AddRange(new object[] {
            "CustomerID",
            "Plate",
            "StartDate",
            "EndDate",
            "Location",
            "ReservationID"});
            this.comboBoxSortBy.Location = new System.Drawing.Point(907, 60);
            this.comboBoxSortBy.Name = "comboBoxSortBy";
            this.comboBoxSortBy.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSortBy.TabIndex = 3;
            this.comboBoxSortBy.SelectedIndexChanged += new System.EventHandler(this.comboBoxSortBy_SelectedIndexChanged);
            // 
            // ListRentsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1040, 815);
            this.Controls.Add(this.comboBoxSortBy);
            this.Controls.Add(this.dataGridViewRents);
            this.Name = "ListRentsScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListRentsScreen";
            this.Load += new System.EventHandler(this.ListRentsScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRents;
        private System.Windows.Forms.ComboBox comboBoxSortBy;
    }
}