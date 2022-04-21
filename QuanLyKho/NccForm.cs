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
            }    
            else
            {
                btnAdd.Text = "Thêm";
                string name = inpName.Text;
                string address = inpAddress.Text;
                string phoneNumber = inpPhoneNumber.Text;
                string email = inpEmail.Text;
                this.nhaCungCapTableAdapter1.Insert(name, address, phoneNumber, email);
                this.nhaCungCapTableAdapter1.Fill(this.quanlykhoDataSet.NhaCungCap);
                inpEmail.Text = inpName.Text = inpPhoneNumber.Text = inpAddress.Text = "";
                inpAddress.Enabled = inpName.Enabled = inpPhoneNumber.Enabled = inpEmail.Enabled = false;

            }
        }

        private void inpName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void selectRow(object sender, EventArgs e)
        {
            btnDelete.Enabled = btnEdit.Enabled = true;
            foreach(DataGridViewRow row in dataGridView1.SelectedRows)
            {
                inpName.Text = row.Cells["Ten"].Value.ToString();
                inpAddress.Text = row.Cells["DiaChi"].Value.ToString();
                inpMa.Text = row.Cells["MaNcc"].Value.ToString();
                inpEmail.Text = row.Cells["Email"].Value.ToString();
                inpPhoneNumber.Text = row.Cells["SDT"].Value.ToString();
            }
            inpAddress.Enabled = inpName.Enabled = inpPhoneNumber.Enabled = inpEmail.Enabled = true;
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
            this.nhaCungCapTableAdapter1.Fill(this.quanlykhoDataSet.NhaCungCap);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            if (inpMa.Text == "")
                return;

            string nameOrgin = "", addressOrigin = "", idOrigin = "", emailOrigin = "", phoneOrigin = "";

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
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
            this.nhaCungCapTableAdapter1.Fill(this.quanlykhoDataSet.NhaCungCap);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string nameOrgin = "", addressOrigin = "", idOrigin = "", emailOrigin = "", phoneOrigin = "";

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                nameOrgin = row.Cells["Ten"].Value.ToString();
                addressOrigin = row.Cells["DiaChi"].Value.ToString();
                idOrigin = row.Cells["MaNcc"].Value.ToString();
                emailOrigin = row.Cells["Email"].Value.ToString();
                phoneOrigin = row.Cells["SDT"].Value.ToString();
            }
            this.nhaCungCapTableAdapter1.Delete(int.Parse(idOrigin), nameOrgin, addressOrigin, emailOrigin, phoneOrigin);
            this.nhaCungCapTableAdapter1.Fill(this.quanlykhoDataSet.NhaCungCap);
            inpMa.Text = inpEmail.Text = inpName.Text = inpPhoneNumber.Text = inpAddress.Text = "";
            btnEdit.Enabled = btnDelete.Enabled = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
