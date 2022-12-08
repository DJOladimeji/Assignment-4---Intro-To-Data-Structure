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
    public partial class Add_to_Customer_Table : Form
    {
        public Add_to_Customer_Table()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string connstring = "server=localhost; uid=root;pwd=Tamilore2003!;database=arnoldagritools";
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();
                string sql = "insert into customerTable(firstName, lastName, streetAddress, city, prov, postalCode, phoneNum, birthDay, birthMonth, birthYear, primaryLanguage, accountID, orderID, BranchID) Values('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "', '" + textBox6.Text + "', '"
                    + textBox7.Text + "', '" + textBox8.Text + "', '" + textBox9.Text + "', '" + textBox10.Text + "', '" + textBox11.Text + "', '" + textBox12.Text + "', '" + textBox13.Text + "', '" + textBox14.Text + "')";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                con.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

            MessageBox.Show("Added To Table");
        }
    }
}
