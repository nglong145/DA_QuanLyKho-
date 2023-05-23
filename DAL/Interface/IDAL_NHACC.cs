using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DAL
{
    public interface IDAL_NHACC
    {
        int Insert(string MaNhaCC, string TenNhaCC, string MaSoThue, string DiaChi, string SDT, string Email);
        int Delete(string MaNhaCC);
        int Update(string MaNhaCC, string TenNhaCC, string MaSoThue, string DiaChi, string SDT, string Email);
        DataTable GetList();
        //DataTable getClass_ID(int classID);
        //int getclassID_Last();
        int CheckMaNhaCC(string MaNhaCC);
    }
}
