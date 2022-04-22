using QuanLyKho.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.DAL
{
    class NhaCcDAL
    {
        public static string sqlConn = ConfigurationManager.ConnectionStrings["QuanLyKho.Properties.Settings.quanlykhoConnectionString"].ToString();
        public static DataTable Search(string keyword)
        {
            SqlConnection con = new SqlConnection(sqlConn);
            con.Open();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = con;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "select top 50 * from NhaCungCap where ten like @ten";
            sqlCmd.Parameters.AddWithValue("ten", "%" + keyword + "%");
            SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);
            DataTable dtRecord = new DataTable();
            sqlDataAdap.Fill(dtRecord);
            return dtRecord;
        }

        public static List<NhaCungCap> SearchList(string keyword)
        {
            SqlConnection sqlConnection = new SqlConnection(sqlConn);
            sqlConnection.Open();
            List<NhaCungCap> list_ncc = new List<NhaCungCap>();
            var cmd = sqlConnection.CreateCommand();
            cmd.CommandText = "select top 20 * from NhaCungCap where ten like @ten";
            cmd.Parameters.AddWithValue("ten", "%" + keyword + "%");
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                NhaCungCap ncc = new NhaCungCap();
                ncc.Name = reader["Ten"].ToString();
                ncc.Id = int.Parse(reader["MaNcc"].ToString());
                ncc.Address = reader["DiaChi"].ToString();
                list_ncc.Add(ncc);
            }
            reader.Close();
            return list_ncc;
        }


        //public static Result Update(int ma, string ten, string diachi, string email, string sdt)
        //{
        //    SqlConnection con = new SqlConnection(sqlConn);
        //    try
        //    {
        //        con.Open();
        //        SqlCommand sqlCmd = new SqlCommand();
        //        sqlCmd.Connection = con;
        //        sqlCmd.CommandType = CommandType.Text;
        //        sqlCmd.CommandText = @"
        //                UPDATE CuaHang
        //                SET Ten = @ten, DiaChi = @diachi, Email = @email, SDT = @sdt
        //                WHERE MaCh = @ma;
        //        ";
        //        sqlCmd.Parameters.AddWithValue("ma", ma);
        //        sqlCmd.Parameters.AddWithValue("ten", ten);
        //        sqlCmd.Parameters.AddWithValue("diachi", diachi);
        //        sqlCmd.Parameters.AddWithValue("email", email);
        //        sqlCmd.Parameters.AddWithValue("sdt", sdt);
        //        sqlCmd.ExecuteNonQuery();
        //        return new Result(true, "OK");
        //    }
        //    catch (Exception e)
        //    {
        //        return new Result(false, e.Message);
        //    }
        //    finally
        //    {
        //        con.Close();
        //    }
        //}
    }
}
