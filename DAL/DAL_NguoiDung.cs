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
    public class DAL_NguoiDung:IDAL_NguoiDung
    {

        private const string PARM_MAND = "@mand";
        private const string PARM_TENND = "@tennd";
        private const string PARM_SODT = "@sdt";
        private const string PARM_EMAIL = "@email";
        private const string PARM_TAIKHOAN = "@tk";
        private const string PARM_MATKHAU = "@mk";
        private const string PARM_TRANGTHAI = "@tt";       

        public bool Login(string taikhoan, string matkhau)
        {
            SqlParameter[] parm = new SqlParameter[]
           {
                new SqlParameter(PARM_TAIKHOAN,SqlDbType.Char,30),
                new SqlParameter(PARM_MATKHAU,SqlDbType.Char,30)
           };
            parm[0].Value = taikhoan;
            parm[1].Value = matkhau;

            int count = (int)SqlHelper.ExecuteScalar(SqlHelper.ConnectionString, CommandType.StoredProcedure, "sp_login", parm);
            return count > 0;
        }

        public int Insert(string MaND, string TenND, string SoDT, string Email, string TaiKhoan, string MatKhau, string TrangThai)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_MAND,SqlDbType.Char,10),
                new SqlParameter(PARM_TENND,SqlDbType.NVarChar,50),
                new SqlParameter(PARM_SODT,SqlDbType.Char,10),
                new SqlParameter(PARM_EMAIL,SqlDbType.Char,50),
                new SqlParameter(PARM_TAIKHOAN,SqlDbType.Char,30),
                new SqlParameter(PARM_MATKHAU,SqlDbType.Char,30),
                new SqlParameter(PARM_TRANGTHAI,SqlDbType.NVarChar,30),
            };
            parm[0].Value = MaND;
            parm[1].Value = TenND;
            parm[2].Value = SoDT;
            parm[3].Value = Email;
            parm[4].Value = TaiKhoan;
            parm[5].Value = MatKhau;
            parm[6].Value = TrangThai;
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "sp_themnguoidung", parm);
        }

        public int Delete(string MaND)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_MAND,SqlDbType.Char,10)
            };
            parm[0].Value = MaND;

            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "sp_xoanguoidung", parm);
        }

        public int Update(string MaND, string TenND, string SoDT, string Email, string TaiKhoan, string MatKhau, string TrangThai)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_MAND,SqlDbType.Char,10),
                new SqlParameter(PARM_TENND,SqlDbType.NVarChar,50),
                new SqlParameter(PARM_SODT,SqlDbType.Char,10),
                new SqlParameter(PARM_EMAIL,SqlDbType.Char,50),
                new SqlParameter(PARM_TAIKHOAN,SqlDbType.Char,30),
                new SqlParameter(PARM_MATKHAU,SqlDbType.Char,30),
                new SqlParameter(PARM_TRANGTHAI,SqlDbType.NVarChar,30)
            };
            parm[0].Value = MaND;
            parm[1].Value = TenND;
            parm[2].Value = SoDT;
            parm[3].Value = Email;
            parm[4].Value = TaiKhoan;
            parm[5].Value = MatKhau;
            parm[6].Value = TrangThai;
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "sp_capnhatnguoidung", parm);
        }

        public DataTable GetList()
        {
            SqlDataReader dra = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.StoredProcedure, "sp_laydsuser", null);
            DataTable table = new DataTable();
            table.Columns.Add("MaND", typeof(string));
            table.Columns.Add("TenND", typeof(string));
            table.Columns.Add("SoDT", typeof(string));
            table.Columns.Add("Email", typeof(string));
            table.Columns.Add("TaiKhoan", typeof(string));
            table.Columns.Add("MatKhau", typeof(string));
            table.Columns.Add("TrangThai", typeof(string));
            while (dra.Read())
            {
                table.Rows.Add(dra["MaND"].ToString(), dra["TenND"].ToString(), dra["SoDT"].ToString(), dra["Email"].ToString(), dra["TaiKhoan"].ToString(), dra["MatKhau"].ToString(), dra["TrangThai"].ToString());
            }
            dra.Dispose();
            return table;
        }

        public int CheckMaND(string MaND)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_MAND,SqlDbType.Char,10)
            };
            parm[0].Value = MaND;
            return (int)SqlHelper.ExecuteScalar(SqlHelper.ConnectionString, CommandType.StoredProcedure, "sp_checkmand", parm);
        }

        public int CheckTaiKhoan(string TaiKhoan)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_TAIKHOAN,SqlDbType.Char,30)
            };
            parm[0].Value = TaiKhoan;
            return (int)SqlHelper.ExecuteScalar(SqlHelper.ConnectionString, CommandType.StoredProcedure, "sp_checkusername", parm);
        }

        public string GetQuyen(string TaiKhoan, string MatKhau)
        {
            string quyen = "";
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_TAIKHOAN,SqlDbType.Char,30),
                new SqlParameter(PARM_MATKHAU,SqlDbType.Char,30)
            };
            parm[0].Value = TaiKhoan;
            parm[1].Value = MatKhau;
            SqlDataReader dr = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.StoredProcedure, "sp_layquyen", parm);
            if (dr.Read())
            {
                quyen = dr[0].ToString();
            }
            dr.Close();
            return quyen;
        }

        public string GetName(string TaiKhoan, string MatKhau)
        {
            string ten = "";
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_TAIKHOAN,SqlDbType.Char,30),
                new SqlParameter(PARM_MATKHAU,SqlDbType.Char,30)
            };
            parm[0].Value = TaiKhoan;
            parm[1].Value = MatKhau;
            SqlDataReader dr = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.StoredProcedure, "sp_layten", parm);
            if (dr.Read())
            {
                ten = dr[0].ToString();
            }
            dr.Close();
            return ten;
        }

        public IList<DTO_NguoiDung> Search(string Word)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
            new SqlParameter("@word", SqlDbType.NVarChar, 100)
            };
            parm[0].Value = Word;

            SqlDataReader dataReader = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.StoredProcedure, "sp_timnd", parm);

            IList<DTO_NguoiDung> list = new List<DTO_NguoiDung>();

            while (dataReader.Read())
            {
                DTO_NguoiDung dtond = new DTO_NguoiDung();
                dtond.MAND = dataReader["MAND"].ToString();
                dtond.TENND = dataReader["TENND"].ToString();
                dtond.SODT = dataReader["SODT"].ToString();
                dtond.EMAIL = dataReader["EMAIL"].ToString();
                dtond.TAIKHOAN = dataReader["TAIKHOAN"].ToString();
                dtond.MATKHAU = dataReader["MATKHAU"].ToString();
                dtond.TRANGTHAI = dataReader["TRANGTHAI"].ToString();
                list.Add(dtond);
            }

            dataReader.Dispose();
            return list;
        }
    }
}
