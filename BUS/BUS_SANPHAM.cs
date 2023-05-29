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
    public class BUS_SANPHAM:IBUS_SANPHAM
    {
        private readonly IDAL_SANPHAM dalsp = new DAL_SANPHAM();

        public int CheckMaSP(string MaSP)
        {
            return dalsp.CheckMaSP(MaSP);
        }

        public IList<DTO_SanPham> GetList()
        {
            System.Data.DataTable table = dalsp.GetList();
            IList<DTO_SanPham> list = new List<DTO_SanPham>();
            foreach (DataRow row in table.Rows)
            {
                DTO_SanPham dtosp = new DTO_SanPham();
                dtosp.MASP = row.Field<string>(0);
                dtosp.TENSP = row.Field<string>(1);
                dtosp.TENDVT = row.Field<string>(2);
                dtosp.TENDM = row.Field<string>(3);
                dtosp.THONGSODACTA = row.Field<string>(4);
                dtosp.NHASX = row.Field<string>(5);
                list.Add(dtosp);
            }
            return list;
        }

        public IList<DTO_SanPham> GetUnit()
        {
            System.Data.DataTable table = dalsp.GetUnit();
            IList<DTO_SanPham> list = new List<DTO_SanPham>();
            foreach (DataRow row in table.Rows)
            {
                DTO_SanPham dtosp = new DTO_SanPham();
                dtosp.TENDVT = row.Field<string>(0);
                list.Add(dtosp);
            }
            return list;
        }

        public IList<DTO_SanPham> GetCategory()
        {
            System.Data.DataTable table = dalsp.GetCategory();
            IList<DTO_SanPham> list = new List<DTO_SanPham>();
            foreach (DataRow row in table.Rows)
            {
                DTO_SanPham dtosp = new DTO_SanPham();
                dtosp.TENDM = row.Field<string>(0);
                list.Add(dtosp);
            }
            return list;
        }

        public int Insert(DTO_SanPham dtosp)
        {
            if (CheckMaSP(dtosp.MASP) == 0)
                return dalsp.Insert(dtosp.MASP, Tools.ChuanHoaXau(dtosp.TENSP), Tools.ChuanHoaXau(dtosp.TENDVT), Tools.ChuanHoaXau(dtosp.TENDM), Tools.ChuanHoaXau(dtosp.THONGSODACTA), Tools.ChuanHoaXau(dtosp.NHASX));
            else return -1;

        }

        public int Delete(string MASP)
        {
            if (CheckMaSP(MASP) != 0)
                return dalsp.Delete(MASP);
            else return -1;
        }

        public int Update(DTO_SanPham dtosp)
        {
            if (CheckMaSP(dtosp.MASP) != 0)
                return dalsp.Update(dtosp.MASP, Tools.ChuanHoaXau(dtosp.TENSP), Tools.ChuanHoaXau(dtosp.TENDVT), Tools.ChuanHoaXau(dtosp.TENDM), Tools.ChuanHoaXau(dtosp.THONGSODACTA), Tools.ChuanHoaXau(dtosp.NHASX));
            else return -1;
        }

        public IList<DTO_SanPham> Search(string Word)
        {
            return dalsp.Search(Word);

        }
    }
}
