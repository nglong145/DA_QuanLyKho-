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
using DocumentFormat.OpenXml.Bibliography;


namespace BUS
{
    public class BUS_CTHDXuat:IBUS_CTHDXuat
    {
        private readonly IDAL_CTHDXUAT dalctx = new DAL_CTHDXUAT();
        public IList<DTO_CTHDXuat> GetList()
        {
            System.Data.DataTable table = dalctx.GetList();
            IList<DTO_CTHDXuat> list = new List<DTO_CTHDXuat>();
            foreach (DataRow row in table.Rows)
            {
                DTO_CTHDXuat dtoctx = new DTO_CTHDXuat();
                dtoctx.MACTHDXUAT = row.Field<string>(0);
                dtoctx.MAHDXUAT = row.Field<string>(1);
                dtoctx.TENSP = row.Field<string>(2);
                dtoctx.TENKHO = row.Field<string>(3);
                dtoctx.TENDVT = row.Field<string>(4);
                dtoctx.SLBAN = row.Field<int>(5);
                dtoctx.GIABAN = row.Field<int>(6);
                list.Add(dtoctx);
            }
            return list;
        }

        public IList<DTO_CTHDXuat> GetExportID()
        {
            System.Data.DataTable table = dalctx.GetExportID();
            IList<DTO_CTHDXuat> list = new List<DTO_CTHDXuat>();
            foreach (DataRow row in table.Rows)
            {
                DTO_CTHDXuat dtoctx = new DTO_CTHDXuat();
                dtoctx.MAHDXUAT = row.Field<string>(0);
                list.Add(dtoctx);
            }
            return list;
        }

        public IList<DTO_CTHDXuat> GetWareHouse()
        {
            System.Data.DataTable table = dalctx.GetWareHouse();
            IList<DTO_CTHDXuat> list = new List<DTO_CTHDXuat>();
            foreach (DataRow row in table.Rows)
            {
                DTO_CTHDXuat dtoctx = new DTO_CTHDXuat();
                dtoctx.TENKHO = row.Field<string>(0);
                list.Add(dtoctx);
            }
            return list;
        }

        public IList<DTO_CTHDXuat> GetProduct()
        {
            System.Data.DataTable table = dalctx.GetProduct();
            IList<DTO_CTHDXuat> list = new List<DTO_CTHDXuat>();
            foreach (DataRow row in table.Rows)
            {
                DTO_CTHDXuat dtoctx = new DTO_CTHDXuat();
                dtoctx.TENSP = row.Field<string>(0);
                list.Add(dtoctx);
            }
            return list;
        }

        public IList<DTO_CTHDXuat> GetUnit()
        {
            System.Data.DataTable table = dalctx.GetUnit();
            IList<DTO_CTHDXuat> list = new List<DTO_CTHDXuat>();
            foreach (DataRow row in table.Rows)
            {
                DTO_CTHDXuat dtoctx = new DTO_CTHDXuat();
                dtoctx.TENDVT = row.Field<string>(0);
                list.Add(dtoctx);
            }
            return list;
        }

        public IList<DTO_CTHDXuat> GetList(string MaHDXuat)
        {
            DataTable table = dalctx.GetList(MaHDXuat);
            IList<DTO_CTHDXuat> list = new List<DTO_CTHDXuat>();
            foreach (DataRow row in table.Rows)
            {
                DTO_CTHDXuat dtoctx = new DTO_CTHDXuat();
                dtoctx.MAHDXUAT = row.Field<string>(0);
                dtoctx.MACTHDXUAT = row.Field<string>(1);
                dtoctx.TENKHO = row.Field<string>(2);
                dtoctx.TENSP = row.Field<string>(3);
                dtoctx.TENDVT = row.Field<string>(4);
                dtoctx.SLBAN = row.Field<int>(5);
                dtoctx.GIABAN = row.Field<int>(6);
                list.Add(dtoctx);
            }
            return list;
        }

        public int Insert(DTO_CTHDXuat dtoctx)
        {
            if (CheckMaCTHDX(dtoctx.MACTHDXUAT) == 0)
                return dalctx.Insert(dtoctx.MACTHDXUAT, dtoctx.MAHDXUAT, dtoctx.TENSP, dtoctx.TENKHO, dtoctx.SLBAN, dtoctx.GIABAN);
            else return -1;

        }

        public int CheckMaCTHDX(string MaCTHDXuat)
        {
            return dalctx.CheckMaCTHDX(MaCTHDXuat);
        }

        public int Delete(string MaCTHDXuat)
        {
            if (CheckMaCTHDX(MaCTHDXuat) != 0)
                return dalctx.Delete(MaCTHDXuat);
            else return -1;
        }

        public IList<DTO_CTHDXuat> Search(string Word)
        {
            return dalctx.Search(Word);

        }
    }
}
