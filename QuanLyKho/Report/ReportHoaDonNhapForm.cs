using CrystalDecisions.CrystalReports.Engine;
using QuanLyKho.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKho.Report
{
    public partial class ReportHoaDonNhapForm : Form
    {
        public ReportHoaDonNhapForm()
        {
            InitializeComponent();
        }

        private void ReportHoaDonNhapForm_Load(object sender, EventArgs e)
        {
            ReportDocument report = new ReportDocument();
            report.Load(@"D:\code\aspx\QuanLyKho\QuanLyKho\Report\CrystalReport_HoaDonNhap.rpt");
            //report.RecordSelectionFormula = "{tbl_detailOrder.price}";
            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrystalReport_HoaDonNhap crystal = new CrystalReport_HoaDonNhap();
            crystal.SetDataSource(HoaDonNhapDAL.GetHoaDon(float.Parse(inpMinTien.Text), float.Parse(inpMaxTien.Text)));
            crystalReportViewer1.ReportSource = crystal;
            crystalReportViewer1.Refresh();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
