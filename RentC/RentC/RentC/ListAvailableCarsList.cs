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
    }
}
