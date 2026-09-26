namespace Assignment
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
            System.Windows.Forms.Label label1;
            this.lblnameofmonth = new System.Windows.Forms.Label();
            this.lbldayofweek = new System.Windows.Forms.Label();
            this.lbldayofthemonth = new System.Windows.Forms.Label();
            this.lbltheyear = new System.Windows.Forms.Label();
            this.txtdayofweek = new System.Windows.Forms.TextBox();
            this.txtnameofmonth = new System.Windows.Forms.TextBox();
            this.txtdayofmonth = new System.Windows.Forms.TextBox();
            this.txtyear = new System.Windows.Forms.TextBox();
            this.btnclose = new System.Windows.Forms.Button();
            this.btshowdata = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.dateoutlabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(157, 273);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(0, 20);
            label1.TabIndex = 3;
            label1.UseMnemonic = false;
            label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblnameofmonth
            // 
            this.lblnameofmonth.AutoSize = true;
            this.lblnameofmonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblnameofmonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnameofmonth.Location = new System.Drawing.Point(161, 94);
            this.lblnameofmonth.Name = "lblnameofmonth";
            this.lblnameofmonth.Size = new System.Drawing.Size(296, 31);
            this.lblnameofmonth.TabIndex = 0;
            this.lblnameofmonth.Text = "enter the name of month";
            // 
            // lbldayofweek
            // 
            this.lbldayofweek.AutoSize = true;
            this.lbldayofweek.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbldayofweek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldayofweek.Location = new System.Drawing.Point(193, 62);
            this.lbldayofweek.Name = "lbldayofweek";
            this.lbldayofweek.Size = new System.Drawing.Size(264, 31);
            this.lbldayofweek.TabIndex = 1;
            this.lbldayofweek.Text = "enter the day of week";
            // 
            // lbldayofthemonth
            // 
            this.lbldayofthemonth.AutoSize = true;
            this.lbldayofthemonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbldayofthemonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldayofthemonth.Location = new System.Drawing.Point(41, 129);
            this.lbldayofthemonth.Name = "lbldayofthemonth";
            this.lbldayofthemonth.Size = new System.Drawing.Size(416, 31);
            this.lbldayofthemonth.TabIndex = 0;
            this.lbldayofthemonth.Text = "enter the numeric day of the month";
            // 
            // lbltheyear
            // 
            this.lbltheyear.AutoSize = true;
            this.lbltheyear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbltheyear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltheyear.Location = new System.Drawing.Point(282, 166);
            this.lbltheyear.Name = "lbltheyear";
            this.lbltheyear.Size = new System.Drawing.Size(175, 31);
            this.lbltheyear.TabIndex = 0;
            this.lbltheyear.Text = "enter the year";
            // 
            // txtdayofweek
            // 
            this.txtdayofweek.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtdayofweek.Location = new System.Drawing.Point(484, 60);
            this.txtdayofweek.Name = "txtdayofweek";
            this.txtdayofweek.Size = new System.Drawing.Size(256, 26);
            this.txtdayofweek.TabIndex = 2;
            // 
            // txtnameofmonth
            // 
            this.txtnameofmonth.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtnameofmonth.Location = new System.Drawing.Point(484, 96);
            this.txtnameofmonth.Name = "txtnameofmonth";
            this.txtnameofmonth.Size = new System.Drawing.Size(256, 26);
            this.txtnameofmonth.TabIndex = 2;
            // 
            // txtdayofmonth
            // 
            this.txtdayofmonth.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtdayofmonth.Location = new System.Drawing.Point(484, 134);
            this.txtdayofmonth.Name = "txtdayofmonth";
            this.txtdayofmonth.Size = new System.Drawing.Size(256, 26);
            this.txtdayofmonth.TabIndex = 2;
            // 
            // txtyear
            // 
            this.txtyear.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtyear.Location = new System.Drawing.Point(484, 171);
            this.txtyear.Name = "txtyear";
            this.txtyear.Size = new System.Drawing.Size(256, 26);
            this.txtyear.TabIndex = 2;
            // 
            // btnclose
            // 
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Location = new System.Drawing.Point(523, 332);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(173, 44);
            this.btnclose.TabIndex = 4;
            this.btnclose.Text = "close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.button1_Click);
            // 
            // btshowdata
            // 
            this.btshowdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btshowdata.Location = new System.Drawing.Point(161, 332);
            this.btshowdata.Name = "btshowdata";
            this.btshowdata.Size = new System.Drawing.Size(147, 44);
            this.btshowdata.TabIndex = 4;
            this.btshowdata.Text = "show data";
            this.btshowdata.UseVisualStyleBackColor = true;
            this.btshowdata.Click += new System.EventHandler(this.btshowdata_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(328, 332);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(178, 44);
            this.btnclear.TabIndex = 4;
            this.btnclear.Text = "clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateoutlabel
            // 
            this.dateoutlabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.dateoutlabel.Enabled = false;
            this.dateoutlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.dateoutlabel.Location = new System.Drawing.Point(203, 243);
            this.dateoutlabel.Name = "dateoutlabel";
            this.dateoutlabel.Size = new System.Drawing.Size(394, 50);
            this.dateoutlabel.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateoutlabel);
            this.Controls.Add(this.btshowdata);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(label1);
            this.Controls.Add(this.txtyear);
            this.Controls.Add(this.txtdayofmonth);
            this.Controls.Add(this.txtnameofmonth);
            this.Controls.Add(this.txtdayofweek);
            this.Controls.Add(this.lbldayofweek);
            this.Controls.Add(this.lbltheyear);
            this.Controls.Add(this.lbldayofthemonth);
            this.Controls.Add(this.lblnameofmonth);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnameofmonth;
        private System.Windows.Forms.Label lbldayofweek;
        private System.Windows.Forms.Label lbldayofthemonth;
        private System.Windows.Forms.Label lbltheyear;
        private System.Windows.Forms.TextBox txtdayofweek;
        private System.Windows.Forms.TextBox txtnameofmonth;
        private System.Windows.Forms.TextBox txtdayofmonth;
        private System.Windows.Forms.TextBox txtyear;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btshowdata;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Label dateoutlabel;
    }
}

