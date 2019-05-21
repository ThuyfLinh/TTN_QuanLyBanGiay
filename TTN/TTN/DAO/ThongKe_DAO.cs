using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTN.DTO;

namespace TTN.DAO
{
    class ThongKe_DAO
    {
        private static ThongKe_DAO instance;

        internal static ThongKe_DAO Instance
        {
            get { if (instance == null) instance = new ThongKe_DAO(); return instance; }
            private set { instance = value;}
        }
        public List<ThongKe_DTO> ThongKe(DateTime tungay, DateTime denngay)
        {
            List<ThongKe_DTO> list = new List<ThongKe_DTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery(" EXEC USP_ThongKeDoanhThu @tungay , @denngay", new object[]{ tungay , denngay});
            foreach (DataRow item in data.Rows)
            {
                ThongKe_DTO thongke = new ThongKe_DTO(item);
                list.Add(thongke);
            }
            return list;

        }
    }
}
