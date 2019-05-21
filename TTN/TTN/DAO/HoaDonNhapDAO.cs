using TTN.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTN.DAO
{
    class HoaDonNhapDAO
    {
        private static HoaDonNhapDAO instance;

        public  static HoaDonNhapDAO Instance
        {
            get { if (instance == null) { instance = new HoaDonNhapDAO(); }return instance; }
            private set { instance = value; }
        }
        public List<HoaDonNhapDTO> GETHOADONNHAP()
        {
            List<HoaDonNhapDTO> list = new List<HoaDonNhapDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("dbo.USP_GETHOADONNHAP ");
            foreach (DataRow item in data.Rows)
            {
                HoaDonNhapDTO hd = new HoaDonNhapDTO(item);
                list.Add(hd);
            }
            return list;
        }
        public bool INSERTHOADONNHAP(DateTime ngayNhap, int idNhanVien)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC USP_INSERTHOADONNHAP @NgayNhap , @idNhanVien ", new object[] { ngayNhap, idNhanVien });

            return result > 0;
        }
        public bool UPDATEHOADONNHAP(int idHoaDon, DateTime ngayNhap, int idNhanVien)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("USP_UPDATEHOADONNHAP @IDHoaDon , @NgayNhap , @idNhanVien ", new object[] { idHoaDon, ngayNhap, idNhanVien });

            return result > 0;
        }
        public bool DELETEHOADONNHAP(int idHoaDon)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC USP_DELETEHOADONNHAP @IDHoaDon ", new object[] { idHoaDon });

            return result > 0;
        }
        public List<HoaDonNhapDTO> SEARCHHOADONNHAP(string str)
        {
            List<HoaDonNhapDTO> HDList = new List<HoaDonNhapDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_SEARCHHOADONNHAP @str ", new object[] { str });
            foreach (DataRow item in data.Rows)
            {
                HoaDonNhapDTO hd = new HoaDonNhapDTO(item);
                HDList.Add(hd);
            }
            return HDList;
        }
    }
}
