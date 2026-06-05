using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    public partial class AddStudent : Form
    {
        string connectionString = @"server=(localdb)\MSSQLLocalDB;database=DATABASENAME;Trusted_Connection=true";

        public AddStudent()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //ERRORS
            epValidate.Clear();
            bool hasErrors = false;

            if (String.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                hasErrors = true;
                epValidate.SetError(txtFirstName, "First Name cannot be empty.");
            }

            if (String.IsNullOrWhiteSpace(txtLastName.Text))
            {
                hasErrors = true;
                epValidate.SetError(txtLastName, "Last Name cannot be empty.");
            }

            if (String.IsNullOrWhiteSpace(txtMajor.Text))
            {
                hasErrors = true;
                epValidate.SetError(txtMajor, "Major cannot be empty.");
            }

            if (hasErrors)
            {
                return;
            }

            //Add the student to the table 
            Student student = new Student();
            student.FirstName = txtFirstName.Text;
            student.LastName = txtLastName.Text;
            student.Major = txtMajor.Text;
            AddStudentToStudentDb(student);
        }

        public void AddStudentToStudentDb(Student student)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string insertStatement = "INSERT INTO dbo.Student(FirstName, LastName, Major)" +
                "VALUES (@FirstName, @LastName, @Major)";

                using (SqlCommand command = new SqlCommand(insertStatement, connection))
                {
                    command.Parameters.AddWithValue("@FirstName", student.FirstName);
                    command.Parameters.AddWithValue("@LastName", student.LastName);
                    command.Parameters.AddWithValue("@Major", student.Major);
                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Added a new student successfully!");

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    } 
}
