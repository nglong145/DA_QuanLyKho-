using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Net.NetworkInformation;
using DTO;

namespace DAL
{
    public interface IDAL_SANPHAM
    {
        int Insert(string MaSP, string TenSP, string TenDVT, string TenDM, string TSDT, string NhaSX);

        int Delete(string MaSP);
        int Update(string MaSP, string TenSP, string TenDVT, string TenDM, string TSDT, string NhaSX);
        DataTable GetList();
        DataTable GetUnit();
        DataTable GetCategory();
        IList<DTO_SanPham> Search(string Word);
        int CheckMaSP(string MaSP);

    }
}
