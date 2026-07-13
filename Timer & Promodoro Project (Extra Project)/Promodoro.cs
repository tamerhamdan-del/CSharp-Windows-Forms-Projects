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


    
    public partial class Promodoro : Form
    {
        int MinutsFromComboBox=0;
        int Seconds=0 ;
        public Promodoro()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MinutsFromComboBox =Convert.ToInt32( comboBox1.SelectedItem);
            Seconds = 0;


        }

        private void PromodoroTimer_Tick(object sender, EventArgs e)
        {
            lblMinuts.Text = MinutsFromComboBox.ToString("00") + " :";
            lblSeconds.Text = Seconds.ToString("00");

            if (Seconds == 0)
            {
                if (MinutsFromComboBox == 0)
                {
                    PromodoroTimer.Stop();
                    return;
                }

                MinutsFromComboBox--;
                Seconds = 59;
            }


            else
            {
                Seconds--;
            }

           


        }

        private void button1_Click(object sender, EventArgs e)
        {
            PromodoroTimer.Enabled=true;
        }
    }
}
