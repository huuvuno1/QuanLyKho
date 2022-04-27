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
    internal class CuaHangDAL
    {
        public static string sqlConn = ConfigurationManager.ConnectionStrings["QuanLyKho.Properties.Settings.quanlykhoConnectionString"].ToString();
        public static DataTable Search(string keyword)
        {
            SqlConnection con = new SqlConnection(sqlConn);
            con.Open();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = con;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "select top 50 * from CuaHang where ten like @tensp";
            sqlCmd.Parameters.AddWithValue("tensp", "%" + keyword + "%");
            SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);
            DataTable dtRecord = new DataTable();
            sqlDataAdap.Fill(dtRecord);
            return dtRecord;
        }

        public static Result Update(int ma, string ten, string diachi, string email, string sdt)
        {
            SqlConnection con = new SqlConnection(sqlConn);
            try
            {
                con.Open();
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = con;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = @"
                        UPDATE CuaHang
                        SET Ten = @ten, DiaChi = @diachi, Email = @email, SDT = @sdt
                        WHERE MaCh = @ma;
                ";
                sqlCmd.Parameters.AddWithValue("ma", ma);
                sqlCmd.Parameters.AddWithValue("ten", ten);
                sqlCmd.Parameters.AddWithValue("diachi", diachi);
                sqlCmd.Parameters.AddWithValue("email", email);
                sqlCmd.Parameters.AddWithValue("sdt", sdt);
                sqlCmd.ExecuteNonQuery();
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

        public static BindingList<CuaHang> SearchList(string keyword)
        {
            SqlConnection sqlConnection = new SqlConnection(sqlConn);
            sqlConnection.Open();
            BindingList<CuaHang> list_ncc = new BindingList<CuaHang>();
            var cmd = sqlConnection.CreateCommand();
            cmd.CommandText = "select top 50 * from CuaHang where ten like @ten";
            cmd.Parameters.AddWithValue("ten", "%" + keyword + "%");
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                CuaHang cuaHang = new CuaHang();
                cuaHang.Ten = reader["Ten"].ToString();
                cuaHang.MaCh = int.Parse(reader["MaCh"].ToString());
                cuaHang.DiaChi = reader["DiaChi"].ToString();
                cuaHang.Email = reader["Email"].ToString();
                cuaHang.SDT = reader["SDT"].ToString();
                list_ncc.Add(cuaHang);
            }
            reader.Close();
            return list_ncc;
        }

        internal static Result Delete(int mach)
        {
            SqlConnection con = new SqlConnection(sqlConn);
            try
            {
                con.Open();
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = con;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = $@"DELETE FROM CuaHang WHERE MaCh={mach};";
                sqlCmd.ExecuteNonQuery();
                return new Result(true, "OK");
            }
            catch (Exception e)
            {
                return new Result(false, "Không thể xóa, thông cửa hàng này đang được liên kết với bảng khác");
            }
            finally
            {
                con.Close();
            }
        }
    }
}
