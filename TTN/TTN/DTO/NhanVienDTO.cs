using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTN.DTO
{
    class NhanVienDTO
    {
        private int idNv;
        private string tenNv;
        private DateTime ngaySinh;
        private string diaChi;

        public int IdNv { get => idNv; set => idNv = value; }
        public string TenNv { get => tenNv; set => tenNv = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }

        public string DiaChi { get => diaChi; set => diaChi = value; }

        public NhanVienDTO(int idNv,string tenNv,DateTime ngaySinh,string diaChi)
        {
            this.idNv = idNv;
            this.tenNv = tenNv;
            this.ngaySinh = ngaySinh;
            this.diaChi = diaChi;
        }
        public NhanVienDTO(DataRow row)
        {
            int.TryParse(row["IDNhanVien"].ToString(), out this.idNv);
            this.tenNv = row["TenNV"].ToString();
            DateTime.TryParse(row["NgSinh"].ToString(), out this.ngaySinh);
            this.diaChi = row["DiaChi"].ToString();
        }
    }
}
