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
    public class BUS_KHOHANG:IBUS_KHOHANG
    {
        private readonly IDAL_KHOHANG dalkho = new DAL_KHOHANG();

        //public int CheckMaKH(string MaKH)
        //{
        //    return dalkh.CheckMaKH(MaKH);
        //}

        public IList<DTO_Kho> GetList()
        {
            System.Data.DataTable table = dalkho.GetList();
            IList<DTO_Kho> list = new List<DTO_Kho>();
            foreach (DataRow row in table.Rows)
            {
                DTO_Kho dtokho = new DTO_Kho();
                dtokho.MAKHO = row.Field<string>(0);
                dtokho.TENKHO = row.Field<string>(1);
                dtokho.DIACHI = row.Field<string>(2);
                dtokho.MACT_KHO = row.Field<string>(3);
                dtokho.MASP = row.Field<string>(4);
                dtokho.SOLUONG = row.Field<int>(5);
                list.Add(dtokho);
            }
            return list;
        }
        public int Insert(DTO_Kho dtokho)
        {
            //if (CheckMaKH(dtokh.MAKH) == 0)
                return dalkho.Insert(dtokho.MAKHO, Tools.ChuanHoaXau(dtokho.TENKHO), dtokho.DIACHI, dtokho.MACT_KHO, dtokho.MASP, dtokho.SOLUONG);
            //else return -1;

        }

        public int Delete(string MaKho)
        {
            //if (CheckMaKH(MaKH) != 0)
                return dalkho.Delete(MaKho);
            //else return -1;
        }

        public int Update(DTO_Kho dtokho)
        {
            //if (CheckMaKH(dtokh.MAKH) != 0)
                return dalkho.Update(dtokho.MAKHO, Tools.ChuanHoaXau(dtokho.TENKHO), dtokho.DIACHI, dtokho.MACT_KHO, dtokho.MASP, dtokho.SOLUONG);
            //else return -1;
        }
    }
}
