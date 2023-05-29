using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DTO;

namespace DAL
{
    public interface IDAL_HDXUAT
    {
        DataTable GetList();
        DataTable GetName();
        int CheckMahdxuat(string MaHDXuat);

        int Insert(string MaHDXuat, string TenKH, string TenND, DateTime NgayBan, string SoHoaDon);

        int Update(string MaHDXuat, string TenKH, string TenND, DateTime NgayBan, string SoHoaDon);

        int Delete(string MaHDXuat);

        DataTable GetList(string MaHDXuat);

        IList<DTO_HDXuat> Search(string Word);
    }
}
