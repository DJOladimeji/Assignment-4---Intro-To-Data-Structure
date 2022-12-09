using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Assignment_4
{
    public partial class Add_to_Branch_table : Form
    {
        public Add_to_Branch_table()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            try
            {
                

                string connstring = "server=localhost; uid=root;pwd=Tamilore2003!;database=arnoldagritools";
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();
                string sql = "insert into branchTable(noOfOrders, streetAddress, city, prov, postalCode, noOfEmployee) Values('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "', '" + textBox6.Text + "')";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                con.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

            watch.Stop();

            
            MessageBox.Show("Added To Table");

            this.Close();
            MessageBox.Show($"Execution time: {watch.ElapsedMilliseconds} ms");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add_to_Branch_table_Load(object sender, EventArgs e)
        {

        }
    }
}
