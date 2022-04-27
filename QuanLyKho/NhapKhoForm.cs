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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKho
{
    internal partial class NhapKhoForm : Form
    {
        private HoaDonNhap billDetail;

        public NhapKhoForm()
        {
            InitializeComponent();
        }

        public NhapKhoForm(HoaDonNhap bill)
        {
            billDetail = bill;
            InitializeComponent();
        }

        private void NhapKhoForm_Load(object sender, EventArgs e)
        {
            // form nhập bình thường
            if (billDetail == null)
            {
                FillDataToProductCombobox();
                FillDataToNccCombobox();
            }
            // form được mở để xem chi tiết
            else
            {
                NhapKhoForm_Load_Bill_Detail();
            }
        }

        private void NhapKhoForm_Load_Bill_Detail()
        {
            DisableAllButton();
            this.Text = "Chi tiết hóa đơn " + billDetail.MaHD;

            // load data to combobox ncc
            var cb_ncc = new BindingList<NhaCungCap>();
            cb_ncc.Add(new NhaCungCap(billDetail.MaNhaCungCap, billDetail.TenNhaCungCap));
            comboBoxNcc.DataSource = cb_ncc;
            comboBoxNcc.DisplayMember = "Name";
            comboBoxNcc.ValueMember = "Id";

            // load info created bill by employee
            inpMaNv.Visible = inpTenNv.Visible = labelMaNv.Visible = labelTenNv.Visible = true;
            inpMaNv.Text = billDetail.MaNhanVienLap.ToString();
            inpTenNv.Text = billDetail.TenNhanVienLap;

            // load list products in bill
            listSanPham.DataSource = HoaDonNhapDAL.GetProductsInBill(billDetail.MaHD);
        }

        private void DisableAllButton()
        {
            comboxProduct.Enabled = comboBoxNcc.Enabled = inpSoLuong.Enabled = inpGiaNhap.Enabled = false;
            btnAddProductToBill.Enabled = btnSearchNcc.Enabled = button1.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = false;
        }

        private void inpSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchProducts(object sender, EventArgs e)
        {
            
            //comboxProduct.Items.Add
        }

        private void SearchProducts(object sender, KeyEventArgs e)
        {
            
        }

        private void valueChange(object sender, EventArgs e)
        {
            comboxProduct.DroppedDown = true;
        }

        private void kkkk(object sender, EventArgs e)
        {
            comboxProduct.DroppedDown = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FillDataToProductCombobox();
            comboxProduct.DroppedDown = true;
        }

        private void FillDataToProductCombobox()
        {
            var keyword = comboxProduct.Text;
            var products = ProductDAL.search(keyword);
            comboxProduct.DataSource = products;
            comboxProduct.DisplayMember = "Ten";
            comboxProduct.ValueMember = "MaSp";
        }

        private void FillDataToNccCombobox()
        {
            var keyword = comboBoxNcc.Text;
            var ncc = NhaCcDAL.SearchList(keyword);
            comboBoxNcc.DataSource = ncc;
            comboBoxNcc.DisplayMember = "Name";
            comboBoxNcc.ValueMember = "Id";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form ncc = new NccForm();
            ncc.ShowDialog(this);
        }

        private void listSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BindingList<SpHoaDonNhap> list = (BindingList<SpHoaDonNhap>)listSanPham.DataSource;
            if (list == null || list.Count == 0)
                return;
            if (listSanPham.Columns[e.ColumnIndex].Name == "Remove")
            {
                for(var i = 0; i < list.Count; i++)
                {
                    if (i == e.RowIndex)
                    {
                        list.Remove(list[i]);
                    }
                }
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            BindingList<SpHoaDonNhap> list_sp = (BindingList<SpHoaDonNhap>)listSanPham.DataSource;
            if (list_sp == null || list_sp.Count == 0)
            {
                MessageBox.Show("Cảnh báo!", "Bạn chưa thêm sản phẩm nào!");
                return;
            } 
            var result = MessageBox.Show("Hoàn thành đơn nhập hàng?", "Xác nhận!", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                string now = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                NhaCungCap ncc = (NhaCungCap)comboBoxNcc.SelectedItem;
                NhanVien nv = (NhanVien)MyApplication.Get("user_login");
                HoaDonNhapDAL.CreateHoaDonNhap(now, nv.MaNv, ncc.Id, list_sp);
                MessageBox.Show("Lưu thành công!");
                list_sp.Clear();
            }
        }

        private void btnSearchNcc_Click(object sender, EventArgs e)
        {
            FillDataToNccCombobox();
            comboBoxNcc.DroppedDown = true;
        }

        private void btnAddProductToBill_Click(object sender, EventArgs e)
        {
            if (!IsNumber(inpSoLuong.Text) && !IsNumber(inpSoLuong.Text))
            {
                MessageBox.Show("Cảnh báo", "Bạn phải nhập dữ liệu hợp lệ!");
                return;
            }

            BindingList<SpHoaDonNhap> sp = (BindingList<SpHoaDonNhap>)listSanPham.DataSource;

            if (sp == null)
            {
                sp = new BindingList<SpHoaDonNhap>();
            }

            var comboSp = (SanPham)comboxProduct.SelectedItem;
            var id_sp = comboSp.MaSp;
            var ten_sp = comboSp.Ten;

            var gia_nhap = float.Parse(inpGiaNhap.Text);
            var so_luong = float.Parse(inpSoLuong.Text);

            bool isExistInList = false;
            foreach (var item in sp)
            {
                if (item.MaSp == id_sp)
                {
                    var confirmResult = MessageBox.Show("Sản phẩm được đã được thêm vào hóa đơn.\n Bạn muốn ghi đè không?",
                                     "Cảnh báo!!",
                                     MessageBoxButtons.OKCancel);
                    if (confirmResult == DialogResult.OK)
                    {
                        item.SoLuongNhap = so_luong;
                        item.GiaNhap = gia_nhap;
                    }
                    isExistInList = true;
                    break;
                }
            }

            if (!isExistInList)
                sp.Add(new SpHoaDonNhap(id_sp, ten_sp, so_luong, gia_nhap));

            inpGiaNhap.Text = inpSoLuong.Text = "";

            listSanPham.DataSource = sp;
            listSanPham.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var result = new FormThemSanPham().ShowDialog();
            if (result == DialogResult.Cancel)
            {
                FillDataToProductCombobox();
            }
        }

        private void ShowData(object sender, EventArgs e)
        {
            
        }

        private void ValidateSoLuong(object sender, CancelEventArgs e)
        {
            if (!IsNumber(inpSoLuong.Text))
            {
                errorProviderSoLuong.SetError(inpSoLuong, "Bạn phải nhập số!");
            }
            else
            {
                errorProviderSoLuong.Clear();
            }
        }

        private void ValidateGiaNhap(object sender, CancelEventArgs e)
        {
            if (!IsNumber(inpGiaNhap.Text))
            {
                errorProviderGiaNhap.SetError(inpGiaNhap, "Bạn phải nhập số!");
            }
            else
            {
                errorProviderGiaNhap.Clear();
            }
        }

        bool IsNumber(string text)
        {
            return !string.IsNullOrWhiteSpace(text) && Regex.IsMatch(text, "^[0-9]*$");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
