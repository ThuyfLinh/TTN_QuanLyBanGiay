using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace TTN.DTO
{
    class TenGiay_DTO
    {
        private int IDgiay;
        private string tenGiay;
        private int soLuong;
        private decimal donGia;

        public int IDGiay
        {
            get { return IDgiay; }
            set { IDgiay = value; }
        }

        public string TenGiay
        {
            get { return tenGiay; }
            set { tenGiay = value; }
        }
        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }
        public decimal DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }
        public TenGiay_DTO()
        {
            this.IDgiay = 0;
            this.tenGiay = "";
            this.soLuong = 0;
            this.donGia = 0;
        }
        public TenGiay_DTO(int IDGiay, string TenGiay, int SoLuong, int DonGia)
        {
            this.IDgiay = IDGiay;
            this.tenGiay = TenGiay;
            this.soLuong = SoLuong;
            this.donGia = DonGia;
        }
        public TenGiay_DTO(DataRow row)
        {
      //      Int32.TryParse(row["IDGiay"].ToString(), out this.IDgiay);
            this.tenGiay = row["TenGiay"].ToString();
      //      Int32.TryParse(row["SoLuong"].ToString(), out this.soLuong);
      //      decimal.TryParse(row["DonGia"].ToString(), out this.donGia);
        }
    }
}
