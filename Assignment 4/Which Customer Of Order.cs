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

namespace Assignment_4
{
    public partial class Which_Customer_Of_Order : Form
    {
        public Which_Customer_Of_Order()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static string[] cusNumOfOrder = new string[10];

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                cusNumOfOrder[i] = "";
            }

            var watch = System.Diagnostics.Stopwatch.StartNew();

            try
            {
                string connstring = "server=localhost; uid=root;pwd=Tamilore2003!;database=arnoldagritools";
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();
                string sql = "SELECT o.noOfItem FROM customerTable c inner join orderTable o ON c.customerID = o.customerID WHERE c.customerID = " + textBox1.Text + ";";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                int i = 0;

                while (reader.Read())
                {
                    cusNumOfOrder[i] = reader["noOfItem"].ToString();

                    i++;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

            CusNoOFItem c = new CusNoOFItem();
            c.Show();
            this.Close();

            MessageBox.Show($"Execution time: {watch.ElapsedMilliseconds} ms");
        }
    }
}
