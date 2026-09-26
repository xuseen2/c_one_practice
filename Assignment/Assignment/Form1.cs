using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DataTableClearEventArgs textbox and label 
            txtdayofweek.Clear();
            txtdayofmonth.Clear();
            txtnameofmonth.Clear();
            txtyear.Clear();
            dateoutlabel.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btshowdata_Click(object sender, EventArgs e)
        {
            //creating variables to user input 
            string Dayofweek, month, day, year, fulldate;

            //Asign variable to user input

            Dayofweek = txtdayofweek.Text;
            month = txtdayofmonth.Text;
            day = txtdayofmonth.Text;
            year=txtyear.Text;

            //Process-using concatination
            fulldate=Dayofweek+" "+month+" "+day + "" +year;

            //Display the output
            dateoutlabel.Text = fulldate;


        }
    }
}
