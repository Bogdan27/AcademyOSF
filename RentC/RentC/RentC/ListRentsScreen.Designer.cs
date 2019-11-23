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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRents)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRents
            // 
            this.dataGridViewRents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRents.Location = new System.Drawing.Point(47, 46);
            this.dataGridViewRents.Name = "dataGridViewRents";
            this.dataGridViewRents.RowTemplate.Height = 24;
            this.dataGridViewRents.Size = new System.Drawing.Size(705, 358);
            this.dataGridViewRents.TabIndex = 0;
            // 
            // ListRentsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewRents);
            this.Name = "ListRentsScreen";
            this.Text = "ListRentsScreen";
            this.Load += new System.EventHandler(this.ListRentsScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRents;
    }
}