using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.Model
{
    class NhaCungCap
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public NhaCungCap() { }
        public NhaCungCap(int id, string name) 
        {
            Id = id;
            Name = name;
        }
    }
}
