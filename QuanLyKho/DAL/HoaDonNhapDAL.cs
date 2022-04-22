using QuanLyKho.Model;
using QuanLyKho.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.DAL
{
    class HoaDonNhapDAL
    {
        static string sqlConn = ConfigurationManager.ConnectionStrings["QuanLyKho.Properties.Settings.quanlykhoConnectionString"].ToString();

        public static Result CreateHoaDonNhap(string NgayLap, string LoaiHoaDon, int MaNv, BindingList<SpHoaDon> list)
        {
            SqlConnection con = new SqlConnection(sqlConn);
            try
            {
                con.Open();
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = con;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = $@"INSERT INTO HoaDon(NgayLap, LoaiHoaDon, MaNv) VALUES('{NgayLap}', '{LoaiHoaDon}', 0) SELECT @@IDENTITY";
                var ma_hd = sqlCmd.ExecuteScalar();

                string sql = "";
                foreach (var item in list)
                {
                    sql += $"INSERT INTO HoaDonNhap_NhaCungCap (MaHd, MaNcc) VALUES({ma_hd}, {item.MaNhaCungCap});";
                    sql += $"INSERT INTO ChiTietHoaDon (MaHD, MaSp, SoLuong) VALUES({ma_hd}, {item.MaSp}, {item.SoLuongNhap});";
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

    }
}
