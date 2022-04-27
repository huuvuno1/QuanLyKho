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

namespace QuanLyKho
{
    public partial class NhanVienForm : Form
    {
        public NhanVienForm()
        {
            InitializeComponent();
        }

        private void NhanVienForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanlykhoDataSet.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.quanlykhoDataSet.NhanVien);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "Thêm")
            {
                inpGioiTinh.Enabled = btnCancel.Enabled = true;
                inpAddress.Enabled = inpName.Enabled = inpMail.Enabled = inpPhone.Enabled = inpUsername.Enabled = true;
                btnAdd.Text = "Lưu";
                btnCancel.Enabled = true;
                btnEdit.Enabled = btnDelete.Enabled = false;
                inpMa.Text = inpGioiTinh.Text = inpMail.Text = inpAddress.Text = inpName.Text = inpUsername.Text = "";
            }
            else
            {
                btnAdd.Text = "Thêm";
                string gender = inpGioiTinh.Text; 
                string name = inpName.Text;    
                string address = inpAddress.Text;
                string phoneNumber = inpMail.Text;
                string email = inpPhone.Text;

                this.nhanVienTableAdapter.Insert(name, phoneNumber, email, address, gender, email, "huuvuno1");
                this.nhanVienTableAdapter.Fill(this.quanlykhoDataSet.NhanVien);
                inpMa.Text = inpGioiTinh.Text = inpMail.Text = inpAddress.Text = inpPhone.Text = inpName.Text = "";
                inpGioiTinh.Enabled = inpAddress.Enabled = inpName.Enabled = inpMail.Enabled = inpUsername.Enabled = inpPhone.Enabled = false;

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int ma_nv = int.Parse(inpMa.Text);
            Result result = NhanVienDAL.Delete(ma_nv);
            if (result.Status)
            {
                MessageBox.Show("Xóa thành công!");
                this.nhanVienTableAdapter.Fill(this.quanlykhoDataSet.NhanVien);
                btnCancel_Click(null, null);
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra: " + result.Message);
            }    
        }

        private void bindDataToForm(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (btnAdd.Text == "Lưu")
                return;



            if (e.RowIndex < 0 || e.RowIndex >= dataGridView1.Rows.Count - 1)
            {
                inpMa.Text = inpGioiTinh.Text = inpMail.Text = inpAddress.Text = inpUsername.Text = inpPhone.Text = inpName.Text = "";
                inpPhone.Enabled = false;
                return;
            }
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            if (row == null)
                return;
            inpMa.Text = row.Cells["MaNv"].Value.ToString();
            inpGioiTinh.Text = row.Cells["GioiTinh"].Value.ToString();
            inpMail.Text = row.Cells["Email"].Value.ToString();
            inpAddress.Text = row.Cells["DiaChi"].Value.ToString();
            inpName.Text = row.Cells["Ten"].Value.ToString();
            inpPhone.Text = row.Cells["SDT"].Value.ToString();
            inpUsername.Text = row.Cells["Username"].Value.ToString();
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Text == "Sửa")
            {
                inpGioiTinh.Enabled = inpAddress.Enabled = inpName.Enabled = inpMail.Enabled = inpUsername.Enabled = inpPhone.Enabled = true;
                btnEdit.Text = "Cập nhật";
                btnAdd.Enabled = btnDelete.Enabled = false;
                btnCancel.Enabled = true;
                return;
            }
            btnEdit.Text = "Sửa";
            NhanVienDAL.Update(int.Parse(inpMa.Text), inpName.Text, inpGioiTinh.Text, inpAddress.Text, inpMail.Text, inpPhone.Text, inpUsername.Text);
            btnCancel_Click(null, null);
            this.nhanVienTableAdapter.Fill(this.quanlykhoDataSet.NhanVien);
            MessageBox.Show("Sửa thành công!");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            inpGioiTinh.Enabled = inpAddress.Enabled = inpName.Enabled = 
                btnCancel.Enabled = btnEdit.Enabled = btnDelete.Enabled = 
                inpMail.Enabled = inpPhone.Enabled = inpUsername.Enabled = false;
            inpMa.Text = inpGioiTinh.Text = inpMail.Text = inpAddress.Text = inpUsername.Text = inpPhone.Text = inpName.Text = "";
            btnAdd.Enabled = true;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnAdd.Text = "Thêm";
            btnEdit.Text = "Sửa";

        }

        private void loaddata(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellBorderStyleChanged(object sender, EventArgs e)
        {

        }
    }
}
