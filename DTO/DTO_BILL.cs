using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DTO
{
    public class DTO_BILL
    {
        protected string MaHDXuat;
        protected string SoHoaDon;
        protected string TenND;
        protected DateTime NgayBan;
        protected string TenKH;
        protected int Total;


        public DTO_BILL()
        {

        }

        public DTO_BILL(string MaHDXuat, string SoHoaDon, string TenND, DateTime NgayBan, string TenKH, int Total)
        {
            this.MaHDXuat = MaHDXuat;
            this.SoHoaDon = SoHoaDon;
            this.TenND = TenND;
            this.NgayBan = NgayBan;
            this.TenKH = TenKH;
            this.Total = Total;
        }

        public string MAHDXUAT
        {
            get { return MaHDXuat; }
            set { MaHDXuat = value; }
        }
        public string SOHOADON
        {
            get { return SoHoaDon; }
            set { SoHoaDon = value; }
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

        public string TENKH
        {
            get { return TenKH; }
            set { TenKH = value; }
        }
        public int TOTAL
        {
            get { return Total; }
            set { Total = value; }
        }
    }
}
