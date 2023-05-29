using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Security.Cryptography;
using DTO;

namespace DAL
{
    public class DAL_CTKHO:IDAL_CTKHO
    {
        private const string PARM_MACTKHO = "@mactkho";
        private const string PARM_MAKHO = "@makho";
        private const string PARM_MASP = "@masp";
        private const string PARM_SOLUONG = "@sluong";
        private const string PARM_TENSP = "@tensp";

        public int Insert(string MaCTKho, string MaKho,string TenSP)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_MACTKHO,SqlDbType.Char,10),
                new SqlParameter(PARM_MAKHO,SqlDbType.Char,10),
                new SqlParameter(PARM_TENSP,SqlDbType.NVarChar,50),
            };
            parm[0].Value = MaCTKho;
            parm[1].Value = MaKho;
            parm[2].Value = TenSP;
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "sp_themctkho", parm);
        }

        public int Delete(string MaCTKho)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_MACTKHO,SqlDbType.Char,10)
            };
            parm[0].Value = MaCTKho;

            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "sp_xoactkho", parm);
        }

        public int Update(string MaCTKho, string MaKho, string TenSP)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_MACTKHO,SqlDbType.Char,10),
                new SqlParameter(PARM_MAKHO,SqlDbType.Char,10),
                new SqlParameter(PARM_TENSP,SqlDbType.NVarChar,50),
            };
            parm[0].Value = MaCTKho;
            parm[1].Value = MaKho;
            parm[2].Value = TenSP;
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "sp_suactkho", parm);
        }

        public DataTable GetList()
        {
            SqlDataReader dra = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.StoredProcedure, "sp_laydsctkho", null);
            DataTable table = new DataTable();
            table.Columns.Add("MaCT_Kho", typeof(string));
            table.Columns.Add("MaKho", typeof(string));
            table.Columns.Add("MaSP", typeof(string));
            table.Columns.Add("SoLuong", typeof(int));
            table.Columns.Add("TenKho", typeof(string));
            table.Columns.Add("DiaChi", typeof(string));
            table.Columns.Add("TenSP", typeof(string));
            while (dra.Read())
            {
                table.Rows.Add(dra["MaCT_Kho"].ToString(), dra["MaKho"].ToString(), dra["MaSP"].ToString(), dra["SoLuong"], dra["TenKho"].ToString(), dra["DiaChi"].ToString(), dra["TenSP"].ToString());
            }
            dra.Dispose();
            return table;
        }

        public DataTable GetProductName()
        {
            SqlDataReader dra = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.StoredProcedure, "sp_laytensp", null);
            DataTable table = new DataTable();
            table.Columns.Add("TenSP", typeof(string));
            while (dra.Read())
            {
                table.Rows.Add(dra["TenSP"].ToString());
            }
            dra.Dispose();
            return table;
        }

        public DataTable GetWHDetail(string MaKho)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_MAKHO,SqlDbType.Char,10)
            };
            parm[0].Value = MaKho;
            SqlDataReader dra = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.StoredProcedure, "sp_laysdsctkhotheomakho", parm);
            DataTable table = new DataTable();
            table.Columns.Add("MaKho", typeof(string));
            table.Columns.Add("TenKHo", typeof(string));
            table.Columns.Add("DiaChi", typeof(string));
            table.Columns.Add("MaCT_Kho", typeof(string));
            table.Columns.Add("TenSP", typeof(string));
            table.Columns.Add("SoLuong", typeof(int));
            while (dra.Read())
            {
                table.Rows.Add(int.Parse(dra["MaKho"].ToString()), dra["TenKHo"].ToString(), dra["DiaChi"].ToString(), dra["MaCT_Kho"].ToString(), dra["TenSP"].ToString(), dra["SoLuong"].ToString());
            }
            dra.Dispose();
            return table;
        }

        public int CheckMaCTKho(string MaCTKho)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_MACTKHO,SqlDbType.Char,10),
               };
            parm[0].Value = MaCTKho;
            return (int)SqlHelper.ExecuteScalar(SqlHelper.ConnectionString, CommandType.StoredProcedure, "sp_checkmactkho", parm);
        }

        public IList<DTO_CTKho> Search(string Word)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
            new SqlParameter("@word", SqlDbType.NVarChar, 100)
            };
            parm[0].Value = Word;

            SqlDataReader dataReader = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.StoredProcedure, "sp_timctkho", parm);

            IList<DTO_CTKho> list = new List<DTO_CTKho>();

            while (dataReader.Read())
            {
                DTO_CTKho dtokho = new DTO_CTKho();
                dtokho.MACT_KHO = dataReader["MaCT_Kho"].ToString();
                dtokho.MAKHO = dataReader["MaKho"].ToString();
                dtokho.TENSP = dataReader["TenSP"].ToString();
                dtokho.SOLUONG = int.Parse(dataReader["SoLuong"].ToString());

                list.Add(dtokho);
            }

            dataReader.Dispose();
            return list;
        }
    }
}
