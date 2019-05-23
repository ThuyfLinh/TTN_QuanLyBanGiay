using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTN.GUI
{
    public partial class fThongKeNV : MetroFramework.Forms.MetroForm
    {
        public fThongKeNV()
        {
            InitializeComponent();
        }

       

        private void btnPrint_Click_1(object sender, EventArgs e)
        {
            string name = txtName.Text;
            if (name == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin");
                return;
            }
            fThongKe frame = new fThongKe(name);
            this.Hide();
            frame.ShowDialog();
            this.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
