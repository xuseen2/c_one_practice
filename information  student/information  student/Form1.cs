using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace information__student
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnshowinfo_Click(object sender, EventArgs e)
        
             
        {
            string studentname, intstudentid, department, semester, allinformation;
            //assign variable
            studentname = txtstudentname.Text;
            int studentid = int.Parse(txtstudentid.Text);
            department = txtdepartment.Text;
            semester = txtsemeter.Text;
            //process  concatination
            allinformation = studentname + " " + studentid + " " + department + " " + semester;
            //display
            lbloutput.Text = allinformation;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtstudentname.Clear();
            txtstudentid.Clear();
            txtdepartment.Clear();
            txtsemeter.Clear();
            lbloutput.Text = "  ";
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbloutput_Click(object sender, EventArgs e)
        {

        }

        private void txtsemeter_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdepartment_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtstudentid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtstudentname_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblsemeter_Click(object sender, EventArgs e)
        {

        }

        private void lbldepartment_Click(object sender, EventArgs e)
        {

        }

        private void lblsrudentid_Click(object sender, EventArgs e)
        {

        }

        private void lblname_Click(object sender, EventArgs e)
        {

        }
    }
}
