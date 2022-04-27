using CrystalDecisions.CrystalReports.Engine;
using QuanLyKho.DAL;
using QuanLyKho.Model;
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
    public partial class ReportHoaDonXuatForm : Form
    {
        public ReportHoaDonXuatForm()
        {
            InitializeComponent();
        }

        private void ReportHoaDonXuatForm_Load(object sender, EventArgs e)
        {
            //ReportDocument report = new ReportDocument();
            //report.Load(@"D:\code\aspx\QuanLyKho\QuanLyKho\Report\CrystalReport_HoaDonXuat.rpt");
            //report.RecordSelectionFormula = "{tbl_detailOrder.price}";
            var report = new CrystalReport_HoaDonXuat();
            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.RefreshReport();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            CrystalReport_HoaDonXuat crystal = new CrystalReport_HoaDonXuat();
            crystal.SetDataSource(HoaDonXuatDAL.GetHoaDon(inpName.Text));
            crystalReportViewer1.ReportSource = crystal;
            crystalReportViewer1.Refresh();
        }
    }
}
