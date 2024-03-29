﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using System.Data.OleDb;

namespace Bank_FD_management
{
    public partial class frmFD_reports : Form
    {

        public frmFD_reports()
        {
            InitializeComponent();
            dtpStartDate.Visible = false;
            dtpEndDate.Visible = false;
            txtID.Visible = false;
            lblStartDate.Visible = false;
            lblEndDate.Visible = false;
            lblID.Visible = false;
            lblendamt.Visible = false;
            lblstartamt.Visible = false;
            txtstartamt.Visible = false;
            txtendamt.Visible = false;

            dtpEndDate.MaxDate = DateTime.Now;
            dtpStartDate.MaxDate = DateTime.Now;

            ctrlOnFocusPnl1();
            ctrlOnLostFocusPnl1();

            btnViewReport.Enabled = false;

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

        //just for got focusing every panel 
        private void ctrlOnFocusPnl1()
        {
            foreach (Control i in pnlDetails.Controls)
            {
                if (i is TextBox || i is ComboBox || i is DateTimePicker)
                {
                    i.GotFocus += onFocus;
                }
            }
        }
        //just for on lost focusing the panel
        private void ctrlOnLostFocusPnl1()
        {
            foreach (Control i in pnlDetails.Controls)
            {
                if (i is TextBox || i is ComboBox || i is DateTimePicker)
                {
                    i.LostFocus += onLostFocus;
                }
            }
        }

        private void lblReport_Type_Click(object sender, EventArgs e)
        {

        }

        private void cmbReportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbReportType.Text == "Customer FD Report")
            {
                lblID.Visible = true;
                txtID.Visible = true;

                lblStartDate.Visible = false;
                dtpStartDate.Visible = false;
                lblEndDate.Visible = false;
                dtpEndDate.Visible = false;
                lblendamt.Visible = false;
                lblstartamt.Visible = false;
                txtstartamt.Visible = false;
                txtendamt.Visible = false;
            }
            else if(cmbReportType.Text == "Create FD report" || cmbReportType.Text == "Customer Report"|| cmbReportType.Text == "Break FD report")
            {
                lblID.Visible = false;
                txtID.Visible = false;
                lblendamt.Visible = false;
                lblstartamt.Visible = false;
                txtstartamt.Visible = false;
                txtendamt.Visible = false;

                lblStartDate.Visible = true;
                dtpStartDate.Visible = true;
                lblEndDate.Visible = true;
                dtpEndDate.Visible = true;

                btnViewReport.Enabled = true;
            }
            else
            {
                dtpStartDate.Visible = false;
                dtpEndDate.Visible = false;
                txtID.Visible = false;
                lblStartDate.Visible = false;
                lblEndDate.Visible = false;
                lblID.Visible = false;
                btnViewReport.Enabled = false;
                lblendamt.Visible = false;
                lblstartamt.Visible = false;
                txtstartamt.Visible = false;
                txtendamt.Visible = false;

            }
            if (cmbReportType.Text == "Today FD Report"||cmbReportType.Text == "Matured FD Report")
            {
                dtpStartDate.Visible = false;
                dtpEndDate.Visible = false;
                txtID.Visible = false;
                lblStartDate.Visible = false;
                lblEndDate.Visible = false;
                lblID.Visible = false;

                lblendamt.Visible = false;
                lblstartamt.Visible = false;
                txtstartamt.Visible = false;
                txtendamt.Visible = false;

                btnViewReport.Enabled = true;
            }
            if(cmbReportType.Text== "Amount Wise")
            {
                lblendamt.Visible = true;
                lblstartamt.Visible = true;
                txtstartamt.Visible = true;
                txtendamt.Visible = true;
                btnViewReport.Enabled = true;
            }
        }

        private void cmbReportType_TextChanged(object sender, EventArgs e)
        {
        }

