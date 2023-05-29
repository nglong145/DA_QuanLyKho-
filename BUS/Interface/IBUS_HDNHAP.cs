using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BUS
{
    public interface IBUS_HDNHAP
    {
        IList<DTO_HDNhap> GetList();
        IList<DTO_HDNhap> GetSuplier();
        int CheckMaHDNhap(string MaHDNhap);
        int Insert(DTO_HDNhap dtohdn);

        int Update(DTO_HDNhap dtohdn);

        int Delete(string MaHDNhap);

        IList<DTO_HDNhap> Search(string Word);
    }
}
