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
    public partial class NccForm : Form
    {
        public NccForm()
        {
            InitializeComponent();
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "Thêm")
            {
                inpAddress.Enabled = inpName.Enabled = inpPhoneNumber.Enabled = inpEmail.Enabled = true;
                btnAdd.Text = "Lưu";
                btnEdit.Enabled = btnDelete.Enabled = false;
                btnCancel.Enabled = true;
            }    
            else
            {
                btnAdd.Text = "Thêm";
                string name = inpName.Text;
                string address = inpAddress.Text;
                string phoneNumber = inpPhoneNumber.Text;
                string email = inpEmail.Text;
                this.nhaCungCapTableAdapter1.Insert(name, address, phoneNumber, email);
                dataGridView_Ncc.DataSource = NhaCcDAL.Search("");
                inpEmail.Text = inpName.Text = inpPhoneNumber.Text = inpAddress.Text = "";
                inpAddress.Enabled = inpName.Enabled = inpPhoneNumber.Enabled = inpEmail.Enabled = false;

            }
        }

        private void inpName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void closeingForm(object sender, FormClosingEventArgs e)
        {
            MainForm.Instance.Show();
        }

        private void NccForm_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = btnEdit.Enabled = false;
            inpAddress.Enabled = inpName.Enabled = inpPhoneNumber.Enabled = inpEmail.Enabled = false;
            inpName.Focus();
            dataGridView_Ncc.DataSource = NhaCcDAL.Search("");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            if (btnEdit.Text == "Sửa")
            {
                inpAddress.Enabled = inpName.Enabled = inpPhoneNumber.Enabled = inpEmail.Enabled = true;
                btnAdd.Enabled = btnDelete.Enabled = false;
                btnCancel.Enabled = true;
                btnEdit.Text = "Lưu";
                return;
            }

            string nameOrgin = "", addressOrigin = "", idOrigin = "", emailOrigin = "", phoneOrigin = "";

            foreach (DataGridViewRow row in dataGridView_Ncc.SelectedRows)
            {
                 nameOrgin = row.Cells["Ten"].Value.ToString();
                 addressOrigin = row.Cells["DiaChi"].Value.ToString();
                 idOrigin = row.Cells["MaNcc"].Value.ToString();
                 emailOrigin = row.Cells["Email"].Value.ToString();
                 phoneOrigin = row.Cells["SDT"].Value.ToString();
            }

            string id = inpMa.Text;
            string name = inpName.Text;
            string address = inpAddress.Text;
            string phoneNumber = inpPhoneNumber.Text;
            string email = inpEmail.Text;
            this.nhaCungCapTableAdapter1.Update(name, address, email, phoneNumber, int.Parse(id), nameOrgin, addressOrigin, emailOrigin, phoneOrigin);
            dataGridView_Ncc.DataSource = NhaCcDAL.Search("");
            btnCancel_Click(null, null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int ma_ncc = int.Parse(inpMa.Text);
            Result result = NhaCcDAL.Detele(ma_ncc);
            if (result.Status)
            {
                MessageBox.Show("Xóa thành công!");
            } 
            else
            {
                MessageBox.Show(result.Message);
                return;
            }    
            dataGridView_Ncc.DataSource = NhaCcDAL.Search(""); 
            inpMa.Text = inpEmail.Text = inpName.Text = inpPhoneNumber.Text = inpAddress.Text = "";
            btnEdit.Enabled = btnDelete.Enabled = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            inpMa.Text = inpEmail.Text = inpName.Text = inpPhoneNumber.Text = inpAddress.Text = "";
            btnEdit.Enabled = btnDelete.Enabled = btnCancel.Enabled = false;
            btnAdd.Text = "Thêm";
            btnEdit.Text = "Sửa";
            btnAdd.Enabled = true;
        }

        private void selectRow(object sender, EventArgs e)
        {
            
        }

        private void selectRow(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || btnAdd.Text == "Lưu")
                return;
            btnDelete.Enabled = btnEdit.Enabled = true;
            var row = dataGridView_Ncc.Rows[e.RowIndex];
            inpName.Text = row.Cells["Ten"].Value.ToString();
            inpAddress.Text = row.Cells["DiaChi"].Value.ToString();
            inpMa.Text = row.Cells["MaNcc"].Value.ToString();
            inpEmail.Text = row.Cells["Email"].Value.ToString();
            inpPhoneNumber.Text = row.Cells["SDT"].Value.ToString();
            //inpAddress.Enabled = inpName.Enabled = inpPhoneNumber.Enabled = inpEmail.Enabled = true;
        }
    }
}
