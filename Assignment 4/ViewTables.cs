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
    public partial class ViewTables : Form
    {
        //for account table 
        public static string[] accountTableAccountID = new string[10];
        public static string[] accountTablePayemntDay = new string[10];
        public static string[] accountTablePaymentMonth = new string[10];
        public static string[] accountTablePaymentYear = new string[10];
        public static string[] accountTableTypeOfPayment = new string[10];
        public static string[] accountTableCustomerID = new string[10];
        //--------------------------------------------------------------------------------

        //for dependant table
        public static string[] dependantTableDependantID = new string[10];
        public static string[] dependantTableFirstName = new string[10];
        public static string[] dependantTableLastName = new string[10];
        public static string[] dependantTableAge = new string[10];
        public static string[] dependantTableEmployeeID = new string[10];
        //--------------------------------------------------------------------------------

        //for branch table
        public static string[] branchTableBranchID = new string[10];
        public static string[] branchTableNoOfOrders = new string[10];
        public static string[] branchTableStreetAddress = new string[10];
        public static string[] branchTableCity =  new string[10];
        public static string[] branchTableProv = new string[10];
        public static string[] branchTablePostalCode = new string[10]; 
        public static string[] branchTableNoOfEmployee = new string[10];
        //--------------------------------------------------------------------------------

        //for customer table 
        public static string[] customerTableCustomerID = new string[10];
        public static string[] customerTableFirstName =  new string[10];
        public static string[] customerTableLastName =  new string[10];
        public static string[] customerTableStreetAddress = new string[10];
        public static string[] customerTableCity = new string[10];
        public static string[] customerTableProv = new string[10];
        public static string[] customerTablePostalCode = new string[10];
        public static string[] customerTablePhoneNum = new string[10];
        public static string[] customerTableBirthDay = new string[10];
        public static string[] customerTableBirthMonth = new string[10];
        public static string[] customerTableBirthYear = new string[10];
        public static string[] customerTablePrimaryLanguage = new string[10];
        public static string[] customerTableAccountID = new string[10];
        public static string[] customerTableOrderID = new string[10];
        public static string[] customerTableBranchID = new string[10];
        //--------------------------------------------------------------------------------

        //for department Table 
        public static string[] departmentTableDepartmentID = new string[10];
        public static string[] departmentTableName = new string[10];
        public static string[] departmentTableBranchID = new string[10];
        //--------------------------------------------------------------------------------

        //for employee table
        public static string[] employeeTableEmployeeID = new string[10];
        public static string[] employeeTableFirstName = new string[10];
        public static string[] employeeTableLastname = new string[10];
        public static string[] employeeTableStreetAddress = new string[10];
        public static string[] employeeTableCity = new string[10];
        public static string[] employeeTableProv = new string[10];
        public static string[] employeeTablePhoneNum = new string[10];
        public static string[] employeeTableBirthDay = new string[10];
        public static string[] employeeTableBirthMonth = new string[10];
        public static string[] employeeTableBirthYear = new string[10];
        public static string[] employeeTableTitle = new string[10];
        public static string[] employeeTableSalary = new string[10];
        public static string[] employeeTableNoOfSkills = new string[10];
        public static string[] employeeTableAge = new string[10];
        public static string[] employeeTableDepartmentID = new string[10];
        public static string[] employeeTableBranchID = new string[10];
        //--------------------------------------------------------------------------------

        //for item Table
        public static string[] itemTableItemID = new string[10];
        public static string[] itemTableDescription = new string[10];
        public static string[] itemTableColour = new string[10];
        public static string[] itemTableSize = new string[10];
        public static string[] itemTablePattern = new string[10];
        public static string[] itemTableType = new string[10];
        //--------------------------------------------------------------------------------

        //for order Table
        public static string[] orderTableOrderID = new string[10];
        public static string[] orderTableOrderDay = new string[10];
        public static string[] orderTableOrderMonth = new string[10];
        public static string[] orderTableOrderYear = new string[10];
        public static string[] orderTableCreditAuthorization = new string[10];
        public static string[] orderTableItemID = new string[10];
        public static string[] orderTableNoOfItem = new string[10];
        public static string[] orderTableBranchID = new string[10];
        public static string[] orderTableCustomerID = new string[10];
        //--------------------------------------------------------------------------------

        public ViewTables()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();;

            try
            {
                string connstring = "server=localhost; uid=root;pwd=Tamilore2003!;database=arnoldagritools";
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();
                string sql = "select * from accountTable";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                int i = 0;

                while (reader.Read())
                {
                    accountTableAccountID[i] = reader["accountID"].ToString();
                    accountTablePayemntDay[i] = reader["paymentDay"].ToString();
                    accountTablePaymentMonth[i] = reader["paymentMonth"].ToString();
                    accountTablePaymentYear[i] = reader["paymentYear"].ToString();
                    accountTableTypeOfPayment[i] = reader["typeOfPayment"].ToString();
                    accountTableCustomerID[i] = reader["customerID"].ToString();
                   
                    i++;
                }

                con.Close();
            }
            catch(MySqlException ex) 
            { 
                MessageBox.Show(ex.ToString()); 
            }

            watch.Stop();

            

            accountTable a = new accountTable();

            a.Show();

            MessageBox.Show($"Execution time: {watch.ElapsedMilliseconds} ms");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            try
            {
                string connstring = "server=localhost; uid=root;pwd=Tamilore2003!;database=arnoldagritools";
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();
                string sql = "select * from branchtable";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                int i = 0;

                while (reader.Read())
                {
                    branchTableBranchID[i] = reader["branchID"].ToString();
                    branchTableNoOfOrders[i] = reader["noOfOrders"].ToString();
                    branchTableStreetAddress[i] = reader["streetAddress"].ToString();
                    branchTableCity[i] = reader["city"].ToString();
                    branchTableProv[i] = reader["prov"].ToString();
                    branchTablePostalCode[i] = reader["postalCode"].ToString();
                    branchTableNoOfEmployee[i] = reader["noOfEmployee"].ToString();

                    i++;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

            watch.Stop();

            

            branchTable b = new branchTable();
            b.Show();

            MessageBox.Show($"Execution time: {watch.ElapsedMilliseconds} ms");
        }

      

        private void button3_Click(object sender, EventArgs e)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            try
            {
                string connstring = "server=localhost; uid=root;pwd=Tamilore2003!;database=arnoldagritools";
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();
                string sql = "select * from customertable";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                int i = 0;

                while (reader.Read())
                {
                    customerTableCustomerID[i] = reader["customerID"].ToString();
                    customerTableFirstName[i] = reader["firstName"].ToString();
                    customerTableLastName[i] = reader["lastName"].ToString();
                    customerTableStreetAddress[i] = reader["streetAddress"].ToString();
                    customerTableCity[i] = reader["city"].ToString();
                    customerTableProv[i] = reader["prov"].ToString();
                    customerTablePostalCode[i] = reader["postalCode"].ToString();
                    customerTablePhoneNum[i] = reader["phoneNum"].ToString();
                    customerTableBirthDay[i] = reader["birthDay"].ToString();
                    customerTableBirthMonth[i] = reader["birthMonth"].ToString();
                    customerTableBirthYear[i] = reader["birthYear"].ToString();
                    customerTablePrimaryLanguage[i] = reader["primaryLanguage"].ToString();
                    customerTableAccountID[i] = reader["accountID"].ToString();
                    customerTableOrderID[i] = reader["orderID"].ToString();
                    customerTableBranchID[i] = reader["BranchID"].ToString();

                    i++;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

            watch.Stop();

            

            customerTable c = new customerTable();

            c.Show();

            MessageBox.Show($"Execution time: {watch.ElapsedMilliseconds} ms");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            try
            {
                string connstring = "server=localhost; uid=root;pwd=Tamilore2003!;database=arnoldagritools";
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();
                string sql = "select * from itemtable";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                int i = 0;

                while (reader.Read())
                {
                    itemTableItemID[i] = reader["itemID"].ToString();
                    itemTableDescription[i] = reader["description"].ToString();
                    itemTableColour[i] = reader["colour"].ToString();
                    itemTableSize[i] = reader["size"].ToString();
                    itemTablePattern[i] = reader["pattern"].ToString();
                    itemTableType[i] = reader["type"].ToString();

                    i++;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

            watch.Stop();

            

            itemTable it = new itemTable();
            it.Show();

            MessageBox.Show($"Execution time: {watch.ElapsedMilliseconds} ms");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            try
            {
                string connstring = "server=localhost; uid=root;pwd=Tamilore2003!;database=arnoldagritools";
                MySqlConnection con = new MySqlConnection(); 
                con.ConnectionString = connstring;
                con.Open();
                string sql = "select * from ordertable";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                int i = 0;

                while (reader.Read())
                {
                    orderTableOrderID[i] = reader["orderID"].ToString();
                    orderTableOrderDay[i] = reader["orderDay"].ToString();
                    orderTableOrderMonth[i] = reader["orderMonth"].ToString();
                    orderTableOrderYear[i] = reader["orderYear"].ToString();
                    orderTableCreditAuthorization[i] = reader["creditAuthorization"].ToString();
                    orderTableItemID[i] = reader["itemID"].ToString();
                    orderTableNoOfItem[i] = reader["noOfItem"].ToString();
                    orderTableBranchID[i] = reader["branchID"].ToString();
                    orderTableCustomerID[i] = reader["customerID"].ToString();

                    i++;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

            watch.Stop();

            

            orderTable o = new orderTable();
            o.Show();
            MessageBox.Show($"Execution time: {watch.ElapsedMilliseconds} ms");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewTables_Load(object sender, EventArgs e)
        {

        }
    }
}
