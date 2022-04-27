using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.Model
{
    internal class SpHoaDonXuat
    {
        public int MaSp { get; set; }
        public string TenSanPham { get; set; }
        public float SoLuongXuat { get; set; }
        public float GiaXuat { get; set; }
        public int MaChiTietSp { get; set; }
        public SpHoaDonXuat() { }
        public SpHoaDonXuat(int masp, string tensp, float soluong, float gianhap)
        {
            MaSp = masp;
            TenSanPham = tensp;
            SoLuongXuat = soluong;
            GiaXuat = gianhap;
        }
    }
}
