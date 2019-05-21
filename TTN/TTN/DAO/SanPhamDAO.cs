using TTN.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTN.DAO
{
    class SanPhamDAO
    {
        private static SanPhamDAO instance;

        public static SanPhamDAO Instance
        {
            get { if (instance == null) instance = new SanPhamDAO(); return instance; }
            private set { instance = value; }
        }

        public List<Giay_DTO> GetListGiay()
        {
            List<Giay_DTO> maGiayList = new List<Giay_DTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM GIAY");
            foreach (DataRow item in data.Rows)
            {
                Giay_DTO maGiay = new Giay_DTO(item);
                maGiayList.Add(maGiay);
            }
            return maGiayList;
        }

        public bool InsertGiay(string TenGiay, int SoLuong, decimal DonGia)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("Insert into GIAY(TenGiay,SoLuong,DonGia) Values(" +
                              "N'" + TenGiay + "'," +
                              "N'" + SoLuong + "'," +
                              "N'" + DonGia + "'" +
                               ")");

            return result>0;
        }

        public bool DeleteGiay(int id)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("EXEC USP_DeleteGiay @id ", new object[] { id });
            return result>0;
        }

        public bool UpdateGiay(int IDGiay, string TenGiay, int SoLuong, decimal DonGia)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("exec USP_UpdateGiay @maGiay , @ten , @soluong , @dongia ", new object[] { IDGiay,TenGiay,SoLuong,DonGia });
            
            return result>0;
        }

        public List<Giay_DTO> SearchGiay(string TenGiay)
        {
            List<Giay_DTO> DSGiay = new List<Giay_DTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("exec USP_SearchGiay @TenGiay ", new object[] { TenGiay });
            foreach (DataRow item in data.Rows)
            {
                Giay_DTO kh = new Giay_DTO(item);
                DSGiay.Add(kh);
            }
            return DSGiay;
        }
    }
}
