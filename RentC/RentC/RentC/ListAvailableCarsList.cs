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
    public partial class ListAvailableCarsList : Form
    {
        string lastSelectedItem = "";


        ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
        public ListAvailableCarsList()
        {
            InitializeComponent();
        }

        private void ListAvailableCarsList_Load(object sender, EventArgs e)
        {

            ServiceReference1.GetListData getListData = new ServiceReference1.GetListData();
            getListData = client.getData();
            DataTable dataTable = new DataTable();
            dataTable = getListData.userTable;
            dataGridViewAvailableCars.DataSource = dataTable;
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
                dataGridViewAvailableCars.Sort(dataGridViewAvailableCars.Columns[comboBoxSortBy.Text], ListSortDirection.Descending);
                lastSelectedItem = "";

            }
            else
            {
                dataGridViewAvailableCars.Sort(dataGridViewAvailableCars.Columns[comboBoxSortBy.Text], ListSortDirection.Ascending);
                lastSelectedItem = comboBoxSortBy.Text;
            }
        }
    }
}
