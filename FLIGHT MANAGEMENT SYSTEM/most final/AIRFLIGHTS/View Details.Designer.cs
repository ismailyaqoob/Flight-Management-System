namespace AIRFLIGHTS
{
    partial class View_Details
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Rlocal = new System.Windows.Forms.RadioButton();
            this.Rinternational = new System.Windows.Forms.RadioButton();
            this.origin = new System.Windows.Forms.ComboBox();
            this.LocalDestination = new System.Windows.Forms.ComboBox();
            this.International = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cabinclass = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.enterpass = new System.Windows.Forms.TextBox();
            this.showdetail = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ecppr = new System.Windows.Forms.Label();
            this.fc = new System.Windows.Forms.Label();
            this.ec = new System.Windows.Forms.Label();
            this.bs = new System.Windows.Forms.Label();
            this.int_ori = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lpec = new System.Windows.Forms.Label();
            this.lfc = new System.Windows.Forms.Label();
            this.lec = new System.Windows.Forms.Label();
            this.lbs = new System.Windows.Forms.Label();
            this.ori_local = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Rlocal
            // 
            this.Rlocal.AutoSize = true;
            this.Rlocal.Location = new System.Drawing.Point(344, 81);
            this.Rlocal.Name = "Rlocal";
            this.Rlocal.Size = new System.Drawing.Size(100, 17);
            this.Rlocal.TabIndex = 0;
            this.Rlocal.TabStop = true;
            this.Rlocal.Text = "LOCAL FLIGHT";
            this.Rlocal.UseVisualStyleBackColor = true;
            this.Rlocal.CheckedChanged += new System.EventHandler(this.Rlocal_CheckedChanged);
            // 
            // Rinternational
            // 
            this.Rinternational.AutoSize = true;
            this.Rinternational.Location = new System.Drawing.Point(344, 126);
            this.Rinternational.Name = "Rinternational";
            this.Rinternational.Size = new System.Drawing.Size(153, 17);
            this.Rinternational.TabIndex = 1;
            this.Rinternational.TabStop = true;
            this.Rinternational.Text = "INTERNATIONAL FLIGHT";
            this.Rinternational.UseVisualStyleBackColor = true;
            this.Rinternational.CheckedChanged += new System.EventHandler(this.Rinternational_CheckedChanged);
            // 
            // origin
            // 
            this.origin.FormattingEnabled = true;
            this.origin.Items.AddRange(new object[] {
            "Karachi",
            "Lahore",
            "Peshawar",
            "Islamabad"});
            this.origin.Location = new System.Drawing.Point(344, 192);
            this.origin.Name = "origin";
            this.origin.Size = new System.Drawing.Size(121, 21);
            this.origin.TabIndex = 2;
            // 
            // LocalDestination
            // 
            this.LocalDestination.FormattingEnabled = true;
            this.LocalDestination.Items.AddRange(new object[] {
            "Mon-Karachi",
            "Tues-Lahore",
            "Wed-Karachi",
            "Thurs-Islamabad",
            "Fri-Peshawar",
            "Sat-Islamabad",
            "Sun-Faisalabad"});
            this.LocalDestination.Location = new System.Drawing.Point(344, 252);
            this.LocalDestination.Name = "LocalDestination";
            this.LocalDestination.Size = new System.Drawing.Size(121, 21);
            this.LocalDestination.TabIndex = 3;
            // 
            // International
            // 
            this.International.FormattingEnabled = true;
            this.International.Items.AddRange(new object[] {
            "Mon-Sudia Arabia",
            "Tues-Dubai",
            "Wed-America",
            "Thurs-London",
            "Fri-China",
            "Sat-Russia",
            "Sun-United Kingdom"});
            this.International.Location = new System.Drawing.Point(344, 311);
            this.International.Name = "International";
            this.International.Size = new System.Drawing.Size(121, 21);
            this.International.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ORIGIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "LOCAL FLIGHTS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "INTERNATIONAL FLIGHTS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(369, 422);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "SHOW LIST";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(161, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cabin Class";
            // 
            // cabinclass
            // 
            this.cabinclass.FormattingEnabled = true;
            this.cabinclass.Items.AddRange(new object[] {
            "Premium Economy Class",
            "Economy Class",
            "Business Class",
            "First Class"});
            this.cabinclass.Location = new System.Drawing.Point(344, 370);
            this.cabinclass.Name = "cabinclass";
            this.cabinclass.Size = new System.Drawing.Size(121, 21);
            this.cabinclass.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(572, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 523);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PASSPORT_NUMBERS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(161, 504);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "ENTER PASSPORT NUMBER";
            // 
            // enterpass
            // 
            this.enterpass.Location = new System.Drawing.Point(344, 497);
            this.enterpass.Name = "enterpass";
            this.enterpass.Size = new System.Drawing.Size(121, 20);
            this.enterpass.TabIndex = 15;
            // 
            // showdetail
            // 
            this.showdetail.Location = new System.Drawing.Point(369, 540);
            this.showdetail.Name = "showdetail";
            this.showdetail.Size = new System.Drawing.Size(75, 23);
            this.showdetail.TabIndex = 16;
            this.showdetail.Text = "SEARCH";
            this.showdetail.UseVisualStyleBackColor = true;
            this.showdetail.Click += new System.EventHandler(this.showdetail_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ecppr);
            this.groupBox2.Controls.Add(this.fc);
            this.groupBox2.Controls.Add(this.ec);
            this.groupBox2.Controls.Add(this.bs);
            this.groupBox2.Controls.Add(this.int_ori);
            this.groupBox2.Location = new System.Drawing.Point(782, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 246);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "INTERNATIONAL";
            // 
            // ecppr
            // 
            this.ecppr.AutoSize = true;
            this.ecppr.Location = new System.Drawing.Point(6, 148);
            this.ecppr.Name = "ecppr";
            this.ecppr.Size = new System.Drawing.Size(122, 13);
            this.ecppr.TabIndex = 4;
            this.ecppr.Text = "Premium Economy Class";
            // 
            // fc
            // 
            this.fc.AutoSize = true;
            this.fc.Location = new System.Drawing.Point(6, 174);
            this.fc.Name = "fc";
            this.fc.Size = new System.Drawing.Size(54, 13);
            this.fc.TabIndex = 3;
            this.fc.Text = "First Class";
            // 
            // ec
            // 
            this.ec.AutoSize = true;
            this.ec.Location = new System.Drawing.Point(6, 114);
            this.ec.Name = "ec";
            this.ec.Size = new System.Drawing.Size(82, 13);
            this.ec.TabIndex = 2;
            this.ec.Text = "Economic Class";
            // 
            // bs
            // 
            this.bs.AutoSize = true;
            this.bs.Location = new System.Drawing.Point(6, 81);
            this.bs.Name = "bs";
            this.bs.Size = new System.Drawing.Size(77, 13);
            this.bs.TabIndex = 1;
            this.bs.Text = "Business Class";
            // 
            // int_ori
            // 
            this.int_ori.AutoSize = true;
            this.int_ori.Location = new System.Drawing.Point(6, 44);
            this.int_ori.Name = "int_ori";
            this.int_ori.Size = new System.Drawing.Size(0, 13);
            this.int_ori.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lpec);
            this.groupBox3.Controls.Add(this.lfc);
            this.groupBox3.Controls.Add(this.lec);
            this.groupBox3.Controls.Add(this.lbs);
            this.groupBox3.Controls.Add(this.ori_local);
            this.groupBox3.Location = new System.Drawing.Point(787, 346);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(194, 257);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "LOCAL";
            // 
            // lpec
            // 
            this.lpec.AutoSize = true;
            this.lpec.Location = new System.Drawing.Point(6, 175);
            this.lpec.Name = "lpec";
            this.lpec.Size = new System.Drawing.Size(122, 13);
            this.lpec.TabIndex = 9;
            this.lpec.Text = "Premium Economy Class";
            // 
            // lfc
            // 
            this.lfc.AutoSize = true;
            this.lfc.Location = new System.Drawing.Point(6, 201);
            this.lfc.Name = "lfc";
            this.lfc.Size = new System.Drawing.Size(54, 13);
            this.lfc.TabIndex = 8;
            this.lfc.Text = "First Class";
            // 
            // lec
            // 
            this.lec.AutoSize = true;
            this.lec.Location = new System.Drawing.Point(6, 141);
            this.lec.Name = "lec";
            this.lec.Size = new System.Drawing.Size(82, 13);
            this.lec.TabIndex = 7;
            this.lec.Text = "Economic Class";
            // 
            // lbs
            // 
            this.lbs.AutoSize = true;
            this.lbs.Location = new System.Drawing.Point(6, 108);
            this.lbs.Name = "lbs";
            this.lbs.Size = new System.Drawing.Size(77, 13);
            this.lbs.TabIndex = 6;
            this.lbs.Text = "Business Class";
            // 
            // ori_local
            // 
            this.ori_local.AutoSize = true;
            this.ori_local.Location = new System.Drawing.Point(6, 71);
            this.ori_local.Name = "ori_local";
            this.ori_local.Size = new System.Drawing.Size(0, 13);
            this.ori_local.TabIndex = 5;
            // 
            // View_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.showdetail);
            this.Controls.Add(this.enterpass);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cabinclass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.International);
            this.Controls.Add(this.LocalDestination);
            this.Controls.Add(this.origin);
            this.Controls.Add(this.Rinternational);
            this.Controls.Add(this.Rlocal);
            this.Name = "View_Details";
            this.Size = new System.Drawing.Size(999, 647);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Rlocal;
        private System.Windows.Forms.RadioButton Rinternational;
        private System.Windows.Forms.ComboBox origin;
        private System.Windows.Forms.ComboBox LocalDestination;
        private System.Windows.Forms.ComboBox International;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cabinclass;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox enterpass;
        private System.Windows.Forms.Button showdetail;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label ecppr;
        private System.Windows.Forms.Label fc;
        private System.Windows.Forms.Label ec;
        private System.Windows.Forms.Label bs;
        private System.Windows.Forms.Label int_ori;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lpec;
        private System.Windows.Forms.Label lfc;
        private System.Windows.Forms.Label lec;
        private System.Windows.Forms.Label lbs;
        private System.Windows.Forms.Label ori_local;
    }
}
