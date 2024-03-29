﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Text.RegularExpressions;

namespace Bank_FD_management
{
    public partial class frmForgetCustID : Form
    {
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
        private void ctrlOnFocusPnl1()
        {
            foreach (Control i in pnlDetails.Controls)
            {
                if (i is TextBox || i is ComboBox || i is DateTimePicker)
                {
                    i.GotFocus += onFocus;
                }
            }
            txtID.GotFocus += onFocus;
        }
        private void ctrlOnFocusPnl2()
        {
            foreach (Control i in pnlButtons.Controls)
            {
                if (i is Button)
                {
                    i.GotFocus += onFocus;
                }
            }
        }

        private void ctrlOnLostFocusPnl1()
        {
            foreach (Control i in pnlDetails.Controls)
            {
                if (i is TextBox || i is ComboBox || i is DateTimePicker)
                {
                    i.LostFocus += onLostFocus;
                }
            }
            txtID.LostFocus += onLostFocus;
        }

        private void ctrlOnLostFocusPnl2()
        {
            foreach (Control i in pnlButtons.Controls)
            {
                if (i is Button)
                {
                    i.LostFocus += onLostFocus;
                }
            }
        }
        private void clear()
        {
            foreach (Control c in pnlDetails.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
            txtID.Text = "";
        }

        // for removing all the text from cancel button
        private void btnCancel_Click(object sender, EventArgs e)
        {
            clear();
        }

        // for exiting the current form 
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public frmForgetCustID()
        {
            InitializeComponent();
            ctrlOnFocusPnl1();
            ctrlOnFocusPnl2();
            ctrlOnLostFocusPnl1();
            ctrlOnLostFocusPnl2();
        }

        private void frmForgetCustID_Load(object sender, EventArgs e)
        {

        }

        private void pnltitle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFetchID_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand("select c_id from customer_master where c_name = '" + txtName.Text + "' and dob = #" + dtpCustBirth.Value.ToString("yyyy-MM-dd HH:mm:ss") + "# and pan = '" + txtPan.Text + "'", Program.conn);
                int id = (int)cmd.ExecuteScalar();
                txtID.Text = id.ToString();
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("Record does not Exists");
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtPan_Validating(object sender, CancelEventArgs e)
        {
            string validPan = "[A-Z]{5}[0-9]{4}[A-Z]{1}";
            Regex re = new Regex(validPan);
            if (!re.IsMatch(txtPan.Text) && !string.IsNullOrEmpty(txtPan.Text))
            {
                MessageBox.Show("Invalid PAN Entered!");
                txtPan.Focus();
            }
        }
    }
}
