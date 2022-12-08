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
    public partial class employeeTable : Form
    {
        public employeeTable()
        {
            InitializeComponent();
        }

        private void employeeTable_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("EmployeeID");
            dt.Columns.Add("First Name");
            dt.Columns.Add("Last Name");
            dt.Columns.Add("Street Address");
            dt.Columns.Add("City");
            dt.Columns.Add("Provice");
            dt.Columns.Add("Phone Number");
            dt.Columns.Add("Birth day");
            dt.Columns.Add("Birth Month");
            dt.Columns.Add("Birth Year");
            dt.Columns.Add("Title");
            dt.Columns.Add("Salary");
            dt.Columns.Add("No Of Skills");
            dt.Columns.Add("Age");
            dt.Columns.Add("DepartmentID");
            dt.Columns.Add("BranchID");

            for (int i = 0; i < 6; i++)
            {
                dt.Rows.Add(ViewTables.employeeTableEmployeeID[i], ViewTables.employeeTableFirstName[i], ViewTables.employeeTableLastname[i], ViewTables.employeeTableStreetAddress[i], ViewTables.employeeTableCity[i], ViewTables.employeeTableProv[i], ViewTables.employeeTablePhoneNum[i], ViewTables.employeeTableBirthDay[i], ViewTables.employeeTableBirthMonth[i], ViewTables.employeeTableBirthYear[i],
                    ViewTables.employeeTableTitle[i], ViewTables.employeeTableSalary[i], ViewTables.employeeTableNoOfSkills, ViewTables.employeeTableAge[i], ViewTables.employeeTableDepartmentID[i], ViewTables.employeeTableBranchID[i]);
            }

            dataGridView1.DataSource = dt;
        }
    }
}
