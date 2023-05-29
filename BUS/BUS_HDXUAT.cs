using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL;
using Utility;
using DTO;
using System.Security.Claims;
using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Wordprocessing;
//using DocumentFormat.OpenXml.Drawing.Charts;

namespace BUS
{
    public class BUS_HDXUAT:IBUS_HDXUAT
    {
        private readonly IDAL_HDXUAT dalhdx = new DAL_HDXUAT();

        public IList<DTO_HDXuat> GetList()
        {
            System.Data.DataTable table = dalhdx.GetList();
            IList<DTO_HDXuat> list = new List<DTO_HDXuat>();
            foreach (DataRow row in table.Rows)
            {
                DTO_HDXuat dtohdx = new DTO_HDXuat();
                dtohdx.MAHDXUAT = row.Field<string>(0);
                dtohdx.TENKH = row.Field<string>(1);
                dtohdx.TENND = row.Field<string>(2);
                dtohdx.NGAYBAN = row.Field<DateTime>(3);
                dtohdx.SOHOADON = row.Field<string>(4);
                list.Add(dtohdx);
            }
            return list;
        }

        public IList<DTO_HDXuat> GetName()
        {
            System.Data.DataTable table = dalhdx.GetName();
            IList<DTO_HDXuat> list = new List<DTO_HDXuat>();
            foreach (DataRow row in table.Rows)
            {
                DTO_HDXuat dtohdx = new DTO_HDXuat();
                dtohdx.TENKH = row.Field<string>(0);
                list.Add(dtohdx);
            }
            return list;
        }

        public int CheckMahdxuat (string MaHDXuat)
        {
            return dalhdx.CheckMahdxuat (MaHDXuat);
        }

        public int Insert(DTO_HDXuat dtohdx)
        {
            if (CheckMahdxuat(dtohdx.MAHDXUAT) == 0 )
                return dalhdx.Insert(dtohdx.MAHDXUAT, Tools.ChuanHoaXau(dtohdx.TENKH), Tools.ChuanHoaXau(dtohdx.TENND), dtohdx.NGAYBAN, dtohdx.SOHOADON);
            else return -1;
        }

        public int Delete(string MaHDXuat)
        {
            if (CheckMahdxuat(MaHDXuat) != 0)
                return dalhdx.Delete(MaHDXuat);
            else return -1;
        }

        public int Update(DTO_HDXuat dtohdx)
        {
            if (CheckMahdxuat(dtohdx.MAHDXUAT) != 0)
                return dalhdx.Update(dtohdx.MAHDXUAT, Tools.ChuanHoaXau(dtohdx.TENKH), Tools.ChuanHoaXau(dtohdx.TENND), dtohdx.NGAYBAN, dtohdx.SOHOADON);
            else return -1;
        }

        public IList<DTO_HDXuat> Search(string Word)
        {
            return dalhdx.Search(Word);

        }


        public DTO_BILL GetList(string MaHDXuat)
        {
            System.Data.DataTable table = dalhdx.GetList(MaHDXuat);
            if (CheckMahdxuat(MaHDXuat) != 0)
            {
                DTO_BILL dtohdx = new DTO_BILL();
                dtohdx.MAHDXUAT = table.Rows[0].Field<string>(0);
                dtohdx.TENKH = table.Rows[0].Field<string>(1);
                dtohdx.TENND = table.Rows[0].Field<string>(2);
                dtohdx.NGAYBAN = table.Rows[0].Field<DateTime>(3);
                dtohdx.SOHOADON = table.Rows[0].Field<string>(4);
                dtohdx.TOTAL = table.Rows[0].Field<int>(5);
                return dtohdx;
            }
            else return null;
        }

        public void KetXuatWord(string MaHDXuat, string templatePath, string exportPath)
        {
            DTO_BILL dtohdx = GetList(MaHDXuat);
            IBUS_CTHDXuat busctx = new BUS_CTHDXuat();
            IList<DTO_CTHDXuat> list = busctx.GetList(MaHDXuat);
            Dictionary<string, string> dictionaryData = new Dictionary<string, string>();
            dictionaryData.Add("mahdxuat", dtohdx.MAHDXUAT.ToString());
            dictionaryData.Add("tenkh", dtohdx.TENKH.ToString());
            dictionaryData.Add("tennd", dtohdx.TENND.ToString());
            dictionaryData.Add("ngayban", dtohdx.NGAYBAN.ToString());
            dictionaryData.Add("sohoadon", dtohdx.SOHOADON.ToString());
            dictionaryData.Add("total", dtohdx.TOTAL.ToString());
            System.IO.File.Copy(templatePath, exportPath, true);
            ExportDoc.CreateHDTemplate(exportPath, dictionaryData, list);
        }

    }
}
