using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BUS
{
    public interface IBUS_BILL
    {
        DataTable GetList(string MaHdXuat);
    }
}
