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


        public static BindingList<SanPhamChiTiet> SearchInStock(string keyword)
        {
            SqlConnection sqlConnection = new SqlConnection(Constant.SQL_CONNECTION_STRING);
            sqlConnection.Open();
            BindingList<SanPhamChiTiet> products = new BindingList<SanPhamChiTiet>();
            var cmd = sqlConnection.CreateCommand();
            cmd.CommandText = @"SELECT * from SanPham sp 
                                inner join ChiTietSanPham ctsp on sp.MaSp = ctsp.MaSp
                                WHERE ten like @tensp";
            cmd.Parameters.AddWithValue("tensp", "%" + keyword + "%");
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                SanPhamChiTiet product = new SanPhamChiTiet();
                product.MaSp = int.Parse(reader["Masp"].ToString());
                product.Ten = reader["Ten"].ToString();
                product.MoTa = reader["MoTa"].ToString();
                product.DonViTinh = reader["DonViTinh"].ToString();
                product.Gia = float.Parse(reader["GiaTien"].ToString());
                product.SoLuong = float.Parse(reader["SoLuongTrongKho"].ToString());
                product.Display = $"Mã: {product.MaSp} - Tên: {product.Ten} - Giá: {product.Gia} - SL còn trong kho: {product.SoLuong}";
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

        public static Result UpdateProduct(int masp, string ten, string mota, string donvi)
        {
            SqlConnection con = new SqlConnection(sqlConn);
            try
            {
                con.Open();
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = con;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "update SanPham set ten=@ten, mota=@mota, donvitinh=@donvi where masp=@masp";
                sqlCmd.Parameters.AddWithValue("masp", masp);
                sqlCmd.Parameters.Add("ten", SqlDbType.NVarChar).Value = ten;
                sqlCmd.Parameters.Add("mota", SqlDbType.NVarChar).Value = mota;
                sqlCmd.Parameters.Add("donvi", SqlDbType.NVarChar).Value = donvi;
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

        public static BindingList<SanPhamChiTiet> Filter(float min_tien, float max_tien)
        {
            SqlConnection conn = new SqlConnection(Constant.SQL_CONNECTION_STRING);
            conn.Open();
            SqlCommand cmd = new SqlCommand($@"select * FROM SanPham sp 
                            inner join ChiTietSanPham ctsp on sp.MaSp = ctsp.MaSp 
                            WHERE giatien <= {max_tien} and giatien >= {min_tien}
                            ", conn);
            var reader = cmd.ExecuteReader();

            BindingList<SanPhamChiTiet> list = new BindingList<SanPhamChiTiet>();

            while (reader.Read())
            {
                SanPhamChiTiet sp = new SanPhamChiTiet();
                sp.DonViTinh = reader["DonViTinh"].ToString();
                sp.Ten = reader["Ten"].ToString();
                sp.MoTa = reader["Ten"].ToString();
                sp.SoLuong = float.Parse(reader["SoLuongTrongKho"].ToString());
                sp.Gia = float.Parse(reader["GiaTien"].ToString());
                sp.MaSp = int.Parse(reader["MaSp"].ToString());

                list.Add(sp);
            }
            conn.Close();
            return list;
        }
    }
}
