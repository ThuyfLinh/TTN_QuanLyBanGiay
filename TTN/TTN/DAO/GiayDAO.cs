using TTN.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTN.DAO
{
    class GiayDAO
    {
        private static GiayDAO instance;

        internal static GiayDAO Instance
        {
            get { if (instance == null) instance = new GiayDAO(); return instance; }
            private set { instance = value; }
        }
       

        public List<Giay_DTO> GetGiay()
        {
            List<Giay_DTO> list = new List<Giay_DTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("dbo.USP_GETGIAY ");
            foreach (DataRow item in data.Rows)
            {
                Giay_DTO Giay = new Giay_DTO(item);
                list.Add(Giay);
            }
            return list;
        }



        public bool INSERTGIAY(string tenGiay, int soLuong, decimal donGia)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC USP_GIAY @TenGiay , @SoLuong , @DonGia ", new object[] { tenGiay, soLuong, donGia });

            return result > 0;
        }

   

        public bool UPDATEGIAY(int idGiay, string tenGiay, int soLuong, decimal donGia)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC USP_UPDATEGIAY @IDGiay , @TenGiay , @SoLuong , @DonGia ", new object[] { idGiay, tenGiay, soLuong, donGia });

            return result > 0;
        }
        public bool DELETEGIAY(int idGiay)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC USP_DELETEGIAY @IDGiay ", new object[] { idGiay });

            return result > 0;
        }
        public List<Giay_DTO> SEARCHGIAY(string str)
        {
            List<Giay_DTO> GiayList = new List<Giay_DTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_SEARCHGIAY @search ", new object[] { str });
            foreach (DataRow item in data.Rows)
            {
                Giay_DTO Giay = new Giay_DTO(item);
                GiayList.Add(Giay);
            }
            return GiayList;
        }
    }
}
