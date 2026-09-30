namespace calculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbltotalbill = new System.Windows.Forms.Label();
            this.lblamount = new System.Windows.Forms.Label();
            this.lblusage = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblelectricity = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtunitprice = new System.Windows.Forms.TextBox();
            this.txtcurrent = new System.Windows.Forms.TextBox();
            this.txtprevius = new System.Windows.Forms.TextBox();
            this.txtcustomer = new System.Windows.Forms.TextBox();
            this.lblpriceperunit = new System.Windows.Forms.Label();
            this.lblcurrentreading = new System.Windows.Forms.Label();
            this.lblpreviusreading = new System.Windows.Forms.Label();
            this.lblcustomername = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbltotalbill
            // 
            this.lbltotalbill.AutoSize = true;
            this.lbltotalbill.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbltotalbill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbltotalbill.Location = new System.Drawing.Point(404, 371);
            this.lbltotalbill.Name = "lbltotalbill";
            this.lbltotalbill.Size = new System.Drawing.Size(179, 22);
            this.lbltotalbill.TabIndex = 38;
            this.lbltotalbill.Text = "                                          \r\n";
            // 
            // lblamount
            // 
            this.lblamount.AutoSize = true;
            this.lblamount.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblamount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblamount.Location = new System.Drawing.Point(404, 334);
            this.lblamount.Name = "lblamount";
            this.lblamount.Size = new System.Drawing.Size(179, 22);
            this.lblamount.TabIndex = 39;
            this.lblamount.Text = "                                          \r\n";
            // 
            // lblusage
            // 
            this.lblusage.AutoSize = true;
            this.lblusage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblusage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblusage.Location = new System.Drawing.Point(404, 302);
            this.lblusage.Name = "lblusage";
            this.lblusage.Size = new System.Drawing.Size(179, 22);
            this.lblusage.TabIndex = 40;
            this.lblusage.Text = "                                          \r\n";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(110, 373);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(274, 20);
            this.lbltotal.TabIndex = 37;
            this.lbltotal.Text = "Total Bill (Including 5$ Fixed Charge) :";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(249, 336);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(135, 20);
            this.lblTax.TabIndex = 36;
            this.lblTax.Text = "Tax Amount(7%) :";
            // 
            // lblelectricity
            // 
            this.lblelectricity.AutoSize = true;
            this.lblelectricity.Location = new System.Drawing.Point(198, 302);
            this.lblelectricity.Name = "lblelectricity";
            this.lblelectricity.Size = new System.Drawing.Size(186, 20);
            this.lblelectricity.TabIndex = 35;
            this.lblelectricity.Text = "Electricity Usage (Units) :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(368, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 29);
            this.button1.TabIndex = 34;
            this.button1.Text = "calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtunitprice
            // 
            this.txtunitprice.Location = new System.Drawing.Point(446, 154);
            this.txtunitprice.Name = "txtunitprice";
            this.txtunitprice.Size = new System.Drawing.Size(244, 26);
            this.txtunitprice.TabIndex = 30;
            // 
            // txtcurrent
            // 
            this.txtcurrent.Location = new System.Drawing.Point(446, 122);
            this.txtcurrent.Name = "txtcurrent";
            this.txtcurrent.Size = new System.Drawing.Size(244, 26);
            this.txtcurrent.TabIndex = 31;
            // 
            // txtprevius
            // 
            this.txtprevius.Location = new System.Drawing.Point(446, 90);
            this.txtprevius.Name = "txtprevius";
            this.txtprevius.Size = new System.Drawing.Size(244, 26);
            this.txtprevius.TabIndex = 32;
            // 
            // txtcustomer
            // 
            this.txtcustomer.Location = new System.Drawing.Point(446, 57);
            this.txtcustomer.Name = "txtcustomer";
            this.txtcustomer.Size = new System.Drawing.Size(244, 26);
            this.txtcustomer.TabIndex = 33;
            // 
            // lblpriceperunit
            // 
            this.lblpriceperunit.AutoSize = true;
            this.lblpriceperunit.Location = new System.Drawing.Point(252, 157);
            this.lblpriceperunit.Name = "lblpriceperunit";
            this.lblpriceperunit.Size = new System.Drawing.Size(132, 20);
            this.lblpriceperunit.TabIndex = 27;
            this.lblpriceperunit.Text = "Price Per Unit($) :";
            // 
            // lblcurrentreading
            // 
            this.lblcurrentreading.AutoSize = true;
            this.lblcurrentreading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblcurrentreading.Location = new System.Drawing.Point(205, 126);
            this.lblcurrentreading.Name = "lblcurrentreading";
            this.lblcurrentreading.Size = new System.Drawing.Size(179, 22);
            this.lblcurrentreading.TabIndex = 28;
            this.lblcurrentreading.Text = "Enter Current Reading :";
            // 
            // lblpreviusreading
            // 
            this.lblpreviusreading.AutoSize = true;
            this.lblpreviusreading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblpreviusreading.Location = new System.Drawing.Point(207, 94);
            this.lblpreviusreading.Name = "lblpreviusreading";
            this.lblpreviusreading.Size = new System.Drawing.Size(177, 22);
            this.lblpreviusreading.TabIndex = 29;
            this.lblpreviusreading.Text = "Enter Previus Reading :";
            // 
            // lblcustomername
            // 
            this.lblcustomername.AutoSize = true;
            this.lblcustomername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblcustomername.Location = new System.Drawing.Point(209, 61);
            this.lblcustomername.Name = "lblcustomername";
            this.lblcustomername.Size = new System.Drawing.Size(175, 22);
            this.lblcustomername.TabIndex = 26;
            this.lblcustomername.Text = "Enter Customer name :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbltotalbill);
            this.Controls.Add(this.lblamount);
            this.Controls.Add(this.lblusage);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblelectricity);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtunitprice);
            this.Controls.Add(this.txtcurrent);
            this.Controls.Add(this.txtprevius);
            this.Controls.Add(this.txtcustomer);
            this.Controls.Add(this.lblpriceperunit);
            this.Controls.Add(this.lblcurrentreading);
            this.Controls.Add(this.lblpreviusreading);
            this.Controls.Add(this.lblcustomername);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltotalbill;
        private System.Windows.Forms.Label lblamount;
        private System.Windows.Forms.Label lblusage;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblelectricity;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtunitprice;
        private System.Windows.Forms.TextBox txtcurrent;
        private System.Windows.Forms.TextBox txtprevius;
        private System.Windows.Forms.TextBox txtcustomer;
        private System.Windows.Forms.Label lblpriceperunit;
        private System.Windows.Forms.Label lblcurrentreading;
        private System.Windows.Forms.Label lblpreviusreading;
        private System.Windows.Forms.Label lblcustomername;
    }
}

