using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOTEL_BOOKING_ROOM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            string name = txtname.Text.Trim();

            int age, nights, guests;
            if (name == "")
            {
                MessageBox.Show("Please enter guest name.");
                txtname.Focus();
                return;
            }

            if (!int.TryParse(txtage.Text, out age) ||
                !int.TryParse(txtnight.Text, out nights) ||
                !int.TryParse(txtguest.Text, out guests))
            {
                MessageBox.Show("Please enter valid numbers.");
                return;
            }
            if (age < 18)
            {
                MessageBox.Show("Guest must be 18 or older.");
                return;
            }

            if (nights < 1 || guests < 1)
            {
                MessageBox.Show("Nights and guests must be at least 1.");
                return;
            }
            double rate = 0;
            string room = "";

            if (rdstandard.Checked)
            {
                rate = 50;
                room = "Standard";
            }
            else if (rdnormal.Checked)
            {
                rate = 80;
                room = "Normal";
            }
            else if (rdhight.Checked)
            {
                rate = 120;
                room = "Hight";
            }
            else
            {
                MessageBox.Show("Please select a room type.");
                return;
            }

            double roomCost = rate * nights;
            double breakfastCost = 0;
            if (checkbreak.Checked)
            {
                breakfastCost = 10 * guests * nights;
            }

            double totalCost = roomCost + breakfastCost;

            MessageBox.Show(
                "Booking Details\n\n" +
                "Guest Name: " + name + "\n" +
                "Guest Age: " + age + "\n" +
                "Room Type: " + room + "\n" +
                "Number of Nights: " + nights + "\n" +
                "Number of Guests: " + guests + "\n" +
                "Room Cost: $" + roomCost.ToString("0.00") + "\n" +
                "Breakfast Cost: $" + breakfastCost.ToString("0.00") + "\n" +
                "Total Cost: $" + totalCost.ToString("0.00"),
                "Booking Summary"
            );
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtage.Clear();
            txtnight.Clear();
            txtguest.Clear();
            btnclear.Text = "  ";


            rdstandard.Checked = false;
            rdnormal.Checked = false;
            rdhight.Checked = false;
            checkbreak.Checked = false;

            txtname.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}

