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

namespace QuanLyKho.Dialog
{
    public partial class FormChiTietSanPham : Form
    {
        private SanPham product;

        public FormChiTietSanPham()
        {
            InitializeComponent();
        }

        public FormChiTietSanPham(SanPham sp)
        {
            this.product = sp;
            InitializeComponent();
        }

        private void FormChiTietSanPham_Load(object sender, EventArgs e)
        {
            if (product != null)
            {
                dataGridViewChiTiet.DataSource = ChiTietSpDAL.Find(product.MaSp);
                inpDonViTinh.Text = product.DonViTinh;
                inpMa.Text = product.MaSp.ToString();
                inpMoTa.Text = product.MoTa;
                inpTen.Text = product.Ten;
            }
        }
    }
}
