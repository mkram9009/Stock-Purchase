using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_Purchase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
                
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // capture the input values from textboxes
            decimal costs = Decimal.Parse(textCostPerShare.Text);
            decimal number = Decimal.Parse(textNumberOfShares.Text);

            // calculation for sum of stock amount
            decimal amount = Math.Round(costs * number, 2);

            // calculation for projected 5% increase
            decimal increase = (amount * .05m) + amount;

            // calculation for projected 10% decrease
            decimal decrease = amount - (amount * .1m);

            // converts decimals into strings for formatting purposes
            textAmount.Text = amount.ToString("c");
            textIncrease.Text = increase.ToString("c");
            textDecrease.Text = decrease.ToString("c");

            textDecrease.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