        private void cmbReportType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cmbReportType.Text == "Customer FD Report")
                {
                    txtID.Focus();
                }
                else
                {
                    dtpStartDate.Focus();
                }
            }
        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {

            if (cmbReportType.Text == "Customer Report")
            {
                OleDbCommand cmd = new OleDbCommand("Select * from Customer_master where Add_date >= #" + dtpStartDate.Value.ToString("yyyy-MM-dd") + "# and Add_date <= #" + dtpEndDate.Value.ToString("yyyy-MM-dd") + "#", Program.conn);
                OleDbDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    ReportDocument crypt = new ReportDocument();
                    crypt.Load(@"C:\Users\HARSH\source\project\Fixed_deposite_system\Bank_FD_management\Bank_FD_management\Reports\Customer_add_report.rpt");
                    //crypt.Load(@"C:\Users\Hiremath\source\repos\Fixed_deposite_system\Bank_FD_management\Bank_FD_management\Reports\Customer_add_report.rpt");
                    //crypt.Load(@"D:\Fixed_deposite_system\Bank_FD_management\Bank_FD_management\Reports\Customer_add_report.rpt");
                    crypt.RecordSelectionFormula = "{Customer_master.Add_date} >= #" + dtpStartDate.Value.ToString("yyyy-MM-dd") + "# and {Customer_master.Add_date} <= #" + dtpEndDate.Value.ToString("yyyy-MM-dd") + "# ";
                    crypt.DataDefinition.FormulaFields["tdate"].Text = "'" + dtpStartDate.Text + " TO " + dtpEndDate.Text + "'";
                    crypt.Refresh();
                    CrystalReportViewer view1 = new CrystalReportViewer();
                    pnlTitle.Visible = false;
                    pnlDetails.Visible = false;
                    pnlButtons.Visible = false;
                    view1.Dock = DockStyle.Fill;
                    view1.ReportSource = crypt;
                    this.Controls.Add(view1);
                }
                else
                {
                    MessageBox.Show("the given Customer does not exists");
                }
            }


            if (cmbReportType.Text == "Customer FD Report")
            {
                OleDbCommand cmd = new OleDbCommand("Select * from FD_Master where C_ID=" + txtID.Text, Program.conn);
                OleDbDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    ReportDocument crypt = new ReportDocument();
                    crypt.Load(@"C:\Users\HARSH\source\project\Fixed_deposite_system\Bank_FD_management\Bank_FD_management\Reports\ID_Report.rpt");
                    //crypt.Load("C:/Users/Hiremath/source/repos/Fixed_deposite_system/Bank_FD_management/Bank_FD_management/Reports/ID_Report.rpt");
                    //crypt.Load(@"D:\Fixed_deposite_system\Bank_FD_management\Bank_FD_management\Reports\Customer_add_report.rpt");
                    crypt.RecordSelectionFormula = "{FD_master.C_ID} =" + Convert.ToInt32(txtID.Text) + "";
                    crypt.Refresh();
                    CrystalReportViewer view1 = new CrystalReportViewer();
                    pnlTitle.Visible = false;
                    pnlDetails.Visible = false;
                    pnlButtons.Visible = false;
                    view1.Dock = DockStyle.Fill;
                    view1.ReportSource = crypt;
                    this.Controls.Add(view1);
                }
                else
                {
                    MessageBox.Show("the given Customer does not exists");
                }
            }

            if (cmbReportType.Text == "Create FD report")
            {
                OleDbCommand cmd = new OleDbCommand("Select * from FD_Master where Cert_dt >= #" + dtpStartDate.Value.ToString("yyyy-MM-dd") + "# and Cert_dt <= #" + dtpEndDate.Value.ToString("yyyy-MM-dd") + "#", Program.conn);
                OleDbDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    ReportDocument crypt = new ReportDocument();
                    crypt.Load(@"C:\Users\HARSH\source\project\Fixed_deposite_system\Bank_FD_management\Bank_FD_management\Reports\Create_FD_report.rpt");
                    //crypt.Load("C:/Users/Hiremath/source/repos/Fixed_deposite_system/Bank_FD_management/Bank_FD_management/Reports/Create_FD_report.rpt");
                    //crypt.Load(@"D:\Fixed_deposite_system\Bank_FD_management\Bank_FD_management\Reports\Customer_add_report.rpt");
                    crypt.RecordSelectionFormula = "{FD_master.Cert_dt} >= #" + dtpStartDate.Value.ToString("yyyy-MM-dd") + "# and {FD_master.Cert_dt} <= #" + dtpEndDate.Value.ToString("yyyy-MM-dd") + "# ";
                    crypt.DataDefinition.FormulaFields["tdate"].Text = "'" + dtpStartDate.Text + " TO " + dtpEndDate.Text + "'";
                    crypt.Refresh();
                    CrystalReportViewer crp = new CrystalReportViewer();
                    pnlTitle.Visible = false;
                    pnlDetails.Visible = false;
                    pnlButtons.Visible = false;
                    //crp.ReportSource = crypt;
                    //crp.Show();
                    crp.Dock = DockStyle.Fill;
                    crp.ReportSource = crypt;
                    this.Controls.Add(crp);
                }
                else
                {
                    MessageBox.Show("there is no data for given date interval");
                }
            }

            if (cmbReportType.Text == "Break FD report")
            {
                OleDbCommand cmd = new OleDbCommand("Select * from Break_FD where withdraw_dt >= #" + dtpStartDate.Value.ToString("yyyy-MM-dd") + "# and withdraw_dt <= #" + dtpEndDate.Value.ToString("yyyy-MM-dd") + "#", Program.conn);
                OleDbDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    ReportDocument crypt = new ReportDocument();
                    crypt.Load(@"C:\Users\Hiremath\source\repos\Fixed_deposite_system\Bank_FD_management\Bank_FD_management\Reports\Break_FD_Report.rpt");
                    //crypt.Load(@"D:\Fixed_deposite_system\Bank_FD_management\Bank_FD_management\Reports\Customer_add_report.rpt");
                    crypt.RecordSelectionFormula = "{Break_FD.withdraw_dt} >= #" + dtpStartDate.Value.ToString("yyyy-MM-dd") + "# and {Break_FD.withdraw_dt} <= #" + dtpEndDate.Value.ToString("yyyy-MM-dd") + "# ";
                    crypt.DataDefinition.FormulaFields["tdate"].Text = "'" + dtpStartDate.Text + " TO " + dtpEndDate.Text + "'";
                    crypt.Refresh();
                    CrystalReportViewer crp = new CrystalReportViewer();
                    pnlTitle.Visible = false;
                    pnlDetails.Visible = false;
                    pnlButtons.Visible = false;
                    //crp.ReportSource = crypt;
                    //crp.Show();
                    crp.Dock = DockStyle.Fill;
                    crp.ReportSource = crypt;
                    this.Controls.Add(crp);
                }
                else
                {
                    MessageBox.Show("there is no data for given date interval");
                }
            }


            if (cmbReportType.Text == "Amount Wise")
            {
                OleDbCommand cmd = new OleDbCommand("Select * from FD_Master where FD_amount >= " + txtstartamt.Text+ " and FD_amount <= " +txtendamt.Text + "", Program.conn);
                OleDbDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    ReportDocument crypt = new ReportDocument();
                    crypt.Load(@"C:\Users\HARSH\source\project\Fixed_deposite_system\Bank_FD_management\Bank_FD_management\Reports\Amount_wise_FD_report.rpt");
                    //crypt.Load(@"C:\Users\Hiremath\source\repos\Fixed_deposite_system\Bank_FD_management\Bank_FD_management\Reports\Amount_wise_FD_report.rpt");
                    //crypt.Load(@"D:\Fixed_deposite_system\Bank_FD_management\Bank_FD_management\Reports\Customer_add_report.rpt");
                    crypt.RecordSelectionFormula = "{FD_Master.FD_amount} >= " + txtstartamt.Text + " and {FD_Master.FD_amount} <= " + txtendamt.Text + " ";
                    crypt.DataDefinition.FormulaFields["tamount"].Text = "'" + txtstartamt.Text + " TO " + txtendamt.Text + "'";
                    crypt.Refresh();
                    CrystalReportViewer crp = new CrystalReportViewer();
                    pnlTitle.Visible = false;
                    pnlDetails.Visible = false;
                    pnlButtons.Visible = false;
                    //crp.ReportSource = crypt;
                    //crp.Show();
                    crp.Dock = DockStyle.Fill;
                    crp.ReportSource = crypt;
                    this.Controls.Add(crp);
                }
                else
                {
                    MessageBox.Show("there is no data for given date interval");
                }
            }

            if (cmbReportType.Text == "Matured FD Report")
            {
                OleDbCommand cmd = new OleDbCommand("Select * from Break_FD where withdraw_dt >= Mature_dt", Program.conn);
                OleDbDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    ReportDocument crypt = new ReportDocument();
                    crypt.Load(@"C:\Users\HARSH\source\project\Fixed_deposite_system\Bank_FD_management\Bank_FD_management\Reports\Matured_FD_Report.rpt");
                    //crypt.Load(@"C:\Users\Hiremath\source\repos\Fixed_deposite_system\Bank_FD_management\Bank_FD_management\Reports\Matured_FD_Report.rpt");
                    //crypt.Load(@"D:\Fixed_deposite_system\Bank_FD_management\Bank_FD_management\Reports\Customer_add_report.rpt");
                    crypt.RecordSelectionFormula = "{Break_FD.withdraw_dt} >=  {Break_FD.Mature_dt}";
                    crypt.Refresh();
                    CrystalReportViewer crp = new CrystalReportViewer();
                    pnlTitle.Visible = false;
                    pnlDetails.Visible = false;
                    pnlButtons.Visible = false;
                    //crp.ReportSource = crypt;
                    //crp.Show();
                    crp.Dock = DockStyle.Fill;
                    crp.ReportSource = crypt;
                    this.Controls.Add(crp);
                }
                else
                {
                    MessageBox.Show("there is no data for given date interval");
                }
            }


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbReportType_DropDown(object sender, EventArgs e)
        {

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            cmbReportType.SelectedIndex = -1;
            txtID.Text = "";
            btncancel.Enabled = false;
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtID.Text))
            {
                btnViewReport.Enabled = true;
            }
        }

        private void dtpStartDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnViewReport.Focus();
            }
        }

        private void txtstartamt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void txtendamt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }
    }
}
