using QuanLyKho.DAL;
using QuanLyKho.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKho
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            NhanVien result = NhanVienDAL.Login(inpUsername.Text, inpPassword.Text);
            if (result != null)
            {
                this.Hide();
                MyApplication.Set("user_login", result);
                MainForm main = new MainForm();
                main.Owner = this;
                main.ShowDialog();
                this.Close();

                //if (this.InvokeRequired)
                //{
                    //this.Invoke(new MethodInvoker(delegate { Thread.Sleep(1000); this.Close(); }));
                //}

            }
            else
            {
                msgLogin.Text = "Username hoặc mật khẩu không chính xác!";
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
