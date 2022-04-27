using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho
{
    class NguoiDung
    {
        public string HoTen { get; set; }
        public int NamSinh { get; set; }
        public int Tuoi { get; set; }

        public NguoiDung() { }
        public NguoiDung(string ten, int namsinh)
        {
            HoTen = ten;
            NamSinh = namsinh;
        }
    }
}
