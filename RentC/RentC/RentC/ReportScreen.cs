using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentC
{
    public partial class ReportScreen : Form
    {
        public ReportScreen()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Back)
            {
                BackToMenu.goToMenu(this);
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
