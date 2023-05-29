using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BUS
{
    public interface IBUS_SANPHAM
    {
        int Insert(DTO_SanPham dtosp);
        int Delete(string MaSP);
        int Update(DTO_SanPham dtosp);
        IList<DTO_SanPham> GetList();
        IList<DTO_SanPham> GetUnit();
        IList<DTO_SanPham> GetCategory();

        IList<DTO_SanPham> Search(string Word);
        int CheckMaSP(string MaSP);
    }
}
