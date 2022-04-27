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
    internal partial class XuatKhoForm : Form
    {
        private HoaDonXuat billDetail;

        public XuatKhoForm()
        {
            InitializeComponent();
        }

        public XuatKhoForm(HoaDonXuat bill)
        {
            billDetail = bill;
            InitializeComponent();
        }

        private void XuatKhoForm_Load(object sender, EventArgs e)
        {
            // form nhập bình thường
            if (billDetail == null)
            {
                FillDataToProductCombobox();
                comboxProduct.Focus();
                FillDataToCuaHangCombobox();
                listSanPham.DataSource = new BindingList<SpHoaDonXuat>();
            }
            // form được mở để xem chi tiết
            else
            {
                XuatKhoForm_Load_Bill_Detail();
            }
            
        }


        private void XuatKhoForm_Load_Bill_Detail()
        {
            DisableAllButton();
            this.Text = "Chi tiết hóa đơn xuất " + billDetail.MaHD;

            var cb_ch = new BindingList<CuaHang>();
            cb_ch.Add(new CuaHang(billDetail.MaCuaHang, billDetail.TenCuaHang));
            comboBoxCH.DataSource = cb_ch;
            comboBoxCH.DisplayMember = "Ten";
            comboBoxCH.ValueMember = "MaCh";

            // load info created bill by employee
            inpMaNv.Visible = inpTenNv.Visible = labelMaNv.Visible = labelTenNv.Visible = true;
            inpMaNv.Text = billDetail.MaNhanVienLap.ToString();
            inpTenNv.Text = billDetail.TenNhanVienLap;

            // load list products in bill
            listSanPham.DataSource = HoaDonXuatDAL.GetProductsInBill(billDetail.MaHD);
        }

        private void DisableAllButton()
        {
            comboxProduct.Enabled = comboBoxCH.Enabled = inpSoLuong.Enabled = comboBoxGiaXuat.Enabled = false;
            btnAddProductToBill.Enabled = btnSearchNcc.Enabled = button1.Enabled = button4.Enabled = button5.Enabled = false;
        }

        private void FillDataToProductCombobox()
        {
            var keyword = comboxProduct.Text;
            var products = ProductDAL.search(keyword);
            comboxProduct.DataSource = products;
            comboxProduct.DisplayMember = "Ten";
            comboxProduct.ValueMember = "MaSp";
        }

        private void FillDataToCuaHangCombobox()
        {
            var keyword = comboBoxCH.Text;
            var result = CuaHangDAL.SearchList(keyword);
            comboBoxCH.DataSource = result;
            comboBoxCH.DisplayMember = "Ten";
            comboBoxCH.ValueMember = "MaCh";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FillDataToProductCombobox();
            comboxProduct.DroppedDown = true;
        }

        private void comboxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            SanPham sp = (SanPham)comboxProduct.SelectedItem;
            var list = ChiTietSpDAL.Find(sp.MaSp);
            comboBoxGiaXuat.DataSource = list;
            comboBoxGiaXuat.DisplayMember = "Display";
            comboBoxGiaXuat.ValueMember = "MaChiTiet";
        }

        private void ValidateSoLuong(object sender, CancelEventArgs e)
        {
            float soluong = 0;
            float.TryParse(inpSoLuong.Text, out soluong);
            ChiTietSp ct = (ChiTietSp)comboBoxGiaXuat.SelectedItem;
            if (soluong <= 0 || soluong > ct.SoLuong)
            {
                if (ct.SoLuong <= 0)
                {
                    errorProviderSoLuong.SetError(inpSoLuong, $"Số lượng trong kho đã hết");
                }
                else
                    errorProviderSoLuong.SetError(inpSoLuong, $"Số lượng phải từ 1-{ct.SoLuong}");
            } else
            {
                errorProviderSoLuong.Clear();
            }
        }

        private void comboBoxGiaXuat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (inpSoLuong.Text != "")
            {
                ValidateSoLuong(null, null);
            }
        }

        private void btnAddProductToBill_Click(object sender, EventArgs e)
        {
            string err_soluong = errorProviderSoLuong.GetError(inpSoLuong);
            if (inpSoLuong.Text == "" || err_soluong != "")
            {
                MessageBox.Show("Vui lòng nhập số lượng hợp lệ!");
                ValidateSoLuong(null, null);
                return;
            }
            SanPham cbb_sp = (SanPham)comboxProduct.SelectedItem;
            ChiTietSp cbb_ct = (ChiTietSp)comboBoxGiaXuat.SelectedItem;
            BindingList<SpHoaDonXuat> list = (BindingList<SpHoaDonXuat>)listSanPham.DataSource;

            bool isExist = false;
            foreach (var item in list)
            {
                if (item.MaChiTietSp == cbb_ct.MaChiTiet && item.MaSp == cbb_sp.MaSp)
                {
                    var confirmResult = MessageBox.Show("Sản phẩm với giá này đã được thêm vào hóa đơn.\n Bạn muốn ghi đè không?",
                                     "Cảnh báo!!",
                                     MessageBoxButtons.OKCancel);
                    if (confirmResult == DialogResult.OK)
                    {
                        item.SoLuongXuat = float.Parse(inpSoLuong.Text);
                        listSanPham.Refresh();
                    }

                    isExist = true;
                    break;
                }
            }
                    
            if (!isExist)
            {
                SpHoaDonXuat sp = new SpHoaDonXuat();
                sp.MaSp = cbb_sp.MaSp;
                sp.TenSanPham = cbb_sp.Ten;
                sp.GiaXuat = cbb_ct.GiaTien;
                sp.SoLuongXuat = float.Parse(inpSoLuong.Text);
                ChiTietSp ct = (ChiTietSp)comboBoxGiaXuat.SelectedItem;
                sp.MaChiTietSp = ct.MaChiTiet;
                list.Add(sp);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BindingList<SpHoaDonXuat> list = (BindingList<SpHoaDonXuat>)listSanPham.DataSource;
            // validate
            if (list == null || list.Count == 0)
            {
                MessageBox.Show("Bạn chưa thêm sản phẩm nào!");
                return;
            }
            string err_soluong = errorProviderSoLuong.GetError(inpSoLuong);
            if (inpSoLuong.Text == "" || err_soluong != "")
            {
                MessageBox.Show("Vui lòng nhập số lượng hợp lệ!");
                ValidateSoLuong(null, null);
                return;
            }
            // end validate

            var now = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            CuaHang cuahang = (CuaHang)comboBoxCH.SelectedItem;

            NhanVien nv = (NhanVien)MyApplication.Get("user_login");
            var result = HoaDonXuatDAL.CreateHoaDonXuat(now, nv.MaNv, cuahang.MaCh, list);
            if (result.Status)
            {
                MessageBox.Show("Lưu thành công!");
                inpSoLuong.Text = "";
                list.Clear();
                comboxProduct_SelectedIndexChanged(null, null);
            }
            else
            {
                MessageBox.Show(result.Message);
            }
        }

    }
}
