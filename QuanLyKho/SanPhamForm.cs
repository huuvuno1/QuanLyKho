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
            btnSave.Enabled = inpTenSp.Enabled  = inpMoTa.Enabled = inpDonVi.Enabled = inpMaSp.Enabled = false;
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
            dataGridViewSp.DataSource = ProductDAL.search(text);
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
                inpTenSp.Text = inpMoTa.Text = inpDonVi.Text = "";
                btnSave.Enabled = inpTenSp.Enabled = inpMoTa.Enabled = inpDonVi.Enabled = false;
                return;
            }
            DataGridViewRow row = dataGridViewSp.Rows[e.RowIndex];
            inpMaSp.Text = row.Cells["MaSp"].Value.ToString();
            inpTenSp.Text = row.Cells["Ten"].Value.ToString();
            inpMoTa.Text = row.Cells["MoTa"].Value.ToString();
            inpDonVi.Text = row.Cells["DonViTinh"].Value.ToString();
            btnSave.Enabled = inpTenSp.Enabled = inpMoTa.Enabled = inpDonVi.Enabled = true;
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
                string donvi = inpDonVi.Text;
                string mota = inpMoTa.Text;
                var result = ProductDAL.UpdateProduct(masp, ten, mota, donvi);
                if (!result.Status)
                {
                    MessageBox.Show("Cập nhật không thành công: " + result.Message, "Có lỗi xảy ra!!!");
                }

                string text = inpSearch.Text;
                dataGridViewSp.DataSource = ProductDAL.search("");
            }
        }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            BindingList<SanPham> products = (BindingList<SanPham>)dataGridViewSp.DataSource;
            if (dataGridViewSp.Columns[e.ColumnIndex].Name == "Detail")
            {
                new FormChiTietSanPham(products[e.RowIndex]).ShowDialog(this);
            }
            else
            {
                SanPham product = products[e.RowIndex];
                inpDonVi.Text = product.DonViTinh;
                inpTenSp.Text = product.Ten;
                inpMaSp.Text = product.MaSp.ToString();
                inpMoTa.Text = product.MoTa;
                inpTenSp.Enabled = inpMoTa.Enabled = inpDonVi.Enabled = true;
                btnSave.Enabled = true;
            }
        }

        private void inpMaSp_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
