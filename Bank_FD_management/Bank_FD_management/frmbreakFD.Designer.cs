﻿namespace Bank_FD_management
{
    partial class frmbreakFD
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
            this.pnltitle = new System.Windows.Forms.Panel();
            this.lbltitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmaturedate = new System.Windows.Forms.TextBox();
            this.lblmaturitydate = new System.Windows.Forms.Label();
            this.txtstartingdate = new System.Windows.Forms.TextBox();
            this.lblstartdate = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblfdamount = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.txtcertid = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnfetchdetails = new System.Windows.Forms.Button();
            this.pnlbuttons = new System.Windows.Forms.Panel();
            this.btnexit = new System.Windows.Forms.Button();
            this.btncreate = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.txtfinalamount = new System.Windows.Forms.TextBox();
            this.lblfinalamount = new System.Windows.Forms.Label();
            this.txttotalinterest = new System.Windows.Forms.TextBox();
            this.lbltotalinterest = new System.Windows.Forms.Label();
            this.txtinterestrate = new System.Windows.Forms.TextBox();
            this.lblinterestrate = new System.Windows.Forms.Label();
            this.txtwithdate = new System.Windows.Forms.TextBox();
            this.lblwithdate = new System.Windows.Forms.Label();
            this.pnltitle.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlbuttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnltitle
            // 
            this.pnltitle.BackColor = System.Drawing.Color.LightGray;
            this.pnltitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnltitle.Controls.Add(this.lbltitle);
            this.pnltitle.Location = new System.Drawing.Point(13, 12);
            this.pnltitle.Name = "pnltitle";
            this.pnltitle.Size = new System.Drawing.Size(1101, 60);
            this.pnltitle.TabIndex = 34;
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.Location = new System.Drawing.Point(457, 7);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(176, 42);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "FD Break";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtwithdate);
            this.panel1.Controls.Add(this.lblwithdate);
            this.panel1.Controls.Add(this.txtfinalamount);
            this.panel1.Controls.Add(this.lblfinalamount);
            this.panel1.Controls.Add(this.txttotalinterest);
            this.panel1.Controls.Add(this.lbltotalinterest);
            this.panel1.Controls.Add(this.txtinterestrate);
            this.panel1.Controls.Add(this.lblinterestrate);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtmaturedate);
            this.panel1.Controls.Add(this.lblmaturitydate);
            this.panel1.Controls.Add(this.txtstartingdate);
            this.panel1.Controls.Add(this.lblstartdate);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.lblfdamount);
            this.panel1.Controls.Add(this.txtname);
            this.panel1.Controls.Add(this.lblname);
            this.panel1.Location = new System.Drawing.Point(12, 158);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1102, 417);
            this.panel1.TabIndex = 35;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(756, 157);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(147, 29);
            this.textBox4.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(648, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 52;
            this.label2.Text = "FD Status :";
            // 
            // txtmaturedate
            // 
            this.txtmaturedate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtmaturedate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmaturedate.Location = new System.Drawing.Point(473, 157);
            this.txtmaturedate.Name = "txtmaturedate";
            this.txtmaturedate.Size = new System.Drawing.Size(147, 29);
            this.txtmaturedate.TabIndex = 51;
            // 
            // lblmaturitydate
            // 
            this.lblmaturitydate.AutoSize = true;
            this.lblmaturitydate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmaturitydate.Location = new System.Drawing.Point(347, 160);
            this.lblmaturitydate.Name = "lblmaturitydate";
            this.lblmaturitydate.Size = new System.Drawing.Size(125, 24);
            this.lblmaturitydate.TabIndex = 50;
            this.lblmaturitydate.Text = "Maturity date :";
            // 
            // txtstartingdate
            // 
            this.txtstartingdate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtstartingdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstartingdate.Location = new System.Drawing.Point(161, 157);
            this.txtstartingdate.Name = "txtstartingdate";
            this.txtstartingdate.Size = new System.Drawing.Size(147, 29);
            this.txtstartingdate.TabIndex = 49;
            // 
            // lblstartdate
            // 
            this.lblstartdate.AutoSize = true;
            this.lblstartdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstartdate.Location = new System.Drawing.Point(32, 160);
            this.lblstartdate.Name = "lblstartdate";
            this.lblstartdate.Size = new System.Drawing.Size(123, 24);
            this.lblstartdate.TabIndex = 48;
            this.lblstartdate.Text = "Starting date :";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(148, 101);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 29);
            this.textBox1.TabIndex = 25;
            // 
            // lblfdamount
            // 
            this.lblfdamount.AutoSize = true;
            this.lblfdamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfdamount.Location = new System.Drawing.Point(29, 104);
            this.lblfdamount.Name = "lblfdamount";
            this.lblfdamount.Size = new System.Drawing.Size(113, 24);
            this.lblfdamount.TabIndex = 24;
            this.lblfdamount.Text = "FD amount :";
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(147, 46);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(491, 29);
            this.txtname.TabIndex = 23;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(70, 49);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(71, 24);
            this.lblname.TabIndex = 22;
            this.lblname.Text = "Name :";
            // 
            // txtcertid
            // 
            this.txtcertid.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtcertid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcertid.Location = new System.Drawing.Point(149, 14);
            this.txtcertid.Name = "txtcertid";
            this.txtcertid.Size = new System.Drawing.Size(198, 29);
            this.txtcertid.TabIndex = 29;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(27, 16);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(123, 24);
            this.lblID.TabIndex = 28;
            this.lblID.Text = "Certificate ID :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnfetchdetails);
            this.panel2.Controls.Add(this.txtcertid);
            this.panel2.Controls.Add(this.lblID);
            this.panel2.Location = new System.Drawing.Point(13, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1101, 60);
            this.panel2.TabIndex = 36;
            // 
            // btnfetchdetails
            // 
            this.btnfetchdetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfetchdetails.Location = new System.Drawing.Point(375, 11);
            this.btnfetchdetails.Name = "btnfetchdetails";
            this.btnfetchdetails.Size = new System.Drawing.Size(127, 34);
            this.btnfetchdetails.TabIndex = 42;
            this.btnfetchdetails.Text = "Fetch Details";
            this.btnfetchdetails.UseVisualStyleBackColor = true;
            // 
            // pnlbuttons
            // 
            this.pnlbuttons.BackColor = System.Drawing.Color.LightGray;
            this.pnlbuttons.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlbuttons.Controls.Add(this.btnexit);
            this.pnlbuttons.Controls.Add(this.btncreate);
            this.pnlbuttons.Controls.Add(this.btncancel);
            this.pnlbuttons.Location = new System.Drawing.Point(12, 589);
            this.pnlbuttons.Name = "pnlbuttons";
            this.pnlbuttons.Size = new System.Drawing.Size(1102, 94);
            this.pnlbuttons.TabIndex = 56;
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(654, 27);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(130, 38);
            this.btnexit.TabIndex = 2;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            // 
            // btncreate
            // 
            this.btncreate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btncreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncreate.Location = new System.Drawing.Point(485, 27);
            this.btncreate.Name = "btncreate";
            this.btncreate.Size = new System.Drawing.Size(130, 38);
            this.btncreate.TabIndex = 1;
            this.btncreate.Text = "Break";
            this.btncreate.UseVisualStyleBackColor = false;
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.Location = new System.Drawing.Point(316, 27);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(130, 38);
            this.btncancel.TabIndex = 0;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = false;
            // 
            // txtfinalamount
            // 
            this.txtfinalamount.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtfinalamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfinalamount.Location = new System.Drawing.Point(163, 331);
            this.txtfinalamount.Name = "txtfinalamount";
            this.txtfinalamount.Size = new System.Drawing.Size(147, 29);
            this.txtfinalamount.TabIndex = 59;
            // 
            // lblfinalamount
            // 
            this.lblfinalamount.AutoSize = true;
            this.lblfinalamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfinalamount.Location = new System.Drawing.Point(28, 334);
            this.lblfinalamount.Name = "lblfinalamount";
            this.lblfinalamount.Size = new System.Drawing.Size(129, 24);
            this.lblfinalamount.TabIndex = 58;
            this.lblfinalamount.Text = "Final amount :";
            // 
            // txttotalinterest
            // 
            this.txttotalinterest.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txttotalinterest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalinterest.Location = new System.Drawing.Point(162, 273);
            this.txttotalinterest.Name = "txttotalinterest";
            this.txttotalinterest.Size = new System.Drawing.Size(147, 29);
            this.txttotalinterest.TabIndex = 57;
            // 
            // lbltotalinterest
            // 
            this.lbltotalinterest.AutoSize = true;
            this.lbltotalinterest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalinterest.Location = new System.Drawing.Point(29, 276);
            this.lbltotalinterest.Name = "lbltotalinterest";
            this.lbltotalinterest.Size = new System.Drawing.Size(126, 24);
            this.lbltotalinterest.TabIndex = 56;
            this.lbltotalinterest.Text = "Total Interest :";
            // 
            // txtinterestrate
            // 
            this.txtinterestrate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtinterestrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtinterestrate.Location = new System.Drawing.Point(161, 215);
            this.txtinterestrate.Name = "txtinterestrate";
            this.txtinterestrate.Size = new System.Drawing.Size(147, 29);
            this.txtinterestrate.TabIndex = 55;
            // 
            // lblinterestrate
            // 
            this.lblinterestrate.AutoSize = true;
            this.lblinterestrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinterestrate.Location = new System.Drawing.Point(39, 218);
            this.lblinterestrate.Name = "lblinterestrate";
            this.lblinterestrate.Size = new System.Drawing.Size(116, 24);
            this.lblinterestrate.TabIndex = 54;
            this.lblinterestrate.Text = "Interest rate :";
            // 
            // txtwithdate
            // 
            this.txtwithdate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtwithdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtwithdate.Location = new System.Drawing.Point(473, 216);
            this.txtwithdate.Name = "txtwithdate";
            this.txtwithdate.Size = new System.Drawing.Size(147, 29);
            this.txtwithdate.TabIndex = 61;
            // 
            // lblwithdate
            // 
            this.lblwithdate.AutoSize = true;
            this.lblwithdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwithdate.Location = new System.Drawing.Point(334, 218);
            this.lblwithdate.Name = "lblwithdate";
            this.lblwithdate.Size = new System.Drawing.Size(139, 24);
            this.lblwithdate.TabIndex = 60;
            this.lblwithdate.Text = "Withdraw date :";
            // 
            // frmbreakFD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 695);
            this.Controls.Add(this.pnlbuttons);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnltitle);
            this.Name = "frmbreakFD";
            this.Text = "FD Break";
            this.pnltitle.ResumeLayout(false);
            this.pnltitle.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlbuttons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnltitle;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtcertid;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnfetchdetails;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblfdamount;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmaturedate;
        private System.Windows.Forms.Label lblmaturitydate;
        private System.Windows.Forms.TextBox txtstartingdate;
        private System.Windows.Forms.Label lblstartdate;
        private System.Windows.Forms.Panel pnlbuttons;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btncreate;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.TextBox txtfinalamount;
        private System.Windows.Forms.Label lblfinalamount;
        private System.Windows.Forms.TextBox txttotalinterest;
        private System.Windows.Forms.Label lbltotalinterest;
        private System.Windows.Forms.TextBox txtinterestrate;
        private System.Windows.Forms.Label lblinterestrate;
        private System.Windows.Forms.TextBox txtwithdate;
        private System.Windows.Forms.Label lblwithdate;
    }
}