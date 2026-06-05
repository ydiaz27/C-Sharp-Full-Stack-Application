using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            using (AddStudent modal = new AddStudent())
            {
                DialogResult result = modal.ShowDialog();
            }
        }

        private void btnViewStudents_Click(object sender, EventArgs e)
        {
            using (ViewStudents modal = new ViewStudents())
            {
                DialogResult result = modal.ShowDialog();
            }
        }

        private void btnAddMajor_Click(object sender, EventArgs e)
        {
            using (AddMajor modal = new AddMajor())
            {
                DialogResult result = modal.ShowDialog();
            }
        }

        private void btnViewMajors_Click(object sender, EventArgs e)
        {
            using (ViewMajors modal = new ViewMajors())
            {
                DialogResult result = modal.ShowDialog();
            }
        }
    }
}
