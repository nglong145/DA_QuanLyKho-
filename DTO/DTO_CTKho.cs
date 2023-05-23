using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_CTKho
    {
        protected string MaCT_Kho;
        protected string MaKho;
        protected string MaSP;
        protected int SoLuong;

        public DTO_CTKho()
        {

        }

        public DTO_CTKho(string MaCT_Kho, string MaKho, string MaSP, int SoLuong)
        {
            this.MaCT_Kho = MaCT_Kho;
            this.MaKho = MaKho;
            this.MaSP = MaSP;
            this.SoLuong = SoLuong;
        }

        public string MACT_KHO
        {
            get { return MACT_KHO; }
            set { MACT_KHO = value; }
        }
        public string MAKHO
        {
            get { return MAKHO; }
            set { MAKHO = value; }
        }
        public string MASP
        {
            get { return MASP; }
            set { MASP = value; }
        }
        public int SOLUONG
        {
            get { return SOLUONG; }
            set { SOLUONG = value; }
        }
    }
}
