using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentC
{
    public partial class ListRentsScreen : Form
    {
        string lastSelectedItem = "";


        public ListRentsScreen()
        {
            InitializeComponent();
        }

        private void ListRentsScreen_Load(object sender, EventArgs e)
        {
           ShowData.showData("Reservations", dataGridViewRents);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                BackToMenu.goToMenu(this);
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void comboBoxSortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSortBy.SelectedItem.ToString().Equals(lastSelectedItem))
            {
                dataGridViewRents.Sort(dataGridViewRents.Columns[comboBoxSortBy.Text], ListSortDirection.Descending);
                lastSelectedItem = "";

            }
            else
            {
                dataGridViewRents.Sort(dataGridViewRents.Columns[comboBoxSortBy.Text], ListSortDirection.Ascending);
                lastSelectedItem = comboBoxSortBy.Text;
            }
        }
    }
}
