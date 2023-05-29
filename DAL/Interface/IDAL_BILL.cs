using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Net.NetworkInformation;

namespace DAL
{
    public interface IDAL_BILL
    {
        DataTable GetList(string MaHDXuat);
        //DataTable GetBill(string MaHDXuat);
    }
}
