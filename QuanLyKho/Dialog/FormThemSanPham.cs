using QuanLyKho.DAL;
using QuanLyKho.Utils;
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
    public partial class FormThemSanPham : Form
    {
        public FormThemSanPham()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inpDonViTinh.Text = inpMoTa.Text = inpTen.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var action = MessageBox.Show("Xác nhận!", "Bạn xác nhận thêm sản phẩm này?", MessageBoxButtons.OKCancel);
            if (DialogResult.OK == action)
            {
                var ten = inpTen.Text;
                var mota = inpMoTa.Text;
                var donvitinh = inpDonViTinh.Text;
                Result result = ProductDAL.Save(ten, donvitinh, mota);
                if (result.Status == false)
                {
                    MessageBox.Show("Lỗi!", "Có lỗi xảy ra: " + result.Message);
                }
                else
                {
                    MessageBox.Show("Thành công!", "Đã lưu sản phẩm");
                    inpDonViTinh.Text = inpMoTa.Text = inpTen.Text = "";
                }
            }
        }
    }
}
