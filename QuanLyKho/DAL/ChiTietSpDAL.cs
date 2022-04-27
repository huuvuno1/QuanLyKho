using QuanLyKho.Model;
using QuanLyKho.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.DAL
{
    internal class ChiTietSpDAL
    {
        public static BindingList<ChiTietSp> Find(int MaSp)
        {
            BindingList<ChiTietSp> list = new BindingList<ChiTietSp>();
            SqlConnection conn = new SqlConnection(Constant.SQL_CONNECTION_STRING);
            conn.Open();
            string sql = $@"SELECT MaChiTietSp, GiaTien, MaSp, SoLuongTrongKho
                            FROM ChiTietSanPham WHERE MaSp = {MaSp}";
            SqlCommand cmd = new SqlCommand(sql, conn);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ChiTietSp ct = new ChiTietSp();
                ct.MaChiTiet = int.Parse(reader["MaChiTietSp"].ToString());
                ct.SoLuong = float.Parse(reader["SoLuongTrongKho"].ToString());
                ct.GiaTien = float.Parse(reader["GiaTien"].ToString());
                ct.Display = $"Giá: {ct.GiaTien.ToString("N0")} - Tồn kho: {ct.SoLuong}";
                list.Add(ct);
            }
            conn.Close();
            return list;
        }
    }
}
