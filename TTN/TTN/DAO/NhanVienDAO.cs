using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTN.DTO;

namespace TTN.DAO
{
    class NhanVienDAO
    {
        private static NhanVienDAO instance;

        internal static NhanVienDAO Instance
        {
            get { if (instance == null) instance = new NhanVienDAO(); return instance; }
            private set { instance = value; }
        }
        public List<NhanVienDTO> GetNV()
        {
            List<NhanVienDTO> list = new List<NhanVienDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC dbo.USP_GetListNV");
            foreach (DataRow item in data.Rows)
            {
                NhanVienDTO nv = new NhanVienDTO(item);
                list.Add(nv);
            }
            return list;

        }

        public bool InsertNv(string hoten, DateTime ngsinh, string diachi)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC dbo.USP_InsertNhanVien @tennv , @ngaysinh , @diachi ", new object[] { hoten , ngsinh , diachi });

            return result > 0;
        }

        public bool UpdateNv(string hoten, DateTime ngsinh, string diachi, int manv)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC dbo.USP_UpdateNhanVien @manv , @tennv , @ngaysinh , @diachi ", new object[] { manv, hoten, ngsinh, diachi });

            return result > 0;
        }
        public bool DeleteNv(int manv)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC dbo.USP_DeleteNhanVien @manv ", new object[] { manv });

            return result > 0;
        }
        public List<NhanVienDTO> SearchNv(string str)
        {
            List<NhanVienDTO> NvList = new List<NhanVienDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC dbo.USP_SearchNhanVien @search ", new object[] { str });
            foreach (DataRow item in data.Rows)
            {
                NhanVienDTO NhanVien = new NhanVienDTO(item);
                NvList.Add(NhanVien);
            }
            return NvList;
        }
    }
}
