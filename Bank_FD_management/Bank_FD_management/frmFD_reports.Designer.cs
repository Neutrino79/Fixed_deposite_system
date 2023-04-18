﻿namespace Bank_FD_management
{
    partial class frmFD_reports
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
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblReport_Type = new System.Windows.Forms.Label();
            this.cmbReportType = new System.Windows.Forms.ComboBox();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnViewReport = new System.Windows.Forms.Button();
            this.pnlTitle.SuspendLayout();
            this.pnlDetails.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.LightGray;
            this.pnlTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Location = new System.Drawing.Point(10, 11);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(1094, 60);
            this.pnlTitle.TabIndex = 7;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(431, 7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(209, 42);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "FD Reports";
            // 
            // pnlDetails
            // 
            this.pnlDetails.BackColor = System.Drawing.Color.LightGray;
            this.pnlDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDetails.Controls.Add(this.txtID);
            this.pnlDetails.Controls.Add(this.lblID);
            this.pnlDetails.Controls.Add(this.dtpEndDate);
            this.pnlDetails.Controls.Add(this.dtpStartDate);
            this.pnlDetails.Controls.Add(this.lblEndDate);
            this.pnlDetails.Controls.Add(this.lblStartDate);
            this.pnlDetails.Controls.Add(this.lblReport_Type);
            this.pnlDetails.Controls.Add(this.cmbReportType);
            this.pnlDetails.Location = new System.Drawing.Point(13, 82);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Size = new System.Drawing.Size(1091, 434);
            this.pnlDetails.TabIndex = 8;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(469, 224);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(163, 29);
            this.txtID.TabIndex = 53;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(384, 227);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(79, 24);
            this.lblID.TabIndex = 54;
            this.lblID.Text = "Cust ID :";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(469, 263);
            this.dtpEndDate.MaxDate = new System.DateTime(2023, 1, 7, 23, 15, 14, 0);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(181, 29);
            this.dtpEndDate.TabIndex = 52;
            this.dtpEndDate.Value = new System.DateTime(2023, 1, 7, 0, 0, 0, 0);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(469, 185);
            this.dtpStartDate.MaxDate = new System.DateTime(2023, 1, 7, 23, 15, 14, 0);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(181, 29);
            this.dtpStartDate.TabIndex = 51;
            this.dtpStartDate.Value = new System.DateTime(2023, 1, 7, 0, 0, 0, 0);
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(371, 265);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(96, 24);
            this.lblEndDate.TabIndex = 50;
            this.lblEndDate.Text = "End date :";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(370, 188);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(97, 24);
            this.lblStartDate.TabIndex = 49;
            this.lblStartDate.Text = "Start date :";
            // 
            // lblReport_Type
            // 
            this.lblReport_Type.AutoSize = true;
            this.lblReport_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReport_Type.Location = new System.Drawing.Point(282, 111);
            this.lblReport_Type.Name = "lblReport_Type";
            this.lblReport_Type.Size = new System.Drawing.Size(181, 24);
            this.lblReport_Type.TabIndex = 48;
            this.lblReport_Type.Text = "Select Report Type :";
            this.lblReport_Type.Click += new System.EventHandler(this.lblReport_Type_Click);
            // 
            // cmbReportType
            // 
            this.cmbReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReportType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbReportType.ForeColor = System.Drawing.Color.Black;
            this.cmbReportType.FormattingEnabled = true;
            this.cmbReportType.Items.AddRange(new object[] {
            "Customer wise Report",
            "Date wise report"});
            this.cmbReportType.Location = new System.Drawing.Point(469, 108);
            this.cmbReportType.Name = "cmbReportType";
            this.cmbReportType.Size = new System.Drawing.Size(234, 32);
            this.cmbReportType.TabIndex = 0;
            this.cmbReportType.SelectedIndexChanged += new System.EventHandler(this.cmbReportType_SelectedIndexChanged);
            this.cmbReportType.TextChanged += new System.EventHandler(this.cmbReportType_TextChanged);
            this.cmbReportType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbReportType_KeyDown);
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.LightGray;
            this.pnlButtons.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlButtons.Controls.Add(this.btnExit);
            this.pnlButtons.Controls.Add(this.btnViewReport);
            this.pnlButtons.Location = new System.Drawing.Point(13, 527);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(1091, 60);
            this.pnlButtons.TabIndex = 9;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(629, 9);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(130, 38);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnViewReport
            // 
            this.btnViewReport.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnViewReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewReport.Location = new System.Drawing.Point(365, 9);
            this.btnViewReport.Name = "btnViewReport";
            this.btnViewReport.Size = new System.Drawing.Size(159, 38);
            this.btnViewReport.TabIndex = 2;
            this.btnViewReport.Text = "View Report";
            this.btnViewReport.UseVisualStyleBackColor = false;
            this.btnViewReport.Click += new System.EventHandler(this.btnViewReport_Click);
            // 
            // frmFD_reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 599);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlDetails);
            this.Controls.Add(this.pnlTitle);
            this.Name = "frmFD_reports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFD_reports";
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.ComboBox cmbReportType;
        private System.Windows.Forms.Label lblReport_Type;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnViewReport;
        private System.Windows.Forms.Button btnExit;
    }
}