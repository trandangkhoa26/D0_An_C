using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;
namespace Đồ_án_cuối_năm.DTO
{
    public class TINNHAN_DTO
    {
        private int Id;
        private int NguoiGoi;
        private int NguoiNhan;
        private string NoiDung;
        private int DaDoc;

        public int id { get=>Id; set=>Id=value; }
        public int nguoigoi { get=>NguoiGoi;set=>NguoiGoi=value; }
        public int nguoinhan { get => NguoiNhan;set=>NguoiNhan=value; }
        public string noidung { get=>NoiDung; set=>NoiDung=value; }
        public int dadoc { get=>DaDoc; set=>DaDoc=value; }

        public TINNHAN_DTO(int id,int nggoi,int ngnhan,string noidung,int dadoc) 
        {
            this.id = id;
            this.nguoigoi= nggoi;   
            this.nguoinhan= ngnhan;
            this.noidung= noidung;
            this.dadoc= dadoc;
        }    

        public TINNHAN_DTO(DataRow rows) 
        {
            this.id = (int)rows["Id"];
            this.nguoigoi = (int)rows["NguoiGoi"];
            this.nguoinhan = (int)rows["NguoiNhan"];
            this.noidung = (string)rows["NoiDung"];
            this.dadoc = (int)rows["DaDoc"];
        }
    }
}
