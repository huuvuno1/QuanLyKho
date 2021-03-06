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

namespace QuanLyKho
{
    internal partial class HoaDonNhapKhoForm : Form
    {
        

        public HoaDonNhapKhoForm()
        {
            InitializeComponent();
        }

        private void HoaDonNhapKhoForm_Load(object sender, EventArgs e)
        {
            BindingList<HoaDonNhap> list = HoaDonNhapDAL.GetHoaDon();
            dataGridView.DataSource = list;
        }

        private void ShowDetailHoaDonNhap(object sender, DataGridViewCellEventArgs e)
        {
            BindingList<HoaDonNhap> list = (BindingList<HoaDonNhap>)dataGridView.DataSource;
            if (e.RowIndex < 0 || e.RowIndex > list.Count - 1)
                return;
            if (dataGridView.Columns[e.ColumnIndex].Name == "Detail")
            {
                new NhapKhoForm(list[e.RowIndex]).ShowDialog(this);
            }
        }
    }
}
