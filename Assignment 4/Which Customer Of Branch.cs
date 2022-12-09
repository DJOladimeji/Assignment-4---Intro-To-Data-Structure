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
    public partial class Which_Customer_Of_Branch : Form
    {
        public Which_Customer_Of_Branch()
        {
            InitializeComponent();
        }

        public static string[] cusBranJoin_FirstName = new string[10];
        public static string[] cusBranJoin_LastName = new string[10];
        public static string[] cusBranJoin_BranchID = new string[10];
        public static string[] cusBranJoin_StreetAddress = new string[10];
        public static string[] cusBranJoin_City = new string[10];
        public static string[] cusBranJoin_PostalCode = new string[10];

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                cusBranJoin_FirstName[i] = "";
                cusBranJoin_LastName[i] = "";
                cusBranJoin_BranchID[i] = "";
                cusBranJoin_StreetAddress[i] = "";
                cusBranJoin_City[i] = "";
                cusBranJoin_PostalCode[i] = "";
            }

            var watch = System.Diagnostics.Stopwatch.StartNew();
;

            try
            {
                string connstring = "server=localhost; uid=root;pwd=Tamilore2003!;database=arnoldagritools";
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();
                string sql = "SELECT c.firstName, c.Lastname, b.branchID, b.streetAddress, b.city, b.postalCode FROM customerTable c INNER JOIN branchTable b ON c.branchID = b.branchID WHERE c.customerID = " + textBox1.Text + ";";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                int i = 0;

                while (reader.Read())
                {
                    cusBranJoin_FirstName[i] = reader["firstName"].ToString();
                    cusBranJoin_LastName[i] = reader["lastName"].ToString();
                    cusBranJoin_BranchID[i] = reader["branchID"].ToString();
                    cusBranJoin_StreetAddress[i] = reader["streetAddress"].ToString();
                    cusBranJoin_City[i] = reader["city"].ToString();
                    cusBranJoin_PostalCode[i] = reader["postalCode"].ToString();

                    i++;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

            watch.Stop();

            

            CusBranchJoin c = new CusBranchJoin();
            c.Show();
            this.Close();

            MessageBox.Show($"Execution time: {watch.ElapsedMilliseconds} ms");
        }

        private void Which_Customer_Of_Branch_Load(object sender, EventArgs e)
        {

        }
    }
}
