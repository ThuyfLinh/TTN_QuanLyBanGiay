using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace TTN.DTO
{
    class KhachHang_DTO
    {
        private int makh;
        private string tenkh;
        private int sdt;

        public int Makh { get => makh; set => makh = value; }
        public string Tenkh { get => tenkh; set => tenkh = value; }
        public int Sdt { get => sdt; set => sdt = value; }

        public KhachHang_DTO(int makh, string tenkh, int sdt)
        {
            this.makh = makh;
            this.tenkh = tenkh;
            this.Sdt = sdt;
        }
        public KhachHang_DTO(DataRow row)
        {
            Int32.TryParse(row["IDKhachHang"].ToString(), out this.makh);
            this.tenkh = row["TenKhachHang"].ToString();
            Int32.TryParse(row["SDT"].ToString(), out this.sdt);
        }
    }
}
