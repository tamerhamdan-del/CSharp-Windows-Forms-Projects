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
    public partial class List_View : Form
    {
        public List_View()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtID.Text) || string.IsNullOrEmpty(txtName.Text))
            {
                return;
            }


            ListViewItem Item = new ListViewItem(txtID.Text.Trim());


            if (rbMale.Checked)
            {
                Item.ImageIndex = 0;
            }
            else
            {
                Item.ImageIndex = 1;
            }


            Item.SubItems.Add(txtName.Text.Trim());

            listView1.Items.Add(Item);

            txtID.Clear();
            txtName.Clear();

            txtID.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(listView1.SelectedItems[0].Text);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            for(int i = 1; i <= 10; i++)
            {
                ListViewItem Item = new ListViewItem(i.ToString());

                if (i % 2 == 0)
                {
                    Item.ImageIndex = 0;
                }
                else
                {
                    Item.ImageIndex= 1;

                 
                }

                Item.SubItems.Add("Person" + i);
                listView1.Items.Add(Item);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.List;

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Tile;

        }
    }
}
