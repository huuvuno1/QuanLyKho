using QuanLyKho.DAL;
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
            this.cuaHangTableAdapter.Fill(this.quanlykhoDataSet.CuaHang);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm")
            {
                inpName.Enabled = inpAddress.Enabled = inpEmail.Enabled = inpPhone.Enabled = labelMa.Visible = true;
                btnThem.Text = "Lưu";
            } else
            {
                var ten = inpName.Text;
                var diachi = inpAddress.Text;
                var mail = inpEmail.Text;
                var sdt = inpPhone.Text;
                cuaHangTableAdapter.Insert(ten, diachi, mail, sdt);
                btnThem.Text = "Thêm";
                inpName.Enabled = inpAddress.Enabled = inpEmail.Enabled = inpPhone.Enabled = labelMa.Visible = false;
                this.cuaHangTableAdapter.Fill(this.quanlykhoDataSet.CuaHang);
            }
        }

        private void loadDataToForm(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridView1.Rows[e.RowIndex];
            inpMa.Text = row.Cells["MaCh"].Value.ToString();
            inpName.Text = row.Cells["Ten"].Value.ToString();
            inpAddress.Text = row.Cells["DiaChi"].Value.ToString();
            inpEmail.Text = row.Cells["Email"].Value.ToString();
            inpPhone.Text = row.Cells["SDT"].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (btnSua.Text == "Sửa")
            {
                inpName.Enabled = inpAddress.Enabled = inpEmail.Enabled = inpPhone.Enabled = labelMa.Visible = true;
                btnSua.Text = "Lưu thay đổi";
                btnThem.Enabled = false;
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
                cuaHangBindingSource.DataSource = CuaHangDAL.Search("");
            }    
        }
    }
}
