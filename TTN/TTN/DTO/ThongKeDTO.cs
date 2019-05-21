using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTN.DTO
{
    class ThongKe_DTO
    {
        private int idGiay;
        private string tenGiay;
        private int soLuong;
        private float donGia;
        private float tongTien;

        public int IdGiay
        {
            get
            {
                return idGiay;
            }

            set
            {
                idGiay = value;
            }
        }

        public string TenGiay
        {
            get
            {
                return tenGiay;
            }

            set
            {
                tenGiay = value;
            }
        }

        public int SoLuong
        {
            get
            {
                return soLuong;
            }

            set
            {
                soLuong = value;
            }
        }

        public float DonGia
        {
            get
            {
                return donGia;
            }

            set
            {
                donGia = value;
            }
        }

        public float TongTien
        {
            get
            {
                return tongTien;
            }

            set
            {
                tongTien = value;
            }
        }

        public ThongKe_DTO(DataRow row)
        {
            Int32.TryParse(row["idGiay"].ToString(), out idGiay);
            Int32.TryParse(row["soLuong"].ToString(), out soLuong);
            float.TryParse(row["donGia"].ToString(), out donGia);
            float.TryParse(row["tongTien"].ToString(), out tongTien);
            TenGiay = row["tenGiay"].ToString();
        }
    }
}
