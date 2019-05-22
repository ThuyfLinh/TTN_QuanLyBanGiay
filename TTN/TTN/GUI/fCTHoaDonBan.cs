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
        }


    }
}
