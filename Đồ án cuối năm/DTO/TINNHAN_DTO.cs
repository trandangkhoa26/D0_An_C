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
        private int NhanDan;
        private string DiaChiAnh;
        private string DiaChiFile;
        private DateTime ThoiGian;

        public int id { get=>Id; set=>Id=value; }
        public int nguoigoi { get=>NguoiGoi;set=>NguoiGoi=value; }
        public int nguoinhan { get => NguoiNhan;set=>NguoiNhan=value; }
        public string noidung { get=>NoiDung; set=>NoiDung=value; }
        public int nhandann { get => NhanDan; set => NhanDan = value; }
        public string diachianh { get => DiaChiAnh; set => DiaChiAnh = value; }
        public string diachifile { get => DiaChiFile; set => DiaChiFile = value; }
        public DateTime thoigian { get=>ThoiGian; set=>ThoiGian=value; }

        public TINNHAN_DTO(int id,int nggoi,int ngnhan,string noidung,int nhandan,string diachianh,string diachifile,DateTime tg) 
        {
            this.id = id;
            this.nguoigoi= nggoi;   
            this.nguoinhan= ngnhan;
            this.noidung= noidung;
            this.nhandann= nhandan; 
            this.diachianh= diachianh;  
            this.diachifile= diachifile;
            this.thoigian= tg;
        }    

        public TINNHAN_DTO(DataRow rows) 
        {
            this.id = (int)rows["Id"];
            this.nguoigoi = (int)rows["NguoiGoi"];
            this.nguoinhan = (int)rows["NguoiNhan"];
            this.noidung = (string)rows["NoiDung"];
            this.nhandann = (int)rows["NhanDan"];
            this.diachianh = (string)rows["DiaChiAnh"];
            this.diachifile = (string)rows["DiaChiFile"];
            this.thoigian = (DateTime)rows["ThoiGian"];
        }
    }
}
