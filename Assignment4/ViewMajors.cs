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
    public partial class ViewMajors : Form
    {
        string connectionString = @"server=(localdb)\MSSQLLocalDB;database=Dominican;Trusted_Connection=true";

        public ViewMajors()
        {
            InitializeComponent();
            ViewMajorsMethod();
        }

        public void ViewMajorsMethod()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM dbo.Major", conn);
                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);
                dgvViewMajors.DataSource = dt;
            }
        }
    }
}
