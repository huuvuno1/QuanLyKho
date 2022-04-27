using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.Model
{
    internal class SpHoaDonNhap
    {
        public int MaSp { get; set; }
        public string TenSanPham { get; set; }
        public float SoLuongNhap { get; set; }
        public float GiaNhap { get; set; }

        public float TongTien { get; set; }

        public SpHoaDonNhap() { }
        public SpHoaDonNhap(int masp, string tensp, float soluong, float gianhap)
        {
            MaSp = masp;
            TenSanPham = tensp;
            SoLuongNhap = soluong;
            GiaNhap = gianhap;
        }
    }
}
