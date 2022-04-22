using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKho.Report
{
    public partial class ReportSanPhamForm : Form
    {
        public ReportSanPhamForm()
        {
            InitializeComponent();
        }

        private void ReportSanPhamForm_Load(object sender, EventArgs e)
        {
            ReportDocument report = new ReportDocument();
            report.Load(@"D:\code\aspx\QuanLyKho\QuanLyKho\Report\CrystalReport_SanPham.rpt");
            //report.RecordSelectionFormula = "{tbl_detailOrder.price}";
            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.RefreshReport();
        }
    }
}
