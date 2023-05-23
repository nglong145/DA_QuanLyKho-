using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;


namespace DAL
{
    public interface IDAL_DonViTinh
    {
        int Insert(int MaDVT, string TenDVT);
        int Delete(int MaDVT);
        int Update(int MaDVT, string TenDVT);
        DataTable GetList();
        //DataTable getClass_ID(int classID);
        //int getclassID_Last();
        int CheckMaDVT(int MaDVT);
    }
}
