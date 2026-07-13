using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer___Promodoro_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int SecondsCounter = 0;
        int MinutsCounter = 0;
        int HoursCounter = 0;


        private void button1_Click(object sender, EventArgs e)
        {

            
            MainTimer.Enabled = true;



        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            SecondsCounter++;
            if (SecondsCounter == 60)
            {
                SecondsCounter = 0;
                MinutsCounter++;
                if (MinutsCounter == 60)
                {
                    MinutsCounter = 0;
                    HoursCounter++;

                }
            }

            lblHours.Text = HoursCounter.ToString("00")+"      :";
            lblMinuts.Text = MinutsCounter.ToString("00")+"    :";
            lblSeconds.Text = SecondsCounter.ToString("00");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainTimer.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
             SecondsCounter = 0;
             MinutsCounter = 0;
             HoursCounter = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form frm = new Promodoro();
            frm.ShowDialog();
        }
    }
}
