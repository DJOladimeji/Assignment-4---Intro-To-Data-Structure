using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_4
{
    public partial class orderTable : Form
    {
        public orderTable()
        {
            InitializeComponent();
        }

        private void orderTable_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("OrderID");
            dt.Columns.Add("Order Day");
            dt.Columns.Add("Order Month");
            dt.Columns.Add("Order Year");
            dt.Columns.Add("Credit Authorization");
            dt.Columns.Add("ItemID");
            dt.Columns.Add("No Of Item");
            dt.Columns.Add("Branch ID");
            dt.Columns.Add("Customer ID");

            for (int i = 0; i < 6; i++)
            {
                dt.Rows.Add(ViewTables.orderTableOrderID[i], ViewTables.orderTableOrderDay[i], ViewTables.orderTableOrderMonth[i], ViewTables.orderTableOrderYear[i], ViewTables.orderTableCreditAuthorization[i],
                    ViewTables.orderTableItemID[i], ViewTables.orderTableNoOfItem[i], ViewTables.orderTableBranchID[i], ViewTables.orderTableCustomerID[i]);
            }

            dataGridView1.DataSource = dt;
        }
    }
}
