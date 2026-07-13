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
    public partial class frmMessageBox : Form
    {
        public frmMessageBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi,this is A Message!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi,this is A Message!","This is The Title");
        }

        private void button3_Click(object sender, EventArgs e)
        {
           if( MessageBox.Show("Are You Sure ? ", "Confirm!", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                //Do Any Think You want To Do
                MessageBox.Show("User Pressed OK ! ");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are You Sure ? ", "Confirm!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are You Sure ? ", "Confirm!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
        }
    }
}
