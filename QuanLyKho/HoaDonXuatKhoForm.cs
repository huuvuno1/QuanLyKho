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
    public partial class HoaDonXuatKhoForm : Form
    {
        public HoaDonXuatKhoForm()
        {
            InitializeComponent();
        }

        private void HoaDonXuatKhoForm_Load(object sender, EventArgs e)
        {
            dataGridView.DataSource = HoaDonXuatDAL.GetHoaDon();
        }

        private void ShowDetailHoaDonXuat(object sender, DataGridViewCellEventArgs e)
        {
            BindingList<HoaDonXuat> list = (BindingList<HoaDonXuat>)dataGridView.DataSource;
            if (e.RowIndex < 0 || e.RowIndex > list.Count - 1)
                return;
            if (dataGridView.Columns[e.ColumnIndex].Name == "Detail")
            {
                new XuatKhoForm(list[e.RowIndex]).ShowDialog(this);
            }
        }
    }
}
