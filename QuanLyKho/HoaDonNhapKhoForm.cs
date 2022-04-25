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
    public partial class HoaDonNhapKhoForm : Form
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
    }
}
