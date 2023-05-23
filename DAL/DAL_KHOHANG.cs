using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Security.Cryptography;

namespace DAL
{
    public class DAL_KHOHANG:IDAL_KHOHANG
    {
        private const string PARM_MAKHO = "@makho";
        private const string PARM_TENKHO = "@tenkho";
        private const string PARM_DIACHI = "@diachi";
        private const string PARM_MACTKHO = "@mactk";
        private const string PARM_MASP = "@masp";
        private const string PARM_SOLUONG = "@sluong";

        public int Insert(string MaKho, string TenKho, string DiaChi, string MaCTKho, string MaSP, int SoLuong)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_MAKHO,SqlDbType.Char,10),
                new SqlParameter(PARM_TENKHO,SqlDbType.NVarChar,50),
                new SqlParameter(PARM_DIACHI,SqlDbType.Char,10),
                new SqlParameter(PARM_MACTKHO,SqlDbType.Char,50),
                new SqlParameter(PARM_MASP,SqlDbType.Char,30),
                new SqlParameter(PARM_SOLUONG,SqlDbType.Char,30),
            };
            parm[0].Value = MaKho;
            parm[1].Value = TenKho;
            parm[2].Value = DiaChi;
            parm[3].Value = MaCTKho;
            parm[4].Value = MaSP;
            parm[5].Value = SoLuong;
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "sp_themkho", parm);
        }

        public int Delete(string MaKho)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_MAKHO,SqlDbType.Char,10)
            };
            parm[0].Value = MaKho;

            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "sp_xoakho", parm);
        }

        public int Update(string MaKho, string TenKho, string DiaChi, string MaCTKho, string MaSP, int SoLuong)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_MAKHO,SqlDbType.Char,10),
                new SqlParameter(PARM_TENKHO,SqlDbType.NVarChar,50),
                new SqlParameter(PARM_DIACHI,SqlDbType.Char,10),
                new SqlParameter(PARM_MACTKHO,SqlDbType.Char,50),
                new SqlParameter(PARM_MASP,SqlDbType.Char,30),
                new SqlParameter(PARM_SOLUONG,SqlDbType.Char,30),
            };
            parm[0].Value = MaKho;
            parm[1].Value = TenKho;
            parm[2].Value = DiaChi;
            parm[3].Value = MaCTKho;
            parm[4].Value = MaSP;
            parm[5].Value = SoLuong;
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "sp_suakho", parm);
        }

        public DataTable GetList()
        {
            SqlDataReader dra = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.StoredProcedure, "sp_laydanhsachkho", null);
            DataTable table = new DataTable();
            table.Columns.Add("MaKho", typeof(string));
            table.Columns.Add("TenKho", typeof(string));
            table.Columns.Add("DiaChi", typeof(string));
            table.Columns.Add("MaCT_Kho", typeof(string));
            table.Columns.Add("MaSP", typeof(string));
            table.Columns.Add("SoLuong", typeof(int));
            while (dra.Read())
            {
                table.Rows.Add(dra["MaKho"].ToString(), dra["TenKho"].ToString(), dra["DiaChi"].ToString(), dra["MaCT_Kho"].ToString(), dra["MaSP"].ToString(), dra["SoLuong"]);
            }
            dra.Dispose();
            return table;
        }

        //public int CheckMaND(string MaND)
        //{
        //    SqlParameter[] parm = new SqlParameter[]
        //    {
        //        new SqlParameter(PARM_MAKHO,SqlDbType.Char,10)
        //    };
        //    parm[0].Value = MaND;
        //    return (int)SqlHelper.ExecuteScalar(SqlHelper.ConnectionString, CommandType.StoredProcedure, "sp_checkmand", parm);
        //}l

    
    }
}
