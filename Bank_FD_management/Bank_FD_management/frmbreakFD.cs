﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Bank_FD_management
{


    public partial class frmbreakFD : Form
    {

        private ErrorProvider err = new ErrorProvider();
        private static string myConn = "Provider=Microsoft.ACE.Oledb.12.0; Data Source=../../../DB/Data.accdb";
        private OleDbConnection conn = new OleDbConnection(myConn);


        public void setConnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                MessageBox.Show("Connection succesfull");
            }
        }


        // just for on focusing the seperate panel
        private void onFocus(object sender, EventArgs e)
        {
            var ctrl = sender as Control;
            ctrl.Tag = ctrl.BackColor;
            ctrl.BackColor = Color.Cyan;
        }

        private void onLostFocus(object sender, EventArgs e)
        {
            var ctrl = sender as Control;
            ctrl.Tag = ctrl.BackColor;
            ctrl.BackColor = Color.White;
        }



        //for every control on panel got focus
        private void ctrlOnFocuspnl1()
        {
            foreach (Control i in pnlFetch.Controls)
            {
                if (i is TextBox || i is ComboBox || i is Button)
                {
                    i.GotFocus += onFocus;
                }
            }
        }

        private void ctrlOnFocuspnl2()
        {
            foreach (Control i in pnlBreak.Controls)
            {
                if (i is TextBox || i is DateTimePicker)
                {
                    i.GotFocus += onFocus;
                }
            }
        }

        private void ctrlOnFocuspnl3()
        {
            btnCancel.GotFocus += onFocus;
            btnBreak.GotFocus += onFocus;
            btnExit.GotFocus += onFocus;
        }

        private void ctrlOnFocuspnlmid1()
        {
            foreach (Control i in pnlMid1.Controls)
            {
                if (i is TextBox || i is DateTimePicker)
                {
                    i.GotFocus += onFocus;
                }
            }
        }
        private void ctrlOnFocuspnlmid2()
        {
            foreach (Control i in pnlMid2.Controls)
            {
                if (i is TextBox)
                {
                    i.GotFocus += onFocus;
                }
            }
        }


        //for every control on panel lost focus
        private void ctrlOnLostFocuspnl1()
        {
            foreach (Control i in pnlFetch.Controls)
            {
                if (i is TextBox || i is ComboBox || i is Button)
                {
                    i.LostFocus += onLostFocus;
                }
            }
        }

        private void ctrlOnLostFocuspnl2()
        {
            foreach (Control i in pnlBreak.Controls)
            {
                if (i is TextBox || i is ComboBox || i is DateTimePicker)
                {
                    i.LostFocus += onLostFocus;
                }
            }
        }

        private void ctrlOnLostFocuspnl3()
        {
            btnCancel.LostFocus += onLostFocus;
            btnBreak.LostFocus += onLostFocus;
            btnExit.LostFocus += onLostFocus;
        }

        private void ctrlOnLostFocuspnlmid1()
        {
            foreach (Control i in pnlMid1.Controls)
            {
                if (i is TextBox || i is DateTimePicker)
                {
                    i.LostFocus += onLostFocus;
                }
            }
        }
        private void ctrlOnLostFocuspnlmid2()
        {
            foreach (Control i in pnlMid2.Controls)
            {
                if (i is TextBox)
                {
                    i.LostFocus += onLostFocus;
                }
            }
        }


        // for removing all the text from cancel button
        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtCertID.Text = "";

            foreach (Control c in pnlBreak.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
        }


        // for exiting the current form 
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        public frmbreakFD()
        {
            InitializeComponent();

            ctrlOnFocuspnl1();
            ctrlOnFocuspnl2();
            ctrlOnFocuspnl3();
            ctrlOnFocuspnlmid1();
            ctrlOnFocuspnlmid2();

            ctrlOnLostFocuspnl1();
            ctrlOnLostFocuspnl2();
            ctrlOnLostFocuspnl3();
            ctrlOnLostFocuspnlmid1();
            ctrlOnLostFocuspnlmid2();
        }

        

        private void rbdPayInterest_CheckedChanged(object sender, EventArgs e)
        {
            btnBreak.Text = "Pay Interest";

            // fetch data from db
            setConnection();
            OleDbCommand cmd = new OleDbCommand("select * from fd_transection where cert_id = " + txtCertID.Text, conn);
            OleDbDataReader dr = cmd.ExecuteReader();

            // calculations for paying interest.....
            var curr = DateTime.Now.Date;
            var startDate = dtpStartDate.Value.Date;
            var endDate = dtpMatureDate.Value.Date;
            var span = dtpMatureDate.Value.Date - dtpStartDate.Value.Date;
            DateTime paidDate = new DateTime(2002, 10, 14); // init to a specific date for sdefault value
            int paidIntr = 0, alreadyPaidAmt = 0;

            if(dr.HasRows)
            {
                while(dr.Read())
                {
                    paidDate = DateTime.Parse(dr["paidDate"].ToString());
                    paidIntr = int.Parse(dr["paid_intr"].ToString());
                    alreadyPaidAmt = int.Parse(dr["payable_intr"].ToString());

                    if(!string.IsNullOrEmpty(dr["paidDate"].ToString()))
                    {
                        startDate = DateTime.Parse(dr["paidDate"].ToString()).Date;
                    }
                }
            }
            dr.Close();
 
            try
            {
                if(txtFDStatus.Text == "Open") // find from table or something, all the conditions 
                {
                    if(curr < startDate.AddMonths(1))
                    {
                        txtpayable_intr.Text = "0";
                        txtPaid_intr.Text = "0";
                        MessageBox.Show("nanter yee");
                    }
                    if(curr >= startDate.AddMonths(1))
                    {
                        var countMonth = (curr.Month - startDate.Month);
                        var totalMonths = ((endDate.Year - startDate.Year) * 12) + endDate.Month - startDate.Month;
                        
                        var payableForMonth = (int.Parse(txtTotalInterest.Text) / totalMonths) - alreadyPaidAmt;
                        txtpayable_intr.Text = (payableForMonth * countMonth).ToString();
                        txtPaid_intr.Text = paidIntr.ToString();   
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rbdBreakFD_CheckedChanged(object sender, EventArgs e)
        {
            btnBreak.Text = "Break";
        }

        private void btnFetchDetails_Click(object sender, EventArgs e)
        {
           try
           {
                if (!string.IsNullOrEmpty(txtCertID.Text))
                {
                    setConnection();
                    OleDbCommand cmd = new OleDbCommand("select * from FD_master where cert_id = " + txtCertID.Text, conn);
                    OleDbDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            txtName.Text = dr["C_name"].ToString();
                            txtFD_ID.Text = dr["FD_ID"].ToString();
                            txtFDStatus.Text = dr["status"].ToString();
                            txtFDAmount.Text = dr["FD_amount"].ToString();
                            txtFinalAmount.Text = dr["Mature_amount"].ToString();

                            dtpStartDate.MaxDate = DateTime.Now;
                            dtpStartDate.Text = dr["Cert_dt"].ToString();

                            DateTime dt = DateTime.Parse(dr["Mature_dt"].ToString());
                            dtpMatureDate.MaxDate = dt;
                            dtpMatureDate.Value = dt;

                            txtPeriod.Text = dr["FD_type"].ToString();                     
                            txtelapsed_days.Text = (DateTime.Now.Subtract(dtpStartDate.Value).TotalDays).ToString("0");
                            txtinterestRate.Text = dr["intr_rate"].ToString();
                            txtTotalInterest.Text = dr["Total_intr"].ToString();
                        }
                    }

                    else
                    {
                        MessageBox.Show("No data found for id " + txtCertID.Text);
                        // add clear form method
                        txtCertID.Text = "";
                        txtName.Text = "";
                        txtCertID.Focus();
                    }
                }
                else
                {
                    err.SetError(txtCertID, "Enter ID");
                    txtCertID.Focus();
                }

           }
           catch (Exception ex)
           {
                MessageBox.Show(ex.Message);
           }
        }

        private void pnlButtons_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnBreak_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnBreak.Text == "Pay Interest")
                {
                    if (!string.IsNullOrEmpty(txtpayable_intr.Text) && !string.IsNullOrEmpty(txtPaid_intr.Text))
                    {
                        if(DateTime.Now.Date <= dtpMatureDate.Value.Date)
                        {
                            OleDbCommand cmd = new OleDbCommand("update fd_transection set paid_intr = " + txtPaid_intr.Text + ", paidDate = #" + DateTime.Now.Date + "# where = cert_id = " + txtCertID.Text, conn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("paise tyla dile. aata nanter yee");
                        }
                        else
                        {
                            MessageBox.Show("Zal ki aata! date sampali bal, aani kiti interest pahijet");
                        }
                    }
                }
                else if(btnBreak.Text == "Break")
                {
                    dtpWith_date.MaxDate = DateTime.Now.AddDays(1).Date;
                    dtpWith_date.Text = DateTime.Now.Date.ToString("dd-MM-yyyy");

                    OleDbCommand cmd = new OleDbCommand("select p_interest from interest_master where duration = '" + txtPeriod.Text + "'", conn);
                    var penIntrDiff = cmd.ExecuteScalar();
                    txtpen_intr.Text = penIntrDiff.ToString();


                    if(DateTime.Now.Date < dtpMatureDate.Value.Date)
                    {
                        OleDbCommand cmdFdType = new OleDbCommand("select Period_intr from fd_master where cert_id = " + txtCertID.Text, conn);
                        string fdType = Convert.ToString(cmdFdType.ExecuteScalar());

                        var countMonth = (DateTime.Now.Month - dtpStartDate.Value.Month);
                        var totalMonths = ((dtpMatureDate.Value.Year - dtpStartDate.Value.Year) * 12) + dtpMatureDate.Value.Month - dtpStartDate.Value.Month;
                        var payableForMonth = (int.Parse(txtTotalInterest.Text) / totalMonths);

                        if (fdType == "Monthly")
                        {
                            var alreadyPaid = (int.Parse(txtTotalInterest.Text) / totalMonths) * countMonth;
                            int newAmt = Convert.ToInt32(txtFDAmount.Text) * (Convert.ToInt32(txtinterestRate.Text) - Convert.ToInt32(penIntrDiff)) / 100;
                            txtWith_amt.Text = (int.Parse(txtFDAmount.Text) + newAmt - alreadyPaid).ToString();
                        }
                        else if(fdType == "Quaterly")
                        {
                            var alreadyPaid = (int.Parse(txtTotalInterest.Text) / 4) * countMonth;
                            int newAmt = Convert.ToInt32(txtFDAmount.Text) * (Convert.ToInt32(txtinterestRate.Text) - Convert.ToInt32(penIntrDiff)) / 100;
                            txtWith_amt.Text = (int.Parse(txtFDAmount.Text) + newAmt - alreadyPaid).ToString();
                        }
                        else if(fdType == "Half Yearly")
                        {
                            var alreadyPaid = (int.Parse(txtTotalInterest.Text) / 6) * countMonth;
                            int newAmt = Convert.ToInt32(txtFDAmount.Text) * (Convert.ToInt32(txtinterestRate.Text) - Convert.ToInt32(penIntrDiff)) / 100;
                            txtWith_amt.Text = (int.Parse(txtFDAmount.Text) + newAmt - alreadyPaid).ToString();
                        }
                        else if(fdType == "more than 365 days")
                        {
                            txtWith_amt.Text = txtFinalAmount.Text;
                        }
                    }
                    else if(DateTime.Now.Date >= dtpMatureDate.Value.Date)
                    {
                        txtWith_amt.Text = txtFinalAmount.Text;
                    }

                    DialogResult res = MessageBox.Show("Do you want to break the FD?", "Confirm", MessageBoxButtons.YesNo);
                    if(res == DialogResult.Yes)
                    {
                        // update status in tables fd_transection and insert data into break_fd table
                        OleDbCommand cmdUpdateStatus = new OleDbCommand("update fd_transection set fd_status = 'Break' where cert_id = " + txtCertID.Text, conn);
                        cmdUpdateStatus.ExecuteNonQuery();
                        OleDbCommand cmdUpdateStatus1 = new OleDbCommand("update fd_master set status = 'Break' where cert_id = " + txtCertID.Text, conn);
                        cmdUpdateStatus1.ExecuteNonQuery();
                        MessageBox.Show("Your fd is breaked");
                        // data insertion is remaining
                    }
                    else
                    {
                        // clear the form
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtCertID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                btnFetchDetails.PerformClick();
            }
        }
    }
}
