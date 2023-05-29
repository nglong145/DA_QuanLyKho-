using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DTO;

namespace DAL
{
    public interface IDAL_KHOHANG
    {
        DataTable GetList();
        int Insert(string MaKho, string TenKho, string DiaChi);
        int Delete(string MaKho);
        int Update(string MaKho, string TenKho, string DiaChi);
        int CheckMaKho(string MaKho);

        IList<DTO_Kho> Search(string Word);
    }
}
