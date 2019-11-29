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
            switch (keyData)
            {
                case Keys.D1:
                case Keys.NumPad1:

                    RegisterNewCartRentScreen registerNewCartRentScreen = new RegisterNewCartRentScreen();
                    registerNewCartRentScreen.Show(this);
                    this.Hide();
                    break;

                case Keys.D2:
                case Keys.NumPad2:
                    UpdateCartRentScreen updateCartRentScreen = new UpdateCartRentScreen();
                    updateCartRentScreen.Show(this);
                    this.Hide();
                    break;

                case Keys.D3:
                case Keys.NumPad3:
                    ListRentsScreen listRentsScreen = new ListRentsScreen();
                    listRentsScreen.Show(this);
                    this.Hide();
                    break;

                case Keys.D4:
                case Keys.NumPad4:
                    ListAvailableCarsList listAvailableCarsList = new ListAvailableCarsList();
                    listAvailableCarsList.Show(this);
                    this.Hide();
                    break;

                case Keys.Back:
                    BackToMenu.goToMenu(this);
                    break;

            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
