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
    public partial class XuatKhoForm : Form
    {
        public XuatKhoForm()
        {
            InitializeComponent();
        }

        private void XuatKhoForm_Load(object sender, EventArgs e)
        {
            FillDataToProductCombobox();
            comboxProduct.Focus();
        }

        private void FillDataToProductCombobox()
        {
            var keyword = comboxProduct.Text;
            var products = ProductDAL.search(keyword);
            comboxProduct.DataSource = products;
            comboxProduct.DisplayMember = "Ten";
            comboxProduct.ValueMember = "MaSp";
        }
    }
}
