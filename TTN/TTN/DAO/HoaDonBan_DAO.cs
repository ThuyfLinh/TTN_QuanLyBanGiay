using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTN.DTO;
using System.Data;

namespace TTN.DAO
{
    class HoaDonBan_DAO
    {
        private static HoaDonBan_DAO instance;

        public static HoaDonBan_DAO Instance
        {
            get { if (instance == null) instance = new HoaDonBan_DAO(); return instance; }
            private set { instance = value; }
        }
        public List<HoaDonBan_DTO> GetHoaDonBan()
        {
            List<HoaDonBan_DTO> ListHoaDonBan = new List<HoaDonBan_DTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("PROC_GetListHoaDonBan");
            foreach (DataRow item in data.Rows)
            {
                HoaDonBan_DTO hoadonban = new HoaDonBan_DTO(item);
                ListHoaDonBan.Add(hoadonban);
            }
            return ListHoaDonBan;
        }
        public List<HoaDonBan_DTO> SearchHD(string str)
        {
            List<HoaDonBan_DTO> HDList = new List<HoaDonBan_DTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC proc_searchHoaDonBan  @str ", new object[] { str });
            foreach (DataRow item in data.Rows)
            {
                HoaDonBan_DTO hdb = new HoaDonBan_DTO(item);
                HDList.Add(hdb);
            }
            return HDList;
        }
        public bool Insert_HoaDonBan_KHold(string tenNV, string tenKH, string tenCT, DateTime ngay,string sdt)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC PROC_INSERT_HoaDonBan_KHold  @TenNV , @TenKH , @SDT , @TenCT , @Ngay ", new object[] {tenNV,tenKH,sdt,tenCT,ngay });

            return result > 0;
        }
        public bool Insert_HoaDonBan_KHnew(string tenNV, string tenKH, string tenCT, DateTime ngay, string sdt)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC PROC_INSERT_HoaDonBan_KHnew  @TenNV , @TenKH , @SDT , @TenCT , @Ngay ", new object[] { tenNV, tenKH, sdt, tenCT, ngay });

            return result > 0;
        }
        public bool Update_HoaDonBan(int maHD,string tenNV, string tenKH, string tenCT, DateTime ngay, string sdt)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("exec PROC_UPDATE_HoaDonBan  @MaHD , @TenNV , @TenKH , @SoDT , @TenCT , @Ngay ", new object[] { maHD,tenNV, tenKH, sdt, tenCT, ngay });

            return result > 0;
        }
    }
}
