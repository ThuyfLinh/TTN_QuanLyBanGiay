using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTN.DTO;
namespace TTN.DAO
{
    class ThongKeDAO
    {
        private static ThongKeDAO instance;

        internal static ThongKeDAO Instance
        {
            get { if (instance == null) instance = new ThongKeDAO(); return instance; }
            private set { instance = value; }
        }
        public List<ThongKe_DTO> GetListThongKe()
        {
            List<ThongKe_DTO> list = new List<ThongKe_DTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select IDGiay , TenGiay , SoLuong , DonGia , (SoLuong * DonGia) as N'TongTien' from GIAY");
            foreach (DataRow item in data.Rows)
            {
                ThongKe_DTO tk = new ThongKe_DTO(item);
                list.Add(tk);
            }
            return list;
        }
        public float GetTongTien()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select sum(SoLuong * DonGia) as tongtien from GIAY");
            DataRow item = data.Rows[0];
            float tongTien;
            float.TryParse(item["tongTien"].ToString(), out tongTien);
            return tongTien;
        }
    }
}
