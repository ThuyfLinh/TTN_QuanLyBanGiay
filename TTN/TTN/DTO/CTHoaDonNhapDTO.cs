using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTN.DTO
{
    class CTHoaDonNhapDTO
    {
        private int idHoaDon;
        private int idGiay;
        private decimal donGia;
        private int slYeuCau;
        private int slNhan;

        public int IdHoaDon { get => idHoaDon; set => idHoaDon = value; }
        public int IdGiay { get => idGiay; set => idGiay = value; }
        public decimal DonGia { get => donGia; set => donGia = value; }
        public int SlYeuCau { get => slYeuCau; set => slYeuCau = value; }
        public int SlNhan { get => slNhan; set => slNhan = value; }
        public CTHoaDonNhapDTO(int idHoaDon,int idGiay,decimal donGia,int slYeuCau,int slNhan)
        {
            this.idHoaDon = idHoaDon;
            this.idGiay = idGiay;
            this.donGia = donGia;
            this.slYeuCau = slYeuCau;
            this.slNhan = slNhan;
        }
        public CTHoaDonNhapDTO(DataRow row)
        {
            Int32.TryParse(row["IDHoaDon"].ToString(), out this.idHoaDon);
            Int32.TryParse(row["IDGiay"].ToString(), out this.idGiay);
            decimal.TryParse(row["DonGia"].ToString(), out this.donGia);          
            Int32.TryParse(row["SLYeuCau"].ToString(), out this.slYeuCau);
            Int32.TryParse(row["SLNhan"].ToString(), out this.slNhan);

        }
    }
}
