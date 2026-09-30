using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Creating Variables
                string customerName;
                double previousReading, currentReading, pricePerUnit, electricityUsage,
                       electricityCharge, taxAmount, totalBill;

                // Constant Variables
                const double taxPercentage = 0.07;
                const double fixedCharge = 5;

                // Assigning Variables
                customerName = txtcustomer.Text;
                previousReading = double.Parse(txtprevius.Text);
                currentReading = double.Parse(txtcurrent.Text);
                pricePerUnit = double.Parse(txtunitprice.Text);

                // Calculating Electricity Usage
                electricityUsage = currentReading - previousReading;

                // Calculating Electricity Charge
                electricityCharge = electricityUsage * pricePerUnit;

                // Calculating Tax Amount
                taxAmount = electricityCharge * taxPercentage;

                // Calculating Total Bill
                totalBill = electricityCharge + taxAmount + fixedCharge;

                // Displaying Results
                lblusage.Text = electricityUsage.ToString("0");
                lblamount.Text = "$" + taxAmount.ToString("0.00");
                lbltotalbill.Text = "$" + totalBill.ToString("0.00");
            }
            catch
            {
                MessageBox.Show("invalid error");
            }
        }

    }
    }

