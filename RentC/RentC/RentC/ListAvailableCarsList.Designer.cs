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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvailableCars)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAvailableCars
            // 
            this.dataGridViewAvailableCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAvailableCars.Location = new System.Drawing.Point(74, 46);
            this.dataGridViewAvailableCars.Name = "dataGridViewAvailableCars";
            this.dataGridViewAvailableCars.RowTemplate.Height = 24;
            this.dataGridViewAvailableCars.Size = new System.Drawing.Size(652, 358);
            this.dataGridViewAvailableCars.TabIndex = 2;
            // 
            // ListAvailableCarsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewAvailableCars);
            this.Name = "ListAvailableCarsList";
            this.Text = "ListAvailableCarsList";
            this.Load += new System.EventHandler(this.ListAvailableCarsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvailableCars)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAvailableCars;
    }
}