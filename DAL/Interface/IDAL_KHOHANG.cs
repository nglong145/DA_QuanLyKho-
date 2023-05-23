using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DAL
{
    public interface IDAL_KHOHANG
    {
        DataTable GetList();
        int Insert(string MaKho, string TenKho, string DiaChi, string MaCTKho, string MaSP, int SoLuong);
        int Delete(string MaKho);
        int Update(string MaKho, string TenKho, string DiaChi, string MaCTKho, string MaSP, int SoLuong);
        //int CheckMaKHO(string MaKho);
        //int CheckMaCTKHO(string MaCTKho);
    }
}
