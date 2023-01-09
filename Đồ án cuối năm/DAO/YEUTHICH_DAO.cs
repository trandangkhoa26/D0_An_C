using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Đồ_án_cuối_năm.DTO;
namespace Đồ_án_cuối_năm.DAO
{
    public class YEUTHICH_DAO
    {
        private static YEUTHICH_DAO instance;
        public static YEUTHICH_DAO Instance
        {
            get { if (instance == null) instance = new YEUTHICH_DAO(); return instance; }
            private set { instance = value; }
        }

        public void AddYeuThich(int tk , int nguoibanthich)
        {
            string query = string.Format("AddYeuThich {0}, {1}", tk, nguoibanthich);
            DataProvider.Instance.ExecuteQuery(query);
        }
        public void RemoveYeuThich(int tk, int nguoibanthich)
        {
            string query = string.Format("RemoveYeuThich {0}, {1}", tk, nguoibanthich);
            DataProvider.Instance.ExecuteQuery(query);
        }

        public void RemoveAll(int tk)
        {
            string query = string.Format("delete from THICH where TaiKhoan = "+tk);
            DataProvider.Instance.ExecuteQuery(query);
        }
        public List<YEUTHICH_DTO> GetListLike(int tk)
        {
            List<YEUTHICH_DTO> list = new List<YEUTHICH_DTO>();
            string query = string.Format("select * from THICH where TaiKhoan = " + tk);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                YEUTHICH_DTO like = new YEUTHICH_DTO(item);
                list.Add(like);
            }
            return list;
        }

        public List<YEUTHICH_DTO> KiemTraYeuThich(int tk, int nguoibanthich)
        {
            List<YEUTHICH_DTO> list = new List<YEUTHICH_DTO>();
            string query = string.Format("select * from THICH where TaiKhoan = " + tk + "and NguoiBanThich = " + nguoibanthich);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                YEUTHICH_DTO like = new YEUTHICH_DTO(item);
                list.Add(like);
            }
            return list;
        }

        public bool CheckMatch(int tk,int nguoibanthich)
        {
            List<YEUTHICH_DTO> list = new List<YEUTHICH_DTO>();
            string query = string.Format("select * from THICH where (TaiKhoan = " + tk +"and NguoiBanThich = "+nguoibanthich+") or ( TaiKhoan ="+nguoibanthich+ "and NguoiBanThich ="+tk+")");
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                YEUTHICH_DTO like = new YEUTHICH_DTO(item);
                list.Add(like);
            }
            return list.Count==2;
        }

        public List<YEUTHICH_DTO> GetListLiked(int tk)
        {
            List<YEUTHICH_DTO> list = new List<YEUTHICH_DTO>();
            string query = string.Format("select * from THICH where NguoiBanThich = " + tk);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                YEUTHICH_DTO like = new YEUTHICH_DTO(item);
                list.Add(like);
            }
            return list;
        }

    }
}
