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
    public partial class fGiay : MetroFramework.Forms.MetroForm
    {
        public fGiay()
        {
            InitializeComponent();
            Load();
        }
        BindingSource ListGiay = new BindingSource();

        void Load()
        {
            ListGiay.DataSource = SanPhamDAO.Instance.GetListGiay();
            dgvGiay.DataSource = ListGiay;
            AddBinding();
        }

        void AddBinding()
        {
            txtIDGiay.DataBindings.Add(new Binding("Text", dgvGiay.DataSource, "IDGiay", true, DataSourceUpdateMode.Never));
            txtTenGiay.DataBindings.Add(new Binding("Text", dgvGiay.DataSource, "TenGiay", true, DataSourceUpdateMode.Never));
            txtSoLuong.DataBindings.Add(new Binding("Text", dgvGiay.DataSource, "SoLuong", true, DataSourceUpdateMode.Never));
            txtDonGia.DataBindings.Add(new Binding("Text", dgvGiay.DataSource, "DonGia", true, DataSourceUpdateMode.Never));
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            ListGiay.DataSource = SanPhamDAO.Instance.SearchGiay(txtSearch.Text);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenGiay.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên giày", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string TenGiay = txtTenGiay.Text;
            int SoLuong = Convert.ToInt32(txtSoLuong.Text);
            decimal DonGia = Convert.ToDecimal(txtDonGia.Text);
            if (SanPhamDAO.Instance.InsertGiay(TenGiay, SoLuong, DonGia))
            {
                MessageBox.Show("Bạn thêm 1 giày thành công", "thông báo", MessageBoxButtons.OK);
                ListGiay.DataSource = SanPhamDAO.Instance.GetListGiay();
            }
            else
            {
                MessageBox.Show("Bạn thêm thất bại", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtIDGiay.Text == "")
            {
                MessageBox.Show("phải chọn 1 giày để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                var xacnhan = MessageBox.Show("bạn có chắc chắn muốn sửa giày : " + txtTenGiay.Text, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (xacnhan == DialogResult.Yes)
                {
                    if (SanPhamDAO.Instance.UpdateGiay(Convert.ToInt32(txtIDGiay.Text), txtTenGiay.Text, Convert.ToInt32(txtSoLuong.Text), Convert.ToDecimal(txtDonGia.Text)))
                    {
                        MessageBox.Show("Sửa giày thành công", "Thông báo", MessageBoxButtons.OK);
                        ListGiay.DataSource = SanPhamDAO.Instance.GetListGiay();
                    }
                    else
                    {
                        MessageBox.Show("Sửa giày không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtIDGiay.Text == "")
            {
                MessageBox.Show("phải chọn 1 giày để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                var xacnhan = MessageBox.Show("bạn có chắc chắn muốn xóa giày : " + txtTenGiay.Text, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (xacnhan == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(txtIDGiay.Text);
                    if (SanPhamDAO.Instance.DeleteGiay(id))
                    {
                        MessageBox.Show("Xóa giày thành công!", "Thông báo", MessageBoxButtons.OK);
                        ListGiay.DataSource = SanPhamDAO.Instance.GetListGiay();
                    }
                    else
                    {
                        MessageBox.Show("Xóa giày không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtIDGiay.Text = "";
            txtTenGiay.Text = "";
            txtSoLuong.Text = "";
            txtDonGia.Text = "";
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ListGiay.DataSource = SanPhamDAO.Instance.GetListGiay();
            dgvGiay.DataSource = ListGiay;
        }
    }
}
