using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Utility;
using DAL;
using System.Data;

namespace BUS
{
    public class BUS_BILL:IBUS_BILL
    {
        IDAL_BILL dalb = new DAL_BIL();
        public DataTable GetList(string MaHDXuat)
        {
            return dalb.GetList(MaHDXuat);
        }
    }
}
