using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.Model
{
    public class SanPham
    {
        public int MaSp { get; set; }
        public string Ten { get; set; }
        public string MoTa { get; set; }
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
