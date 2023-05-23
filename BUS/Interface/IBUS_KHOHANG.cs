using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BUS
{
    public interface IBUS_KHOHANG
    {
        int Insert(DTO_Kho dtokho);
        int Delete(string MaKho);
        int Update(DTO_Kho dtokho);
        IList<DTO_Kho> GetList();

    }
}
