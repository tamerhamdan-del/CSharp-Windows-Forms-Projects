using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Track_Bar_Simple_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void UpdateColor()
        {
            lblRed.Text="Red: "+trackBarRed.Value.ToString();
            lblGreen.Text = "Green: " + trackBarGreen.Value.ToString();
            lblBlue.Text = "Blue: " + trackBarBlue.Value.ToString();

            this.BackColor = Color.FromArgb(trackBarRed.Value, trackBarGreen.Value, trackBarBlue.Value);


        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

            UpdateColor();
        }

        private void trackBarGreen_Scroll(object sender, EventArgs e)
        {
            UpdateColor();
        }

        private void trackBarBlue_Scroll(object sender, EventArgs e)
        {
            UpdateColor();
        }
    }
}
