using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Net.NetworkInformation;
using DTO;

namespace DAL
{
    public interface IDAL_CTHDXUAT
    {
        DataTable GetList();
        DataTable GetExportID();
        DataTable GetWareHouse();
        DataTable GetProduct();
        DataTable GetUnit();

        DataTable GetList(string MaHDXuat);

        int Insert(string MaCTHDXuat, string MaHDXuat, string TenSP, string TenKho, int SoLuong, int Gia);

        int CheckMaCTHDX(string MaCTHDXuat);

        int Delete(string MaCTHDXuat);

        IList<DTO_CTHDXuat> Search(string Word);
    }
}
