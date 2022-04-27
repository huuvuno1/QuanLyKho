using QuanLyKho.DAL;
using QuanLyKho.Model;
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
    public partial class CuaHangForm : Form
    {
        public CuaHangForm()
        {
            InitializeComponent();
        }

        private void CuaHangForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanlykhoDataSet.CuaHang' table. You can move, or remove it, as needed.
            dataGridView1.DataSource = CuaHangDAL.SearchList("");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm")
            {
                inpName.Enabled = inpAddress.Enabled = inpEmail.Enabled = inpPhone.Enabled = labelMa.Visible = true;
                inpName.Text = inpAddress.Text = inpEmail.Text = inpPhone.Text = inpMa.Text = "";
                btnThem.Text = "Lưu";
                btnHuy.Enabled = true;
                btnSua.Enabled = btnXoa.Enabled = false;
            } else
            {
                var ten = inpName.Text;
                var diachi = inpAddress.Text;
                var mail = inpEmail.Text;
                var sdt = inpPhone.Text;
                cuaHangTableAdapter.Insert(ten, diachi, mail, sdt);
                btnThem.Text = "Thêm";
                inpName.Enabled = inpAddress.Enabled = inpEmail.Enabled = inpPhone.Enabled = labelMa.Visible = false;
                dataGridView1.DataSource = CuaHangDAL.SearchList("");
            }
        }

        private void loadDataToForm(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || btnThem.Text == "Lưu")
                return;
            var row = dataGridView1.Rows[e.RowIndex];
            inpMa.Text = row.Cells["MaCh"].Value.ToString();
            inpName.Text = row.Cells["Ten"].Value.ToString();
            inpAddress.Text = row.Cells["DiaChi"].Value.ToString();
            inpEmail.Text = row.Cells["Email"].Value.ToString();
            inpPhone.Text = row.Cells["SDT"].Value.ToString();
            btnXoa.Enabled = btnSua.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (btnSua.Text == "Sửa")
            {
                inpName.Enabled = inpAddress.Enabled = inpEmail.Enabled = inpPhone.Enabled = labelMa.Visible = true;
                btnSua.Text = "Lưu thay đổi";
                btnThem.Enabled = btnXoa.Enabled = false;
                btnHuy.Enabled = true;
            }
            else
            {
                var confirmResult = MessageBox.Show("Bạn chắc chắn muốn lưu thay này?",
                                     "Xác nhận!!",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    var ma = int.Parse(inpMa.Text);
                    var ten = inpName.Text;
                    var diachi = inpAddress.Text;
                    var email = inpEmail.Text;
                    var sdt = inpPhone.Text;
                    var result = CuaHangDAL.Update(ma, ten, diachi, email, sdt);

                    if (!result.Status)
                    {
                        MessageBox.Show("Cập nhật không thành công: " + result.Message, "Có lỗi xảy ra!!!");
                    }
                }
                inpName.Enabled = inpAddress.Enabled = inpEmail.Enabled = inpPhone.Enabled = labelMa.Visible = false;
                btnSua.Text = "Sửa";
                btnThem.Enabled = true;
                dataGridView1.DataSource = CuaHangDAL.SearchList("");
            }    
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            inpName.Enabled = inpAddress.Enabled = inpEmail.Enabled = inpPhone.Enabled = labelMa.Visible = false;
            btnThem.Enabled = true;
            btnThem.Text = "Thêm";
            btnSua.Text = "Sửa";
            btnSua.Enabled = btnXoa.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (inpMa.Text == "")
                return;
            //BindingList<CuaHang> list = (BindingList<CuaHang>)dataGridView1.DataSource;
            var confirmResult = MessageBox.Show("Bạn chắc chắn muốn lưu thay này?",
                                     "Xác nhận!!",
                                 MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Result result = CuaHangDAL.Delete(int.Parse(inpMa.Text));
                if (!result.Status)
                {
                    MessageBox.Show(result.Message);
                }
                dataGridView1.DataSource = CuaHangDAL.SearchList("");
            }
        }
    }
}
