using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTN.DTO
{
    class IDNhanVien_DTO
    {
        private int idNhanVien;
        
        public int IdNhanVien { get => idNhanVien; set => idNhanVien = value; }
        public IDNhanVien_DTO(int idNhanVien)
        {
            this.idNhanVien = idNhanVien;
        }
        public IDNhanVien_DTO(DataRow row)
        {
            Int32.TryParse(row["IDNhanVien"].ToString(), out this.idNhanVien);
        }
    }
}
