using TTN.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTN.DAO
{
    class KhuyenMaiDAO
    {
        private static KhuyenMaiDAO instance;

        public static KhuyenMaiDAO Instance
        {
            get { if (instance == null) instance = new KhuyenMaiDAO(); return instance; }
            private set { instance = value; }
        }

        public List<KhuyenMaiDTO> GetKhuyenMai()
        {
            List<KhuyenMaiDTO> ListKhuyenMai = new List<KhuyenMaiDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from KhuyenMai");
            foreach (DataRow item in data.Rows)
            {
                KhuyenMaiDTO khuyenMai = new KhuyenMaiDTO(item);
                ListKhuyenMai.Add(khuyenMai);
            }
            return ListKhuyenMai;
        }
        public List<KhuyenMaiDTO> SearchKM(string str)
        {
            List<KhuyenMaiDTO> KMList = new List<KhuyenMaiDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_SearchKM @str ", new object[] { str });
            foreach (DataRow item in data.Rows)
            {
                KhuyenMaiDTO tenKM = new KhuyenMaiDTO(item);
                KMList.Add(tenKM);
            }
            return KMList;
        }
        public int SelectID()
        {
            int result = DataProvider.Instance.ExecuteNonQuery("Select IDGiay from KHUYENMAI");
            return result;
        }

        public bool UpdateKM(int idkm, string tenct, string mota, DateTime ngaybd, DateTime ngaykt, float chietkhau)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("EXEC USP_UpdateKM @idkm , @ten , @mota , @ngaybd , @ngaykt , @chietkhau ", new object[] { idkm, tenct, mota, ngaybd, ngaykt, chietkhau });

            return result > 0;
        }
        public bool DeleteKM(int maKM)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("EXEC USP_DeleteKM @maKM ", new object[] { maKM });

            return result > 0;
        }

        public int InsertKM(string tenct, string mota, DateTime ngaybd, DateTime ngaykt, float chietkhau)
        {

            //string query = string.Format("EXEC USP_InsertKM @ten , @mota , @ngaybd , @ngaykt , @chietkhau ", new object[] { tenct, mota, ngaybd, ngaykt, chietkhau });
            string query = "Insert into KHUYENMAI(TenCT,MoTa,NgayBD,NgayKT,ChietKhau) values (" +
                "N'"+tenct+"',"+
                "N'" + mota + "'," +
                "'" + ngaybd + "'," +
                "'" + ngaykt + "'," +
                 chietkhau +
                ")";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        public int LayIDKM()
        {
            int id = 0;
            string query = string.Format("select max(IDKhuyenMai) as IDKhuyenMai from KHUYENMAI");
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            if(data.Rows.Count <= 0)
            {
                return 0;
            }
            else
            {
                foreach(DataRow item in data.Rows)
                {
                    id = Convert.ToInt32(item["IDKhuyenMai"]);
                }
            }
            return id;
        }

        public int ThemCTKM(List<CTKhuyenMai_DTO> CTKM,int IDKM)
        {
                foreach (CTKhuyenMai_DTO ct in CTKM)
                {
                    int insert = DataProvider.Instance.ExecuteNonQuery("EXEC USP_ThemCTKM @IDKM , @MaGiay , @ChietKhau ", new object[] { IDKM, ct.MaGiay, ct.ChietKhau });
                }
                return 1;
        }

        public string HoanThanh(List<CTKhuyenMai_DTO> CTKM,string TenCT,string MoTa,DateTime NgayBD,DateTime NgayKT)
        {
                InsertKM(TenCT, MoTa, NgayBD, NgayKT,0);
                int IDKMMoi=LayIDKM();
                ThemCTKM(CTKM, IDKMMoi);
                return "success";
        }
        
    }
}
