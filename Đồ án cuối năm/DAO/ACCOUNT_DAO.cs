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

        public bool DangNhap(string userName, string passWord)
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

        public int GetCustomerIDbyName(string userName)
        {
            string query = "select Id from NGUOIDUNG where TenNguoiDung= N'" + userName +"'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            int id = Convert.ToInt32(data.Rows[0]["Id"]);
            return id;
        }

        public ACCOUNT_DTO GetCustomerInfo(string userName, string passWord)
        {
            string query = String.Format("select * from nguoidung where TaiKhoan ='" + userName + "' and MatKhau ='" + passWord + "'");
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            
            ACCOUNT_DTO acc = new ACCOUNT_DTO(data.Rows[0]);
            return acc;
        }

        public ACCOUNT_DTO GetCustomerInfoID(int id)
        {
            string query = String.Format("select * from nguoidung where Id ="+id);
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

        public List<ACCOUNT_DTO> GetNguoiDung(int tk)
        {
            List<ACCOUNT_DTO> list = new List<ACCOUNT_DTO>();
            string query = string.Format("select * from NGUOIDUNG where Id !=" +tk);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                ACCOUNT_DTO nguoi = new ACCOUNT_DTO(item);
                list.Add(nguoi);
            }
            return list;
        }

        public List<ACCOUNT_DTO> GetNguoiDungMF(string gioitinh)
        {
            List<ACCOUNT_DTO> list = new List<ACCOUNT_DTO>();
            string query =string.Format( "select * from NGUOIDUNG where GioiTinh = N'"+gioitinh+"' and Id != " + Global.current_ID);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                ACCOUNT_DTO nguoi = new ACCOUNT_DTO(item);
                list.Add(nguoi);
            }
            return list;
        }

        public List<ACCOUNT_DTO> SearchTruong(string truong,int tk )
        {
            string temp = "";
            if (truong == "")
                temp = "or 1 = 1";
            List<ACCOUNT_DTO> list = new List<ACCOUNT_DTO>();

            string query = string.Format("SELECT * FROM NGUOIDUNG WHERE (dbo.fuConvertToUnsign1(Truong) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%' {1}) and Id != " + tk , truong, temp);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                ACCOUNT_DTO person = new ACCOUNT_DTO(item);
                list.Add(person);
            }
            return list;
        }
        public List<ACCOUNT_DTO> SearchYear(int year, int tk)
        {
            List<ACCOUNT_DTO> list = new List<ACCOUNT_DTO>();
            string query = string.Format("select * from NGUOIDUNG where NamSinh ="+year+" and Id !=" + tk);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                ACCOUNT_DTO nguoi = new ACCOUNT_DTO(item);
                list.Add(nguoi);
            }
            return list;
        }
        public List<ACCOUNT_DTO> SearchYearSchool(int year,int tk)
        {
            List<ACCOUNT_DTO> list = new List<ACCOUNT_DTO>();
            string query = string.Format("select * from NGUOIDUNG where NamHoc=" + year + " and Id !=" + tk);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                ACCOUNT_DTO nguoi = new ACCOUNT_DTO(item);
                list.Add(nguoi);
            }
            return list;
        }
    }
}
