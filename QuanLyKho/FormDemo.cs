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
    public partial class FormDemo : Form
    {
        public FormDemo()
        {
            InitializeComponent();
        }

        private void FormDemo_Load(object sender, EventArgs e)
        {
            BindingList<NguoiDung> nguois = new BindingList<NguoiDung>();
            nguois.Add(new NguoiDung("Dat", 2001));
            nguois.Add(new NguoiDung("Hung", 2001));
            nguois.Add(new NguoiDung("Lap", 2001));
            dataGridViewTest.DataSource = nguois;


            BindingList<NguoiDung> data = (BindingList<NguoiDung>)dataGridViewTest.DataSource;
            foreach (NguoiDung item in data)
            {
                item.Tuoi = DateTime.Now.Year - item.NamSinh;
            }
        }
    }
}
