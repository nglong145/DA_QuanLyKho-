using DTO;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_NHACC : IDAL_NHACC
    {
        private const string PARM_MANHACC = "@mancc";
        private const string PARM_TENNHACC = "@tenncc";
        private const string PARM_MASOTHUE = "@mst";
        private const string PARM_DIACHI = "@diachi";
        private const string PARM_SODT = "@sdt";
        private const string PARM_EMAIL = "@email";
        public int Insert(string MaNhaCC, string TenNhaCC, string MaSoThue, string DiaChi, string SDT, string Email)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_MANHACC,SqlDbType.Char,10),
                new SqlParameter(PARM_TENNHACC,SqlDbType.NVarChar,70),
                new SqlParameter(PARM_MASOTHUE,SqlDbType.Char,10),
                new SqlParameter(PARM_DIACHI,SqlDbType.NVarChar,50),
                new SqlParameter(PARM_SODT,SqlDbType.Char,10),
                new SqlParameter(PARM_EMAIL,SqlDbType.VarChar,30),
            };
            parm[0].Value = MaNhaCC;
            parm[1].Value = TenNhaCC;
            parm[2].Value = MaSoThue;
            parm[3].Value = DiaChi;
            parm[4].Value = SDT;
            parm[5].Value = Email;
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "sp_themnhacc", parm);
        }

        public int Delete(string MaNhaCC)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_MANHACC,SqlDbType.Char,10)
            };
            parm[0].Value = MaNhaCC;

            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "sp_xoanhacc", parm);
        }

        public int Update(string MaNhaCC, string TenNhaCC, string MaSoThue, string DiaChi, string SDT, string Email)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_MANHACC,SqlDbType.Char,10),
                new SqlParameter(PARM_TENNHACC,SqlDbType.NVarChar,70),
                new SqlParameter(PARM_MASOTHUE,SqlDbType.Char,10),
                new SqlParameter(PARM_DIACHI,SqlDbType.NVarChar,50),
                new SqlParameter(PARM_SODT,SqlDbType.Char,10),
                new SqlParameter(PARM_EMAIL,SqlDbType.VarChar,30)
            };
            parm[0].Value = MaNhaCC;
            parm[1].Value = TenNhaCC;
            parm[2].Value = MaSoThue;
            parm[3].Value = DiaChi;
            parm[4].Value = SDT;
            parm[5].Value = Email;
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "sp_capnhatnhacc", parm);
        }

        public DataTable GetList()
        {
            SqlDataReader dra = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.StoredProcedure, "sp_laydsnhacc", null);
            DataTable table = new DataTable();
            table.Columns.Add("MaNhaCC", typeof(string));
            table.Columns.Add("TenNhaCC", typeof(string));
            table.Columns.Add("MaSoThue", typeof(string));
            table.Columns.Add("DiaChi", typeof(string));
            table.Columns.Add("SoDT", typeof(string));
            table.Columns.Add("Email", typeof(string));
            while (dra.Read())
            {
                table.Rows.Add(dra["MaNhaCC"].ToString(), dra["TenNhaCC"].ToString(), dra["MaSoThue"].ToString(), dra["DiaChi"].ToString(), dra["SoDT"].ToString(), dra["Email"].ToString());
            }
            dra.Dispose();
            return table;
        }

        public int CheckMaNhaCC(string MaNhaCC)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_MANHACC,SqlDbType.Char,10)
            };
            parm[0].Value = MaNhaCC;
            return (int)SqlHelper.ExecuteScalar(SqlHelper.ConnectionString, CommandType.StoredProcedure, "sp_checkmancc", parm);
        }

        public IList<DTO_NhaCungCap> Search(string Word)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
            new SqlParameter("@word", SqlDbType.NVarChar, 100)
            };
            parm[0].Value = Word;

            SqlDataReader dataReader = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.StoredProcedure, "sp_timncc", parm);

            IList<DTO_NhaCungCap> list = new List<DTO_NhaCungCap>();

            while (dataReader.Read())
            {
                DTO_NhaCungCap dtoncc = new DTO_NhaCungCap();
                dtoncc.MANHACC = dataReader["MaNHaCC"].ToString();
                dtoncc.TENNHACC = dataReader["TenNhaCC"].ToString();
                dtoncc.MASOTHUE = dataReader["MaSoTHue"].ToString();
                dtoncc.DIACHI = dataReader["DiaChi"].ToString();
                dtoncc.SODT = dataReader["SoDT"].ToString();
                dtoncc.EMAIL = dataReader["Email"].ToString();
                list.Add(dtoncc);
            }

            dataReader.Dispose();
            return list;
        }
    }
}
