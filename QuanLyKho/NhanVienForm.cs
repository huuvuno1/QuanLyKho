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
                inpGioiTinh.Enabled = true;
                inpAddress.Enabled = inpName.Enabled = inpMail.Enabled = inpPhone.Enabled = true;
                btnAdd.Text = "Lưu";
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
                inpPhone.Text = inpName.Text = inpMail.Text = inpAddress.Text = "";
                inpGioiTinh.Enabled = inpAddress.Enabled = inpName.Enabled = inpMail.Enabled = inpPhone.Enabled = false;

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void bindDataToForm(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dataGridView1.Rows.Count - 1)
            {
                inpMa.Text = inpGioiTinh.Text = inpMail.Text = inpAddress.Text = inpName.Text = "";
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
        }
    }
}
