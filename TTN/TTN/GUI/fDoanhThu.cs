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
    public partial class fDoanhThu : MetroFramework.Forms.MetroForm
    {
        public fDoanhThu()
        {
            InitializeComponent();
            Load();
            LoadDateTimePicker();
        }
        public string TenNV { get; set; }
        void Load()
        {
            dgvThongKe.DataSource = ThongKe_DAO.Instance.ThongKe(dtpTuNgay.Value, dtpDenNgay.Value);
            TongDoanhThu();
        }
        void LoadDateTimePicker()
        {
            DateTime today = DateTime.Now;
            dtpTuNgay.Value = new DateTime(today.Year, today.Month, 1);
            dtpDenNgay.Value = DateTime.Now;
        }
        void TongDoanhThu()
        {
            double tongtien = 0;
            int n = dgvThongKe.Rows.Count;
            for (int i = 0; i < n; i++)
            {
                double y;
                string s = dgvThongKe.Rows[i].Cells["TongTien"].Value.ToString();
                double.TryParse(s, out y);
                tongtien = tongtien + y;
            }
            lblTongTien.Text = tongtien.ToString();
            lblTongHoaDon.Text = n.ToString();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            Load();
        }
    }
}
