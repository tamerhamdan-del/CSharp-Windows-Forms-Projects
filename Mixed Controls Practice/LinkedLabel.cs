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
    public partial class LinkedLabel : Form
    {
        public LinkedLabel()
        {
            InitializeComponent();
        }

        private void lbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lbl.LinkVisited = true;
            System.Diagnostics.Process.Start("https://programmingadvices.com/courses/2012538/lectures/45852526");
        }
    }
}
