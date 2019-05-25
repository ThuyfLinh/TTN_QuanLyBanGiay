using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TNN.GUI;
using TTN.DAO;
using TTN.DTO;

namespace TTN.GUI
{
    public partial class fNhanVien : MetroFramework.Forms.MetroForm
    {
        BindingSource NvList = new BindingSource();
        public fNhanVien()
        {
            InitializeComponent();
            Load();
        }

        void Load()
        {
            dgvNhanVien.DataSource = NvList;
            LoadListNV();
            AddBinding();
        }

        void LoadListNV()
        {
            NvList.DataSource = NhanVienDAO.Instance.GetNV();
            EditDataGridView();
        }

        void AddBinding()
        {
            lblMa.DataBindings.Add(new Binding("Text", dgvNhanVien.DataSource, "IDNV", true, DataSourceUpdateMode.Never));
            txtHoTen.DataBindings.Add(new Binding("Text", dgvNhanVien.DataSource, "TenNV", true, DataSourceUpdateMode.Never));
            dtpNSNV.DataBindings.Add(new Binding("Text", dgvNhanVien.DataSource, "ngaySinh", true, DataSourceUpdateMode.Never));
            txtDiaChi.DataBindings.Add(new Binding("Text", dgvNhanVien.DataSource, "DIACHI", true, DataSourceUpdateMode.Never));
        }
        private void EditDataGridView()
        {
            dgvNhanVien.Columns["IDNV"].Visible = false;
            dgvNhanVien.Columns["TenNV"].HeaderText = "Họ Tên";
            dgvNhanVien.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            dgvNhanVien.Columns["DiaChi"].HeaderText = "Địa Chỉ";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "") MessageBox.Show("Chưa nhập thông tin tìm kiếm");
            string str = txtSearch.Text;
            dgvNhanVien.DataSource = NvList;
            NvList.DataSource = NhanVienDAO.Instance.SearchNv(str);
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            LoadListNV();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            lblMa.Text = "";
            txtHoTen.Text = "";
            txtDiaChi.Text = "";
            dtpNgaySinh.Value = DateTime.Now;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thêm nhân viên có tên là: " + txtHoTen.Text, "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                if (txtHoTen.Text == "" || txtDiaChi.Text == "")
                {
                    MessageBox.Show("Sai hoặc thiếu thông tin");
                    //                    LoadListNV();
                }
                else
                {
                    string hoTen = txtHoTen.Text;
                    DateTime ngaySinh;
                    DateTime.TryParse(dtpNgaySinh.Text, out ngaySinh);
                    string diaChi = txtDiaChi.Text;
                    if (NhanVienDAO.Instance.InsertNv(hoTen, ngaySinh, diaChi))
                    {
                        MessageBox.Show("Thêm nhân viên thành công! ");
                        LoadListNV();
                    }
                    else
                    {

                        MessageBox.Show("Có lỗi khi thêm nhân viên! ");
                    }
                }
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            //long check;
            if (MessageBox.Show("Bạn có thật sự muốn sửa nhân viên có tên là: " + txtHoTen.Text, "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                if (txtHoTen.Text == "" || txtDiaChi.Text == "")
                {
                    MessageBox.Show("Sai hoặc thiếu thông tin");
                }
                else
                {
                    string hoTen = txtHoTen.Text;
                    DateTime ngaySinh;
                    DateTime.TryParse(dtpNgaySinh.Text, out ngaySinh);
                    string diaChi = txtDiaChi.Text;
                    int maNv;
                    Int32.TryParse(lblMa.Text, out maNv);
                    if (NhanVienDAO.Instance.UpdateNv(hoTen, ngaySinh, diaChi, maNv))
                    {
                        MessageBox.Show("Sửa nhân viên thành công! ");
                        LoadListNV();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi sửa nhân viên! ");
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Nếu xóa nhân viên sẽ ảnh hưởng đến thông tin hóa đơn .Bạn có thật sự muốn xóa nhân viên có mã là: " + txtHoTen.Text, "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                int maNV;
                Int32.TryParse(lblMa.Text, out maNV);
                if (NhanVienDAO.Instance.DeleteNv(maNV))
                {
                    MessageBox.Show("Xóa nhân viên thành công! ");
                    LoadListNV();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi xóa nhân viên! ");
                }
            }
        }
    }
}
