using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTN.DTO
{
    class KhuyenMaiDTO
    {
        private int maKM;
        private string tenCT;
        private string moTa;
        private DateTime ngayBD;
        private DateTime ngayKT;
        private float chietKhau;

        public int MaKM
        {
            get { return maKM; }
            set { maKM = value; }
        }

        public string TenCT
        {
            get { return tenCT; }
            set { tenCT = value; }
        }

        public string MoTa
        {
            get { return moTa; }
            set { moTa = value; }
        }

        public DateTime NgayBD
        {
            get { return ngayBD; }
            set { ngayBD = value; }
        }

        public DateTime NgayKT
        {
            get { return ngayKT; }
            set { ngayKT = value; }
        }
        
        public float ChietKhau
        {
            get { return chietKhau; }
            set { chietKhau = value; }
        }

        

        public KhuyenMaiDTO(int MaKM,string TenCT,string MoTa,DateTime NgayBD,DateTime NgayKT,float ChietKhau)
        {
            this.maKM = MaKM;
            this.tenCT = TenCT;
            this.moTa = MoTa;
            this.ngayBD = NgayBD;
            this.ngayKT = NgayKT;
            this.chietKhau = ChietKhau;
        }

        public KhuyenMaiDTO(DataRow row)
        {
            Int32.TryParse(row["IDKhuyenMai"].ToString(), out this.maKM);
            this.tenCT = row["TenCT"].ToString();
            this.moTa = row["MoTa"].ToString();
            DateTime.TryParse(row["NgayBD"].ToString(), out this.ngayBD);
            DateTime.TryParse(row["NgayKT"].ToString(), out this.ngayKT);
            float.TryParse(row["ChietKhau"].ToString(), out this.chietKhau);
        }
    }
}
