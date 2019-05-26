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
    public partial class fKhachHang : MetroFramework.Forms.MetroForm
    {
        BindingSource KHlist = new BindingSource();
        public fKhachHang()
        {
            InitializeComponent();
            LoadKH();
        }
        public void LoadKH()
        {
            dgvKhachHang.DataSource = KHlist;
            LoadListKH();
            AddBinding();

        }
        void LoadListKH()
        {

            KHlist.DataSource = KhachHang_DAO.Instance.GetDSKH();
            EditDataGridView();

        }

        void EditDataGridView()
        {
            dgvKhachHang.Columns["MaKH"].HeaderText = "Mã KH";
            dgvKhachHang.Columns["MaKH"].Width = 50;
            dgvKhachHang.Columns["TenKH"].HeaderText = "Tên Khách Hàng";
            dgvKhachHang.Columns["TenKH"].Width = 400;
            dgvKhachHang.Columns["SDT"].HeaderText = "Số Điện Thoại";
            dgvKhachHang.Columns["SDT"].Width = 290;

        }
        void AddBinding()
        {
            txtMaKH.DataBindings.Add(new Binding("Text", dgvKhachHang.DataSource, "MaKH", true, DataSourceUpdateMode.Never));
            txtTenKH.DataBindings.Add(new Binding("Text", dgvKhachHang.DataSource, "TenKH", true, DataSourceUpdateMode.Never));
            txtSDT.DataBindings.Add(new Binding("Text", dgvKhachHang.DataSource, "SDT", true, DataSourceUpdateMode.Never));

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "") MessageBox.Show("Chưa nhập thông tin tìm kiếm");
            string str = txtTimKiem.Text;
            dgvKhachHang.DataSource = KHlist;
            KHlist.DataSource = KhachHang_DAO.Instance.SearchKH(str);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn sửa khách hàng có tên là: " + txtTenKH.Text, "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                if (txtTenKH.Text == "" || txtSDT.Text == "")
                {
                    MessageBox.Show("Sai hoặc thiếu thông tin");
                    //                    LoadListNV();
                }
                else
                {
                    int makh;
                    Int32.TryParse(txtMaKH.Text, out makh);
                    string tenkh = txtTenKH.Text;
                    int sdt;
                    Int32.TryParse(txtSDT.Text, out sdt);
                    if (KhachHang_DAO.Instance.UpdateKH(makh, tenkh, sdt))
                    {
                        MessageBox.Show("Sửa thông tin thành công! ");
                        LoadListKH();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi sửa thông tin! ");
                    }
                }
            }
        }

        private void btnThemKM_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thêm Khách hàng có tên là: " + txtTenKH.Text, "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                if (txtTenKH.Text == "" || txtSDT.Text == "")
                {
                    MessageBox.Show("Sai hoặc thiếu thông tin");
                    LoadListKH();
                }
                else
                {
                    string tenkh = txtTenKH.Text;
                    int sdt;
                    Int32.TryParse(txtSDT.Text, out sdt);
                    if (KhachHang_DAO.Instance.InsertKH(tenkh, sdt))
                    {
                        MessageBox.Show("Thêm khách hàng thành công! ");
                        LoadListKH();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi thêm khách hàng! ");
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn xóa Khách hàng có mã là: " + txtMaKH.Text, "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                int maKH;
                Int32.TryParse(txtMaKH.Text, out maKH);
                if (KhachHang_DAO.Instance.DeleteKhachHang(maKH))
                {
                    MessageBox.Show("Xóa khách hàng thành công! ");
                    LoadListKH();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi xóa khách hàng! ");
                }
            }
        }
    }
}
