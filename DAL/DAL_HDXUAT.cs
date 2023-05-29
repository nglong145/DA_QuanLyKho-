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
    public class DAL_HDXUAT:IDAL_HDXUAT
    {
        private const string PARM_MAHDXUAT = "@mahdx";
        private const string PARM_TENKH = "@tenkh";
        private const string PARM_TENND = "@tennd";
        private const string PARM_NGAYBAN = "@ngay";
        private const string PARM_SOHOADON = "@shd";

        public DataTable GetList()
        {
            SqlDataReader dra = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.StoredProcedure, "sp_laydshdx", null);
            DataTable table = new DataTable();
            table.Columns.Add("MaHDXuat", typeof(string));
            table.Columns.Add("TenKH", typeof(string));
            table.Columns.Add("TenND", typeof(string));
            table.Columns.Add("NgayBan", typeof(DateTime));
            table.Columns.Add("SoHoaDon", typeof(string));
            while (dra.Read())
            {
                table.Rows.Add(dra["MaHDXuat"].ToString(), dra["TenKH"].ToString(), dra["TenND"].ToString(), DateTime.Parse(dra["NgayBan"].ToString()), dra["SoHoaDon"].ToString());
            }
            dra.Dispose();
            return table;
        }

        public DataTable GetName()
        {
            SqlDataReader dra = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.StoredProcedure, "sp_laytenkh", null);
            DataTable table = new DataTable();
            table.Columns.Add("TenKH", typeof(string));
            while (dra.Read())
            {
                table.Rows.Add(dra["TenKH"].ToString());
            }
            dra.Dispose();
            return table;
        }

        public int CheckMahdxuat(string MaHDXuat)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_MAHDXUAT,SqlDbType.Char,10)
            };
            parm[0].Value = MaHDXuat;
            return (int)SqlHelper.ExecuteScalar(SqlHelper.ConnectionString, CommandType.StoredProcedure, "sp_checkmahdx", parm);
        }

        public int Insert(string MaHDXuat, string TenKH, string TenND, DateTime NgayBan, string SoHoaDon)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_MAHDXUAT,SqlDbType.Char,10),
                new SqlParameter(PARM_TENKH,SqlDbType.NVarChar,30),
                new SqlParameter(PARM_TENND,SqlDbType.NVarChar,50),
                new SqlParameter(PARM_NGAYBAN,SqlDbType.Date),
                new SqlParameter(PARM_SOHOADON,SqlDbType.Char,10),
            };
            parm[0].Value = MaHDXuat;
            parm[1].Value = TenKH;
            parm[2].Value = TenND;
            parm[3].Value = NgayBan;
            parm[4].Value = SoHoaDon;
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "sp_themhdx", parm);
        }

        public int Update(string MaHDXuat, string TenKH, string TenND, DateTime NgayBan, string SoHoaDon)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_MAHDXUAT,SqlDbType.Char,10),
                new SqlParameter(PARM_TENKH,SqlDbType.NVarChar,30),
                new SqlParameter(PARM_TENND,SqlDbType.NVarChar,50),
                new SqlParameter(PARM_NGAYBAN,SqlDbType.Date),
                new SqlParameter(PARM_SOHOADON,SqlDbType.Char,10),
            };
            parm[0].Value = MaHDXuat;
            parm[1].Value = TenKH;
            parm[2].Value = TenND;
            parm[3].Value = NgayBan;
            parm[4].Value = SoHoaDon;
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "sp_suahdx", parm);
        }

        public int Delete(string MaHDXuat)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_MAHDXUAT,SqlDbType.Char,10)
            };
            parm[0].Value = MaHDXuat;

            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "sp_xoahdx", parm);
        }

        public DataTable GetList(string MaHDXuat)
        {

            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_MAHDXUAT,SqlDbType.Char,10)
            };
            parm[0].Value = MaHDXuat;
            SqlDataReader dra = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.StoredProcedure, "sp_laydshdxBymahdx", parm);
            DataTable table = new DataTable();
            table.Columns.Add("mahdxuat", typeof(string));
            table.Columns.Add("tenkh", typeof(string));
            table.Columns.Add("tennd", typeof(string));
            table.Columns.Add("ngayban", typeof(DateTime));
            table.Columns.Add("sohoadon", typeof(string));
            table.Columns.Add("total", typeof(int));
            while (dra.Read())
            {
                table.Rows.Add(dra["mahdxuat"].ToString(), dra["tenkh"].ToString(), dra["tennd"].ToString(), dra["ngayban"].ToString(), dra["sohoadon"].ToString(), dra["total"].ToString());
            }
            dra.Dispose();
            return table;
        }

        public IList<DTO_HDXuat> Search(string Word)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
            new SqlParameter("@word", SqlDbType.NVarChar, 100)
            };
            parm[0].Value = Word;

            SqlDataReader dataReader = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.StoredProcedure, "sp_timkiemhdx", parm);

            IList<DTO_HDXuat> list = new List<DTO_HDXuat>();

            while (dataReader.Read())
            {
                DTO_HDXuat dtohdx = new DTO_HDXuat();
                dtohdx.MAHDXUAT = dataReader["MaHDXuat"].ToString();
                dtohdx.TENKH = dataReader["TenKH"].ToString();
                dtohdx.TENND = dataReader["TenND"].ToString();
                dtohdx.NGAYBAN = DateTime.Parse(dataReader["NgayBan"].ToString());
                dtohdx.SOHOADON = dataReader["SoHoaDon"].ToString();
                list.Add(dtohdx);
            }

            dataReader.Dispose();
            return list;
        }
    }
}
