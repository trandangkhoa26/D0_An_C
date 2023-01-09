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
        private static TINNHAN_DAO instance;
        public static TINNHAN_DAO Instance
        {
            get { if (instance == null) instance = new TINNHAN_DAO(); return instance; }
            private set { instance = value; }
        }

        public void AddYeuThich(int tk , string nguoibanthich)
        {
            string query = string.Format("AddYeuThich {0}, {1}", tk, nguoibanthich);
            DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
