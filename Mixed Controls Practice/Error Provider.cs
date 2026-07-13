using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWinFormsProject
{
    public partial class Error_Provider : Form
    {
        public Error_Provider()
        {
            InitializeComponent();
        }

        private void Error_Provider_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFirstName, "First Name Should Have A Value!");
                txtFirstName.Focus();
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtFirstName, "");

            }
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtLastName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtLastName, "Last Name Should Have A Value!");
                txtLastName.Focus();
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtLastName, "");

            }
        }
    }
}
