using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ReportsApplication2
{
    public partial class Form1 : Form
    {
        Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        public Form1()
        {
            InitializeComponent();

            reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            reportViewer1.Dock = DockStyle.Fill;          
            reportViewer1.LocalReport.ReportPath = "Report1.rdlc";
            this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.Controls.Add(reportViewer1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            this.reportViewer1.RefreshReport();
        }
    }
}