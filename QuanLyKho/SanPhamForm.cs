using QuanLyKho.DAL;
using QuanLyKho.Dialog;
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
    public partial class SanPhamForm : Form
    {
        public SanPhamForm()
        {
            InitializeComponent();
            dataGridViewSp.DataSource = ProductDAL.search("");
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            btnSave.Enabled = inpTenSp.Enabled = inpGiaSp.Enabled = inpMoTa.Enabled = inpDonVi.Enabled = inpSL.Enabled = false;
        }

        private void inpName_TextChanged(object sender, EventArgs e)
        {

        }

        private void inpName_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string text = inpSearch.Text;
            sanPhamBindingSource.DataSource = ProductDAL.SearchProduct(text);
            //this.sanPhamTableAdapter.Fill(this.quanlykhoDataSet.SanPham);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void loadRowToForm(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dataGridViewSp.Rows.Count - 1)
            {
                inpTenSp.Text = inpGiaSp.Text = inpMoTa.Text = inpDonVi.Text = inpSL.Text = "";
                btnSave.Enabled = inpTenSp.Enabled = inpGiaSp.Enabled = inpMoTa.Enabled = inpDonVi.Enabled = inpSL.Enabled = false;
                return;
            }
            DataGridViewRow row = dataGridViewSp.Rows[e.RowIndex];
            inpMaSp.Text = row.Cells["MaSp"].Value.ToString();
            inpTenSp.Text = row.Cells["Ten"].Value.ToString();
            inpGiaSp.Text = row.Cells["GiaTien"].Value.ToString();
            inpMoTa.Text = row.Cells["MoTa"].Value.ToString();
            inpDonVi.Text = row.Cells["DonViTinh"].Value.ToString();
            inpSL.Text = row.Cells["SoLuong"].Value.ToString();
            btnSave.Enabled = inpTenSp.Enabled = inpGiaSp.Enabled = inpMoTa.Enabled = inpDonVi.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Bạn chắc chắn muốn lưu thay này?",
                                     "Xác nhận!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                int masp = int.Parse(inpMaSp.Text);
                string ten = inpTenSp.Text;
                float gia = 0;
                float.TryParse(inpGiaSp.Text, out gia);
                string donvi = inpDonVi.Text;
                string mota = inpMoTa.Text;
                float soluong = 0;
                float.TryParse(inpSL.Text, out soluong);
                var result = ProductDAL.UpdateProduct(masp, ten, mota, donvi, gia);
                if (!result.Status)
                {
                    MessageBox.Show("Cập nhật không thành công: " + result.Message, "Có lỗi xảy ra!!!");
                }

                string text = inpSearch.Text;
                sanPhamBindingSource.DataSource = ProductDAL.SearchProduct(text);
            }
        }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (dataGridViewSp.Columns[e.ColumnIndex].Name == "Detail")
            {
                BindingList<SanPham> products = (BindingList<SanPham>)dataGridViewSp.DataSource;
                new FormChiTietSanPham(products[e.RowIndex]).ShowDialog(this);
            }
        }
    }
}
