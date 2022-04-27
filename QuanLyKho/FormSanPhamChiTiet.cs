using QuanLyKho.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKho
{
    public partial class FormSanPhamChiTiet : Form
    {
        public FormSanPhamChiTiet()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float min = float.Parse(inpMin.Text);
            float max = float.Parse(inpMax.Text);
            dataGridViewSp.DataSource = ProductDAL.Filter(min, max);
        }

        private void FormSanPhamChiTiet_Load(object sender, EventArgs e)
        {
            dataGridViewSp.DataSource = ProductDAL.Filter(0, 100000000);
        }
    }
}
