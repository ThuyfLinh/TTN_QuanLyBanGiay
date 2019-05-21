using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace TTN.DTO
{
    class HoaDonBan_DTO
    {
        private int maHD;
        private string tenNV;
        private string tenKH;
        private string tenCT;
        private DateTime ngay;
        private string sDT;

        public int MaHD { get => maHD; set => maHD = value ; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        public string TenCT { get => tenCT; set => tenCT = value; }
        public DateTime Ngay { get => ngay; set=> ngay = value; }
        public string SDT { get => sDT; set => sDT = value; }

        public HoaDonBan_DTO(int MaHD,string TenNV,string TenKH,string TenCT,DateTime Ngay,string SDT)
        {
            this.maHD = MaHD;
            this.tenNV = TenNV;
            this.tenKH = TenKH;
            this.tenCT = TenCT;
            this.sDT = SDT;
            this.ngay = Ngay;
        }
        public HoaDonBan_DTO(DataRow row)
        {
            Int32.TryParse(row["IDHoaDon"].ToString(), out this.maHD);
            this.tenNV = row["TenNV"].ToString();
            this.tenKH = row["TenKhachHang"].ToString();
            this.tenCT = row["TenCT"].ToString();
            DateTime.TryParse(row["ngay"].ToString(),out this.ngay);
            this.SDT = row["SDT"].ToString();
        }
    }
}
