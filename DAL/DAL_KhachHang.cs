using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Security.Cryptography;
using DAL.Interface;

namespace DAL
{
    public class DAL_KhachHang:IDAL_KhachHang
    {
        private const string PARM_MAKH = "@makh";
        private const string PARM_TENKH = "@tenkh";
        private const string PARM_DIACHI = "@diachi";
        private const string PARM_SODT = "@sdt";

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
        /// <summary>
        /// Hàm xóa lớp được chỉ định bởi mã lớp
        /// </summary>
        /// <param name="classID">Mã lớp</param>

        public int Delete(string MaKH)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_MAKH,SqlDbType.Char,10)
            };
            parm[0].Value = MaKH;

            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "sp_xoakhachhang", parm);
        }
        ///// <summary>
        ///// Hàm cập nhật thông tin lớp học với các thông tin tên lớp, mã lớp,... chỉ định dùng để thay thế
        ///// </summary>
        ///// <param name="classID">Mã lớp</param>
        ///// <param name="className">Tên lớp</param>
        ///// <param name="monitorName">Lớp trưởng</param>
        ///// <param name="teacherName">Giáo viên chủ nhiệm</param>   
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
        ///// <summary>
        ///// Hàm lấy về toàn bộ các lớp có trong CSDL
        ///// </summary> 
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
        ///// <summary>
        ///// Hàm lấy về thông tin một lớp học cụ thể
        ///// </summary> 
        //public DataTable getClass_ID(int classID)
        //{
        //    SqlParameter[] parm = new SqlParameter[]
        //    {
        //        new SqlParameter(PARM_CLASSID,SqlDbType.Int)
        //    };
        //    parm[0].Value = classID;
        //    SqlDataReader dra = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.StoredProcedure, "tbl_Classes_Sel_ID", parm);
        //    DataTable table = new DataTable();
        //    table.Columns.Add("classID", typeof(int));
        //    table.Columns.Add("className", typeof(string));
        //    table.Columns.Add("monitorName", typeof(string));
        //    table.Columns.Add("teacherName", typeof(string));
        //    while (dra.Read())
        //    {
        //        table.Rows.Add(int.Parse(dra["classID"].ToString()), dra["className"].ToString(), dra["monitorName"].ToString(), dra["teacherName"].ToString());
        //    }
        //    dra.Dispose();
        //    return table;
        //}
        //public int getclassID_Last()
        //{
        //    return (int)SqlHelper.ExecuteScalar(SqlHelper.ConnectionString, CommandType.Text, "select top 1 ClassID from tbl_Classes order by ClassID desc", null);
        //}
        public int CheckMaKH(string MaKH)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_MAKH,SqlDbType.Char,10)
            };
            parm[0].Value = MaKH;
            return (int)SqlHelper.ExecuteScalar(SqlHelper.ConnectionString, CommandType.StoredProcedure, "sp_checkmakh", parm);
        }
    }
}
