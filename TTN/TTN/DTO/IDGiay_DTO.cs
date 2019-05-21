using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTN.DTO
{
    class IDGiay_DTO
    {
        private int idGiay;

        public int IdGiay { get => idGiay; set => idGiay = value; }
        public IDGiay_DTO(int idGiay)
        {
            this.idGiay = idGiay;
        }
        public IDGiay_DTO(DataRow row)
        {
            Int32.TryParse(row["IDGiay"].ToString(), out this.idGiay);
        }
    }
}
