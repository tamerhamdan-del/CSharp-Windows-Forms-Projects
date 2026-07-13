using Combo_Box_Exercise.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Combo_Box_Exercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {




            switch (cmbPictures.SelectedItem.ToString().ToLower())
            {
                case "boy":
                    pictureBox1.Image = Resources.Boy;
                    lblTitle.Text = "Boy";
                    break;


                case "girl":
                    pictureBox1.Image = Resources.Girl;
                    lblTitle.Text = "Girl";
                    break;

                case "book":
                    pictureBox1.Image = Resources.Book;
                    lblTitle.Text = "Book";
                    break;

                case "pen":

                    pictureBox1.Image = Resources.Pen;
                    lblTitle.Text = "Pen";
                    break;
            }
        }
    }
}
