using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menue_Strip_Sample_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void updateClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Update Client Is Here!");

        }

        private void addNewClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add New Client Is Here!");
        }

        private void findClientToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Find Client Is Here!");

        }

        private void deleteClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Delete Client Is Here!");

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Login Is Here!");

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exit Is Here!");

        }

        private void findClientToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm=new Form2();
            frm.MdiParent=this;
            frm.Show();
        }
    }
}
