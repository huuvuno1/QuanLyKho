using QuanLyKho.Model;
using QuanLyKho.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.DAL
{
    internal class HoaDonXuatDAL
    {
        public static Result CreateHoaDonXuat(string time, int ma_nv, int ma_ch, BindingList<SpHoaDonXuat> list)
        {
            SqlConnection conn = new SqlConnection(Constant.SQL_CONNECTION_STRING);
            conn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand($@"INSERT INTO HoaDonXuat (NgayLap, MaNv, MaCH)
                            VALUES('{time}', {ma_nv}, {ma_ch}); SELECT @@IDENTITY;", conn);
                var ma_hd = cmd.ExecuteScalar();

                string sql = "";
                foreach (var item in list)
                {
                    sql += $@"INSERT INTO ChiTietHoaDonXuat(MaHd, SoLuongXuat, MaChiTietSp)
                        VALUES({ma_hd}, {item.SoLuongXuat}, {item.MaChiTietSp}); ";
                }

                SqlCommand sqlCommand2 = new SqlCommand(sql, conn);
                sqlCommand2.ExecuteNonQuery();
                return new Result(true, "OK");
            }
            catch (Exception e)
            {
                return new Result(false, "Có lỗi xảy ra: " + e.Message);
            }
        }

        public static BindingList<HoaDonXuat> GetHoaDon(Dictionary<string, string> conditions = null)
        {
            BindingList<HoaDonXuat> list = new BindingList<HoaDonXuat>();
            SqlConnection conn = new SqlConnection(Constant.SQL_CONNECTION_STRING);
            conn.Open();
            SqlCommand cmd = new SqlCommand("get_hoa_don_xuat", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                HoaDonXuat bill = new HoaDonXuat();
                bill.MaHD = int.Parse(reader["MaHd"].ToString());
                bill.MaNhanVienLap = int.Parse(reader["MaNv"].ToString());
                bill.TenNhanVienLap = reader["TenNhanVien"].ToString();
                bill.NgayLap = reader["NgayLap"].ToString();
                bill.TenCuaHang = reader["TenCuaHang"].ToString();
                bill.MaCuaHang = int.Parse(reader["MaCh"].ToString());
                bill.SoLoaiSanPham = float.Parse(reader["SoLoaiSanPham"].ToString());
                bill.TongTien = reader["TongTien"].ToString();
                list.Add(bill);
            }
            conn.Close();
            return list;
        }

        public static DataTable GetHoaDon(string tennv)
        {
            SqlConnection conn = new SqlConnection(Constant.SQL_CONNECTION_STRING);
            conn.Open();
            SqlCommand cmd = new SqlCommand($"SELECT * FROM get_hoa_don_xuat_view WHERE tennhanvien='{tennv}'", conn);
            SqlDataAdapter sqlDataAdap = new SqlDataAdapter(cmd);
            DataTable dtRecord = new DataTable();
            sqlDataAdap.Fill(dtRecord);
            conn.Close();
            return dtRecord;
        }

        internal static BindingList<SpHoaDonXuat> GetProductsInBill(int mahd)
        {
            BindingList<SpHoaDonXuat> list = new BindingList<SpHoaDonXuat>();
            SqlConnection conn = new SqlConnection(Constant.SQL_CONNECTION_STRING);
            conn.Open();
            SqlCommand cmd = new SqlCommand("get_sp_in_hoa_don_xuat", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("ma_hd", mahd);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                SpHoaDonXuat sp = new SpHoaDonXuat();
                sp.MaSp = int.Parse(reader["MaSp"].ToString());
                sp.GiaXuat = float.Parse(reader["GiaXuat"].ToString());
                sp.MaChiTietSp = int.Parse(reader["MaChiTietSp"].ToString());
                sp.TenSanPham = reader["TenSanPham"].ToString();
                sp.SoLuongXuat = float.Parse(reader["SoLuongXuat"].ToString());
                list.Add(sp);
            }
            conn.Close();
            return list;
        }
    }
}
