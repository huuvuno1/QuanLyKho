using QuanLyKho.DAL;
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
            comboxProduct.DroppedDown = true;
            FillDataToProductCombobox();
        }

        private void FillDataToProductCombobox()
        {
            var keyword = comboxProduct.Text;
            var products = ProductDAL.search(keyword);
            comboxProduct.DataSource = products;
            comboxProduct.DisplayMember = "Name";
            comboxProduct.ValueMember = "Id";
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
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string now = DateTime.Now.ToString("yyyy-MM-dd");
            BindingList<SpHoaDon> list_sp = (BindingList<SpHoaDon>)listSanPham.DataSource;
            HoaDonNhapDAL.CreateHoaDonNhap(now, "HD_NHAP", 1, list_sp);
            MessageBox.Show("Lưu thành công!");
            list_sp = new BindingList<SpHoaDon>();
            listSanPham.DataSource = list_sp;
        }

        private void comboxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSearchNcc_Click(object sender, EventArgs e)
        {
            comboBoxNcc.DroppedDown = true;
            FillDataToNccCombobox();
        }

        private void btnAddProductToBill_Click(object sender, EventArgs e)
        {
            BindingList<SpHoaDon> sp = (BindingList<SpHoaDon>)listSanPham.DataSource;

            if (sp == null)
            {
                sp = new BindingList<SpHoaDon>();
            }

            var comboNcc = (NhaCungCap)comboBoxNcc.SelectedItem;
            var id_ncc = comboNcc.Id;
            var ten_ncc = comboNcc.Name;

            var comboSp = (Product)comboxProduct.SelectedItem;
            var id_sp = comboSp.Id;
            var ten_sp = comboSp.Name;

            var gia_nhap = float.Parse(inpGiaNhap.Text);
            var so_luong = float.Parse(inpSoLuong.Text);

            bool isExistInList = false;
            foreach (var item in sp)
            {
                if (item.MaSp == id_sp && item.MaNhaCungCap == id_ncc)
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
                sp.Add(new SpHoaDon(id_sp, ten_sp, so_luong, gia_nhap, id_ncc, ten_ncc));

            inpGiaNhap.Text = inpSoLuong.Text = "";

            listSanPham.DataSource = sp;
            listSanPham.Refresh();
            //DataGridViewButtonColumn column = new DataGridViewButtonColumn();
            //column.Name = "remove";
            //column.Text = "Remove";
            //listSanPham.Columns.Add(column);
        }
    }
}
