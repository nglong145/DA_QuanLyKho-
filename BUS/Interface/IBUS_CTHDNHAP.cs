using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace BUS
{
    public interface IBUS_CTHDNHAP
    {
        IList<DTO_CTHDNhap> GetList();
        IList<DTO_CTHDNhap> GetImportID();
        IList<DTO_CTHDNhap> GetWareHouse();
        IList<DTO_CTHDNhap> GetProduct();
        IList<DTO_CTHDNhap> GetUnit();

        int Insert(DTO_CTHDNhap dtoctn);

        int CheckMaCTHDN(string MaCTHDNhap);

        int Delete(string MaCTHDNhap);

        IList<DTO_CTHDNhap> Search(string Word);
    }
}
