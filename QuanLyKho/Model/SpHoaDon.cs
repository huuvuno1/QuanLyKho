using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.Model
{
    internal class SpHoaDon
    {
        public int MaSp { get; set; }
        public string TenSanPham { get; set; }
        public float SoLuongNhap { get; set; }
        public float GiaNhap { get; set; }
        public int MaNhaCungCap { get; set; }
        public string TenNhaCungCap { get; set; }

        public SpHoaDon(int masp, string tensp, float soluong, float gianhap, int maNcc, string tenNcc)
        {
            MaSp = masp;
            TenSanPham = tensp;
            SoLuongNhap = soluong;
            GiaNhap = gianhap;
            MaNhaCungCap = maNcc;
            TenNhaCungCap = tenNcc;
        }
    }
}
