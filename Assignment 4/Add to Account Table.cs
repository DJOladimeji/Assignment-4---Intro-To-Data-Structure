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
using MySql.Data.MySqlClient;

namespace Assignment_4
{
    public partial class Add_to_Account_Table : Form
    {
        public static string AccountPayDay;
        public static string AccountPayMonth;
        public static string AccountPayYear;
        public static string AccountTypeOfPayment;
        public static string AccountCustomerID;

        public Add_to_Account_Table()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AccountPayDay = textBox1.Text.ToString();
            AccountPayMonth = textBox2.Text.ToString();
            AccountPayYear = textBox3.Text.ToString();
            AccountTypeOfPayment = textBox4.Text.ToString();
            AccountCustomerID = textBox5.Text.ToString();

            try
            {
                string connstring = "server=localhost; uid=root;pwd=Tamilore2003!;database=arnoldagritools";
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();
                string sql = "insert into accountTable (paymentDay, paymentMonth, paymentYear, typeofPayment, customerID) Values('" + AccountPayDay + "', '" + AccountPayMonth + "', '" + AccountPayYear + "', '" + AccountTypeOfPayment + "', '" + AccountCustomerID + "')";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
                
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

            MessageBox.Show("Added to table");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
