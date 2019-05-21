using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTN.DTO
{
    class HoaDonNhapDTO
    {
        private int idHoaDon;
        private DateTime ngayNhap;
        private int idNhanVien;

        public int IdHoaDon { get => idHoaDon; set => idHoaDon = value; }
        public DateTime NgayNhap { get => ngayNhap; set => ngayNhap = value; }
        public int IdNhanVien { get => idNhanVien; set => idNhanVien = value; }
        public HoaDonNhapDTO(int idHoaDon, DateTime ngayNhap ,  int idNhanVien)
        {
            this.idHoaDon = idHoaDon;
            this.ngayNhap = ngayNhap;
            this.idNhanVien = idNhanVien;
        }
        public HoaDonNhapDTO(DataRow row)
        {
            Int32.TryParse(row["IDHoaDon"].ToString(), out this.idHoaDon);

            DateTime.TryParse(row["NgayNhap"].ToString(), out ngayNhap);


            Int32.TryParse(row["IDNhanVien"].ToString(), out this.idNhanVien);

        }
    }
}
