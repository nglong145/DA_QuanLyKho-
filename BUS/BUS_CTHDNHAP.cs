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

namespace BUS
{
    public class BUS_CTHDNHAP:IBUS_CTHDNHAP
    {
        private readonly IDAL_CTHDNHAP dalctn = new DAL_CTHDNHAP();
        public IList<DTO_CTHDNhap> GetList()
        {
            System.Data.DataTable table = dalctn.GetList();
            IList<DTO_CTHDNhap> list = new List<DTO_CTHDNhap>();
            foreach (DataRow row in table.Rows)
            {
                DTO_CTHDNhap dtoctx = new DTO_CTHDNhap();
                dtoctx.MAHDNHAP= row.Field<string>(0);
                dtoctx.MACTHDNHAP = row.Field<string>(1);
                dtoctx.TENSP = row.Field<string>(2);
                dtoctx.TENKHO = row.Field<string>(3);
                dtoctx.TENDVT = row.Field<string>(4);
                dtoctx.SLNHAP = row.Field<int>(5);
                dtoctx.GIANHAP = row.Field<int>(6);
                list.Add(dtoctx);
            }
            return list;
        }

        public IList<DTO_CTHDNhap> GetImportID()
        {
            System.Data.DataTable table = dalctn.GetImportID();
            IList<DTO_CTHDNhap> list = new List<DTO_CTHDNhap>();
            foreach (DataRow row in table.Rows)
            {
                DTO_CTHDNhap dtoctx = new DTO_CTHDNhap();
                dtoctx.MAHDNHAP = row.Field<string>(0);
                list.Add(dtoctx);
            }
            return list;
        }

        public IList<DTO_CTHDNhap> GetWareHouse()
        {
            System.Data.DataTable table = dalctn.GetWareHouse();
            IList<DTO_CTHDNhap> list = new List<DTO_CTHDNhap>();
            foreach (DataRow row in table.Rows)
            {
                DTO_CTHDNhap dtoctx = new DTO_CTHDNhap();
                dtoctx.TENKHO = row.Field<string>(0);
                list.Add(dtoctx);
            }
            return list;
        }

        public IList<DTO_CTHDNhap> GetProduct()
        {
            System.Data.DataTable table = dalctn.GetProduct();
            IList<DTO_CTHDNhap> list = new List<DTO_CTHDNhap>();
            foreach (DataRow row in table.Rows)
            {
                DTO_CTHDNhap dtoctx = new DTO_CTHDNhap();
                dtoctx.TENSP = row.Field<string>(0);
                list.Add(dtoctx);
            }
            return list;
        }

        public IList<DTO_CTHDNhap> GetUnit()
        {
            System.Data.DataTable table = dalctn.GetUnit();
            IList<DTO_CTHDNhap> list = new List<DTO_CTHDNhap>();
            foreach (DataRow row in table.Rows)
            {
                DTO_CTHDNhap dtoctx = new DTO_CTHDNhap();
                dtoctx.TENDVT = row.Field<string>(0);
                list.Add(dtoctx);
            }
            return list;
        }

        public int Insert(DTO_CTHDNhap dtoctx)
        {
            if (CheckMaCTHDN(dtoctx.MACTHDNHAP) == 0)
                return dalctn.Insert(dtoctx.MACTHDNHAP, dtoctx.MAHDNHAP, dtoctx.TENSP, dtoctx.TENKHO, dtoctx.SLNHAP, dtoctx.GIANHAP);
            else return -1;

        }

        public int CheckMaCTHDN(string MaCTHDNhap)
        {
            return dalctn.CheckMaCTHDN(MaCTHDNhap);
        }

        public int Delete(string MaCTHDNhap)
        {
            if (CheckMaCTHDN(MaCTHDNhap) != 0)
                return dalctn.Delete(MaCTHDNhap);
            else return -1;
        }

        public IList<DTO_CTHDNhap> Search(string Word)
        {
            return dalctn.Search(Word);

        }
    }
}
