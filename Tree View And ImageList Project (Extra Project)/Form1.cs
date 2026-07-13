using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tree_View_And_ImageList_Project__Extra_Project_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        TreeNode GetNode(string name)
        {
            TreeNode Node = new TreeNode(name);

            if (rbMale.Checked)
            {

                Node.ImageIndex = 0;
            }
            else
            {
                Node.ImageIndex = 1;
            }

            return Node;        }

        

          private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Enter Name");
                return;
            }

            if (treeView1.Nodes.Count == 0)
            {
                treeView1.Nodes.Add(GetNode(txtName.Text));
            }
            else
            {
                if (treeView1.SelectedNode == null)
                {
                    MessageBox.Show("Select Parent");
                    return;
                }

                treeView1.SelectedNode.Nodes.Add(GetNode(txtName.Text));
                treeView1.SelectedNode.Expand();
            }

            txtName.Clear();
            txtName.Focus();
        }
        

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Remove(treeView1.SelectedNode);
        }
    }
}
