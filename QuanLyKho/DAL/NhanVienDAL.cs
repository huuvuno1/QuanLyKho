using QuanLyKho.Utils;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.DAL
{
    internal class NhanVienDAL
    {
        public static Model.NhanVien Login(string username, string password)
        {
            SqlConnection sqlConnection = new SqlConnection(Constant.SQL_CONNECTION_STRING);
            sqlConnection.Open();
            Model.NhanVien model = null;
            var cmd = sqlConnection.CreateCommand();
            cmd.CommandText = "select * from NhanVien where username=@username and password=@password";
            cmd.Parameters.AddWithValue("username", username);
            cmd.Parameters.AddWithValue("password", password); 
            var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                model = new Model.NhanVien();
                model.MaNv = int.Parse(reader["MaNv"].ToString());
                model.Username = reader["username"].ToString();
                model.Password = reader["password"].ToString();
                model.Ten = reader["Ten"].ToString();
                model.Email = reader["email"].ToString();   
            }
            reader.Close();
            return model;
        }

        internal static Result Delete(int ma_nv)
        {
            try
            {
                SqlConnection conn = new SqlConnection(Constant.SQL_CONNECTION_STRING);
                conn.Open();
                SqlCommand cmd = new SqlCommand($@"DELETE FROM NhanVien WHERE MaNv='{ma_nv}';", conn);
                cmd.ExecuteNonQuery();
                return new Result(true, "OK");
            } 
            catch
            {
                return new Result(false, "Không thể xóa do có ràng buộc!");
            }
        }

        internal static void Update(int manv, string ten, string gioitinh, string diachi, string email, string phone, string username)
        {
            SqlConnection conn = new SqlConnection(Constant.SQL_CONNECTION_STRING);
            conn.Open();
            SqlCommand cmd = new SqlCommand($@"UPDATE NhanVien
                                                SET Username='{username}', Ten=N'{ten}', SDT='{phone}', Email='{email}', DiaChi='{diachi}', GioiTinh='{gioitinh}'
                                                WHERE MaNv='{manv}';", conn);
            cmd.ExecuteNonQuery();
            
        }
    }
}
