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
    public partial class customerTable : Form
    {
        public customerTable()
        {
            InitializeComponent();
        }

        private void customerTable_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("CustomerID");
            dt.Columns.Add("First Name");
            dt.Columns.Add("Last Name");
            dt.Columns.Add("Street Address");
            dt.Columns.Add("City");
            dt.Columns.Add("Provice");
            dt.Columns.Add("Postal Code");
            dt.Columns.Add("Phone Number");
            dt.Columns.Add("Birth day");
            dt.Columns.Add("Birth Month");
            dt.Columns.Add("Birth Year");
            dt.Columns.Add("Primary Language");
            dt.Columns.Add("AccountID");
            dt.Columns.Add("OrderID");
            dt.Columns.Add("BranchID");

            for (int i = 0; i < 6; i++)
            {
                dt.Rows.Add(ViewTables.customerTableCustomerID[i], ViewTables.customerTableFirstName[i], ViewTables.customerTableLastName[i], ViewTables.customerTableStreetAddress[i], ViewTables.customerTableCity[i],
                    ViewTables.customerTableProv[i], ViewTables.customerTablePostalCode[i], ViewTables.customerTablePhoneNum[i], ViewTables.customerTableBirthDay[i], ViewTables.customerTableBirthMonth[i], ViewTables.customerTableBirthYear[i], ViewTables.customerTablePrimaryLanguage[i], ViewTables.customerTableAccountID[i],
                    ViewTables.customerTableOrderID[i], ViewTables.customerTableBranchID[i]);
            }

            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
