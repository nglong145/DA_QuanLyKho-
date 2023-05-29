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
    public class DAL_KHOHANG:IDAL_KHOHANG
    {
        private const string PARM_MAKHO = "@makho";
        private const string PARM_TENKHO = "@tenkho";
        private const string PARM_DIACHI = "@diachi";

        public int Insert(string MaKho, string TenKho, string DiaChi)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_MAKHO,SqlDbType.Char,10),
                new SqlParameter(PARM_TENKHO,SqlDbType.NVarChar,50),
                new SqlParameter(PARM_DIACHI,SqlDbType.NVarChar,100),
            };
            parm[0].Value = MaKho;
            parm[1].Value = TenKho;
            parm[2].Value = DiaChi;

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

        public int Update(string MaKho, string TenKho, string DiaChi)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_MAKHO,SqlDbType.Char,10),
                new SqlParameter(PARM_TENKHO,SqlDbType.NVarChar,50),
                new SqlParameter(PARM_DIACHI,SqlDbType.NVarChar,100),
            };
            parm[0].Value = MaKho;
            parm[1].Value = TenKho;
            parm[2].Value = DiaChi;
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "sp_suakho", parm);
        }

        public DataTable GetList()
        {
            SqlDataReader dra = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.StoredProcedure, "sp_laydanhsachkho", null);
            DataTable table = new DataTable();
            table.Columns.Add("MaKho", typeof(string));
            table.Columns.Add("TenKho", typeof(string));
            table.Columns.Add("DiaChi", typeof(string));
            while (dra.Read())
            {
                table.Rows.Add(dra["MaKho"].ToString(), dra["TenKho"].ToString(), dra["DiaChi"].ToString());
            }
            dra.Dispose();
            return table;
        }

        public int CheckMaKho(string MaKho)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_MAKHO,SqlDbType.Char,10)
            };
            parm[0].Value = MaKho;
            return (int)SqlHelper.ExecuteScalar(SqlHelper.ConnectionString, CommandType.StoredProcedure, "sp_checkmakho", parm);
        }

        public IList<DTO_Kho> Search(string Word)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
            new SqlParameter("@word", SqlDbType.NVarChar, 100)
            };
            parm[0].Value = Word;

            SqlDataReader dataReader = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.StoredProcedure, "sp_timkho", parm);

            IList<DTO_Kho> list = new List<DTO_Kho>();

            while (dataReader.Read())
            {
                DTO_Kho dtokho = new DTO_Kho();
                dtokho.MAKHO = dataReader["MaKho"].ToString();
                dtokho.TENKHO = dataReader["TenKho"].ToString();
                dtokho.DIACHI = dataReader["DiaChi"].ToString();

                list.Add(dtokho);
            }

            dataReader.Dispose();
            return list;
        }

    }
}
