using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace TTN.DTO
{
    class CTHoaDonBan_DTO
    {
        private int maHD;
        private int maGiay;
        private string tenGiay;
        private int soLuong;
        private decimal donGia;
        private float chieuKhau;

        public int MaHD { get => maHD; set => maHD = value; }
        public int MaGiay { get => maGiay; set => maGiay = value; }
        public string TenGiay { get => tenGiay; set => tenGiay = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public decimal DonGia { get => donGia; set => donGia = value; }
        public float ChieuKhau { get => chieuKhau; set => chieuKhau = value; }

        public CTHoaDonBan_DTO(int MaHD, int MaGiay, string TenGiay, int SoLuong, decimal DonGia, float ChieuKhau)
        {
            this.maHD = MaHD;
            this.maGiay = MaGiay;
            this.tenGiay = TenGiay;
            this.soLuong = SoLuong;
            this.donGia = DonGia;
            this.chieuKhau = ChieuKhau;
        }
        public CTHoaDonBan_DTO(DataRow row)
        {
            Int32.TryParse(row["IDHoaDon"].ToString(), out this.maHD);
            Int32.TryParse(row["IDGiay"].ToString(), out this.maGiay);
            this.tenGiay = row["TenGiay"].ToString();
            Int32.TryParse(row["SoLuong"].ToString(), out this.soLuong);
            Decimal.TryParse(row["DonGiaBan"].ToString(), out this.donGia);
            float.TryParse(row["ChietKhau"].ToString(), out this.chieuKhau);
        }
    }
}
