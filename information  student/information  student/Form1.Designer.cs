namespace information__student
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
            this.btnshowinfo = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.lbloutput = new System.Windows.Forms.Label();
            this.txtsemeter = new System.Windows.Forms.TextBox();
            this.txtdepartment = new System.Windows.Forms.TextBox();
            this.txtstudentid = new System.Windows.Forms.TextBox();
            this.txtstudentname = new System.Windows.Forms.TextBox();
            this.lblsemeter = new System.Windows.Forms.Label();
            this.lbldepartment = new System.Windows.Forms.Label();
            this.lblsrudentid = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnshowinfo
            // 
            this.btnshowinfo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnshowinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshowinfo.Location = new System.Drawing.Point(160, 353);
            this.btnshowinfo.Name = "btnshowinfo";
            this.btnshowinfo.Size = new System.Drawing.Size(179, 38);
            this.btnshowinfo.TabIndex = 13;
            this.btnshowinfo.Text = "show information";
            this.btnshowinfo.UseVisualStyleBackColor = false;
            this.btnshowinfo.Click += new System.EventHandler(this.btnshowinfo_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(352, 353);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(143, 38);
            this.btnclear.TabIndex = 14;
            this.btnclear.Text = "clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(534, 353);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(143, 38);
            this.btnexit.TabIndex = 15;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // lbloutput
            // 
            this.lbloutput.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbloutput.Location = new System.Drawing.Point(150, 232);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(537, 63);
            this.lbloutput.TabIndex = 12;
            this.lbloutput.Click += new System.EventHandler(this.lbloutput_Click);
            // 
            // txtsemeter
            // 
            this.txtsemeter.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtsemeter.Location = new System.Drawing.Point(400, 156);
            this.txtsemeter.Name = "txtsemeter";
            this.txtsemeter.Size = new System.Drawing.Size(287, 26);
            this.txtsemeter.TabIndex = 8;
            this.txtsemeter.TextChanged += new System.EventHandler(this.txtsemeter_TextChanged);
            // 
            // txtdepartment
            // 
            this.txtdepartment.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtdepartment.Location = new System.Drawing.Point(400, 124);
            this.txtdepartment.Name = "txtdepartment";
            this.txtdepartment.Size = new System.Drawing.Size(287, 26);
            this.txtdepartment.TabIndex = 9;
            this.txtdepartment.TextChanged += new System.EventHandler(this.txtdepartment_TextChanged);
            // 
            // txtstudentid
            // 
            this.txtstudentid.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtstudentid.Location = new System.Drawing.Point(400, 92);
            this.txtstudentid.Name = "txtstudentid";
            this.txtstudentid.Size = new System.Drawing.Size(287, 26);
            this.txtstudentid.TabIndex = 10;
            this.txtstudentid.TextChanged += new System.EventHandler(this.txtstudentid_TextChanged);
            // 
            // txtstudentname
            // 
            this.txtstudentname.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtstudentname.Location = new System.Drawing.Point(400, 60);
            this.txtstudentname.Name = "txtstudentname";
            this.txtstudentname.Size = new System.Drawing.Size(287, 26);
            this.txtstudentname.TabIndex = 11;
            this.txtstudentname.TextChanged += new System.EventHandler(this.txtstudentname_TextChanged);
            // 
            // lblsemeter
            // 
            this.lblsemeter.AutoSize = true;
            this.lblsemeter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblsemeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsemeter.Location = new System.Drawing.Point(156, 155);
            this.lblsemeter.Name = "lblsemeter";
            this.lblsemeter.Size = new System.Drawing.Size(182, 27);
            this.lblsemeter.TabIndex = 4;
            this.lblsemeter.Text = "enter the semeter";
            this.lblsemeter.Click += new System.EventHandler(this.lblsemeter_Click);
            // 
            // lbldepartment
            // 
            this.lbldepartment.AutoSize = true;
            this.lbldepartment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbldepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldepartment.Location = new System.Drawing.Point(136, 123);
            this.lbldepartment.Name = "lbldepartment";
            this.lbldepartment.Size = new System.Drawing.Size(213, 27);
            this.lbldepartment.TabIndex = 5;
            this.lbldepartment.Text = "enter the department";
            this.lbldepartment.Click += new System.EventHandler(this.lbldepartment_Click);
            // 
            // lblsrudentid
            // 
            this.lblsrudentid.AutoSize = true;
            this.lblsrudentid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblsrudentid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsrudentid.Location = new System.Drawing.Point(150, 92);
            this.lblsrudentid.Name = "lblsrudentid";
            this.lblsrudentid.Size = new System.Drawing.Size(199, 27);
            this.lblsrudentid.TabIndex = 6;
            this.lblsrudentid.Text = "enter the student id";
            this.lblsrudentid.Click += new System.EventHandler(this.lblsrudentid_Click);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(114, 61);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(235, 27);
            this.lblname.TabIndex = 7;
            this.lblname.Text = "enter the student name";
            this.lblname.Click += new System.EventHandler(this.lblname_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnshowinfo);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.lbloutput);
            this.Controls.Add(this.txtsemeter);
            this.Controls.Add(this.txtdepartment);
            this.Controls.Add(this.txtstudentid);
            this.Controls.Add(this.txtstudentname);
            this.Controls.Add(this.lblsemeter);
            this.Controls.Add(this.lbldepartment);
            this.Controls.Add(this.lblsrudentid);
            this.Controls.Add(this.lblname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnshowinfo;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label lbloutput;
        private System.Windows.Forms.TextBox txtsemeter;
        private System.Windows.Forms.TextBox txtdepartment;
        private System.Windows.Forms.TextBox txtstudentid;
        private System.Windows.Forms.TextBox txtstudentname;
        private System.Windows.Forms.Label lblsemeter;
        private System.Windows.Forms.Label lbldepartment;
        private System.Windows.Forms.Label lblsrudentid;
        private System.Windows.Forms.Label lblname;
    }
}

