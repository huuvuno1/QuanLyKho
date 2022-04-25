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
    internal class ProductDAL
    {
        static string sqlConn = ConfigurationManager.ConnectionStrings["QuanLyKho.Properties.Settings.quanlykhoConnectionString"].ToString();
        public static BindingList<SanPham> search(string keyword)
        {
            SqlConnection sqlConnection = new SqlConnection(sqlConn);
            sqlConnection.Open();
            BindingList<SanPham> products = new BindingList<SanPham>();
            var cmd = sqlConnection.CreateCommand();
            cmd.CommandText = "select top 20 * from SanPham where ten like @tensp";
            cmd.Parameters.AddWithValue("tensp", "%" + keyword + "%");
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                SanPham product = new SanPham();
                product.MaSp = int.Parse(reader["Masp"].ToString());
                product.Ten = reader["Ten"].ToString();
                product.MoTa = reader["MoTa"].ToString();
                product.DonViTinh = reader["DonViTinh"].ToString();
                products.Add(product);
            }
            reader.Close();
            return products;
        }

        public static DataTable SearchProduct(string keyword)
        {
            SqlConnection con = new SqlConnection(sqlConn);
            con.Open();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = con;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "select top 50 * from SanPham where ten like @tensp";
            sqlCmd.Parameters.AddWithValue("tensp", "%" + keyword + "%");
            SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);
            DataTable dtRecord = new DataTable();
            sqlDataAdap.Fill(dtRecord);
            return dtRecord;
        }

        public static Result UpdateProduct(int masp, string ten, string mota, string donvi, float gia)
        {
            SqlConnection con = new SqlConnection(sqlConn);
            try
            {
                con.Open();
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = con;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "update SanPham set ten=@ten, mota=@mota, donvitinh=@donvi, giatien=@giatien where masp=@masp";
                sqlCmd.Parameters.AddWithValue("masp", masp);
                sqlCmd.Parameters.Add("ten", SqlDbType.NVarChar).Value = ten;
                sqlCmd.Parameters.Add("mota", SqlDbType.NVarChar).Value = mota;
                sqlCmd.Parameters.Add("donvi", SqlDbType.NVarChar).Value = donvi;
                sqlCmd.Parameters.AddWithValue("giatien", gia);
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

        public static Result Save(string ten, string donvitinh, string mota)
        {
            SqlConnection con = new SqlConnection(sqlConn);
            try
            {
                con.Open();
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = con;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = $@"INSERT INTO SanPham(Ten, MoTa, DonViTinh)
                                        VALUES(N'{ten}', N'{mota}', N'{donvitinh}');";
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
    }
}
