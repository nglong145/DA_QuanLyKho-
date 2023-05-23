using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BUS
{
    public interface IBUS_DonViTinh
    {
        int Insert(DTO_DonViTinh dtodv);
        int Delete(int MaDVT);
        int Update(DTO_DonViTinh dtodv);
        IList<DTO_DonViTinh> GetList();
        //Class getClass_ID(int classID);
        //anh phong dep trai
        //int getclassID_Last();
        int CheckMaDVT(int MaDVT);
    }
}
