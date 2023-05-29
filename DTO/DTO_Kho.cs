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

        public DTO_Kho()
        {

        }

        public DTO_Kho(string MaKho, string TenKho, string DiaChi)
        {
            this.MaKho = MaKho;
            this.TenKho = TenKho;
            this.DiaChi = DiaChi;
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
    }
}
