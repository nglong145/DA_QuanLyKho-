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
    public class DAL_HDNhap:IDAL_HDNHAP
    {
        private const string PARM_MAHDNHAP = "@mahdn";
        private const string PARM_TENNCC = "@tenncc";
        private const string PARM_TENND = "@tennd";
        private const string PARM_NGAYNHAP = "@ngay";
        private const string PARM_SOHOADON = "@shd";

        public DataTable GetList()
        {
            SqlDataReader dra = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.StoredProcedure, "sp_laydshdnhap", null);
            DataTable table = new DataTable();
            table.Columns.Add("MaHDNhap", typeof(string));
            table.Columns.Add("TenNhaCC", typeof(string));
            table.Columns.Add("TenND", typeof(string));
            table.Columns.Add("NgayNhap", typeof(DateTime));
            table.Columns.Add("SoHoaDon", typeof(string));
            while (dra.Read())
            {
                table.Rows.Add(dra["MaHDNhap"].ToString(), dra["TenNhaCC"].ToString(), dra["TenND"].ToString(), dra["NgayNhap"].ToString(), dra["SoHoaDon"].ToString());
            }
            dra.Dispose();
            return table;
        }

        public DataTable GetSuplier()
        {
            SqlDataReader dra = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.StoredProcedure, "sp_laytennhacc", null);
            DataTable table = new DataTable();
            table.Columns.Add("TenNhaCC", typeof(string));
            while (dra.Read())
            {
                table.Rows.Add(dra["TenNhaCC"].ToString());
            }
            dra.Dispose();
            return table;
        }

        public int CheckMaHDNhap(string MaHDNhap)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_MAHDNHAP,SqlDbType.Char,10)
            };
            parm[0].Value = MaHDNhap;
            return (int)SqlHelper.ExecuteScalar(SqlHelper.ConnectionString, CommandType.StoredProcedure, "sp_checkmahdn", parm);
        }

        public int Insert(string MaHDNhap, string TenNCC, string TenND, DateTime NgayNhap, string SoHoaDon)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_MAHDNHAP,SqlDbType.Char,10),
                new SqlParameter(PARM_TENNCC,SqlDbType.NVarChar,70),
                new SqlParameter(PARM_TENND,SqlDbType.NVarChar,50),
                new SqlParameter(PARM_NGAYNHAP,SqlDbType.Date),
                new SqlParameter(PARM_SOHOADON,SqlDbType.Char,10)
            };
            parm[0].Value = MaHDNhap;
            parm[1].Value = TenNCC;
            parm[2].Value = TenND;
            parm[3].Value = NgayNhap;
            parm[4].Value = SoHoaDon;
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "sp_themhdnhap", parm);
        }

        public int Update(string MaHDNhap, string TenNCC, string TenND, DateTime NgayNhap, string SoHoaDon)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_MAHDNHAP,SqlDbType.Char,10),
                new SqlParameter(PARM_TENNCC,SqlDbType.NVarChar,70),
                new SqlParameter(PARM_TENND,SqlDbType.NVarChar,50),
                new SqlParameter(PARM_NGAYNHAP,SqlDbType.Date),
                new SqlParameter(PARM_SOHOADON,SqlDbType.Char,10)
            };
            parm[0].Value = MaHDNhap;
            parm[1].Value = TenNCC;
            parm[2].Value = TenND;
            parm[3].Value = NgayNhap;
            parm[4].Value = SoHoaDon;
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "sp_suahdnhap", parm);
        }

        public int Delete(string MaHDNhap)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_MAHDNHAP,SqlDbType.Char,10)
            };
            parm[0].Value = MaHDNhap;

            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "sp_xoahdnhap", parm);
        }

        public IList<DTO_HDNhap> Search(string Word)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
            new SqlParameter("@word", SqlDbType.NVarChar, 100)
            };
            parm[0].Value = Word;

            SqlDataReader dataReader = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.StoredProcedure, "sp_timkiemhdn", parm);

            IList<DTO_HDNhap> list = new List<DTO_HDNhap>();

            while (dataReader.Read())
            {
                DTO_HDNhap dtohdx = new DTO_HDNhap();
                dtohdx.MAHDNHAP = dataReader["MaHDNhap"].ToString();
                dtohdx.TENNHACC = dataReader["TenNhaCC"].ToString();
                dtohdx.TENND = dataReader["TenND"].ToString();
                dtohdx.NGAYNHAP = DateTime.Parse(dataReader["NgayNhap"].ToString());
                dtohdx.SOHOADON = dataReader["SoHoaDon"].ToString();
                list.Add(dtohdx);
            }

            dataReader.Dispose();
            return list;
        }
    }
}
