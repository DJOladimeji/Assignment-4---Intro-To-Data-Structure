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
    public partial class accountTable : Form
    {
        public accountTable()
        {
            InitializeComponent();
        }

        private void accountTable_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("AccountID");
            dt.Columns.Add("Payment Day");
            dt.Columns.Add("Payment month");
            dt.Columns.Add("Payment year");
            dt.Columns.Add("Type Of Payment");
            dt.Columns.Add("CustomerID");

            for (int i = 0; i < 6; i++)
            {
                dt.Rows.Add(ViewTables.accountTableAccountID[i], ViewTables.accountTablePayemntDay[i], ViewTables.accountTablePaymentMonth[i], ViewTables.accountTablePaymentYear[i], ViewTables.accountTableTypeOfPayment[i], ViewTables.accountTableCustomerID[i]);
            }

            dataGridView1.DataSource = dt;
        }
    }
}
