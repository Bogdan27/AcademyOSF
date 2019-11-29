namespace RentC
{
    partial class WelcomeScreen
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
            this.labelInfo = new System.Windows.Forms.Label();
            this.textBoxWelcome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Arial", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo.Location = new System.Drawing.Point(221, 634);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(534, 32);
            this.labelInfo.TabIndex = 1;
            this.labelInfo.Text = "Press ENTER to continue or ESC to quit.";
            // 
            // textBoxWelcome
            // 
            this.textBoxWelcome.BackColor = System.Drawing.Color.LightSlateGray;
            this.textBoxWelcome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxWelcome.Font = new System.Drawing.Font("Arial", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWelcome.Location = new System.Drawing.Point(137, 36);
            this.textBoxWelcome.Multiline = true;
            this.textBoxWelcome.Name = "textBoxWelcome";
            this.textBoxWelcome.ReadOnly = true;
            this.textBoxWelcome.Size = new System.Drawing.Size(775, 104);
            this.textBoxWelcome.TabIndex = 0;
            this.textBoxWelcome.TabStop = false;
            this.textBoxWelcome.Text = "Welcome to RentC, your brand new solution to manage\n and control your company\'s d" +
    "ata without missing anything.";
            // 
            // WelcomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1040, 815);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.textBoxWelcome);
            this.Name = "WelcomeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WelcomeScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.TextBox textBoxWelcome;
    }
}

