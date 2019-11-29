using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentC
{
     class BackToMenu
    {
        public static void goToMenu(Control control)
        {
            MenuScreen ms = new MenuScreen();
            ms.Show(control);
            control.Hide();
        }


    }
}
