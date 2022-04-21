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
        public static string sqlConn = ConfigurationManager.ConnectionStrings["QuanLyKho.Properties.Settings.quanlykhoConnectionString"].ToString();
        public static Model.NhanVien Login(string username, string password)
        {
            SqlConnection sqlConnection = new SqlConnection(sqlConn);
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
                model.Username = reader["username"].ToString();
                model.Password = reader["password"].ToString();
                model.Ten = reader["Ten"].ToString();
                model.Email = reader["email"].ToString();   
            }
            reader.Close();
            return model;
        }
    }
}
