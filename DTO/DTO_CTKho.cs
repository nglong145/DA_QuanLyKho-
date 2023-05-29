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
        protected string TenKho;
        protected string DiaChi;
        protected string TenSP;

        public DTO_CTKho()
        {

        }

        public DTO_CTKho(string MaCT_Kho, string MaKho, string MaSP, int SoLuong, string TenKho, string DiaChi, string TenSP)
        {
            this.MaCT_Kho = MaCT_Kho;
            this.MaKho = MaKho;
            this.MaSP = MaSP;
            this.SoLuong = SoLuong;
            this.TenKho = TenKho;
            this.DiaChi = DiaChi;
            this.TenSP = TenSP;
        }

        public string MACT_KHO
        {
            get { return MaCT_Kho; }
            set { MaCT_Kho = value; }
        }
        public string MAKHO
        {
            get { return MaKho; }
            set { MaKho = value; }
        }
        public string MASP
        {
            get { return MaSP; }
            set { MaSP = value; }
        }
        public int SOLUONG
        {
            get { return SoLuong; }
            set { SoLuong = value; }
        }

        public string TENKHO
        {
            get { return TenKho; }
            set { TenKho = value; }
        }
        public string DIACHI
        {
            get { return DiaChi; }
            set { DiaChi = value; }
        }

        public string TENSP
        {
            get { return TenSP; }
            set { TenSP = value; }
        }
    }
}
