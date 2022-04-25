using QuanLyKho.Report;
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
    public partial class MainForm : Form
    {
        public static MainForm Instance;
        public MainForm()
        {
            InitializeComponent();
            Instance = this;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            ToggleForm<SanPhamForm>();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        // nav to ncc form
        private void button1_Click(object sender, EventArgs e)
        {
            NccForm nccForm = new NccForm();
            nccForm.Show();
            this.Hide();
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToggleForm<NccForm>();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void xemDanhSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToggleForm<SanPhamForm>();
        }

        private void cửaHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToggleForm<CuaHangForm>();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToggleForm<NhanVienForm>();
        }

        private void hóaĐơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToggleForm<HoaDonNhapKhoForm>();
        }

        private void ToggleForm<T>() where T : Form, new()
        {
            T form = new T()
            {
                ControlBox = false,
                TopLevel = false,
                TopMost = true,
                Text = ""
            };
            fragement.Controls.Clear();
            fragement.Controls.Add(form);
            form.Show();
        }

        private void fragement_Paint(object sender, PaintEventArgs e)
        {

        }

        private void hóaĐơnXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToggleForm<NhapKhoForm>();
        }

        private void xuấtKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToggleForm<XuatKhoForm>();

        }

        private void cửaHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ToggleForm<ReportCuaHangForm>();
        }

        private void nhàCungCấpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ToggleForm<ReportNhaCungCapForm>();
        }

        private void sảnPhẩmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new ReportSanPhamForm().ShowDialog(this);
        }

        private void hóaĐơnNhậpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new ReportHoaDonNhapForm().ShowDialog(this);
        }
    }
}
