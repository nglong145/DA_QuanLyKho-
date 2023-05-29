using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace BUS.Interface
{
    public interface IBUS_KhachHang
    {
        int Insert(DTO_KhachHang dtokh);
        int Delete(string MaKH);
        int Update(DTO_KhachHang dtokh);
        IList<DTO_KhachHang> GetList();
        IList<DTO_KhachHang> Search(string Word);
        int CheckMaKH(string MaKH);

    }
}
