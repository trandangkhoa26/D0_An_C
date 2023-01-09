using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Đồ_án_cuối_năm.DTO;
namespace Đồ_án_cuối_năm.DAO
{
    public class ACCOUNT_DAO
    {
        private static ACCOUNT_DAO instance;
        public static ACCOUNT_DAO Instance
        {
            get { if (instance == null) instance = new ACCOUNT_DAO(); return instance; }
            private set { instance = value; }
        }

        public bool Login(string userName, string passWord)
        {
            string query = "Login @userName , @passWord";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, passWord });

            return result.Rows.Count > 0;
        }

        public int GetCustomerID(string userName, string passWord)
        {
            string query = "select Id from NGUOIDUNG where TaiKhoan='" + userName + "'and MatKhau ='" + passWord + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            int id = Convert.ToInt32(data.Rows[0]["Id"]);
            return id;
        }

        public ACCOUNT_DTO GetCustomerInfo(string userName, string passWord)
        {
            string query = "select * from NGUOIDUNG where TaiKhoan='" + userName + "'and MatKhau ='" + passWord + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            ACCOUNT_DTO acc = new ACCOUNT_DTO(data.Rows[0]);
            return acc;
        }

        public void AddNewCustomer( string user, string pass,string name,int namsinh,string truong,string gioitinh,int namhoc,int chieucao,int cannang)
        {
            string query = string.Format("AddNewUser '{0}', '{1}', N'{2}', {3}, N'{4}',N'{5}',{6},{7},{8}", user, pass,name,namsinh,truong,gioitinh,namhoc,chieucao,cannang);
            DataProvider.Instance.ExecuteQuery(query);
        }

        public void UpdateNGUOIDUNG(int id, string name, int namsinh, string truong, string gioitinh, int namhoc, int chieucao, int cannang,string bio)
        {
            string query = string.Format("UpdateUser {0}, N'{1}',{2}, N'{3}',N'{4}',{5},{6},{7},N'{8}'", id, name, namsinh,truong,gioitinh,namhoc,chieucao,cannang,bio);
            DataProvider.Instance.ExecuteQuery(query);
        }

        public void UpdatePass(int id, string pass)
        {
            string query = string.Format("UpdatePass {0}, '{1}'", id, pass);
            DataProvider.Instance.ExecuteQuery(query);
        }

    }
}
