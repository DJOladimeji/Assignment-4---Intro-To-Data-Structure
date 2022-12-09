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
    public partial class Which_Customer : Form
    {
        public Which_Customer()
        {
            InitializeComponent();
        }

        public static string[] cusOrdJoin_FirstName = new string[10];
        public static string[] cusOrdJoin_LastName = new string[10];
        public static string[] cusOrdJoin_OrderDay = new string[10];
        public static string[] cusOrdJoin_OrderMonth = new string[10];
        public static string[] cusOrdJoin_OrderYear = new string[10];
        public static string[] cusOrdJoin_CreditAuthorization = new string[10];
        public static string[] cusOrdJoin_ItemID = new string[10];
        public static string[] cusOrdJoin_NoOfItem = new string[10];

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 10; i++)
            {
                cusOrdJoin_FirstName[i] = "";
                cusOrdJoin_LastName[i] = "";
                cusOrdJoin_OrderDay[i] = "";
                cusOrdJoin_OrderMonth[i] = "";
                cusOrdJoin_OrderYear[i] = "";
                cusOrdJoin_CreditAuthorization[i] = "";
                cusOrdJoin_ItemID[i] = "";
                cusOrdJoin_NoOfItem[i] = "";
            }

            var watch = System.Diagnostics.Stopwatch.StartNew();

            try
            {
                string connstring = "server=localhost; uid=root;pwd=Tamilore2003!;database=arnoldagritools";
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();
                string sql = "SELECT c.firstName, c.Lastname, o.orderDay, o.orderMonth, o.orderYear, o.creditAuthorization, o.itemId, o.noOfItem FROM customerTable c INNER JOIN orderTable o ON c.customerID = o.customerID WHERE c.customerID = " + textBox1.Text + ";";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                int i = 0;

                while (reader.Read())
                {
                    cusOrdJoin_FirstName[i] = reader["firstName"].ToString();
                    cusOrdJoin_LastName[i] = reader["lastName"].ToString();
                    cusOrdJoin_OrderDay[i] = reader["orderDay"].ToString();
                    cusOrdJoin_OrderMonth[i] = reader["orderMonth"].ToString();
                    cusOrdJoin_OrderYear[i] = reader["orderYear"].ToString();
                    cusOrdJoin_CreditAuthorization[i] = reader["creditAuthorization"].ToString();
                    cusOrdJoin_ItemID[i] = reader["ItemID"].ToString();
                    cusOrdJoin_NoOfItem[i] = reader["NoOfItem"].ToString();

                    i++;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

            watch.Stop();

            

            CusOrderJoin c = new CusOrderJoin();
            c.Show();

            MessageBox.Show($"Execution time: {watch.ElapsedMilliseconds} ms");

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Which_Customer_Load(object sender, EventArgs e)
        {

        }
    }
}
