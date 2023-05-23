using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Kho
    {
        protected string MaKho;
        protected string TenKho;
        protected string DiaChi;
        protected string MaCT_Kho;
        protected string MaSP;
        protected int SoLuong;


        public DTO_Kho()
        {

        }

        public DTO_Kho(string MaKho, string TenKho, string DiaChi, string MaCT_Kho, string MaSP, int SoLuong )
        {
            this.MaKho = MaKho;
            this.TenKho = TenKho;
            this.DiaChi = DiaChi;
            this.MaCT_Kho = MaCT_Kho;
            this.MaSP = MaSP;
            this.SoLuong = SoLuong;
        }

        public string MAKHO
        {
            get { return MaKho; }
            set { MaKho = value; }
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
        public string MACT_KHO
        {
            get { return MaCT_Kho; }
            set { MaCT_Kho = value; }
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
    }
}
