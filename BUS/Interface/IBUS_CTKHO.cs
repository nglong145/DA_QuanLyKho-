using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BUS
{
    public interface IBUS_CTKHO
    {
        int Insert(DTO_CTKho dtoct);
        int Delete(string MaCTKho);
        int Update(DTO_CTKho dtoct);
        int CheckMaCTKho(string MaCTKho);
        IList<DTO_CTKho> GetList();

        IList<DTO_CTKho> GetProductName();

        IList<DTO_CTKho> Search(string Word);

        DTO_CTKho GetWHDetail(string MaKho);
        void KetXuatWord(string MaKho, string templatePath, string exportPath);
    }
}
