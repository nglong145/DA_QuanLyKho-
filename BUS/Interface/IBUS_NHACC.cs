using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BUS
{
    public interface IBUS_NHACC
    {
        int Insert(DTO_NhaCungCap dtoncc);
        int Delete(string MaNhaCC);
        int Update(DTO_NhaCungCap dtoncc);
        IList<DTO_NhaCungCap> GetList();
        //Class getClass_ID(int classID);
        //anh phong dep trai
        //int getclassID_Last();
        int CheckMaNhaCC(string MaNhaCC);

        //IList<Class> Search(Class cls);
        //IList<Class> SearchLinq(Class cls);
        //void KetXuatWord(int ClassID, string templatePath, string exportPath);
    }
}
