using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DonViTinh
    {
        protected int MaDVT;
        protected string TenDVT;

        public DTO_DonViTinh()
        {

        }

        public DTO_DonViTinh(int MaDVT, string TenDVT)
        {
            this.MaDVT = MaDVT;
            this.TenDVT = TenDVT;
        }

        public int MADVT
        {
            get { return MaDVT; }
            set { MaDVT = value; }
        }
        public string TENDVT
        {
            get { return TenDVT; }
            set { TenDVT = value; }
        }
    }
}
