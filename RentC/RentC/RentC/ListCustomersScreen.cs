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
        string lastSelectedItem = "";

        public ListCustomersScreen()
        {
            InitializeComponent();
        }

        private void ListCustomersScreen_Load(object sender, EventArgs e)
        {
            ShowData.showData("Customers", dataGridViewCustomers);

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                BackToMenu.goToMenu(this);
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBoxSortBy.SelectedItem.ToString().Equals(lastSelectedItem))
            {
                dataGridViewCustomers.Sort(dataGridViewCustomers.Columns[comboBoxSortBy.Text], ListSortDirection.Descending);
                lastSelectedItem = "";

            }
            else
            {
                dataGridViewCustomers.Sort(dataGridViewCustomers.Columns[comboBoxSortBy.Text], ListSortDirection.Ascending);
                lastSelectedItem = comboBoxSortBy.Text;
            }

        }
    }
}
