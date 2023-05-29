using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BUS
{
    public interface IBUS_CTHDXuat
    {
        IList<DTO_CTHDXuat> GetList();
        IList<DTO_CTHDXuat> GetExportID();
        IList<DTO_CTHDXuat> GetWareHouse();
        IList<DTO_CTHDXuat> GetProduct();
        IList<DTO_CTHDXuat> GetUnit();

        IList<DTO_CTHDXuat> GetList(string MaHDXuat);

        int Insert(DTO_CTHDXuat dtoctx);

        int CheckMaCTHDX(string MaCTHDXuat);

        int Delete (string MaCTHDXuat);

        IList<DTO_CTHDXuat> Search(string Word);

    }
}
