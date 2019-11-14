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
    public partial class MenuScreen : Form
    {
        public MenuScreen()
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

                case Keys.D5:
                case Keys.NumPad5:
                    RegisterNewCustomerScreen registerNewCustomerScreen = new RegisterNewCustomerScreen();
                    registerNewCustomerScreen.Show(this);
                    this.Hide();
                    break;

                case Keys.D6:
                case Keys.NumPad6:
                    UpdateCustomerScreen updateCustomerScreen = new UpdateCustomerScreen();
                    updateCustomerScreen.Show(this);
                    this.Hide();
                    break;

                case Keys.D7:
                case Keys.NumPad7:
                    ListCustomersScreen listCustomersScreen = new ListCustomersScreen();
                    listCustomersScreen.Show(this);
                    this.Hide();
                    break;

                case Keys.D8:
                case Keys.NumPad8:
                    this.Close();
                    Application.Exit();
                    break;
                 
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}

/*         if (keyData == Keys.D8 || keyData==Keys.NumPad8)
         {
             this.Close();
             Application.Exit();

         }
         if (keyData == Keys.Enter)
         {
             this.Close();
             MenuScreen ms = new MenuScreen();
             ms.Show(this);
         }*/
