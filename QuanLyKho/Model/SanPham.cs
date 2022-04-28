using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.Model
{
    public class SanPham
    {
        [DisplayName("Mã SP")]
        public int MaSp { get; set; }
        [DisplayName("Tên Sp")]
        public string Ten { get; set; }
        [DisplayName("Mô tả")]
        public string MoTa { get; set; }
        [DisplayName("Đơn vị tính")]
        public string DonViTinh { get; set; }

        public SanPham() { }
        public SanPham(int masp, string ten, string mota, string donvitinh)
        {
            MaSp = masp;
            Ten = ten;
            MoTa = mota;
            DonViTinh = donvitinh;
        }
    }

    public class SanPhamChiTiet : SanPham
    {
        public float Gia { get; set; }
        public float SoLuong { get; set; }
        public string Display { get; set; }
    }
}
