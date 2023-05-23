using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_CTHDXuat
    {
        protected string MaCT_HDXuat;
        protected string MaHDXuat;
        protected string MaSP;
        protected string MaKho;
        protected int SLBan;
        protected float GiaBan;
        protected float ChietKhau;


        public DTO_CTHDXuat()
        {

        }

        public DTO_CTHDXuat(string MaCT_HDXuat, string MaHDXuat, string MaSP, string MaKho, int SLBan, float GiaBan, float ChietKhau)
        {
            this.MaCT_HDXuat = MaCT_HDXuat;
            this.MaHDXuat = MaHDXuat;
            this.MaSP = MaSP;
            this.MaKho = MaKho;
            this.SLBan = SLBan;
            this.GiaBan = GiaBan;
            this.ChietKhau = ChietKhau;
        }

        public string MACTHD_XUAT
        {
            get { return MACTHD_XUAT; }
            set { MACTHD_XUAT = value; }
        }
        public string MAHDXUAT
        {
            get { return MAHDXUAT; }
            set { MAHDXUAT = value; }
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
        public int SLBAN
        {
            get { return SLBAN; }
            set { SLBAN = value; }
        }
        public float GIABAN
        {
            get { return GIABAN; }
            set { GIABAN = value; }
        }
        public float CHIETKHAU
        {
            get { return CHIETKHAU; }
            set { CHIETKHAU = value; }
        }
    }
}
