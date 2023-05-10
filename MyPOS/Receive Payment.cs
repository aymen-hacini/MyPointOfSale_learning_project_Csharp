using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPOS
{
    public partial class Receive_Payment : Form
    {
        public Receive_Payment()
        {
            InitializeComponent();
        }
        public Receive_Payment(decimal total)
        {
            this.Totalamount = total;
            InitializeComponent();
        }


        decimal Totalamount = 0;
        decimal Balanceamount = 0;
        private const int CS_DROPSHADOW = 0x00020000;
        public string numbrRole = "Money";
        bool PaymentSuccess = false;

        public bool ShowDialog()
        {
            base.ShowDialog();
            return PaymentSuccess;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            PaymentSuccess = false;
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numbrRole == "DIGITS")
            {
                enteredchk.Text = enteredchk.Text + "1";
            }
            else
                MakeAmount(button1.Text);
        }


        private void MakeAmount(string amount)
        {
            decimal change;
            enteredchk.Text = enteredchk + amount;
            if (enteredchk.Text.Length == 1)

            {
                enteredchk.Text += "0.0";

            }
            if (enteredchk.Text.Length > 4)
            {
                change = Convert.ToDecimal(enteredchk.Text) * 10;
                enteredchk.Text = change.ToString("G29");


            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (numbrRole == "DIGITS")
            {
                enteredchk.Text = enteredchk.Text + "2";
            }
            else
                MakeAmount(button3.Text);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (numbrRole == "DIGITS")
            {
                enteredchk.Text = enteredchk.Text + "3";
            }
            else
                MakeAmount(button2.Text);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (numbrRole == "DIGITS")
            {
                enteredchk.Text = enteredchk.Text + "4";
            }
            else
                MakeAmount(button4.Text);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (numbrRole == "DIGITS")
            {
                enteredchk.Text = enteredchk.Text + "5";
            }
            else
                MakeAmount(button5.Text);

        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (numbrRole == "DIGITS")
            {
                enteredchk.Text = enteredchk.Text + "6";
            }
            else
                MakeAmount(button6.Text);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (numbrRole == "DIGITS")
            {
                enteredchk.Text = enteredchk.Text + "7";
            }
            else
                MakeAmount(button7.Text);
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (numbrRole == "DIGITS")
            {
                enteredchk.Text = enteredchk.Text + "8";
            }
            else
                MakeAmount(button8.Text);
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (numbrRole == "DIGITS")
            {
                enteredchk.Text = enteredchk.Text + "9";
            }
            else
                MakeAmount(button9.Text);
        }
        private void button0_Click(object sender, EventArgs e)
        {
            decimal amount;
            if (numbrRole == "DIGITS")
            {
                enteredchk.Text = enteredchk.Text + "0";
            }
            else
                enteredchk.Text = enteredchk.Text + "0";
            if (enteredchk.Text.Length == 1)
            {
                enteredchk.Text = "0.0" + enteredchk.Text;
            }
            if (enteredchk.Text.Length >= 4)
            {
                amount = Convert.ToDecimal(enteredchk.Text) * 10;
                enteredchk.Text = amount.ToString("G29");
            }
            if (Convert.ToDecimal(enteredchk.Text) < 1)
            {
                enteredchk.Text = enteredchk.Text + "0";
            }
            if (enteredchk.Text.IndexOf(".") < 0)
            {
                enteredchk.Text = enteredchk.Text + ".00";
            }
            if (Convert.ToDecimal(enteredchk.Text) > 1 && (enteredchk.Text.Length - enteredchk.Text.IndexOf(".") - 1 == 1))
            {
                enteredchk.Text = enteredchk.Text + "0";
            }
        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            enteredchk.Clear();
            enteredchk.Select();
        }

        private void Receive_Payment_Load(object sender, EventArgs e)
        {
            lblDueAmt.Text = Totalamount.ToString();
            enteredchk.Select();
            buttonok.Enabled = false;
            Calculate();

        }
        public void Calculate()
        {
            try
            {
                if (enteredchk.Text.Length > 0)
                {
                    decimal EnteredEmt = Convert.ToDecimal(enteredchk.Text);
                    Balanceamount = Totalamount - EnteredEmt;
                    lblbalance.Text = Balanceamount.ToString();
                    if (Balanceamount > 0)
                    {
                        buttonok.Enabled = false;
                        lblbalance.BackColor = Color.Yellow;
                        buttonok.BackColor = Color.LightGreen;
                    }
                    else if (Balanceamount == 0)
                    {
                        buttonok.Enabled = true;
                        lblbalance.BackColor = Color.LightGreen;
                        buttonok.BackColor = Color.Green;
                    }
                    else
                    {
                        buttonok.BackColor = Color.Green;
                        lblbalance.BackColor = Color.Orange;
                        buttonok.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("exception : " + ex);
            }
        }

        private void enteredchk_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void enteredchk_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
        }
    }
}
