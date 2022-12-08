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
    public partial class departmentTable : Form
    {
        public departmentTable()
        {
            InitializeComponent();
        }

        private void departmentTable_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("DepartmentID");
            dt.Columns.Add("Name");
            dt.Columns.Add("BranchID");

            for (int i = 0; i < 6; i++)
            {
                dt.Rows.Add(ViewTables.departmentTableDepartmentID[i], ViewTables.departmentTableName[i], ViewTables.departmentTableBranchID[i]);
            }

            dataGridView1.DataSource = dt;
        }
    }
}
