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
    public partial class itemTable : Form
    {
        public itemTable()
        {
            InitializeComponent();
        }

        private void itemTable_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("ItemID");
            dt.Columns.Add("Decription");
            dt.Columns.Add("Colour");
            dt.Columns.Add("Size");
            dt.Columns.Add("Pattern");
            dt.Columns.Add("Type");

            for (int i = 0; i < 6; i++)
            {
                dt.Rows.Add(ViewTables.itemTableItemID[i], ViewTables.itemTableDescription[i], ViewTables.itemTableColour[i], ViewTables.itemTableSize[i], ViewTables.itemTablePattern[i], ViewTables.itemTableType[i]);
            }

            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
