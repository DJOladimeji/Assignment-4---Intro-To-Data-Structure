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
    public partial class Add_to_Table : Form
    {
        public Add_to_Table()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Add_to_Customer_Table a= new Add_to_Customer_Table();

            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
             Add_to_Branch_table a = new Add_to_Branch_table();
            a.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Add_to_Order_Table a = new Add_to_Order_Table();
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
