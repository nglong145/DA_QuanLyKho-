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
    public class DAL_CTHDXUAT:IDAL_CTHDXUAT
    {
        private const string PARM_MACTHDXUAT = "@macthdx";
        private const string PARM_MAHDXUAT = "@mahdx";
        private const string PARM_TENSP = "@tensp";
        private const string PARM_TENKHO = "@tenkho";
        private const string PARM_TENDVT = "@tendvt";
        private const string PARM_SLUONG = "@sl";
        private const string PARM_GIA = "@gia";

        public DataTable GetList()
        {
            SqlDataReader dra = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.StoredProcedure, "sp_laydsctxuat", null);
            DataTable table = new DataTable();
            table.Columns.Add("MaHDXuat", typeof(string));
            table.Columns.Add("MaCT_HDX", typeof(string));
            table.Columns.Add("TenKho", typeof(string));
            table.Columns.Add("TenSP", typeof(string));
            table.Columns.Add("TenDVT", typeof(string));
            table.Columns.Add("SLBan", typeof(int));
            table.Columns.Add("GiaBan", typeof(int));
            while (dra.Read())
            {
                table.Rows.Add(dra["MaHDXuat"].ToString(), dra["MaCT_HDX"].ToString(), dra["TenKho"].ToString(), dra["TenSP"].ToString(), dra["TenDVT"].ToString(), dra["SLBan"], dra["GiaBan"]);
            }
            dra.Dispose();
            return table;
        }

        public DataTable GetExportID()
        {
            SqlDataReader dra = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.StoredProcedure, "sp_laymahdxuat", null);
            DataTable table = new DataTable();
            table.Columns.Add("MaHDXuat", typeof(string));
            while (dra.Read())
            {
                table.Rows.Add(dra["MaHDXuat"].ToString());
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
                table.Rows.Add( dra["TenDVT"].ToString());
            }
            dra.Dispose();
            return table;
        }


        public int Insert(string MaCTHDXuat, string MaHDXuat, string TenSP, string TenKho, int SoLuong, int Gia)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_MACTHDXUAT,SqlDbType.Char,10),
                new SqlParameter(PARM_MAHDXUAT,SqlDbType.Char,10),
                new SqlParameter(PARM_TENSP,SqlDbType.NVarChar,50),
                new SqlParameter(PARM_TENKHO,SqlDbType.NVarChar,50),
                new SqlParameter(PARM_SLUONG,SqlDbType.Int),
                new SqlParameter(PARM_GIA,SqlDbType.Int)
            };
            parm[0].Value = MaCTHDXuat;
            parm[1].Value = MaHDXuat;
            parm[2].Value = TenSP;
            parm[3].Value = TenKho;
            parm[4].Value = SoLuong;
            parm[5].Value = Gia;
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "sp_themcthdx", parm);
        }

        public int CheckMaCTHDX(string MaCTHDXuat)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_MACTHDXUAT,SqlDbType.Char,10),
               };
            parm[0].Value = MaCTHDXuat;
            return (int)SqlHelper.ExecuteScalar(SqlHelper.ConnectionString, CommandType.StoredProcedure, "sp_checkmacthdx", parm);
        }

        public DataTable GetList(string MaHDXuat)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_MAHDXUAT,SqlDbType.NVarChar,10)
            };
            parm[0].Value = MaHDXuat;
            SqlDataReader dra = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.StoredProcedure, "sp_laydsxthdxBymahdx", parm);
            DataTable table = new DataTable();
            table.Columns.Add("mahdxuat", typeof(string));
            table.Columns.Add("mact_hdx", typeof(string));
            table.Columns.Add("tenkho", typeof(string));
            table.Columns.Add("tensp", typeof(string));
            table.Columns.Add("tendvt", typeof(string));
            table.Columns.Add("slban", typeof(int));
            table.Columns.Add("giaban", typeof(int));
            while (dra.Read())
            {
                table.Rows.Add(
                    dra["mahdxuat"].ToString(),
                    dra["mact_hdx"].ToString(),
                    dra["tenkho"].ToString(),
                    dra["tensp"].ToString(),
                    dra["tendvt"].ToString(),
                    dra["slban"].ToString(),
                    dra["giaban"].ToString()
                    );
            }
            dra.Dispose();
            return table;
        }

        public int Delete(string MaCTHDXuat)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_MACTHDXUAT,SqlDbType.Char,10)
            };
            parm[0].Value = MaCTHDXuat;

            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "sp_xoacthdx", parm);
        }

        public IList<DTO_CTHDXuat> Search(string Word)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
            new SqlParameter("@word", SqlDbType.NVarChar, 100)
            };
            parm[0].Value = Word;

            SqlDataReader dataReader = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.StoredProcedure, "sp_timkiemcthdx", parm);

            IList<DTO_CTHDXuat> list = new List<DTO_CTHDXuat>();

            while (dataReader.Read())
            {
                DTO_CTHDXuat dtoctx = new DTO_CTHDXuat();
                dtoctx.MACTHDXUAT = dataReader["MaCT_HDX"].ToString();
                dtoctx.MAHDXUAT = dataReader["MaHDXuat"].ToString();
                dtoctx.TENSP = dataReader["TenSP"].ToString();
                dtoctx.TENKHO = dataReader["TenKho"].ToString();
                dtoctx.TENDVT = dataReader["TenDVT"].ToString();
                dtoctx.SLBAN = int.Parse(dataReader["SLBan"].ToString());
                dtoctx.GIABAN = int.Parse(dataReader["GiaBan"].ToString());
                list.Add(dtoctx);
            }

            dataReader.Dispose();
            return list;
        }
    }
}
