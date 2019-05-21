using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTN.DTO
{
    class CTKhuyenMai_DTO
    {
        private int maKM;
        private int maGiay;
        private float chietKhau;

        public int MaKM
        {
            get { return maKM; }
            set { maKM = value; }
        }
        public int MaGiay
        {
            get { return maGiay; }
            set { maGiay = value; }
        }
        public float ChietKhau
        {
            get { return chietKhau; }
            set { chietKhau = value; }
        }
        public CTKhuyenMai_DTO()
        {
            maKM = 0;
            maGiay = 0;
            chietKhau = 0;
        }
        public CTKhuyenMai_DTO(int MaKM,int MaGiay , float ChietKhau)
        {
            this.maKM = MaKM;
            this.maGiay = MaGiay;
            this.chietKhau = ChietKhau;
        }
        public CTKhuyenMai_DTO(DataRow row)
        {
            int.TryParse(row["IDKhuyenMai"].ToString(), out this.maKM);
            Int32.TryParse(row["IDGiay"].ToString(), out this.maGiay);
            float.TryParse(row["ChietKhau"].ToString(), out this.chietKhau);
            
        }
    }
}
