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
    public class DAL_SANPHAM:IDAL_SANPHAM
    {
        private const string PARM_MASP = "@masp";
        private const string PARM_TENSP = "@tensp";
        private const string PARM_TENDVT = "@tendvt";
        private const string PARM_TENDM  = "@tendm";
        private const string PARM_TSDT = "@tsdt";
        private const string PARM_NHASX = "@nhasx";

        public int Insert(string MaSP, string TenSP, string TenDVT, string TenDM, string TSDT, string NhaSX)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_MASP,SqlDbType.Char,10),
                new SqlParameter(PARM_TENSP,SqlDbType.NVarChar,50),
                new SqlParameter(PARM_TENDVT,SqlDbType.NVarChar,30),
                new SqlParameter(PARM_TENDM,SqlDbType.NVarChar,30),
                new SqlParameter(PARM_TSDT,SqlDbType.NVarChar,int.MaxValue),
                new SqlParameter(PARM_NHASX,SqlDbType.NVarChar,50),
            };
            parm[0].Value = MaSP;
            parm[1].Value = TenSP;
            parm[2].Value = TenDVT;
            parm[3].Value = TenDM;
            parm[4].Value = TSDT;
            parm[5].Value = NhaSX;
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "sp_themsp", parm);
        }

        public int Delete(string MaSP)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_MASP,SqlDbType.Char,10)
            };
            parm[0].Value = MaSP;

            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "sp_xoasp", parm);
        }

        public int Update(string MaSP, string TenSP, string TenDVT, string TenDM, string TSDT, string NhaSX)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_MASP,SqlDbType.Char,10),
                new SqlParameter(PARM_TENSP,SqlDbType.NVarChar,50),
                new SqlParameter(PARM_TENDVT,SqlDbType.NVarChar,30),
                new SqlParameter(PARM_TENDM,SqlDbType.NVarChar,30),
                new SqlParameter(PARM_TSDT,SqlDbType.NVarChar,int.MaxValue),
                new SqlParameter(PARM_NHASX,SqlDbType.NVarChar,50),
            };
            parm[0].Value = MaSP;
            parm[1].Value = TenSP;
            parm[2].Value = TenDVT;
            parm[3].Value = TenDM;
            parm[4].Value = TSDT;
            parm[5].Value = NhaSX;
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "sp_suasp", parm);
        }

        public DataTable GetList()
        {
            SqlDataReader dra = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.StoredProcedure, "sp_laydssp", null);
            DataTable table = new DataTable();
            table.Columns.Add("MaSP", typeof(string));
            table.Columns.Add("TenSP", typeof(string));
            table.Columns.Add("TenDVT", typeof(string));
            table.Columns.Add("TenDM", typeof(string));
            table.Columns.Add("ThongSoDacTa", typeof(string));
            table.Columns.Add("NhaSX", typeof(string));
            while (dra.Read())
            {
                table.Rows.Add(dra["MaSP"].ToString(), dra["TenSP"].ToString(), dra["TenDVT"].ToString(), dra["TenDM"].ToString(), dra["ThongSoDacTa"].ToString(), dra["NhaSX"].ToString());
            }
            dra.Dispose();
            return table;
        }

        public DataTable GetUnit()
        {
            SqlDataReader dra = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.StoredProcedure, "sp_laytendvt", null);
            DataTable table = new DataTable();
            table.Columns.Add("TenDVT", typeof(string));
            while (dra.Read())
            {
                table.Rows.Add(dra["TenDVT"].ToString());
            }
            dra.Dispose();
            return table;
        }

        public DataTable GetCategory()
        {
            SqlDataReader dra = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.StoredProcedure, "sp_laytendm", null);
            DataTable table = new DataTable();
            table.Columns.Add("TenDM", typeof(string));
            while (dra.Read())
            {
                table.Rows.Add(dra["TenDM"].ToString());
            }
            dra.Dispose();
            return table;
        }

        public int CheckMaSP(string MaSP)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_MASP,SqlDbType.Char,10)
            };
            parm[0].Value = MaSP;
            return (int)SqlHelper.ExecuteScalar(SqlHelper.ConnectionString, CommandType.StoredProcedure, "sp_checkmasp", parm);
        }

        public IList<DTO_SanPham> Search(string Word)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
            new SqlParameter("@word", SqlDbType.NVarChar, 100)
            };
            parm[0].Value = Word;

            SqlDataReader dataReader = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.StoredProcedure, "sp_timkiemsp", parm);

            IList<DTO_SanPham> list = new List<DTO_SanPham>();

            while (dataReader.Read())
            {
                DTO_SanPham dtosp = new DTO_SanPham();
                dtosp.MASP = dataReader["MaSP"].ToString();
                dtosp.TENSP = dataReader["TenSP"].ToString();
                dtosp.TENDVT = dataReader["TenDVT"].ToString();
                dtosp.TENDM = dataReader["TenDM"].ToString();
                dtosp.THONGSODACTA = dataReader["ThongSoDacTa"].ToString();
                dtosp.NHASX = dataReader["NhaSX"].ToString();

                list.Add(dtosp);
            }

            dataReader.Dispose();
            return list;
        }
    }
}
