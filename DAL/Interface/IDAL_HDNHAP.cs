using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DTO;

namespace DAL
{
    public interface IDAL_HDNHAP
    {
        DataTable GetList();
        DataTable GetSuplier();
        int CheckMaHDNhap(string MaHDNhap);

        int Insert(string MaHDNhap, string TenNCC, string TenND, DateTime NgayNhap, string SoHoaDon);

        int Update(string MaHDNhap, string TenNCC, string TenND, DateTime NgayNhap, string SoHoaDon);

        int Delete(string MaHDNhap);

        IList<DTO_HDNhap> Search(string Word);
    }
}
