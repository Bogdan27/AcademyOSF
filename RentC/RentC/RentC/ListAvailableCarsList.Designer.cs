namespace RentC
{
    partial class ListAvailableCarsList
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
            this.dataGridViewAvailableCars = new System.Windows.Forms.DataGridView();
            this.comboBoxSortBy = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvailableCars)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAvailableCars
            // 
            this.dataGridViewAvailableCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAvailableCars.Location = new System.Drawing.Point(58, 36);
            this.dataGridViewAvailableCars.Name = "dataGridViewAvailableCars";
            this.dataGridViewAvailableCars.RowTemplate.Height = 24;
            this.dataGridViewAvailableCars.Size = new System.Drawing.Size(825, 623);
            this.dataGridViewAvailableCars.TabIndex = 2;
            // 
            // comboBoxSortBy
            // 
            this.comboBoxSortBy.FormattingEnabled = true;
            this.comboBoxSortBy.Items.AddRange(new object[] {
            "CarID",
            "Plate",
            "Manufacturer",
            "Model",
            "PricePerDay",
            "Location"});
            this.comboBoxSortBy.Location = new System.Drawing.Point(907, 60);
            this.comboBoxSortBy.Name = "comboBoxSortBy";
            this.comboBoxSortBy.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSortBy.TabIndex = 3;
            this.comboBoxSortBy.SelectedIndexChanged += new System.EventHandler(this.comboBoxSortBy_SelectedIndexChanged);
            // 
            // ListAvailableCarsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1040, 815);
            this.Controls.Add(this.comboBoxSortBy);
            this.Controls.Add(this.dataGridViewAvailableCars);
            this.Name = "ListAvailableCarsList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListAvailableCarsList";
            this.Load += new System.EventHandler(this.ListAvailableCarsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvailableCars)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAvailableCars;
        private System.Windows.Forms.ComboBox comboBoxSortBy;
    }
}