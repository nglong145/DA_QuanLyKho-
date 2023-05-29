using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HDXuat
    {
        protected string MaHDXuat;
        protected string TenKH;
        protected string TenND;
        protected DateTime NgayBan;
        protected string SoHoaDon;

        public DTO_HDXuat()
        {

        }

        public DTO_HDXuat(string MaHDXuat, string TenKH, string TenND, DateTime NgayBan, string SoHoaDon)
        {
            this.MaHDXuat = MaHDXuat;
            this.TenKH = TenKH;
            this.TenND = TenND;
            this.NgayBan = NgayBan;
            this.SoHoaDon = SoHoaDon;
        }

        public string MAHDXUAT
        {
            get { return MaHDXuat; }
            set { MaHDXuat = value; }
        }
        public string TENKH
        {
            get { return TenKH; }
            set { TenKH = value; }
        }
        public string TENND
        {
            get { return TenND; }
            set { TenND = value; }
        }
        public DateTime NGAYBAN
        {
            get { return NgayBan; }
            set { NgayBan = value; }
        }
        public string SOHOADON
        {
            get { return SoHoaDon; }
            set { SoHoaDon = value; }
        }
    }
}
