namespace LucnhOrder
{
    public partial class LunchOrder : Form
    {
        //initializing variables
        private double MainCourse = 0, Addon1 = 0, Addon2 = 0, Addon3 = 0, Subtotal = 0, Vat = 0, Total = 0;
        private const double hAmount = 7.50, pAmount = 5.00, sAmount = 3.50, VAT = 0.15;
        public LunchOrder()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ClearCheckbox();
            txtSubtotal.Enabled = false;
            txtVAT.Enabled = false;
            txtOrderTotal.Enabled = false;

            rbtnHamburger.Checked = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            ClearCheckbox();
        }

        private void rbtnHamburger_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnHamburger.Checked)
            {
                // ClearCheckbox();
                grpbxAddons.Text = "Add-on items (R7.50/each)";
                cbx1.Text = "Lettuce, tomato, and onions";
                cbx2.Text = "Ketchup, mustard, and mayo";
                cbx3.Text = "French fries";
                MainCourse = 24.95;
            }
            else
            {
                MainCourse = 0;
                ClearOrders();
            }
        }

        private void rbtnPizza_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnPizza.Checked)
            {
                //ClearCheckbox();
                grpbxAddons.Text = "Add-on items (R5.00/each)";
                cbx1.Text = "Pepperoni";
                cbx2.Text = "Sausage";
                cbx3.Text = "Olives";
                MainCourse = 19.95;
            }
            else
            {
                MainCourse = 0;
                ClearOrders();
            }
        }

        private void rbtnSalad_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnSalad.Checked)
            {
                grpbxAddons.Text = "Add-on items (R3.50/each)";
                cbx1.Text = "Croutons";
                cbx2.Text = "Macon/Bason bits";
                cbx3.Text = "Bread sticks";
                MainCourse = 14.95;
            }
            else
            {
                MainCourse = 0;
                ClearOrders();
            }
        }

        private void cbx1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx1.Checked)
            {
                ClearOrdersTotal();
                if (cbx1.Text == "Lettuce, tomato, and onions")
                {
                    Addon1 = hAmount;
                }
                if (cbx1.Text == "Pepperoni")
                {
                    Addon1 = pAmount;
                }
                if (cbx1.Text == "Croutons")
                {
                    Addon1 = sAmount;
                }
            }
            else
            {
                Addon1 = 0;
                ClearOrdersTotal();
            }
        }

        private void cbx2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx2.Checked)
            {
                ClearOrdersTotal();
                if (cbx2.Text == "Ketchup, mustard, and mayo")
                {
                    Addon2 = hAmount;
                }
                if (cbx2.Text == "Sausage")
                {
                    Addon2 = pAmount;
                }
                if (cbx2.Text == "Macon/Bason bits")
                {
                    Addon2 = sAmount;
                }
            }
            else
            {
                Addon2 = 0;
                ClearOrdersTotal();
            }
        }

        private void cbx3_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx3.Checked)
            {
                ClearOrdersTotal();
                if (cbx3.Text == "French fries")
                {
                    Addon3 = hAmount;
                }
                if (cbx3.Text == "Olives")
                {
                    Addon3 = pAmount;
                }
                if (cbx3.Text == "Bread sticks")
                {
                    Addon3 = sAmount;
                }
            }
            else
            {
                ClearOrdersTotal();
                Addon3 = 0;
            }
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            Subtotal = 0;
            Vat = 0;
            Total = 0;
            Subtotal = CalcSubtotal();
            Vat = CalcVat();
            Total = CalcTotal();

            txtSubtotal.Text = Subtotal.ToString("C");
            txtVAT.Text = Vat.ToString("C");
            txtOrderTotal.Text = Total.ToString("C");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void Exit()
        {
            Close();
        }
        private void ClearOrders()
        {
            txtOrderTotal.Text = "";
            txtSubtotal.Text = "";
            txtVAT.Text = "";
        }
        private void ClearCheckbox()
        {
            //cbx1.Text = "";
            // cbx2.Text = "";
            //cbx3.Text = "";
            cbx1.Checked = false;
            cbx2.Checked = false;
            cbx3.Checked = false;
        }
        private void ClearOrdersTotal()
        {
            txtOrderTotal.Text = "";
        }
        private double CalcSubtotal()
        {
            double sum = MainCourse + Addon1 + Addon2 + Addon3;
            return sum;
        }
        private double CalcVat()
        {
            return (Subtotal * VAT);
        }
        private double CalcTotal()
        {
            //Math.floor();
            return Subtotal + Vat;
        

        }
        

    }
}