using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BUS
{
    public interface IBUS_HDXUAT
    {
        IList<DTO_HDXuat> GetList();
        IList<DTO_HDXuat> GetName();
        int CheckMahdxuat(string MaHDXuat);
        int Insert(DTO_HDXuat dtohdx);

        int Update(DTO_HDXuat dtohdx);

        int Delete(string MaHDXuat);

        DTO_BILL GetList(string MaHDXuat);
        void KetXuatWord(string MaHDXuat, string templatePath, string exportPath);

        IList<DTO_HDXuat> Search(string Word);
    }
}
