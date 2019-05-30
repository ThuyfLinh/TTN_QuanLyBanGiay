using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTN.DTO;
using System.Data;

namespace TTN.DAO
{
    class CTHoaDonBan_DAO
    {
        private static CTHoaDonBan_DAO instance;

        public static CTHoaDonBan_DAO Instance
        {
            get { if (instance == null) instance = new CTHoaDonBan_DAO(); return instance; }
            private set { instance = value; }
        }
        public List<CTHoaDonBan_DTO> GetCTHoaDonBan(int ID)
        {
            List<CTHoaDonBan_DTO> ListCTHoaDonBan = new List<CTHoaDonBan_DTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetListCTHD  @ID",new object[] { ID });
            foreach (DataRow item in data.Rows)
            {
                CTHoaDonBan_DTO cthoadonban = new CTHoaDonBan_DTO(item);
                ListCTHoaDonBan.Add(cthoadonban);
             
            }
            return ListCTHoaDonBan;
        }
        public decimal getTongtien(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select sum(dongiaban * soluong) as tongtien from cthoadonban where idhoadon = "+id);
            DataRow item = data.Rows[0];
            decimal tongtien = 0;
            decimal.TryParse(item["tongtien"].ToString(), out tongtien);
            return tongtien;
        }
        public List<CTHoaDonBan_DTO> SearchCTHD(int id,string str)
        {
            List<CTHoaDonBan_DTO> CTHDList = new List<CTHoaDonBan_DTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_searchCTHoaDonBan  @id , @str", new object[] { id,str });
            foreach (DataRow item in data.Rows)
            {
                CTHoaDonBan_DTO cthoadonban = new CTHoaDonBan_DTO(item);
                CTHDList.Add(cthoadonban);
            }
            return CTHDList;
        }
        public bool Insert_CTHoaDonBan(int MaHD,int MaGiay,int SoLuong)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC USP_insert_CTHDB  @Mahd , @MaGiay , @SoLuong ", new object[] {MaHD,MaGiay,SoLuong});

            return result > 0;
        }
        public bool Delete_CTHoaDonBan(int MaHD,int MaGiay)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC USP_delete_CTHDB  @MaHD , @MaGiay ", new object[] { MaHD,MaGiay });

            return result > 0;
        }
        public List<TenGiay_DTO> GetListGiay()
        {
            List<TenGiay_DTO> TenGiayList = new List<TenGiay_DTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT TenGiay  FROM dbo.GIAY");
            foreach (DataRow item in data.Rows)
            {
                TenGiay_DTO makh = new TenGiay_DTO(item);
                TenGiayList.Add(makh);
            }
            return TenGiayList;
        }
    }
}
