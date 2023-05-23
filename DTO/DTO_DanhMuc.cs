using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DanhMuc
    {
        protected int MaDM;
        protected string TenDM;

        public DTO_DanhMuc()
        {

        }

        public DTO_DanhMuc(int MaDM, string TenDM)
        {
            this.MaDM = MaDM;
            this.TenDM = TenDM;
        }

        public int MADM
        {
            get { return MADM; }
            set { MADM = value; }
        }
        public string TENDM
        {
            get { return TENDM; }
            set { TENDM = value; }
        }
    }
}
