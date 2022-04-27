using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.Model
{
    class CuaHang
    {
        public int MaCh { get; set; }
        public string Ten { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }

        public CuaHang() { }
        public CuaHang(int id, string name)
        {
            MaCh = id;
            Ten = name;
        }
    }
}
