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
    public partial class fHoaDonNhap : MetroFramework.Forms.MetroForm
    {
        BindingSource HDNList = new BindingSource();
        BindingSource CTHDNList = new BindingSource();
        public fHoaDonNhap()
        {
            InitializeComponent();
            LoadHDN();
            LoadCTHDN();
        }
        public void LoadCTHDN()
        {
            dgvCTHoaDonNhap.DataSource = CTHoaDonNhapDAO.Instance.GETCTHoaDonNhap();
        }

        public void LoadHDN()
        {
            dgvHoaDonNhap.DataSource = HDNList;
            dgvHoaDonNhap.DataSource = HoaDonNhapDAO.Instance.GETHOADONNHAP();
            dgvHoaDonNhap.Columns["IDHoaDon"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            // LoadListHDN();
            LoadIntoComBoBoxIDNhanVien(cboIDNhanVien);
           // LoadIntoComBoBoxIDGiay(cboIDGiay);

            AddBinding();
        }
        void LoadlistHDN()
        {
            HDNList.DataSource = HoaDonNhapDAO.Instance.GETHOADONNHAP();
            //EditDataGridView();
        }
        void LoadIntoComBoBoxIDNhanVien(ComboBox cb)
        {
            cb.DataSource = HoaDonNhapDAO.Instance.GETHOADONNHAP();
            cb.DisplayMember = "IDNhanVien";
        }
        void LoadIntoComBoBoxIDGiay(ComboBox cb)
        {
            cb.DataSource = CTHoaDonNhapDAO.Instance.GETCTHoaDonNhap();
            cb.DisplayMember = "IDGiay";
        }
        void AddBinding()
        {
            lblIDHoaDonNhap.DataBindings.Clear();
            lblIDHoaDonNhap.DataBindings.Add(new Binding("Text", dgvHoaDonNhap.DataSource, "idHoaDon", true, DataSourceUpdateMode.Never));
            dtpNgayNhap.DataBindings.Clear();
            dtpNgayNhap.DataBindings.Add(new Binding("Text", dgvHoaDonNhap.DataSource, "ngayNhap", true, DataSourceUpdateMode.Never));
            cboIDNhanVien.DataBindings.Clear();
            cboIDNhanVien.DataBindings.Add(new Binding("Text", dgvHoaDonNhap.DataSource, "", true, DataSourceUpdateMode.Never));
        }
        private void cboIDNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "") MessageBox.Show("Chưa nhập thông tin tìm kiếm");
            string str = txtSearch.Text;
            dgvHoaDonNhap.DataSource = HDNList;
            dgvHoaDonNhap.DataSource = HoaDonNhapDAO.Instance.SEARCHHOADONNHAP(str);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblIDHoaDonNhap.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            long check;
            if (MessageBox.Show("Bạn có thật sự muốn thêm hóa đơn nhập có mã là: " + lblIDHoaDonNhap.Text, "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                if (lblIDNhanVien.Text == "" || dtpNgayNhap.Text == "")
                {
                    MessageBox.Show("Sai hoặc thiếu thông tin");

                }
                else
                {
                    int idNhanVien;
                    Int32.TryParse(cboIDNhanVien.Text, out idNhanVien);
                    DateTime ngayNhap;
                    DateTime.TryParse(dtpNgayNhap.Text, out ngayNhap);

                    int idHoaDon;
                    int idGiay;
                    int SLYeuCau;
                    int SLNhan;
                    decimal donGia;

                    Int32.TryParse(lblIDHoaDonNhap.Text, out idHoaDon);
                    Int32.TryParse(TxtIDGiay.Text, out idGiay);
                    Int32.TryParse(txtSLNhan.Text, out SLNhan);
                    Int32.TryParse(txtSLYeuCau.Text, out SLYeuCau);
                    decimal.TryParse(txtDonGia.Text, out donGia);

                    if (lblIDHoaDonNhap.Text == "")
                    {
                        if (HoaDonNhapDAO.Instance.INSERTHOADONNHAP(ngayNhap, idNhanVien))
                        {
                            MessageBox.Show("Thêm thông tin hóa đơn nhập thành công! ");
                        }
                    }
                    else
                    {
                        if (CTHoaDonNhapDAO.Instance.INSERTCTHOADONNHAP(idHoaDon, idGiay, donGia, SLYeuCau, SLNhan))
                        {
                            MessageBox.Show("Thêm thông tin hóa đơn nhập thành công! ");

                        }
                    }
                    LoadHDN();
                    LoadCTHDN();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            long check;
            if (MessageBox.Show("Bạn có thật sự muốn sửa hóa đơn có mã là: " + lblIDHoaDonNhap.Text, "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                int idHoaDon;
                Int32.TryParse(lblIDHoaDonNhap.Text, out idHoaDon);
                DateTime ngayNhap;
                DateTime.TryParse(dtpNgayNhap.Text, out ngayNhap);
                int idNhanVien;
                Int32.TryParse(cboIDNhanVien.Text, out idNhanVien);

                if (HoaDonNhapDAO.Instance.UPDATEHOADONNHAP(idHoaDon, ngayNhap, idNhanVien))
                {
                    MessageBox.Show("Sửa thông tin hóa đơn nhập thành công! ");
                    LoadlistHDN();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi sửa thông tin hóa đơn nhập! ");
                }

            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            LoadlistHDN();
        }
    }
}
