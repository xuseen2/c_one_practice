namespace HOTEL_BOOKING_ROOM
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
            this.btnclear = new System.Windows.Forms.Button();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkbreak = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdhight = new System.Windows.Forms.RadioButton();
            this.rdnormal = new System.Windows.Forms.RadioButton();
            this.rdstandard = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtguest = new System.Windows.Forms.TextBox();
            this.txtnight = new System.Windows.Forms.TextBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblnumerguest = new System.Windows.Forms.Label();
            this.lblnight = new System.Windows.Forms.Label();
            this.lblage = new System.Windows.Forms.Label();
            this.lblguest = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(307, 431);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(107, 41);
            this.btnclear.TabIndex = 9;
            this.btnclear.Text = "clear";
            this.btnclear.UseVisualStyleBackColor = true;
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(76, 431);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(118, 41);
            this.btncalculate.TabIndex = 10;
            this.btncalculate.Text = "calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(525, 431);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(112, 41);
            this.btnexit.TabIndex = 11;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(598, -4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(221, 384);
            this.listBox1.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkbreak);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(31, 286);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(468, 111);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Adional Options :";
            // 
            // checkbreak
            // 
            this.checkbreak.AutoSize = true;
            this.checkbreak.Location = new System.Drawing.Point(20, 53);
            this.checkbreak.Name = "checkbreak";
            this.checkbreak.Size = new System.Drawing.Size(313, 24);
            this.checkbreak.TabIndex = 0;
            this.checkbreak.Text = "BreakFast(10 per Guest per Night)";
            this.checkbreak.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdhight);
            this.groupBox2.Controls.Add(this.rdnormal);
            this.groupBox2.Controls.Add(this.rdstandard);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(48, 178);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(443, 76);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Room Type :";
            // 
            // rdhight
            // 
            this.rdhight.AutoSize = true;
            this.rdhight.Location = new System.Drawing.Point(326, 39);
            this.rdhight.Name = "rdhight";
            this.rdhight.Size = new System.Drawing.Size(77, 24);
            this.rdhight.TabIndex = 0;
            this.rdhight.TabStop = true;
            this.rdhight.Text = "Hight";
            this.rdhight.UseVisualStyleBackColor = true;
            // 
            // rdnormal
            // 
            this.rdnormal.AutoSize = true;
            this.rdnormal.Location = new System.Drawing.Point(178, 39);
            this.rdnormal.Name = "rdnormal";
            this.rdnormal.Size = new System.Drawing.Size(90, 24);
            this.rdnormal.TabIndex = 0;
            this.rdnormal.TabStop = true;
            this.rdnormal.Text = "Normal";
            this.rdnormal.UseVisualStyleBackColor = true;
            // 
            // rdstandard
            // 
            this.rdstandard.AutoSize = true;
            this.rdstandard.Location = new System.Drawing.Point(17, 39);
            this.rdstandard.Name = "rdstandard";
            this.rdstandard.Size = new System.Drawing.Size(108, 24);
            this.rdstandard.TabIndex = 0;
            this.rdstandard.TabStop = true;
            this.rdstandard.Text = "Standard";
            this.rdstandard.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtguest);
            this.groupBox1.Controls.Add(this.txtnight);
            this.groupBox1.Controls.Add(this.txtage);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.lblnumerguest);
            this.groupBox1.Controls.Add(this.lblnight);
            this.groupBox1.Controls.Add(this.lblage);
            this.groupBox1.Controls.Add(this.lblguest);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(31, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 160);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal I nformation";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtguest
            // 
            this.txtguest.Location = new System.Drawing.Point(207, 118);
            this.txtguest.Name = "txtguest";
            this.txtguest.Size = new System.Drawing.Size(167, 26);
            this.txtguest.TabIndex = 1;
            // 
            // txtnight
            // 
            this.txtnight.Location = new System.Drawing.Point(207, 80);
            this.txtnight.Name = "txtnight";
            this.txtnight.Size = new System.Drawing.Size(167, 26);
            this.txtnight.TabIndex = 1;
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(207, 48);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(167, 26);
            this.txtage.TabIndex = 1;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(207, 16);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(167, 26);
            this.txtname.TabIndex = 1;
            // 
            // lblnumerguest
            // 
            this.lblnumerguest.AutoSize = true;
            this.lblnumerguest.Location = new System.Drawing.Point(20, 127);
            this.lblnumerguest.Name = "lblnumerguest";
            this.lblnumerguest.Size = new System.Drawing.Size(159, 20);
            this.lblnumerguest.TabIndex = 0;
            this.lblnumerguest.Text = "Number Of Guest :";
            // 
            // lblnight
            // 
            this.lblnight.AutoSize = true;
            this.lblnight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblnight.Location = new System.Drawing.Point(17, 91);
            this.lblnight.Name = "lblnight";
            this.lblnight.Size = new System.Drawing.Size(163, 22);
            this.lblnight.TabIndex = 0;
            this.lblnight.Text = "Number Of Nights :";
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblage.Location = new System.Drawing.Point(71, 55);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(107, 22);
            this.lblage.TabIndex = 0;
            this.lblage.Text = "Guest Age :";
            // 
            // lblguest
            // 
            this.lblguest.AutoSize = true;
            this.lblguest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblguest.Location = new System.Drawing.Point(57, 22);
            this.lblguest.Name = "lblguest";
            this.lblguest.Size = new System.Drawing.Size(121, 22);
            this.lblguest.TabIndex = 0;
            this.lblguest.Text = "Guest Name :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 519);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkbreak;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdhight;
        private System.Windows.Forms.RadioButton rdnormal;
        private System.Windows.Forms.RadioButton rdstandard;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtguest;
        private System.Windows.Forms.TextBox txtnight;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblnumerguest;
        private System.Windows.Forms.Label lblnight;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.Label lblguest;
    }
}

