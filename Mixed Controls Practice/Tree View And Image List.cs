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
    public partial class Tree_View_And_Image_List : Form
    {
        public Tree_View_And_Image_List()
        {
            InitializeComponent();
        }

        private void treeView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(treeView1.SelectedNode.Text);
        }

        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            CheckTreeViewNode(e.Node, e.Node.Checked);
        }


        void CheckTreeViewNode(TreeNode Node, bool IsChecked)
        {

            foreach (TreeNode Item in Node.Nodes)
            {
                Item.Checked = IsChecked;

                if (Item.Nodes.Count > 0)
                {

                    CheckTreeViewNode(Item, IsChecked);

                }

            }
        }
    }
}

