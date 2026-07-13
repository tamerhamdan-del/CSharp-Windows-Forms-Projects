using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Project
{
    public partial class frmPizzaOrder : Form
    {
        public frmPizzaOrder()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        void UpdateOrderSummary()
        {

            UpdateCrust();
            UpdateSize();
            UpdateToppings();
            UpdateWhereToEat();
            UpdateTotalPrice();
        }

        private void frmPizzaOrder_Load(object sender, EventArgs e)
        {
            ResetForm();
            UpdateOrderSummary();
        }


        void ResetForm()
        {
            gbSize.Enabled = true;
            gbCrustType.Enabled = true;
            gbToppings.Enabled = true;
            gbWhereToEat.Enabled = true;



            rbMedium.Checked = true;

            rbThinCrust.Checked = true;

            rbEatIn.Checked = true;

            cbExtraChees.Checked = false;
            cbMushrooms.Checked = false;
            cbTomatoes.Checked = false;
            cbOlives.Checked = false;
            cbOnion.Checked = false;
            cbGreePeppers.Checked = false;


            btnOrderPizza.Enabled = true;

        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
          
            ResetForm();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void gbToppings_Enter(object sender, EventArgs e)
        {

        }


        private void UpdateSize()
        {

            if (rbSmall.Checked == true)
            {
                lblSizeValue.Text = "Small";
                return;
            }


            if (rbMedium.Checked == true)
            {
                lblSizeValue.Text = "Medium";
                return;
            }


            if (rbLarge.Checked == true)
            {
                lblSizeValue.Text = "Large";
                return;
            }

        }

        void UpdateTotalPrice()
        {
            float total = CalculateTotalPrice() * (float)numericUpDown1.Value;
            lblTotalPriceValue.Text = "$" + total.ToString();
        }
        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
          UpdateTotalPrice();
        }

        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
            UpdateTotalPrice();

        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
            UpdateTotalPrice();

        }

        private void label2_Click(object sender, EventArgs e)
        {
          
        }

        private void lblCrustType_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalPrice_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }


        void UpdateCrust()
        {
            UpdateTotalPrice();
            if (rbThinCrust.Checked == true)
            {
                lblCrustTypeValue.Text = "Thin Crust";
                return;
            }

            if (rbThickCrust.Checked == true)
            {
                lblCrustTypeValue.Text = "Thick Crust";
                return;
            }

        }

        private void rbThinCrust_CheckedChanged(object sender, EventArgs e)
        {

            UpdateCrust();
        }

        private void rbThickCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        void UpdateWhereToEat()
        {
            if (rbEatIn.Checked == true)
            {
                lblWhereToEatValue.Text = "Eat In";
            }


            if (rbTakeOut.Checked == true)
            {
                lblWhereToEatValue.Text = "Take Out";
            }

        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }


        private void UpdateToppings()
        {
            UpdateTotalPrice();

            string Toppings = "";

            if (cbExtraChees.Checked == true)
            {
                Toppings += "Extra Chess";
            }
            if (cbMushrooms.Checked == true)
            {
                Toppings += ", Mushrooms";
            }

            if (cbTomatoes.Checked == true)
            {
                Toppings += ", Tomatoes";
            }

            if (cbOnion.Checked == true)
            {
                Toppings += ", Onion";
            }


            if (cbOlives.Checked == true)
            {

                Toppings += ", Olives";
            }

            if (cbGreePeppers.Checked == true)
            {
                Toppings += ", Green Peppers";
            }

            if (Toppings.StartsWith(","))
            {
                Toppings=Toppings.Substring(1,Toppings.Length - 1).Trim();
            }



            if (Toppings == "")
            {
                Toppings = "No Toppings";
            }

            lblToppingsValue.Text = Toppings;
           
        }



        float GetSelectedSizePrice()
        {
            if (rbSmall.Checked)
            {
                return Convert.ToSingle(rbSmall.Tag);
            }

            else if (rbMedium.Checked)
            {
                return Convert.ToSingle(rbMedium.Tag);
            }

            else
            {
                return Convert.ToSingle(rbLarge.Tag);
            }
        }


        float CalculateToppingsPrice()
        {
            float toppingsPrice = 0;

            if (cbExtraChees.Checked)
            {
                toppingsPrice += Convert.ToSingle(cbExtraChees.Tag);
            }



            if (cbMushrooms.Checked)
            {
                toppingsPrice += Convert.ToSingle(cbMushrooms.Tag);
            }


            if (cbTomatoes.Checked)
            {
                toppingsPrice += Convert.ToSingle(cbTomatoes.Tag);
            }


            if (cbOnion.Checked)
            {
                toppingsPrice += Convert.ToSingle(cbOnion.Tag);
            }


            if (cbOlives.Checked)
            {
                toppingsPrice += Convert.ToSingle(cbOlives.Tag);
            }

            if (cbGreePeppers.Checked)
            {
                toppingsPrice += Convert.ToSingle(cbGreePeppers.Tag);
            }

            return toppingsPrice;
        }
      

        float GetSelectedCrustTypePrice()
        {
            if (rbThinCrust.Checked)
            {
                return Convert.ToSingle(rbThinCrust.Tag);
            }

            else
                return Convert.ToSingle(rbThickCrust.Tag);
      
        }


        float CalculateTotalPrice()
        {
            return GetSelectedSizePrice() + GetSelectedCrustTypePrice() + CalculateToppingsPrice();
        }
        

        

        private void cbExtraChees_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void cbMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();


        }

        private void cbTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();


        }

        private void cbOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();


        }

        private void cbOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();


        }

        private void cbGreePeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();


        }

        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Order", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                MessageBox.Show("Order Placed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                gbSize.Enabled = false;
                gbCrustType.Enabled = false;
                gbToppings.Enabled= false;
                gbWhereToEat.Enabled = false;
                btnOrderPizza.Enabled = false;
            }

        }

        private void gbSize_Enter(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }
    }
}
