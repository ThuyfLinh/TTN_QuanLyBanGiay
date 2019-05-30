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

namespace TTN.GUI
{
    public partial class fCTHoaDonBan : MetroFramework.Forms.MetroForm
    {
        private int MaHD;
        BindingSource DanhSachCTHD = new BindingSource();
        public fCTHoaDonBan(int id)
        {
            InitializeComponent();
            MaHD = id;
            LoadList();
        }
        void LoadList()
        {

            dgvCTHD.DataSource = CTHoaDonBan_DAO.Instance.GetCTHoaDonBan(MaHD);
            AddBinding();
        }

        void AddBinding()
        {
            txtMaHD.DataBindings.Clear();
            txtMaHD.DataBindings.Add(new Binding("Text", dgvCTHD.DataSource, "MaHD", true, DataSourceUpdateMode.Never));
            txtMaGiay.DataBindings.Clear();
            txtMaGiay.DataBindings.Add(new Binding("Text", dgvCTHD.DataSource, "MaGiay", true, DataSourceUpdateMode.Never));
            txtSoLuong.DataBindings.Clear();
            txtSoLuong.DataBindings.Add(new Binding("Text", dgvCTHD.DataSource, "SoLuong", true, DataSourceUpdateMode.Never));
            decimal tongtien = CTHoaDonBan_DAO.Instance.getTongtien(int.Parse(txtMaHD.Text));
            txtTongTien.Text = tongtien.ToString();
            
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvCTHD.DataSource = CTHoaDonBan_DAO.Instance.SearchCTHD(int.Parse(txtMaHD.Text), txtTimKiem.Text);
        }

        private void btnXoaCT_Click(object sender, EventArgs e)
        {
            if (txtMaGiay.Text == null || txtSoLuong.Text == null)
            {
                MessageBox.Show("Chọn 1 chi tiết hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa chi tiết khuyến mãi ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    CTHoaDonBan_DAO.Instance.Delete_CTHoaDonBan(Convert.ToInt32(txtMaHD.Text), Convert.ToInt32(txtMaGiay.Text));
                    dgvCTHD.DataSource = CTHoaDonBan_DAO.Instance.GetCTHoaDonBan(Convert.ToInt32(txtMaHD.Text));
                }
                else
                {
                    return;
                }
            }
        }

        private void btnThemCTKM_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text == "" || txtSoLuong.Text == "")
            {
                MessageBox.Show("Sai hoặc thiếu thông tin");
                LoadList();
            }
            else
            {
                int MaHD;
                Int32.TryParse(txtMaHD.Text, out MaHD);
                int MaGiay;
                Int32.TryParse(txtMaGiay.Text, out MaGiay);
                int SoLuong;
                Int32.TryParse(txtSoLuong.Text, out SoLuong);

                if (CTHoaDonBan_DAO.Instance.Insert_CTHoaDonBan(MaHD, MaGiay, SoLuong))
                {
                    MessageBox.Show("Thêm cho tiết thành công! ");
                    LoadList();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi thêm chi tiết! ");
                }
            }
        }
    }
}
