using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTN.DTO;
using System.Data;

namespace TTN.DAO
{
    class KhachHang_DAO
    {
        private static KhachHang_DAO instance;

        internal static KhachHang_DAO Instance
        {
            get { if (instance == null) instance = new KhachHang_DAO(); return instance; }
            private set { instance = value; }
        }
        public List<KhachHang_DTO> GetDSKH()
        {
            List<KhachHang_DTO> list = new List<KhachHang_DTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("dbo.USP_GetallkhachHang");
            foreach (DataRow item in data.Rows)
            {
                KhachHang_DTO KH = new KhachHang_DTO(item);
                list.Add(KH);
            }
            return list;
        }

        public bool InsertKH(string tenkh, int sdt)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC USP_InsertKhachHang @tenkh , @sdt  ", new object[] { tenkh, sdt });

            return result > 0;
        }
        public bool UpdateKH(int makh, string tenkh, int sdt)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC USP_UpdateKhachHang @makh ,  @tenkh , @sdt  ", new object[] { makh, tenkh, sdt });

            return result > 0;
        }
        public bool DeleteKhachHang(int makh)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC USP_DeleteKhachHang @makh ", new object[] { makh });

            return result > 0;
        }
        public List<KhachHang_DTO> SearchKH(string str)
        {
            List<KhachHang_DTO> KHlist = new List<KhachHang_DTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_SearchKhachHang @search ", new object[] { str });
            foreach (DataRow item in data.Rows)
            {
                KhachHang_DTO kh = new KhachHang_DTO(item);
                KHlist.Add(kh);
            }
            return KHlist;
        }
    }
}
