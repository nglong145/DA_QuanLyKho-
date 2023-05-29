using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_CTHDNhap
    {
        protected string MaCTHDNhap;
        protected string MaHDNhap;
        protected string TenSP;
        protected string TenKho;
        protected string TenDVT;
        protected int SLNhap;
        protected int GiaNhap;


        public DTO_CTHDNhap()
        {

        }

        public DTO_CTHDNhap(string MaCTHDNhap, string MaHDNhap, string MaSP, string TenKho, string TenDVT, int SLNhap, int GiaNhap  )
        {
            this.MaCTHDNhap = MaCTHDNhap;
            this.MaHDNhap = MaHDNhap;
            this.TenSP = MaSP;
            this.TenKho = TenKho;
            this.TenDVT = TenDVT;
            this.SLNhap = SLNhap;
            this.GiaNhap = GiaNhap;
        }

        public string MACTHDNHAP
        {
            get { return MaCTHDNhap; }
            set { MaCTHDNhap = value; }
        }
        public string MAHDNHAP
        {
            get { return MaHDNhap; }
            set { MaHDNhap = value; }
        }
        public string TENSP
        {
            get { return TenSP; }
            set { TenSP = value; }
        }
        public string TENKHO
        {
            get { return TenKho; }
            set { TenKho = value; }
        }

        public string TENDVT
        {
            get { return TenDVT; }
            set { TenDVT = value; }
        }
        public int SLNHAP
        {
            get { return SLNhap; }
            set { SLNhap = value; }
        }
        public int GIANHAP
        {
            get { return GiaNhap; }
            set { GiaNhap = value; }
        }
    }
}
