using TTN.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTN.DAO
{
    class CTKhuyenMaiDAO
    {
        private static CTKhuyenMaiDAO instance;

        public static CTKhuyenMaiDAO Instance
        {
            get { if (instance == null) instance = new CTKhuyenMaiDAO(); return instance; }
            private set { instance = value; }
        }

        public List<CTKhuyenMai_DTO> GetListCTKM()
        {
            List<CTKhuyenMai_DTO> ListCTKM = new List<CTKhuyenMai_DTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT IDGIAY,CHIETKHAU FROM CTKHUYENMAI");
            foreach (DataRow item in data.Rows)
            {
                CTKhuyenMai_DTO MaGiay = new CTKhuyenMai_DTO(item);
                ListCTKM.Add(MaGiay);
            }
            return ListCTKM;
        }

        public List<CTKhuyenMai_DTO> ListCTKM(int ID)
        {
            List<CTKhuyenMai_DTO> ListCTKM = new List<CTKhuyenMai_DTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_ListCTKM @ID ", new object[] { ID });
            foreach (DataRow item in data.Rows)
            {
                CTKhuyenMai_DTO MaKM = new CTKhuyenMai_DTO(item);
                ListCTKM.Add(MaKM);
            }
            return ListCTKM;
        }

        public bool InsertCTKM(int IDKM,int IDGiay, float ChietKhau)
        {
            int result = DataProvider.Instance.ExecuteNonQuery( "Insert into CTKHUYENMAI(IDKhuyenMai,IDGiay,ChietKhau) Values(" +
                              "N'" + IDKM + "'," +
                              "N'" + IDGiay + "'," +
                              "N'" + ChietKhau + "'" +
                               ")" );
            return result>0;
        }
        public List<CTKhuyenMai_DTO> SearchKM(string str)
        {
            List<CTKhuyenMai_DTO> KMList = new List<CTKhuyenMai_DTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_SearchKM @str ", new object[] { str });
            foreach (DataRow item in data.Rows)
            {
                CTKhuyenMai_DTO tenKM = new CTKhuyenMai_DTO(item);
                KMList.Add(tenKM);
            }
            return KMList;
        }
        public bool DeleteCTKM(int idkm, int idgiay )
        {
            int result = DataProvider.Instance.ExecuteNonQuery("exec USP_DeleteCTKM @maGiay , @maKM ", new object[] { idgiay , idkm });
            return result>0;
        }
        public bool UpdateCTKM(int idkm, int idgiay, int chietkhau)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("exec USP_UpdateCT @idkm , @idgiay , @chietkhau ", new object[] { idkm, idgiay,chietkhau });
            return result > 0;
        }
    }
}
