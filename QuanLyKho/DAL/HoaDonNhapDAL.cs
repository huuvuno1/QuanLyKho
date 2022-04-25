using QuanLyKho.Model;
using QuanLyKho.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.DAL
{
    class HoaDonNhapDAL
    {
        static string sqlConn = ConfigurationManager.ConnectionStrings["QuanLyKho.Properties.Settings.quanlykhoConnectionString"].ToString();

        public static Result CreateHoaDonNhap(string NgayLap, int MaNv, int MaNcc, BindingList<SpHoaDon> list)
        {
            SqlConnection con = new SqlConnection(sqlConn);
            try
            {
                con.Open();
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = con;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = $@"INSERT INTO HoaDonNhap (NgayLap, MaNv, MaNcc)
                                        VALUES ('{NgayLap}', '{MaNv}', {MaNcc}) SELECT @@IDENTITY";
                var ma_hd = sqlCmd.ExecuteScalar();

                string sql = "";
                foreach (var item in list)
                {
                    sql += $@"INSERT INTO ChiTietHoaDonNhap (MaHD, MaSp, SoLuong, GiaNhap)
                            VALUES({ ma_hd}, {item.MaSp}, {item.SoLuongNhap}, {item.GiaNhap});";
                }
                SqlCommand sqlCmd2 = new SqlCommand(sql, con);
                sqlCmd2.ExecuteNonQuery();

                return new Result(true, "OK");
            }
            catch (Exception e)
            {
                return new Result(false, e.Message);
            }
            finally
            {
                con.Close();
            }
        }


        public static BindingList<HoaDonNhap> GetHoaDon(Dictionary<string, string> conditions = null)
        {
            BindingList<HoaDonNhap> list = new BindingList<HoaDonNhap>();
            SqlConnection conn = new SqlConnection(Constant.SQL_CONNECTION_STRING);
            conn.Open();
            SqlCommand cmd = new SqlCommand("get_hoa_don", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                HoaDonNhap bill = new HoaDonNhap();
                bill.MaHD = int.Parse(reader["MaHd"].ToString());
                bill.MaNhanVienLap = int.Parse(reader["MaNv"].ToString());
                bill.TenNhanVienLap = reader["TenNhanVien"].ToString();
                bill.NgayLap = reader["NgayLap"].ToString();
                bill.TenNhaCungCap = reader["TenNCC"].ToString();
                bill.MaNhaCungCap = int.Parse(reader["MaNCC"].ToString());
                bill.SoLoaiSanPham = float.Parse(reader["SoLoaiSanPham"].ToString());
                bill.TongTien = reader["TongTien"].ToString();
                list.Add(bill);
            }
            conn.Close();
            return list; 
        }

    }
}
