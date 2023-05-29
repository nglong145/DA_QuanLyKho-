using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Net.NetworkInformation;
using DTO;

namespace DAL
{
    public interface IDAL_CTKHO
    {
        DataTable GetList();
        int Insert(string MaCTKho, string MaKho, string TenSP);
        int Delete(string MaCTKho);
        int Update(string MaCTKho, string MaKho, string TenSP);
        int CheckMaCTKho(string MaCTKho);

        DataTable GetProductName();

        DataTable GetWHDetail(string MaKho);

        IList<DTO_CTKho> Search(string Word);
    }
}
