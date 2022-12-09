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
    public partial class CusOrderJoin : Form
    {
        public CusOrderJoin()
        {
            InitializeComponent();
        }

        

        private void CusOrderJoin_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("First Name");
            dt.Columns.Add("Last Name");
            dt.Columns.Add("Order Day");
            dt.Columns.Add("Order Month");
            dt.Columns.Add("Order Year");
            dt.Columns.Add("Credit Auhtorization");
            dt.Columns.Add("ItemID");
            dt.Columns.Add("No Of Item");

            for (int i = 0; i < 6; i++)
            {
                dt.Rows.Add(Which_Customer.cusOrdJoin_FirstName[i], Which_Customer.cusOrdJoin_LastName[i], Which_Customer.cusOrdJoin_OrderDay[i], Which_Customer.cusOrdJoin_OrderMonth[i], Which_Customer.cusOrdJoin_OrderYear[i],
                    Which_Customer.cusOrdJoin_CreditAuthorization[i], Which_Customer.cusOrdJoin_ItemID[i], Which_Customer.cusOrdJoin_NoOfItem[i]);
            }

            dataGridView1.DataSource = dt;
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
