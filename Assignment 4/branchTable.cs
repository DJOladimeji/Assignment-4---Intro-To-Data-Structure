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
    public partial class branchTable : Form
    {
        public branchTable()
        {
            InitializeComponent();
        }

        private void branchTable_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("BranchID");
            dt.Columns.Add("No Of orders");
            dt.Columns.Add("Street Address");
            dt.Columns.Add("City");
            dt.Columns.Add("Province");
            dt.Columns.Add("Postal Code");
            dt.Columns.Add("No Of Employee");

            for (int i = 0; i < 6; i++)
            {
                dt.Rows.Add(ViewTables.branchTableBranchID[i], ViewTables.branchTableNoOfOrders[i], ViewTables.branchTableStreetAddress[i], ViewTables.branchTableCity[i], ViewTables.branchTableProv[i], ViewTables.branchTablePostalCode[i], ViewTables.branchTableNoOfEmployee[i]);
            }

            dataGridView1.DataSource = dt;
        }
    }
}
