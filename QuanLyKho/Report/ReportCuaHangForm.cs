using CrystalDecisions.CrystalReports.Engine;
using QuanLyKho.DAL;
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
    public partial class ReportCuaHangForm : Form
    {
        public ReportCuaHangForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            ReportDocument report = new ReportDocument();
            report.Load(@"D:\code\aspx\QuanLyKho\QuanLyKho\Report\CrystalReport_CuaHang.rpt");
            //report.RecordSelectionFormula = "{tbl_detailOrder.price}";
            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.RefreshReport();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var dataTable = CuaHangDAL.Search(inpSearch.Text);
            CrystalReport_CuaHang category = new CrystalReport_CuaHang();
            category.SetDataSource(dataTable);
            crystalReportViewer1.ReportSource = category;
            crystalReportViewer1.Refresh();
        }
    }
}
