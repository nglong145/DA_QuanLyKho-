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
using DocumentFormat.OpenXml.VariantTypes;
using DocumentFormat.OpenXml.Wordprocessing;
//using DocumentFormat.OpenXml.Drawing.Charts;
namespace BUS
{
    public class BUS_CTKHO:IBUS_CTKHO
    {
        private readonly IDAL_CTKHO dalct = new DAL_CTKHO();

        public IList<DTO_CTKho> GetList()
        {
            System.Data.DataTable table = dalct.GetList();
            IList<DTO_CTKho> list = new List<DTO_CTKho>();
            foreach (DataRow row in table.Rows)
            {
                DTO_CTKho dtoct = new DTO_CTKho();
                dtoct.MACT_KHO = row.Field<string>(0);
                dtoct.MAKHO = row.Field<string>(1);
                dtoct.MASP = row.Field<string>(2);
                dtoct.SOLUONG = row.Field<int>(3);
                dtoct.TENKHO = row.Field<string>(4);
                dtoct.DIACHI = row.Field<string>(5);
                dtoct.TENSP = row.Field<string>(6);
                list.Add(dtoct);
            }
            return list;
        }
        public int Insert(DTO_CTKho dtoct)
        {
            if (CheckMaCTKho(dtoct.MACT_KHO) == 0)
                return dalct.Insert(dtoct.MACT_KHO, dtoct.MAKHO,dtoct.TENSP);
            else return -1;

        }

        public int Delete(string MaCTKho)
        {
            if (CheckMaCTKho(MaCTKho) != 0)
                return dalct.Delete(MaCTKho);
            else return -1;
        }

        public int Update(DTO_CTKho dtoct)
        {
            if (CheckMaCTKho(dtoct.MACT_KHO) != 0)
                return dalct.Update(dtoct.MACT_KHO, dtoct.MAKHO, dtoct.TENSP);
            else return -1;
        }

        public int CheckMaCTKho (string MaCTKho)
        {
            return dalct.CheckMaCTKho(MaCTKho);
        }

        public IList<DTO_CTKho> GetProductName()
        {
            System.Data.DataTable table = dalct.GetProductName();
            IList<DTO_CTKho> list = new List<DTO_CTKho>();
            foreach (DataRow row in table.Rows)
            {
                DTO_CTKho dtoct = new DTO_CTKho();
                dtoct.TENSP = row.Field<string>(0);
                list.Add(dtoct);
            }
            return list;
        }

        public IList<DTO_CTKho> Search(string Word)
        {
            return dalct.Search(Word);

        }

        public DTO_CTKho GetWHDetail(string MaKho)
        {
            System.Data.DataTable table = dalct.GetWHDetail(MaKho); 
            DTO_CTKho dtoctk = new DTO_CTKho();
            dtoctk.MAKHO = table.Rows[0].Field<string>(0);
            dtoctk.TENKHO = table.Rows[0].Field<string>(1);
            dtoctk.DIACHI = table.Rows[0].Field<string>(2);
            dtoctk.MACT_KHO = table.Rows[0].Field<string>(3);
            dtoctk.TENSP = table.Rows[0].Field<string>(4);
            dtoctk.SOLUONG = table.Rows[0].Field<int>(5);
            return dtoctk;

        }
        public void KetXuatWord(string MaKho, string templatePath, string exportPath)
        {
            DTO_CTKho dtoct = new DTO_CTKho();
            IList<DTO_CTKho> list = (IList<DTO_CTKho>)GetWHDetail(MaKho);
            Dictionary<string, string> dictionaryData = new Dictionary<string, string>();
            dictionaryData.Add("MaKho", dtoct.MAKHO.ToString());
            dictionaryData.Add("TenKho", dtoct.TENKHO.ToString());
            dictionaryData.Add("DiaChi", dtoct.DIACHI.ToString());
            System.IO.File.Copy(templatePath, exportPath, true);
            ExportDoc.CreteKhoTemplate(exportPath, dictionaryData, list);
        }

    }
}
