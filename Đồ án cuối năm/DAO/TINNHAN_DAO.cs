using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Đồ_án_cuối_năm.DTO;
namespace Đồ_án_cuối_năm.DAO
{
    public class TINNHAN_DAO
    {
        private static TINNHAN_DAO instance;
        public static TINNHAN_DAO Instance
        {
            get { if (instance == null) instance = new TINNHAN_DAO(); return instance; }
            private set { instance = value; }
        }

        public List<TINNHAN_DTO> GetTinNhan(int nguoigui, string nguoinhan)
        {
            List<TINNHAN_DTO> list = new List<TINNHAN_DTO>();
            string query = "select * from TINNHAN where NguoiGoi='" + nguoigui + "'and NguoiNhan ='" + nguoinhan+ "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                TINNHAN_DTO tinnhan = new TINNHAN_DTO(item);
                list.Add(tinnhan);
            }
            return list;
        }
        
        public void AddTinNhanText(int nguoigui,string noidung,int nguoinhan)
        {
            string query = string.Format("AddNoiDung {0},N'{1}',{2} ", nguoigui, noidung, nguoinhan);
            DataProvider.Instance.ExecuteQuery(query);
        }
        public void AddNhanDan(int nguoigui, string nhandan, int nguoinhan)
        {
            string query = string.Format("AddNhanDan {0},{1},{2} ", nguoigui, nhandan, nguoinhan);
            DataProvider.Instance.ExecuteQuery(query);
        }
        public void AddAnh(int nguoigui, string anh, int nguoinhan)
        {
            string query = string.Format("AddAnh {0},'{1}',{2} ", nguoigui, anh, nguoinhan);
            DataProvider.Instance.ExecuteQuery(query);
        }
        public void AddFile(int nguoigui, string file, int nguoinhan)
        {
            string query = string.Format("AddFile {0},'{1}',{2} ", nguoigui, file, nguoinhan);
            DataProvider.Instance.ExecuteQuery(query);
        }

        public List<TINNHAN_DTO> LoadMessage(int user, int opponent)
        {
            List<TINNHAN_DTO> result = new List<TINNHAN_DTO>();
            string query = "select * from TINNHAN where (NguoiGoi = " + user + " and NguoiNhan = " + opponent +") or (NguoiGoi = " + opponent + " and NguoiNhan = " + user +")";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                TINNHAN_DTO tinnhan = new TINNHAN_DTO(item);
                result.Add(tinnhan);
            }
            return result;
        }

        public DateTime GetLastMessageById(int NguoiGui, int NguoiNhan)
        {
            DateTime result;
            string query = "select MAX(thoigian) as 'Latest' from TINNHAN where (NguoiGoi = " + NguoiGui + " and NguoiNhan = "+ NguoiNhan + ") or(NguoiNhan = " + NguoiGui +" and NguoiGoi = " + NguoiNhan + ")";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            result = Convert.ToDateTime(data.Rows[0]["Latest"]);
            return result;
        }

        public List<int> LichSuNhan(int User)
        {
            List<int> list = new List<int>();

            string query = "select distinct NguoiGoi from TINNHAN where nguoinhan = 17 or nguoigoi = " + User.ToString();
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                list.Add(Convert.ToInt32(row["NguoiGoi"]));
            }
            return list;
        }
  
    }
}
