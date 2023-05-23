﻿using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BUS
{
    public interface IBUS_NguoiDung
    {
        bool Login(string taikhoan, string matkhau);
        int Insert(DTO_NguoiDung dtond);
        int Delete(string MaND);
        int Update(DTO_NguoiDung dtond);
        IList<DTO_NguoiDung> GetList();
        //Class getClass_ID(int classID);
        //anh phong dep trai
        //int getclassID_Last();
        int CheckMaND(string MaND);
        int CheckTaiKhoan(string TaiKhoan);
        string GetQuyen(string TaiKhoan, string MatKhau);
        //IList<Class> Search(Class cls);
        //IList<Class> SearchLinq(Class cls);
        //void KetXuatWord(int ClassID, string templatePath, string exportPath);
    }
}
