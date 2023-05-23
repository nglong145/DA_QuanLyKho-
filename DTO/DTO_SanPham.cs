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
        protected int MaDVT;
        protected int MaDM;
        protected string ThongSoDacTa;
        protected string NhaSX;

        public DTO_SanPham()
        {

        }

        public DTO_SanPham(string MaSP, string TenSP, int MaDVT, int MaDM, string ThongSoDacTa, string NhaSX)
        {
            this.MaSP = MaSP;
            this.TenSP = TenSP;
            this.MaDVT = MaDVT;
            this.MaDM = MaDM;
            this.ThongSoDacTa = ThongSoDacTa;
            this.NhaSX = NhaSX;
        }

        public string MASP
        {
            get { return MASP; }
            set { MASP = value; }
        }
        public string TENSP
        {
            get { return TENSP; }
            set { TENSP = value; }
        }
        public int MADVT
        {
            get { return MADVT; }
            set { MADVT = value; }
        }
        public int MADM
        {
            get { return MADM; }
            set { MADM = value; }
        }
        public string THONGSODACTA
        {
            get { return THONGSODACTA; }
            set { THONGSODACTA = value; }
        }
        public string NHASX
        {
            get { return NHASX; }
            set { NHASX = value; }
        }
    }
}
