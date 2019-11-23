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
    public partial class ListCustomersScreen : Form
    {
        public ListCustomersScreen()
        {
            InitializeComponent();
        }

        private void ListCustomersScreen_Load(object sender, EventArgs e)
        {
            ShowData.showData("Customers", dataGridViewCustomers);
        }
    }
}
