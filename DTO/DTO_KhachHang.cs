using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_KhachHang
    {
        protected string MaKH;
        protected string TenKH;
        protected string SoDT;
        protected string DiaChi;

        public DTO_KhachHang()
        {

        }

        public DTO_KhachHang(string MaKH, string TenKH, string DiaChi, string SoDT)
        {
            this.MaKH = MaKH;
            this.TenKH = TenKH;
            this.SoDT = SoDT;
            this.DiaChi = DiaChi;
        }

        public string MAKH
        {
            get { return MaKH; }
            set { MaKH = value; }
        }
        public string TENKH
        {
            get { return TenKH; }
            set { TenKH = value; }
        }
        public string SODT
        {
            get { return SoDT; }
            set { SoDT = value; }
        }
        public string DIACHI
        {
            get { return DiaChi; }
            set { DiaChi = value; }
        }
    }
}
