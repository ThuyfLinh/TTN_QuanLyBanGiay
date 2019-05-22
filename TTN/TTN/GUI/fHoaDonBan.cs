using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTN.DAO;
using TTN.GUI;

namespace TTN.GUI
{
    public partial class fHoaDonBan : MetroFramework.Forms.MetroForm
    {
        BindingSource DanhSachHD = new BindingSource();
        public fHoaDonBan()
        {
            InitializeComponent();
            LoadList();
        }
        void LoadList()
        {
            dgvHoaDonBan.DataSource = HoaDonBan_DAO.Instance.GetHoaDonBan();
            AddBinding();
        }
        void AddBinding()
        {
            txtMaHD.DataBindings.Clear();
            txtMaHD.DataBindings.Add(new Binding("Text", dgvHoaDonBan.DataSource, "MaHD", true, DataSourceUpdateMode.Never));
            txtTenNV.DataBindings.Clear();
            txtTenNV.DataBindings.Add(new Binding("Text", dgvHoaDonBan.DataSource, "TenNV", true, DataSourceUpdateMode.Never));
            txtTenKH.DataBindings.Clear();
            txtTenKH.DataBindings.Add(new Binding("Text", dgvHoaDonBan.DataSource, "TenKH", true, DataSourceUpdateMode.Never));
            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add(new Binding("Text", dgvHoaDonBan.DataSource, "SDT", true, DataSourceUpdateMode.Never));
            txtKM.DataBindings.Clear();
            txtKM.DataBindings.Add(new Binding("Text", dgvHoaDonBan.DataSource, "TenCT", true, DataSourceUpdateMode.Never));
            dtNgay.DataBindings.Clear();
            dtNgay.DataBindings.Add(new Binding("Text", dgvHoaDonBan.DataSource, "Ngay", true, DataSourceUpdateMode.Never));

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvHoaDonBan.DataSource = HoaDonBan_DAO.Instance.SearchHD(txtTimKiem.Text);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Bạn có chắc chắn muốn sửa hóa đơn " + txtMaHD.Text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                int maHD;
                Int32.TryParse(txtMaHD.Text, out maHD);
                string tenNV = txtTenNV.Text;
                string tenKH = txtTenKH.Text;
                string sdt = txtSDT.Text;
                string tenCT = txtKM.Text;
                DateTime Ngay;
                DateTime.TryParse(dtNgay.Text, out Ngay);
                if (HoaDonBan_DAO.Instance.Update_HoaDonBan(maHD, tenNV, tenKH, tenCT, Ngay, sdt))
                {
                    MessageBox.Show("Sửa thông tin hóa đơn bán thành công! ");
                    LoadList();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi sửa thông tin hóa đơn bán! ");
                }

            }
            else LoadList();
        }

        private void btnThemKM_Click(object sender, EventArgs e)
        {
            if (rbKH_old.Checked)
            {
                if (txtTenKH.Text == "" || txtTenNV.Text == "" || txtKM.Text == "" || txtSDT.Text == "" || dtNgay.Text == "")
                {
                    MessageBox.Show("Sai hoặc thiếu thông tin");
                    LoadList();
                }
                else
                {
                    string tenNV = txtTenNV.Text;
                    string tenKH = txtTenKH.Text;

                    string sdt = txtSDT.Text;
                    string tenCT = txtKM.Text;
                    DateTime Ngay;
                    DateTime.TryParse(dtNgay.Text, out Ngay);
                    if (HoaDonBan_DAO.Instance.Insert_HoaDonBan_KHold(tenNV, tenKH, tenCT, Ngay, sdt))
                    {
                        MessageBox.Show("Thêm khách hàng thành công! ");
                        LoadList();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi thêm khách hàng! ");
                    }
                }
            }
            if (rbKH_new.Checked)
            {
                if (txtTenKH.Text == "" || txtTenNV.Text == "" || txtKM.Text == "" || txtSDT.Text == "" || dtNgay.Text == "")
                {
                    MessageBox.Show("Sai hoặc thiếu thông tin");
                    LoadList();
                }
                else
                {
                    string tenNV = txtTenNV.Text;
                    string tenKH = txtTenKH.Text;
                    string sdt = txtSDT.Text;
                    string tenCT = txtKM.Text;
                    DateTime Ngay;
                    DateTime.TryParse(dtNgay.Text, out Ngay);
                    if (HoaDonBan_DAO.Instance.Insert_HoaDonBan_KHnew(tenNV, tenKH, tenCT, Ngay, sdt))
                    {
                        MessageBox.Show("Thêm khách hàng thành công! ");
                        LoadList();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi thêm khách hàng! ");
                    }
                }
            }
            if (!rbKH_old.Checked && !rbKH_new.Checked)
            {
                MessageBox.Show("Vui lòng chọn loại khách hàng!");
            }
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            fCTHoaDonBan f = new fCTHoaDonBan(int.Parse(txtMaHD.Text));
            f.ShowDialog();
            this.Show();
        }
    }
}
