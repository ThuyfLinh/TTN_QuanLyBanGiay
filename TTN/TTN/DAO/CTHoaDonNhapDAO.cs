using TTN.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTN.DAO
{
    class CTHoaDonNhapDAO
    {
        private static CTHoaDonNhapDAO instance;

        internal static CTHoaDonNhapDAO Instance
        {
            get { if (instance == null) instance = new CTHoaDonNhapDAO(); return instance; }
            private set { instance = value; }
        }

        public CTHoaDonNhapDTO CTHoaDonNhapDTO { get; private set; }

        public List<CTHoaDonNhapDTO> GETCTHoaDonNhap()
        {
            List<CTHoaDonNhapDTO> list = new List<CTHoaDonNhapDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("dbo.USP_GETCTHoaDonNhap ");
            foreach (DataRow item in data.Rows)
            {
                CTHoaDonNhapDTO ct  = new CTHoaDonNhapDTO(item);
                 list.Add(ct);
            }
            return list;
        }

        public List<CTHoaDonNhapDTO> GETCT(int id)
        {
            List<CTHoaDonNhapDTO> list = new List<CTHoaDonNhapDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("dbo.USP_GETCT "+id);
            foreach (DataRow item in data.Rows)
            {
                CTHoaDonNhapDTO ct = new CTHoaDonNhapDTO(item);
                list.Add(ct);
            }
            return list;
        }

        public bool INSERTCTHOADONNHAP(int idHoaDon,int idGiay,decimal donGia, int SLYeuCau, int SLNhan)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC USP_INSERTCTHOADONNHAP  @IDHoaDon , @IDGiay , @DonGia , @SLYeuCau , @SLNhan ", new object[] { idHoaDon, idGiay, donGia, SLYeuCau, SLNhan });

            return result > 0;
        }
        public bool UPDATECTHOADONNHAP(int idHoaDon,int idGiay, decimal donGia, int SLYeuCau, int SLNhan)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC USP_UPDATECTHOADONNHAP @IDHoaDon , @IDGiay , @DonGia , @SLYeuCau, @SLNhan ", new object[] { idHoaDon, idGiay, donGia , SLYeuCau , SLNhan});

            return result > 0;
        }
        public bool DELETECTHOADONNHAP(int idHoaDon)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC USP_DELETECTHOADONNHAP @IDHoaDon ", new object[] { idHoaDon });

            return result > 0;
        }
        public List<CTHoaDonNhapDTO> SEARCHCTHOADONNHAP(string str)
        {
            List<CTHoaDonNhapDTO> CTList = new List<CTHoaDonNhapDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_SEARCHCTHOADONNHAP @search ", new object[] { str });
            foreach (DataRow item in data.Rows)
            {
                CTHoaDonNhapDTO ct = new CTHoaDonNhapDTO(item);
                CTList.Add(ct);
            }
            return CTList;
        }
    }
}

