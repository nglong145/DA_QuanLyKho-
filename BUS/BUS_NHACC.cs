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
    public class BUS_NHACC:IBUS_NHACC
    {
        private readonly IDAL_NHACC dalncc = new DAL_NHACC();
        public int CheckMaNhaCC(string MaNhaCC)
        {
            return dalncc.CheckMaNhaCC(MaNhaCC);
        }

        public IList<DTO_NhaCungCap> GetList()
        {
            System.Data.DataTable table = dalncc.GetList();
            IList<DTO_NhaCungCap> list = new List<DTO_NhaCungCap>();
            foreach (DataRow row in table.Rows)
            {
                DTO_NhaCungCap dtoncc = new DTO_NhaCungCap();
                dtoncc.MANHACC = row.Field<string>(0);
                dtoncc.TENNHACC = row.Field<string>(1);
                dtoncc.MASOTHUE = row.Field<string>(2);
                dtoncc.DIACHI = row.Field<string>(3);
                dtoncc.SODT = row.Field<string>(4);
                dtoncc.EMAIL = row.Field<string>(5);
                list.Add(dtoncc);
            }
            return list;
        }
        public int Insert(DTO_NhaCungCap dtoncc)
        {
            if (CheckMaNhaCC(dtoncc.MANHACC) == 0 )
                return dalncc.Insert(dtoncc.MANHACC, Tools.ChuanHoaXau(dtoncc.TENNHACC), dtoncc.MASOTHUE, dtoncc.DIACHI, dtoncc.SODT, dtoncc.EMAIL);
            else return -1;

        }

        public int Delete(string MaNhaCC)
        {
            if (CheckMaNhaCC(MaNhaCC) != 0)
                return dalncc.Delete(MaNhaCC);
            else return -1;
        }

        public int Update(DTO_NhaCungCap dtoncc)
        {
            if (CheckMaNhaCC(dtoncc.MANHACC) != 0)
                return dalncc.Update(dtoncc.MANHACC, Tools.ChuanHoaXau(dtoncc.TENNHACC), dtoncc.MASOTHUE, dtoncc.DIACHI, dtoncc.SODT, dtoncc.EMAIL);
            else return -1;
        }
    }
}
