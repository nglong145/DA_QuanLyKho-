using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Security.Cryptography;

namespace DAL
{
    public class DAL_DonViTinh:IDAL_DonViTinh
    {
        private const string PARM_MADVT = "@madvt";
        private const string PARM_TENDVT = "@tendvt";

        public int Insert(int MaDVT, string TenDVT)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_MADVT,SqlDbType.Int),
                new SqlParameter(PARM_TENDVT,SqlDbType.NVarChar,30),
            };
            parm[0].Value = MaDVT;
            parm[1].Value = TenDVT;
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "sp_themdvtinh", parm);
        }

        public int Delete(int MaDVT)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_MADVT,SqlDbType.Int)
            };
            parm[0].Value = MaDVT;

            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "sp_xoadvtinh", parm);
        }

        public int Update(int MaDVT, string TenDVT)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_MADVT,SqlDbType.Int),
                new SqlParameter(PARM_TENDVT,SqlDbType.NVarChar,30),
            };
            parm[0].Value = MaDVT;
            parm[1].Value = TenDVT;
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "sp_capnhatdvtinh", parm);
        }

        public DataTable GetList()
        {
            SqlDataReader dra = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.StoredProcedure, "sp_laydsdonvitinh", null);
            DataTable table = new DataTable();
            table.Columns.Add("MaDVT", typeof(int));
            table.Columns.Add("TenDVT", typeof(string));
            while (dra.Read())
            {
                table.Rows.Add(dra["MaDVT"].ToString(), dra["TenDVT"].ToString());
            }
            dra.Dispose();
            return table;
        }

        public int CheckMaDVT(int MaDVT)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_MADVT,SqlDbType.Int)
            };
            parm[0].Value = MaDVT;
            return (int)SqlHelper.ExecuteScalar(SqlHelper.ConnectionString, CommandType.StoredProcedure, "sp_checkmadvt", parm);
        }
    }
}
