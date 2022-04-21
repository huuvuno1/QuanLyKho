using QuanLyKho.DAL;
using QuanLyKho.Model;
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
    public partial class NhapKhoForm : Form
    {
        public NhapKhoForm()
        {
            InitializeComponent();
        }
        
        private void NhapKhoForm_Load(object sender, EventArgs e)
        {
            List<Product> products = new List<Product>();
            products.Add(new Product(1, "vai", "de", 1, 1));
            products.Add(new Product(1, "vai", "de", 1, 1));
            products.Add(new Product(1, "vai", "de", 1, 1));
            listSanPham.DataSource = products;
            DataGridViewButtonColumn column = new DataGridViewButtonColumn();
            column.Name = "uninstall_column";
            column.Text = "Uninstall";
            listSanPham.Columns.Add(column);
        }

        private void inpSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchProducts(object sender, EventArgs e)
        {
            
            //comboxProduct.Items.Add
        }

        private void SearchProducts(object sender, KeyEventArgs e)
        {
            
        }

        private void valueChange(object sender, EventArgs e)
        {
            comboxProduct.DroppedDown = true;
        }

        private void kkkk(object sender, EventArgs e)
        {
            comboxProduct.DroppedDown = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboxProduct.DroppedDown = true;
            var keyword = comboxProduct.Text;
            var products = ProductDAL.search(keyword);
            comboxProduct.DataSource = new BindingSource(products, null);
            comboxProduct.DisplayMember = "Name";
            comboxProduct.ValueMember = "Id";
            comboxProduct.DroppedDown = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form ncc = new NccForm();
            ncc.ShowDialog(this);
        }

        private void listSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
