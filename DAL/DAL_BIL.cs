using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Security.Cryptography;
namespace DAL
{
    public class DAL_BIL:IDAL_BILL
    {
        public DataTable GetList(string MaHDXuat)
        {
            SqlParameter[] parameters = new SqlParameter[]
             {
                new SqlParameter("@mahdx", MaHDXuat)
             };

            using (SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.StoredProcedure, "sp_hoadonban", parameters))
            {
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                return dataTable;
            }
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
    }
}
