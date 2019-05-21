using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTN.GUI;

namespace TTN
{
    public partial class fMain : MetroFramework.Forms.MetroForm
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void mtNhanVien_Click(object sender, EventArgs e)
        {
            fNhanVien nv = new fNhanVien();
            this.Hide();
            nv.ShowDialog();
            this.Show();
        }

        private void mtKhachHang_Click(object sender, EventArgs e)
        {
            fKhachHang form = new fKhachHang();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void mtGiay_Click(object sender, EventArgs e)
        {
            fGiay form = new fGiay();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void mtKhuyenMai_Click(object sender, EventArgs e)
        {
            fKhuyenMai form = new fKhuyenMai();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void mtHoaDonNhap_Click(object sender, EventArgs e)
        {
            fHoaDonNhap form = new fHoaDonNhap();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void mtHoaDonBan_Click(object sender, EventArgs e)
        {
            fHoaDonBan form = new fHoaDonBan();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void mtDoanhThu_Click(object sender, EventArgs e)
        {
           
        }

        private void mtDoanhSo_Click(object sender, EventArgs e)
        {
             fThongKeNV form = new fThongKeNV();
             this.Hide();
             form.ShowDialog();
             this.Show();
        }
    }
}
