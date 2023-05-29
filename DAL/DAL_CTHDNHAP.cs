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
    public class DAL_CTHDNHAP:IDAL_CTHDNHAP
    {
        private const string PARM_MACTHDNHAP = "@macthdn";
        private const string PARM_MAHDNHAP = "@mahdn";
        private const string PARM_TENSP = "@tensp";
        private const string PARM_TENKHO = "@tenkho";
        private const string PARM_SLUONG = "@sl";
        private const string PARM_GIA = "@gia";

        public DataTable GetList()
        {
            SqlDataReader dra = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.StoredProcedure, "sp_laydsctnhap", null);
            DataTable table = new DataTable();
            table.Columns.Add("MaHDNhap", typeof(string));
            table.Columns.Add("MaCT_HDN", typeof(string));
            table.Columns.Add("TenKho", typeof(string));
            table.Columns.Add("TenSP", typeof(string));
            table.Columns.Add("TenDVT", typeof(string));
            table.Columns.Add("SLNhap", typeof(int));
            table.Columns.Add("GiaNhap", typeof(int));
            while (dra.Read())
            {
                table.Rows.Add(dra["MaHDNhap"].ToString(), dra["MaCT_HDN"].ToString(), dra["TenKho"].ToString(), dra["TenSP"].ToString(), dra["TenDVT"].ToString(), dra["SLNhap"], dra["GiaNhap"]);
            }
            dra.Dispose();
            return table;
        }

        public DataTable GetImportID()
        {
            SqlDataReader dra = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.StoredProcedure, "sp_laymahdnahp", null);
            DataTable table = new DataTable();
            table.Columns.Add("MaHDNhap", typeof(string));
            while (dra.Read())
            {
                table.Rows.Add(dra["MaHDNhap"].ToString());
            }
            dra.Dispose();
            return table;
        }

        public DataTable GetWareHouse()
        {
            SqlDataReader dra = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.StoredProcedure, "sp_laytenkho", null);
            DataTable table = new DataTable();
            table.Columns.Add("TenKho", typeof(string));
            while (dra.Read())
            {
                table.Rows.Add(dra["TenKho"].ToString());
            }
            dra.Dispose();
            return table;
        }

        public DataTable GetProduct()
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

        public int Insert(string MaCTHDNhap, string MaHDNhap, string TenSP, string TenKho, int SoLuong, int Gia)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_MACTHDNHAP,SqlDbType.Char,10),
                new SqlParameter(PARM_MAHDNHAP,SqlDbType.Char,10),
                new SqlParameter(PARM_TENSP,SqlDbType.NVarChar,50),
                new SqlParameter(PARM_TENKHO,SqlDbType.NVarChar,50),
                new SqlParameter(PARM_SLUONG,SqlDbType.Int),
                new SqlParameter(PARM_GIA,SqlDbType.Int)
            };
            parm[0].Value = MaCTHDNhap;
            parm[1].Value = MaHDNhap;
            parm[2].Value = TenSP;
            parm[3].Value = TenKho;
            parm[4].Value = SoLuong;
            parm[5].Value = Gia;
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "sp_themcthdn", parm);
        }

        public int CheckMaCTHDN(string MaCTHDNhap)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_MACTHDNHAP,SqlDbType.Char,10),
               };
            parm[0].Value = MaCTHDNhap;
            return (int)SqlHelper.ExecuteScalar(SqlHelper.ConnectionString, CommandType.StoredProcedure, "sp_checkmacthdn", parm);
        }

        public int Delete(string MaCTHDNhap)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_MACTHDNHAP,SqlDbType.Char,10)
            };
            parm[0].Value = MaCTHDNhap;

            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "sp_xoacthdn", parm);
        }


        public IList<DTO_CTHDNhap> Search(string Word)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
            new SqlParameter("@word", SqlDbType.NVarChar, 100)
            };
            parm[0].Value = Word;

            SqlDataReader dataReader = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.StoredProcedure, "sp_timkiemcthdn", parm);

            IList<DTO_CTHDNhap> list = new List<DTO_CTHDNhap>();

            while (dataReader.Read())
            {
                DTO_CTHDNhap dtoctn = new DTO_CTHDNhap();
                dtoctn.MACTHDNHAP = dataReader["MaCT_HDN"].ToString();
                dtoctn.MAHDNHAP = dataReader["MaHDNhap"].ToString();
                dtoctn.TENSP = dataReader["TenSP"].ToString();
                dtoctn.TENKHO = dataReader["TenKho"].ToString();
                dtoctn.TENDVT = dataReader["TenDVT"].ToString();
                dtoctn.SLNHAP = int.Parse(dataReader["SlNhap"].ToString());
                dtoctn.GIANHAP = int.Parse(dataReader["GiaNhap"].ToString());
                list.Add(dtoctn);
            }

            dataReader.Dispose();
            return list;
        }
    }
}
