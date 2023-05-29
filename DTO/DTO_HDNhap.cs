using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HDNhap
    {
        protected string MaHDNhap;
        protected string TenNhaCC;
        protected string TenND;
        protected DateTime NgayNhap;
        protected string SoHoaDon;

        public DTO_HDNhap()
        {

        }

        public DTO_HDNhap(string MaHDNhap, string TenNhaCC, string TenND, DateTime NgayNhap, string SoHoaDon)
        {
            this.MaHDNhap = MaHDNhap;
            this.TenNhaCC = TenNhaCC;
            this.TenND = TenND;
            this.NgayNhap = NgayNhap;
            this.SoHoaDon = SoHoaDon;
        }

        public string MAHDNHAP
        {
            get { return MaHDNhap; }
            set { MaHDNhap = value; }
        }
        public string TENNHACC
        {
            get { return TenNhaCC; }
            set { TenNhaCC = value; }
        }
        public string TENND
        {
            get { return TenND; }
            set { TenND = value; }
        }
        public DateTime NGAYNHAP
        {
            get { return NgayNhap; }
            set { NgayNhap = value; }
        }
        public string SOHOADON
        {
            get { return SoHoaDon; }
            set { SoHoaDon = value; }
        }
    }
}
