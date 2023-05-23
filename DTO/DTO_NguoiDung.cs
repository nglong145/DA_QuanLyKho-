using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NguoiDung
    {
        protected string MaND;
        protected string TenND;
        protected string SoDT;
        protected string Email;
        protected string TaiKhoan;
        protected string MatKhau;
        protected string TrangThai;

        public DTO_NguoiDung() 
        { 

        }

        public DTO_NguoiDung(string MaND, string TenND, string SoDT, string Email, string TaiKhoan, string MatKhau, string TrangThai)
        {
            this.MaND = MaND;
            this.TenND = TenND;
            this.SoDT = SoDT;
            this.Email = Email;
            this.TaiKhoan = TaiKhoan;
            this.MatKhau = MatKhau;
            this.TrangThai = TrangThai;
        }

        public DTO_NguoiDung(string TaiKhoan, string MatKhau, string TrangThai)
        {
            this.TAIKHOAN = TaiKhoan;
            this.MATKHAU = MatKhau;
            this.TRANGTHAI = TrangThai;
        }
        public string MAND
        {
            get { return MaND; }
            set { MaND = value; }
        }
        public string TENND
        {
            get { return TenND; }
            set { TenND = value; }
        }
        public string SODT
        {
            get { return SoDT; }
            set { SoDT = value; }
        }
        public string EMAIL
        {
            get { return Email; }
            set { Email = value; }
        }
        public string TAIKHOAN
        {
            get { return TaiKhoan; }
            set { TaiKhoan = value; }
        }
        public string MATKHAU
        {
            get { return MatKhau; }
            set { MatKhau = value; }
        }
        public string TRANGTHAI
        {
            get { return TrangThai; }
            set { TrangThai = value; }
        }
    }
}
