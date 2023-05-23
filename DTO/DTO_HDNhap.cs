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
        protected string MaNhaCC;
        protected string MaND;
        protected DateTime NgayNhap;
        protected string SoHoaDon;

        public DTO_HDNhap()
        {

        }

        public DTO_HDNhap(string MaHDNhap, string MaNhaCC, string MaND, DateTime NgayNhap, string SoHoaDon)
        {
            this.MaHDNhap = MaHDNhap;
            this.MaNhaCC = MaNhaCC;
            this.MaND = MaND;
            this.NgayNhap = NgayNhap;
            this.SoHoaDon = SoHoaDon;
        }

        public string MAHDNHAP
        {
            get { return MAHDNHAP; }
            set { MAHDNHAP = value; }
        }
        public string MANHACC
        {
            get { return MANHACC; }
            set { MANHACC = value; }
        }
        public string MAND
        {
            get { return MAND; }
            set { MAND = value; }
        }
        public DateTime NGAYNHAP
        {
            get { return NGAYNHAP; }
            set { NGAYNHAP = value; }
        }
        public string SOHOADON
        {
            get { return SOHOADON; }
            set { SOHOADON = value; }
        }
    }
}
