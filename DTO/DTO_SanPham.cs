using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_SanPham
    {
        protected string MaSP;
        protected string TenSP;
        protected string TenDVT;
        protected string TenDM;
        protected string ThongSoDacTa;
        protected string NhaSX;

        public DTO_SanPham()
        {

        }

        public DTO_SanPham(string MaSP, string TenSP, string TenDVT, string TenDM, string ThongSoDacTa, string NhaSX)
        {
            this.MaSP = MaSP;
            this.TenSP = TenSP;
            this.TenDVT = TenDVT;
            this.TenDM = TenDM;
            this.ThongSoDacTa = ThongSoDacTa;
            this.NhaSX = NhaSX;
        }

        public string MASP
        {
            get { return MaSP; }
            set { MaSP = value; }
        }
        public string TENSP
        {
            get { return TenSP; }
            set { TenSP = value; }
        }
        public string TENDVT
        {
            get { return TenDVT; }
            set { TenDVT = value; }
        }
        public string TENDM
        {
            get { return TenDM; }
            set { TenDM = value; }
        }
        public string THONGSODACTA
        {
            get { return ThongSoDacTa; }
            set { ThongSoDacTa = value; }
        }
        public string NHASX
        {
            get { return NhaSX; }
            set { NhaSX = value; }
        }
    }
}
