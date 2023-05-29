using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_CTHDXuat
    {
        protected string MaCTHDXuat;
        protected string MaHDXuat;
        protected string TenSP;
        protected string TenKho;
        protected string TenDVT;
        protected int SLBan;
        protected int GiaBan;


        public DTO_CTHDXuat()
        {

        }

        public DTO_CTHDXuat(string MaCTHDXuat, string MaHDXuat, string TenSP, string TenKho,  string TenDVT, int SLBan, int GiaBan)
        {
            this.MaCTHDXuat = MaCTHDXuat;
            this.MaHDXuat = MaHDXuat;
            this.TenSP = TenSP;
            this.TenKho = TenKho;
            this.TenDVT = TenDVT;
            this.SLBan = SLBan;
            this.GiaBan = GiaBan;
        }

        public string MACTHDXUAT
        {
            get { return MaCTHDXuat; }
            set { MaCTHDXuat = value; }
        }
        public string MAHDXUAT
        {
            get { return MaHDXuat; }
            set { MaHDXuat = value; }
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
        public int SLBAN
        {
            get { return SLBan; }
            set { SLBan = value; }
        }
        public int GIABAN
        {
            get { return GiaBan; }
            set { GiaBan = value; }
        }
    }
}
