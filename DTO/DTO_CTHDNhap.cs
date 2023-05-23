using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_CTHDNhap
    {
        protected string MaCT_HDNhap;
        protected string MaHDNhap;
        protected string MaSP;
        protected string MaKho;
        protected int SLNhap;
        protected float GiaNhap;
        protected float ChietKhau;


        public DTO_CTHDNhap()
        {

        }

        public DTO_CTHDNhap(string MaCT_HDNhap, string MaHDNhap, string MaSP, string MaKho, int SLNhap, float GiaNhap, float ChietKhau)
        {
            this.MaCT_HDNhap = MaCT_HDNhap;
            this.MaHDNhap = MaHDNhap;
            this.MaSP = MaSP;
            this.MaKho = MaKho;
            this.SLNhap = SLNhap;
            this.GiaNhap = GiaNhap;
            this.ChietKhau = ChietKhau;
        }

        public string MACT_HDNHAP
        {
            get { return MACT_HDNHAP; }
            set { MACT_HDNHAP = value; }
        }
        public string MAHDNHAP
        {
            get { return MAHDNHAP; }
            set { MAHDNHAP = value; }
        }
        public string MASP
        {
            get { return MASP; }
            set { MASP = value; }
        }
        public string MAKHO
        {
            get { return MAKHO; }
            set { MAKHO = value; }
        }
        public int SLNHAP
        {
            get { return SLNHAP; }
            set { SLNHAP = value; }
        }
        public float GIANHAP
        {
            get { return GIANHAP; }
            set { GIANHAP = value; }
        }
        public float CHIETKHAU 
        {
            get { return CHIETKHAU; }
            set { CHIETKHAU = value; }
        }
    }
}
