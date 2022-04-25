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
    public partial class NhapKhoForm : Form
    {
        public NhapKhoForm()
        {
            InitializeComponent();
        }
        
        private void NhapKhoForm_Load(object sender, EventArgs e)
        {
            FillDataToProductCombobox();
            FillDataToNccCombobox();
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
            if (listSanPham.Columns[e.ColumnIndex].Name == "Remove")
            {
                BindingList<SpHoaDon> list = (BindingList<SpHoaDon>)listSanPham.DataSource;
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
            string now = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            BindingList<SpHoaDon> list_sp = (BindingList<SpHoaDon>)listSanPham.DataSource;
            NhaCungCap ncc = (NhaCungCap)comboBoxNcc.SelectedItem;
            HoaDonNhapDAL.CreateHoaDonNhap(now, 0, ncc.Id, list_sp);
            MessageBox.Show("Lưu thành công!");
            list_sp = new BindingList<SpHoaDon>();
            listSanPham.DataSource = list_sp;
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

            BindingList<SpHoaDon> sp = (BindingList<SpHoaDon>)listSanPham.DataSource;

            if (sp == null)
            {
                sp = new BindingList<SpHoaDon>();
            }

            var comboNcc = (NhaCungCap)comboBoxNcc.SelectedItem;

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
                    var confirmResult = MessageBox.Show("Sản phẩm được nhà cung cấp này cung cấp đã được thêm trước đó.\n Bạn muốn ghi đè không?",
                                     "Cảnh báo!!",
                                     MessageBoxButtons.OKCancel);
                    if (confirmResult == DialogResult.OK)
                    {
                        item.SoLuongNhap = so_luong;
                        item.GiaNhap = gia_nhap;
                    }
                    isExistInList = true;
                }
            }

            if (!isExistInList)
                sp.Add(new SpHoaDon(id_sp, ten_sp, so_luong, gia_nhap));

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
    }
}
