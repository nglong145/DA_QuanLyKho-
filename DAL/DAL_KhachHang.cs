using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Security.Cryptography;
using DAL.Interface;
using DTO;

namespace DAL
{
    public class DAL_KhachHang:IDAL_KhachHang
    {
        private const string PARM_MAKH = "@makh";
        private const string PARM_TENKH = "@tenkh";
        private const string PARM_DIACHI = "@diachi";
        private const string PARM_SODT = "@sdt";
        private const string PARM_WORD = "@word";

        public int Insert(string MaKH, string TenKH, string DiaChi, string SDT)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_MAKH,SqlDbType.Char,10),
                new SqlParameter(PARM_TENKH,SqlDbType.NVarChar,30),
                new SqlParameter(PARM_DIACHI,SqlDbType.NVarChar,50),
                new SqlParameter(PARM_SODT,SqlDbType.Char,10),
            };
            parm[0].Value = MaKH;
            parm[1].Value = TenKH;
            parm[2].Value = DiaChi;
            parm[3].Value = SDT;
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "sp_themkhachhang", parm);
        }
        

        public int Delete(string MaKH)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_MAKH,SqlDbType.Char,10)
            };
            parm[0].Value = MaKH;

            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "sp_xoakhachhang", parm);
        }

        public int Update(string MaKH, string TenKH, string DiaChi, string SDT)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_MAKH,SqlDbType.Char,10),
                new SqlParameter(PARM_TENKH,SqlDbType.NVarChar,30),
                new SqlParameter(PARM_DIACHI,SqlDbType.NVarChar,50),
                new SqlParameter(PARM_SODT,SqlDbType.Char,10),
            };
            parm[0].Value = MaKH;
            parm[1].Value = TenKH;
            parm[2].Value = DiaChi;
            parm[3].Value = SDT;
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "sp_capnhatkhachhang", parm);
        }

        public DataTable GetList()
        {
            SqlDataReader dra = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.StoredProcedure, "sp_laydskhachhang", null);
            DataTable table = new DataTable();
            table.Columns.Add("MaKH", typeof(string));
            table.Columns.Add("TenKH", typeof(string));
            table.Columns.Add("DiaChi", typeof(string));
            table.Columns.Add("SoDT", typeof(string));
            while (dra.Read())
            {
                table.Rows.Add(dra["MaKH"].ToString(), dra["TenKH"].ToString(), dra["DiaChi"].ToString(), dra["SoDT"].ToString());
            }
            dra.Dispose();
            return table;
        }

        public int CheckMaKH(string MaKH)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_MAKH,SqlDbType.Char,10)
            };
            parm[0].Value = MaKH;
            return (int)SqlHelper.ExecuteScalar(SqlHelper.ConnectionString, CommandType.StoredProcedure, "sp_checkmakh", parm);
        }

        public IList<DTO_KhachHang> Search(string Word)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
            new SqlParameter("@word", SqlDbType.NVarChar, 100) 
            };
            parm[0].Value = Word;

            SqlDataReader dataReader = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.StoredProcedure, "sp_timkh", parm);

            IList<DTO_KhachHang> list = new List<DTO_KhachHang>();

            while (dataReader.Read())
            {
                DTO_KhachHang dtokh = new DTO_KhachHang();
                dtokh.MAKH = dataReader["MaKH"].ToString();
                dtokh.TENKH = dataReader["TenKH"].ToString();
                dtokh.DIACHI = dataReader["DiaChi"].ToString();
                dtokh.SODT = dataReader["SoDT"].ToString();

                list.Add(dtokh);
            }

            dataReader.Dispose();
            return list;
        }
    }
}
