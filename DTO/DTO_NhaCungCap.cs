using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NhaCungCap
    {
        protected string MaNhaCC;
        protected string TenNhaCC;
        protected string MaSoThue;
        protected string DiaChi;
        protected string SoDT;
        protected string Email;

        public DTO_NhaCungCap()
        {

        }

        public DTO_NhaCungCap(string MaNhaCC, string TenNhaCC, string MaSoThue, string DiaChi, string SoDT, string Email)
        {
            this.MaNhaCC = MaNhaCC;
            this.TenNhaCC = TenNhaCC;
            this.MaSoThue = MaSoThue;
            this.DiaChi = DiaChi;
            this.SoDT = SoDT;
            this.Email = Email;
        }

        public string MANHACC
        {
            get { return MaNhaCC; }
            set { MaNhaCC = value; }
        }
        public string TENNHACC
        {
            get { return TenNhaCC; }
            set { TenNhaCC = value; }
        }
        public string MASOTHUE
        {
            get { return MaSoThue; }
            set { MaSoThue = value; }
        }
        public string DIACHI
        {
            get { return DiaChi; }
            set { DiaChi = value; }
        }
        public string SODT
        {
            get { return SoDT; }
            set { SoDT = value; }
        }
        public string EMAIL
        {
            get { return Email; }
            set { Email = value; }
        }
    }
}
