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
    public partial class dependantTable : Form
    {
        public dependantTable()
        {
            InitializeComponent();
        }

        private void dependantTable_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("DependantID");
            dt.Columns.Add("First Name");
            dt.Columns.Add("Last Name");
            dt.Columns.Add("Age");
            dt.Columns.Add("Employee ID");

            for(int i = 0; i < 6; i++)
            {
                dt.Rows.Add(ViewTables.dependantTableDependantID[i], ViewTables.dependantTableFirstName[i], ViewTables.dependantTableLastName[i], ViewTables.dependantTableAge[i], ViewTables.dependantTableEmployeeID[i]);
            }

            dataGridView1.DataSource = dt;
        }
    }
}
