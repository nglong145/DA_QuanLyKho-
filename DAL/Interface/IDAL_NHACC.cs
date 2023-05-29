using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DTO;

namespace DAL
{
    public interface IDAL_NHACC
    {
        int Insert(string MaNhaCC, string TenNhaCC, string MaSoThue, string DiaChi, string SDT, string Email);
        int Delete(string MaNhaCC);
        int Update(string MaNhaCC, string TenNhaCC, string MaSoThue, string DiaChi, string SDT, string Email);
        DataTable GetList();
        IList<DTO_NhaCungCap> Search(string Word);
        int CheckMaNhaCC(string MaNhaCC);
    }
}
