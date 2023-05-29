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
    public class BUS_HDNHAP:IBUS_HDNHAP
    {
        private readonly IDAL_HDNHAP dalhdn = new DAL_HDNhap();

        public IList<DTO_HDNhap> GetList()
        {
            System.Data.DataTable table = dalhdn.GetList();
            IList<DTO_HDNhap> list = new List<DTO_HDNhap>();
            foreach (DataRow row in table.Rows)
            {
                DTO_HDNhap dtohdn = new DTO_HDNhap();
                dtohdn.MAHDNHAP = row.Field<string>(0);
                dtohdn.TENNHACC = row.Field<string>(1);
                dtohdn.TENND = row.Field<string>(2);
                dtohdn.NGAYNHAP = row.Field<DateTime>(3);
                dtohdn.SOHOADON = row.Field<string>(4);
                list.Add(dtohdn);
            }
            return list;
        }

        public IList<DTO_HDNhap> GetSuplier()
        {
            System.Data.DataTable table = dalhdn.GetSuplier();
            IList<DTO_HDNhap> list = new List<DTO_HDNhap>();
            foreach (DataRow row in table.Rows)
            {
                DTO_HDNhap dtohdn = new DTO_HDNhap();
                dtohdn.TENNHACC = row.Field<string>(0);
                list.Add(dtohdn);
            }
            return list;
        }

        public int CheckMaHDNhap(string MaHDNhap)
        {
            return dalhdn.CheckMaHDNhap(MaHDNhap);
        }

        public int Insert(DTO_HDNhap dtohdn)
        {
            if (CheckMaHDNhap(dtohdn.MAHDNHAP) == 0)
                return dalhdn.Insert(dtohdn.MAHDNHAP, Tools.ChuanHoaXau(dtohdn.TENNHACC), Tools.ChuanHoaXau(dtohdn.TENND), dtohdn.NGAYNHAP, dtohdn.SOHOADON);
            else return -1;
        }

        public int Delete(string MaHDNhap)
        {
            if (CheckMaHDNhap(MaHDNhap) != 0)
                return dalhdn.Delete(MaHDNhap);
            else return -1;
        }

        public int Update(DTO_HDNhap dtohdn)
        {
            if (CheckMaHDNhap(dtohdn.MAHDNHAP) != 0)
                return dalhdn.Update(dtohdn.MAHDNHAP, Tools.ChuanHoaXau(dtohdn.TENNHACC), Tools.ChuanHoaXau(dtohdn.TENND), dtohdn.NGAYNHAP, dtohdn.SOHOADON);
            else return -1;
        }

        public IList<DTO_HDNhap> Search(string Word)
        {
            return dalhdn.Search(Word);

        }
    }
}
