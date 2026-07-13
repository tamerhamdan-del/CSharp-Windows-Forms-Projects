using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tree_View_And_ImageList_Project__Extra_Project_;

namespace MyFirstWinFormsProject
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void btnShowPart1_Click(object sender, EventArgs e)
        {
            Form frm1 = new Form1();
            frm1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm1 = new Form1();
            frm1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmMessageBox();
            frm1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form frmChkBoxRadioGroup = new frmChkRadioGroup();
            frmChkBoxRadioGroup.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmMoreAboutTextBox();
            frm1.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form frm = new Form2();
            frm.ShowDialog();
        }

        private void btnMaskedTextBox_Click(object sender, EventArgs e)
        {
            Form frm=new MaskedTextBox();
            frm.ShowDialog();
        }

        private void btnComboBox_Click(object sender, EventArgs e)
        {
            Form frm=new ComboBox();
            frm.ShowDialog();
        }

        private void btnLinkedLabel_Click(object sender, EventArgs e)
        {
            Form frm=new LinkedLabel();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form frm = new CheckedListBox();
            frm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form frm=new DateTimePicker();
            frm.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form frm = new MonthCalender();
            frm.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form frm = new Timer();
            frm.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form frm = new NotifyIcon();
            frm.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form frm = new Tree_View_And_Image_List();
            frm.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form frm = new ProgBar();
            frm.ShowDialog();
        }



        private void ListView_Click(object sender, EventArgs e)
        {
            Form frm = new List_View();
            frm.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form frm = new Error_Provider();
            frm.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form frm = new TrackBar();
            frm.ShowDialog();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Form frm = new NumericUpDown();
            frm.ShowDialog();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Form frm = new Tab_Control();
            frm.ShowDialog();

        }

        private void button17_Click(object sender, EventArgs e)
        {
            Form frm = new Group_Box_VS_Panel();
            frm.ShowDialog();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Form frm = new Dialogs();
            frm.ShowDialog();
        }
    }
}
