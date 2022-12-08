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
    public partial class Add_to_Dependant_Table : Form
    {
        public Add_to_Dependant_Table()
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
                string sql = "insert into dependantTable (firstName, lastName, age, employeeID) Values('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "')";
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
    }
}
