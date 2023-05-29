using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Net.NetworkInformation;
using DTO;

namespace DAL
{
    public interface IDAL_CTHDNHAP
    {
        DataTable GetList();
        DataTable GetImportID();
        DataTable GetWareHouse();
        DataTable GetProduct();
        DataTable GetUnit();

        int Insert(string MaCTHDNhap, string MaHDNhap, string TenSP, string TenKho, int SoLuong, int Gia);

        int CheckMaCTHDN(string MaCTHDNhap);

        int Delete(string MaCTHDNhap);

        IList<DTO_CTHDNhap> Search(string Word);
    }
}
