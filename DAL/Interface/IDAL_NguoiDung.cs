using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DTO;

namespace DAL
{
    public interface IDAL_NguoiDung
    {
        bool Login(string taikhoan, string matkhau);
        int Insert(string MaND, string TenND, string SoDT, string Email, string TaiKhoan, string MatKhau, string TrangThai);

        int Delete(string MaND);
        int Update(string MaND, string TenND, string SoDT, string Email, string TaiKhoan, string MatKhau, string TrangThai);
        DataTable GetList();

        IList<DTO_NguoiDung> Search(string Word);
        int CheckMaND(string MaND);
        int CheckTaiKhoan(string TaiKhoan);
        string GetQuyen(string TaiKhoan, string MatKHau);

        string GetName(string TaiKhoan, string MatKHau);
    }
}
