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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            fThongKe form = new fThongKe();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
    }
}
