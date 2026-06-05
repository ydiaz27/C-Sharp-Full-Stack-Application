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
    public partial class AddMajor : Form
    {
        string connectionString = @"server=(localdb)\MSSQLLocalDB;database=DATABASENAME;Trusted_Connection=true";

        public AddMajor()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            epValidate.Clear();
            bool hasErrors = false;
            
            if (String.IsNullOrWhiteSpace(txtMajorName.Text))
            {
                hasErrors = true;
                epValidate.SetError(txtMajorName, "Major Name cannot be empty.");
                return;
            }
            
            Major major = new Major();
            major.Name = txtMajorName.Text;
            AddToMajorDb(major);
        }

        public void AddToMajorDb(Major major)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string insertStatement = "INSERT INTO dbo.Major(Name)" +
                "VALUES (@Name)";

                using (SqlCommand command = new SqlCommand(insertStatement, connection))
                {
                    command.Parameters.AddWithValue("@Name", major.Name);
                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Added a new major successfully!");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
