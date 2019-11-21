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
    public partial class WelcomeScreen : Form
    {
        public WelcomeScreen()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                Application.Exit();

            }
            if (keyData == Keys.Enter)
            {
                //MenuScreen ms = new MenuScreen();
                //ms.Show(this);
                //Hide();
                goToMenu(this);
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        public static void goToMenu(Control control)
        {
            MenuScreen ms = new MenuScreen();
            ms.Show(control);
            control.Hide();
        }

    }


}
