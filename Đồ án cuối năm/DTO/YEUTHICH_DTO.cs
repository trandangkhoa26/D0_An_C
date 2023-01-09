using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;
namespace Đồ_án_cuối_năm.DTO
{
    public class YEUTHICH_DTO
    {
        private int Id;
        private int TaiKhoan;
        private int NguoiBanThich;

        public int id { get=>Id; set=>Id=value; }
        public int taikhoan { get=>TaiKhoan;set=>TaiKhoan=value; }
        public int nguoibanthich { get=>NguoiBanThich;set=>NguoiBanThich=value;}
        
        public YEUTHICH_DTO(int id,int tk,int nguoibanthich) 
        {
            this.id = id;
            this.taikhoan=tk;
            this.nguoibanthich= nguoibanthich;
        }
        public YEUTHICH_DTO(DataRow rows)
        {
            this.id = (int)rows["Id"];
            this.taikhoan = (int)rows["TaiKhoan"];
            this.nguoibanthich = (int)rows["NguoiBanThich"];
        }
    }
}
