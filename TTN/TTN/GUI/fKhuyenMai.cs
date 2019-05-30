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
    public partial class fKhuyenMai : MetroFramework.Forms.MetroForm
    {
        public fKhuyenMai()
        {
            InitializeComponent();
            Load();
        }
        BindingSource DanhSachKM = new BindingSource();

        void Load()
        {
            dgvKhuyenMai.DataSource = KhuyenMaiDAO.Instance.GetKhuyenMai();
            dgvDSKM.DataSource = DanhSachKM;
            AddBinding();
        }

        void AddBinding()
        {
            txtIDKM.DataBindings.Clear();
            txtIDKM.DataBindings.Add(new Binding("Text", dgvKhuyenMai.DataSource, "MaKM", true, DataSourceUpdateMode.Never));
            txtTenCT.DataBindings.Clear();
            txtTenCT.DataBindings.Add(new Binding("Text", dgvKhuyenMai.DataSource, "TenCT", true, DataSourceUpdateMode.Never));
            txtMoTa.DataBindings.Clear();
            txtMoTa.DataBindings.Add(new Binding("Text", dgvKhuyenMai.DataSource, "MoTa", true, DataSourceUpdateMode.Never));
            txtChietKhau.DataBindings.Clear();
            txtChietKhau.DataBindings.Add(new Binding("Text", dgvKhuyenMai.DataSource, "ChietKhau", true, DataSourceUpdateMode.Never));
            dtpTuNgay.DataBindings.Clear();
            dtpTuNgay.DataBindings.Add(new Binding("Text", dgvKhuyenMai.DataSource, "NgayBD", true, DataSourceUpdateMode.Never));
            dtpDenNgay.DataBindings.Clear();
            dtpDenNgay.DataBindings.Add(new Binding("Text", dgvKhuyenMai.DataSource, "NgayKT", true, DataSourceUpdateMode.Never));

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvKhuyenMai.DataSource = KhuyenMaiDAO.Instance.SearchKM(txtTimKiem.Text);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtTenCT.Text == null || dtpTuNgay.Text == null || dtpDenNgay == null)
            {
                MessageBox.Show("Thêm đầy đủ thông tin khuyến mại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (txtCK.Text == null && txtMaGiay.Text == null)
            {
                var confirm = MessageBox.Show("Bạn có chắc chắn muốn sửa chi tiết khuyến mãi ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    KhuyenMaiDAO.Instance.UpdateKM(Convert.ToInt32(txtIDKM.Text), txtTenCT.Text, txtMoTa.Text, Convert.ToDateTime(dtpTuNgay.Text), Convert.ToDateTime(dtpDenNgay.Text), float.Parse(txtChietKhau.Text));
                    dgvKhuyenMai.DataSource = KhuyenMaiDAO.Instance.GetKhuyenMai();
                }
                else
                {
                    return;
                }
            }
            else
            {
                var confirm = MessageBox.Show("Bạn có chắc chắn muốn sửa chi tiết khuyến mãi ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    KhuyenMaiDAO.Instance.UpdateKM(Convert.ToInt32(txtIDKM.Text), txtTenCT.Text, txtMoTa.Text, Convert.ToDateTime(dtpTuNgay.Text), Convert.ToDateTime(dtpDenNgay.Text), 0);
                    dgvKhuyenMai.DataSource = KhuyenMaiDAO.Instance.GetKhuyenMai();
                }
                else
                {
                    return;
                }
            }
        }

        private void btnThemKM_Click(object sender, EventArgs e)
        {
            
            fCTKhuyenMai KM = new fCTKhuyenMai();
            this.Hide();
            KM.ShowDialog();
            this.Show();
        }

        private void btnThemCTKM_Click(object sender, EventArgs e)
        {
            if (txtMaGiay.Text == null || txtCK.Text == null)
            {
                MessageBox.Show("Thêm thông tin chi tiết khuyến mãi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var confirm = MessageBox.Show("Bạn có chắc chắn muốn thêm chi tiết khuyến mãi ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    CTKhuyenMaiDAO.Instance.InsertCTKM(Convert.ToInt32(txtIDKM.Text), Convert.ToInt32(txtMaGiay.Text), float.Parse(txtCK.Text));
                    dgvDSKM.DataSource = CTKhuyenMaiDAO.Instance.ListCTKM(Convert.ToInt32(txtIDKM.Text));
                }
                else
                {
                    return;
                }
            }
        }

        private void dgvKhuyenMai_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                dgvKhuyenMai.CurrentRow.Selected = true;
                AddBinding();
                DanhSachKM.DataSource = CTKhuyenMaiDAO.Instance.ListCTKM(Convert.ToInt32(txtIDKM.Text));
            }
            catch { }
        }

        private void dgvDSKM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow dr = dgvDSKM.Rows[index];
                txtMaGiay.DataBindings.Add(new Binding("Text", dgvDSKM.DataSource, "MaGiay", true, DataSourceUpdateMode.Never));
                txtCK.DataBindings.Add(new Binding("Text", dgvDSKM.DataSource, "ChietKhau", true, DataSourceUpdateMode.Never));
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void btnXoaCT_Click(object sender, EventArgs e)
        {
            if (txtMaGiay.Text == null || txtCK.Text == null)
            {
                MessageBox.Show("Chọn ít nhất 1 chi tiết khuyến mãi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa chi tiết khuyến mãi ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    CTKhuyenMaiDAO.Instance.DeleteCTKM(Convert.ToInt32(txtIDKM.Text), Convert.ToInt32(txtMaGiay.Text));
                    dgvDSKM.DataSource = CTKhuyenMaiDAO.Instance.ListCTKM(Convert.ToInt32(txtIDKM.Text));
                }
                else
                {
                    return;
                }
            }
        }
    }
}
