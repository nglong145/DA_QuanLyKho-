using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace BUS.Interface
{
    public interface IBUS_KhachHang
    {
        int Insert(DTO_KhachHang dtokh);
        int Delete(string MaKH);
        int Update(DTO_KhachHang dtokh);
        IList<DTO_KhachHang> GetList();
        //Class getClass_ID(int classID);
        //anh phong dep trai
        //int getclassID_Last();
        int CheckMaKH(string MaKH);
        //IList<Class> Search(Class cls);
        //IList<Class> SearchLinq(Class cls);
        //void KetXuatWord(int ClassID, string templatePath, string exportPath);
    }
}
