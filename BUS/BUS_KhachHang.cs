using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL;
using Utility;
using DTO;
using System.Security.Claims;
using BUS.Interface;
using DAL.Interface;
//using DocumentFormat.OpenXml.Drawing.Charts;

namespace BUS
{
    public class BUS_KhachHang:IBUS_KhachHang
    {
        private readonly IDAL_KhachHang dalkh = new DAL_KhachHang();

        public int CheckMaKH(string MaKH)
        {
            return dalkh.CheckMaKH(MaKH);
        }

        public IList<DTO_KhachHang> GetList()
        {
            System.Data.DataTable table = dalkh.GetList();
            IList<DTO_KhachHang> list = new List<DTO_KhachHang>();
            foreach (DataRow row in table.Rows)
            {
                DTO_KhachHang dtokh = new DTO_KhachHang();
                dtokh.MAKH = row.Field<string>(0);
                dtokh.TENKH= row.Field<string>(1);
                dtokh.DIACHI = row.Field<string>(2);
                dtokh.SODT = row.Field<string>(3);
                list.Add(dtokh);
            }
            return list;
        }
        public int Insert(DTO_KhachHang dtokh)
        {
            if (CheckMaKH(dtokh.MAKH) == 0 )
                return dalkh.Insert(dtokh.MAKH, Tools.ChuanHoaXau(dtokh.TENKH), dtokh.DIACHI, dtokh.SODT);
            else return -1;

        }

        public int Delete(string MaKH)
        {
            if (CheckMaKH(MaKH) != 0)
                return dalkh.Delete(MaKH);
            else return -1;
        }

        public int Update(DTO_KhachHang dtokh)
        {
            if (CheckMaKH(dtokh.MAKH) != 0)
                return dalkh.Update(dtokh.MAKH, Tools.ChuanHoaXau(dtokh.TENKH), dtokh.DIACHI, dtokh.SODT);
            else return -1;
        }
    }
}
