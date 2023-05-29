using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BUS
{
    public interface IBUS_NHACC
    {
        int Insert(DTO_NhaCungCap dtoncc);
        int Delete(string MaNhaCC);
        int Update(DTO_NhaCungCap dtoncc);
        IList<DTO_NhaCungCap> GetList();
        IList<DTO_NhaCungCap> Search(string Word);
        int CheckMaNhaCC(string MaNhaCC);

    }
}
