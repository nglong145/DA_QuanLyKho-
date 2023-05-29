using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL;
using Utility;
using DTO;
using System.Security.Claims;
//using DocumentFormat.OpenXml.Drawing.Charts;
namespace BUS
{
    public class BUS_NguoiDung :IBUS_NguoiDung
    {

        private readonly IDAL_NguoiDung dalnd = new DAL_NguoiDung();

        public bool Login(string taikhoan, string matkhau)
        {
            return dalnd.Login(taikhoan, matkhau);
        }
        public int CheckMaND(string MaND)
        {
            return dalnd.CheckMaND(MaND);
        }

        public int CheckTaiKhoan(string TaiKhoan)
        {
            return dalnd.CheckTaiKhoan(TaiKhoan);
        }

        public string GetQuyen(string TaiKhoan, string MatKhau)
        {
            return dalnd.GetQuyen(TaiKhoan, MatKhau);
        }

        public string GetName(string TaiKhoan, string MatKhau)
        {
            return dalnd.GetName(TaiKhoan, MatKhau);
        }

        public IList<DTO_NguoiDung> GetList()
        {
            System.Data.DataTable table = dalnd.GetList();
            IList<DTO_NguoiDung> list = new List<DTO_NguoiDung>();
            foreach (DataRow row in table.Rows)
            {
                DTO_NguoiDung dtond = new DTO_NguoiDung();
                dtond.MAND = row.Field<string>(0);
                dtond.TENND = row.Field<string>(1);
                dtond.SODT = row.Field<string>(2);
                dtond.EMAIL = row.Field<string>(3);
                dtond.TAIKHOAN = row.Field<string>(4);
                dtond.MATKHAU = row.Field<string>(5);
                dtond.TRANGTHAI = row.Field<string>(6);
                list.Add(dtond);
            }
            return list;
        }
        public int Insert(DTO_NguoiDung dtond)
        {
            if (CheckMaND(dtond.MAND) == 0 && CheckTaiKhoan(dtond.TAIKHOAN) ==0)
                return dalnd.Insert(dtond.MAND, Tools.ChuanHoaXau(dtond.TENND), dtond.SODT, dtond.EMAIL, dtond.TAIKHOAN, dtond.MATKHAU, dtond.TRANGTHAI);
            else return -1;

        }

        public int Delete(string MaND)
        {
            if (CheckMaND(MaND) != 0)
                return dalnd.Delete(MaND);
            else return -1;
        }

        public int Update(DTO_NguoiDung dtond)
        {
            if (CheckMaND(dtond.MAND) != 0)
                return dalnd.Update(dtond.MAND, Tools.ChuanHoaXau(dtond.TENND), dtond.SODT, dtond.EMAIL, dtond.TAIKHOAN, dtond.MATKHAU, dtond.TRANGTHAI);
            else return -1;
        }

        public IList<DTO_NguoiDung> Search(string Word)
        {
            return dalnd.Search(Word);

        }
    }
}
