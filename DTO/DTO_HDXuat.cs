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
        protected string MaKH;
        protected string MaND;
        protected DateTime NgayBan;
        protected string SoHoaDon;

        public DTO_HDXuat()
        {

        }

        public DTO_HDXuat(string MaHDXuat, string MaKH, string MaND, DateTime NgayBan, string SoHoaDon)
        {
            this.MaHDXuat = MaHDXuat;
            this.MaKH = MaKH;
            this.MaND = MaND;
            this.NgayBan = NgayBan;
            this.SoHoaDon = SoHoaDon;
        }

        public string MAHDXUAT
        {
            get { return MAHDXUAT; }
            set { MAHDXUAT = value; }
        }
        public string MAKH
        {
            get { return MAKH; }
            set { MAKH = value; }
        }
        public string MAND
        {
            get { return MAND; }
            set { MAND = value; }
        }
        public DateTime NGAYBAN
        {
            get { return NGAYBAN; }
            set { NGAYBAN = value; }
        }
        public string SOHOADON
        {
            get { return SOHOADON; }
            set { SOHOADON = value; }
        }
    }
}
