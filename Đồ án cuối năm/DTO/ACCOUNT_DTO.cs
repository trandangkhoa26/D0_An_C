using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;

namespace Đồ_án_cuối_năm.DTO
{
    public class ACCOUNT_DTO
    {
        private int Id;
        private string TaiKhoan;
        private string MatKhau;
        private string TenNguoiDung;
        private int NamSinh;
        private string Truong;
        private string GioiTinh;
        private int NamHoc;
        private int ChieuCao;
        private int CanNang;
        private string Bio;

        public int id { get => Id; set => Id=value; }
        public string taikhoan { get => TaiKhoan; set => TaiKhoan=value; }
        public string matkhau { get => MatKhau;set=> MatKhau=value; }
        public string tennguoidung { get => TenNguoiDung; set => TenNguoiDung = value; }
        public int namsinh { get => NamSinh;set=> NamSinh=value; }  
        public string truong { get => Truong; set => Truong = value;}
        public string gioitinh { get => GioiTinh; set => GioiTinh = value; }
        public int namhoc { get => NamHoc; set => NamHoc = value;}
        public int chieucao { get => ChieuCao; set => ChieuCao = value; }
        public int cannang {get =>CanNang; set => CanNang=value; }  
        public string bio { get => Bio;set=> Bio=value; }

        public ACCOUNT_DTO(int id,string taikhoan,string matkhau,string ten,int namsinh,string truong,string gioitinh,int namhoc,int chieucao,int cannang,string bio)
        {
            this.id = id;
            this.taikhoan= taikhoan;
            this.matkhau= matkhau;
            this.tennguoidung= ten;
            this.namsinh=namsinh;
            this.truong= truong;
            this.gioitinh=gioitinh;
            this.namhoc=namhoc;
            this.chieucao= chieucao;
            this.cannang= cannang;
            this.bio= bio;
        }
        public ACCOUNT_DTO(DataRow rows)
        {
            this.id = (int)rows["Id"];
            this.taikhoan = (string)rows["TaiKhoan"];
            this.matkhau = (string)rows["MatKhau"];
            this.tennguoidung = (string)rows["TenNguoiDung"];
            this.namsinh = (int)rows["NamSinh"];
            this.truong = (string)rows["Truong"];
            this.gioitinh = (string)rows["GioiTinh"];
            this.namhoc = (int)rows["NamHoc"];
            this.chieucao = (int)rows["ChieuCao"];
            this.cannang = (int)rows["CanNang"];
            this.bio = (string)rows["Bio"];
        }

    }
}
