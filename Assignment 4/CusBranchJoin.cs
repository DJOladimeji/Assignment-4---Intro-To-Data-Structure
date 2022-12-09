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
    public partial class CusBranchJoin : Form
    {
        public CusBranchJoin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CusBranchJoin_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("First Name");
            dt.Columns.Add("Last Name");
            dt.Columns.Add("BranchID");
            dt.Columns.Add("Street Address");
            dt.Columns.Add("City");
            dt.Columns.Add("Postal Code");

            for (int i = 0; i < 6; i++)
            {
                dt.Rows.Add(Which_Customer_Of_Branch.cusBranJoin_FirstName[i], Which_Customer_Of_Branch.cusBranJoin_LastName[i], Which_Customer_Of_Branch.cusBranJoin_BranchID[i], Which_Customer_Of_Branch.cusBranJoin_StreetAddress[i],
                    Which_Customer_Of_Branch.cusBranJoin_City[i], Which_Customer_Of_Branch.cusBranJoin_PostalCode[i]);
            }

            dataGridView1.DataSource = dt;
        }
    }
}
