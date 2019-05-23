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
using TTN.DTO;

namespace TTN.GUI
{
    public partial class fCTKhuyenMai : MetroFramework.Forms.MetroForm
    {
        public fCTKhuyenMai()
        {
            InitializeComponent();
            Load();
        }
        BindingSource listCTKhuyenMai = new BindingSource();
        BindingSource listGiay = new BindingSource();

        void Load()
        {
            LoadListGiay();
            listGiay.DataSource = SanPhamDAO.Instance.GetListGiay();
            dgvKhuyenMai.DataSource = listGiay;
            AddBinding();
        }
        void LoadListGiay()
        {
            listGiay.DataSource = SanPhamDAO.Instance.GetListGiay();
        }

        void AddBinding()
        {
            txtIDGiay.DataBindings.Add(new Binding("Text", dgvKhuyenMai.DataSource, "IDGiay", true, DataSourceUpdateMode.Never));
        }

        List<CTKhuyenMai_DTO> listCTKM = new List<CTKhuyenMai_DTO>();
        public string tempCTKM;
        int tempIndex;

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn hủy các thao tác vừa nhập ", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                txtChietKhau.Text = null;
            }
        }

        private void radKMSP_CheckedChanged(object sender, EventArgs e)
        {
            txtCK.Enabled = false;
            dgvKhuyenMai.Enabled = true;
            dgvDSKM.Enabled = true;
            txtChietKhau.Enabled = true;
            btnHuy.Enabled = true;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void radKMDH_CheckedChanged(object sender, EventArgs e)
        {
            txtCK.Enabled = true;
            dgvKhuyenMai.Enabled = false;
            dgvDSKM.Enabled = false;
            txtChietKhau.Enabled = false;
            btnHuy.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void dgvDSKM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow dr = dgvDSKM.Rows[index];
                tempCTKM = dr.Cells["MaGiay"].Value.ToString();
                tempIndex = index;
            }
            catch (Exception ex)
            {
                tempCTKM = null;
                return;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtIDGiay.Text == "" || txtChietKhau.Text == "")
            {
                MessageBox.Show("Mã giày không tồn tại hoặc không có chiết khấu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (DataGridViewRow row in dgvDSKM.Rows)
                {
                    if (dgvDSKM.Rows.Count > 1 && row.Cells["MaGiay"].Value != null && txtIDGiay.Text.Equals(row.Cells["MaGiay"].Value.ToString()))
                    {
                        MessageBox.Show("Mã giày đã có trong danh sách khuyến mãi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                int check;
                if (Int32.TryParse(txtChietKhau.Text, out check))
                {
                    CTKhuyenMai_DTO ChiTietKM = new CTKhuyenMai_DTO();
                    ChiTietKM.MaGiay = Convert.ToInt32(txtIDGiay.Text);
                    ChiTietKM.ChietKhau = Convert.ToInt32(txtChietKhau.Text);
                    listCTKhuyenMai.Add(ChiTietKM);
                    listCTKM.Add(ChiTietKM);
                    dgvDSKM.DataSource = listCTKhuyenMai;
                    dgvDSKM.Columns["MAKM"].Visible = false;
                }
                else
                {
                    MessageBox.Show("Nhập sai chiết khấu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                //DataTable data = CTKhuyenMaiDAO.Instance.InsertCTKM(Convert.ToInt32(txtIDGiay.Text), Convert.ToInt32(txtChietKhau.Text), Convert.ToInt32(lblMaKM.Text));
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (tempCTKM == null)
            {
                MessageBox.Show("Chọn ít nhất 1 chi tiết khuyến mãi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa chi tiết khuyến mãi là: " + tempCTKM, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    listCTKhuyenMai.RemoveAt(tempIndex);
                    listCTKM.RemoveAt(tempIndex);
                    tempIndex = 0;
                    tempCTKM = null;
                    dgvDSKM.DataSource = listCTKhuyenMai;
                }
                else
                {
                    return;
                }
            }
        }

        private void btnHoanThanh_Click(object sender, EventArgs e)
        {
            if (txtTenCT.Text == "" || dtpTuNgay == null || dtpDenNgay == null)
            {
                MessageBox.Show("Nhập đầy đủ thông tin chương trình khuyến mãi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (radKMDH.Checked == true)
            {
                KhuyenMaiDAO.Instance.InsertKM(txtTenCT.Text, txtMoTa.Text, Convert.ToDateTime(dtpTuNgay.Text), Convert.ToDateTime(dtpDenNgay.Text), float.Parse(txtCK.Text));
                MessageBox.Show("thêm thành công 1 phiếu đổi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                KhuyenMaiDAO.Instance.HoanThanh(listCTKM, txtTenCT.Text, txtMoTa.Text, Convert.ToDateTime(dtpTuNgay.Text), Convert.ToDateTime(dtpDenNgay.Text));
                MessageBox.Show("thêm thành công 12222 phiếu đổi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }


            listCTKhuyenMai.DataSource = SanPhamDAO.Instance.GetListGiay();
            fKhuyenMai KM = new fKhuyenMai();
            this.Hide();
            KM.ShowDialog();
            this.Show();
        }
    }
}
