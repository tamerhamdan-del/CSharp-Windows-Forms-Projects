using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Calculator__Extra_Project_On_C__
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        float GetResult(float Num1,string Op, float Num2 = 0)
        {
            switch (Op)
            {
                case "+":
                    return Num1 + Num2;

                case "-":
                    return Num1 - Num2;

                case "*":
                    return Num1 * Num2;
                case "/":

                    if (Num2 == 0)
                    {
                       if( MessageBox.Show("You Cannot Divide By Zero !","Division Error ", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                        {
                            EquationLine.Text = "";
                            return 0;
                        }
                    }
                    return Num1 / Num2;
                


                case "%":
                    return Num1 % Num2;

                case "^2":
                    return Convert.ToSingle(Math.Pow(Num1, 2));


                case "^0.5":
                    return Convert.ToSingle(Math.Sqrt(Num1));


                default:
                    return 0;

            }
        }
      


        float CalculateResultOfEquationLine(string EquationLine)
        {
            short Index = 0;
            string Operation = " ";

            float FirstNumber = 0;
           float SecondNumber = 0;


            foreach (char c in EquationLine)
            {
                if(c=='+'  || c=='-' || c=='*' || c=='/'  || c == '%')
                {
                    Operation= c.ToString();
                    break;
                }
            }

            if(Operation==" ")
            {
                if (EquationLine.Contains("^2"))
                { 
                    Operation = "^2";
                }

                else if (EquationLine.Contains("^0.5"))
                {
                    Operation = "^0.5";
                }
            }

             Index = Convert.ToInt16(EquationLine.IndexOf(Operation));

             FirstNumber=Convert.ToSingle(EquationLine.Substring(0,Index));

            if (Operation == "^2")
            {
                return GetResult(FirstNumber, Operation);
            }

            else if (Operation == "^0.5")
            {
                return GetResult(FirstNumber, Operation);
            }

            else
            {
                SecondNumber = Convert.ToSingle(EquationLine.Substring(Index + 1));

            }

            

            return GetResult(FirstNumber, Operation, SecondNumber);


        }

        private void button20_Click(object sender, EventArgs e)
        {
            EquationLine.Text = EquationLine.Text + btnDot.Tag;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            EquationLine.Text = EquationLine.Text + btnOne.Tag;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            EquationLine.Text = EquationLine.Text + btnFour.Tag;

        }

        private void button16_Click(object sender, EventArgs e)
        {
            EquationLine.Text = EquationLine.Text + "^2";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            EquationLine.Text = EquationLine.Text + btnSeven.Tag;

        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            EquationLine.Text = EquationLine.Text + btnTwo.Tag;

        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            EquationLine.Text = EquationLine.Text + btnThree.Tag;

        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            EquationLine.Text = EquationLine.Text + btnMinus.Tag;

        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            EquationLine.Text = EquationLine.Text + btnFive.Tag;

        }

        private void btnSex_Click(object sender, EventArgs e)
        {
            EquationLine.Text = EquationLine.Text + btnSex.Tag;

        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            EquationLine.Text = EquationLine.Text + btnMultiply.Tag;

        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            EquationLine.Text = EquationLine.Text + btnEight.Tag;

        }

        private void btnNighn_Click(object sender, EventArgs e)
        {
            EquationLine.Text = EquationLine.Text + btnNighn.Tag;

        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            EquationLine.Text = EquationLine.Text + btnDivision.Tag;

        }

        private void btnSquareRoot_Click(object sender, EventArgs e)
        {
            EquationLine.Text = EquationLine.Text + "^0.5";

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            EquationLine.Text = "";
            EquationLine.ForeColor= Color.White;
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            EquationLine.Text = EquationLine.Text + btnMod.Tag;

        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            EquationLine.Text = EquationLine.Text + btnZero.Tag;

        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(EquationLine.Text))
                EquationLine.Text = "";

            else
            {
                EquationLine.ForeColor = Color.Black;
                EquationLine.Text = CalculateResultOfEquationLine(EquationLine.Text).ToString();
            }

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            EquationLine.Text = EquationLine.Text + btnPlus.Tag;

        }
    }
}
