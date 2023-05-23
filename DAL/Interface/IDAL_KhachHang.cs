using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface
{
    public interface IDAL_KhachHang
    {
        int Insert(string MaKH, string TenKH, string DiaChi, string SDT);

        int Delete(string MaKH);
        int Update(string MaKH, string TenKH, string DiaChi, string SDT);
        DataTable GetList();
        //DataTable getClass_ID(int classID);
        //int getclassID_Last();
        int CheckMaKH(string MaKH);
    }
}
