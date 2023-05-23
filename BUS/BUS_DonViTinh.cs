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
    public class BUS_DonViTinh :IBUS_DonViTinh
    {
        private readonly IDAL_DonViTinh daldv = new DAL_DonViTinh();

        public int CheckMaDVT(int MaDVT)
        {
            return daldv.CheckMaDVT(MaDVT);
        }

        public IList<DTO_DonViTinh> GetList()
        {
            System.Data.DataTable table = daldv.GetList();
            IList<DTO_DonViTinh> list = new List<DTO_DonViTinh>();
            foreach (DataRow row in table.Rows)
            {
                DTO_DonViTinh dtodv = new DTO_DonViTinh();
                dtodv.MADVT = row.Field<int>(0);
                dtodv.TENDVT = row.Field<string>(1);
                list.Add(dtodv);
            }
            return list;
        }
        public int Insert(DTO_DonViTinh dtodv)
        {
            if (CheckMaDVT(dtodv.MADVT) == 0 )
                return daldv.Insert(dtodv.MADVT, Tools.ChuanHoaXau(dtodv.TENDVT));
            else return -1;

        }

        public int Delete(int MaDVT)
        {
            if (CheckMaDVT(MaDVT) != 0)
                return daldv.Delete(MaDVT);
            else return -1;
        }

        public int Update(DTO_DonViTinh dtodv)
        {
            if (CheckMaDVT(dtodv.MADVT) != 0)
                return daldv.Update(dtodv.MADVT, Tools.ChuanHoaXau(dtodv.TENDVT));
            else return -1;
        }
    }
}
