using DTO;
using DAL;
using Novacode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ExportDoc:DocxHelper
    {
        public static string CreteKhoTemplate(string filename, Dictionary<string, string> dictionaryData, IList<DTO_CTKho> data)
        {
            string res = "";
            try
            {
                using (DocX document = DocX.Load(filename))
                {
                    ReplaceTime(document, null);
                    ReplaceData(dictionaryData, null, document);
                    int cRow = 1;
                    if (data != null && data.Count > 0)
                    {
                        Novacode.Table myTable = FindTableWithText(document.Tables, fTempTableData, out int Row, out int cCell);
                        if (data.Count > 0)
                        {
                            for (int i = 0; i < data.Count; i++)
                            {
                                Novacode.Row newRow = myTable.InsertRow(myTable.Rows[cRow], cRow + i + 1);
                                newRow.Cells[0].Paragraphs.First().Append((i + 1).ToString()).ReplaceText(fTempTableData, "");
                                newRow.Cells[1].Paragraphs.First().Append(data[i].MAKHO);
                                newRow.Cells[2].Paragraphs.First().Append(data[i].TENKHO);
                                newRow.Cells[3].Paragraphs.First().Append(data[i].DIACHI);
                                newRow.Cells[4].Paragraphs.First().Append(data[i].MACT_KHO);
                                newRow.Cells[5].Paragraphs.First().Append(data[i].TENSP);
                                newRow.Cells[6].Paragraphs.First().Append(data[i].SOLUONG.ToString());
                            }
                            cRow += 1;
                        }
                        myTable.RemoveRow(1);
                    }
                    document.ReplaceText(fTempTableData, "");
                    document.Save();
                    document.Dispose();
                }
            }
            catch (Exception ex)
            {
                res = ex.Message;
            }
            return res;
        }

        public static string CreateHDTemplate(string filename, Dictionary<string, string> dictionaryData, IList<DTO_CTHDXuat> data)
        {
            string res = "";
            try
            {
                using (DocX document = DocX.Load(filename))
                {
                    ReplaceTime(document, null);
                    ReplaceData(dictionaryData, null, document);
                    int cRow = 1;
                    if (data != null && data.Count > 0)
                    {
                        Novacode.Table myTable = FindTableWithText(document.Tables, fTempTableData, out int Row, out int cCell);
                        if (data.Count > 0)
                        {
                            for (int i = 0; i < data.Count; i++)
                            {
                                Novacode.Row newRow = myTable.InsertRow(myTable.Rows[cRow], cRow + i + 1);
                                newRow.Cells[0].Paragraphs.First().Append((i + 1).ToString()).ReplaceText(fTempTableData, "");
                                newRow.Cells[1].Paragraphs.First().Append(data[i].MACTHDXUAT);
                                newRow.Cells[2].Paragraphs.First().Append(data[i].TENKHO);
                                newRow.Cells[3].Paragraphs.First().Append(data[i].TENSP);
                                newRow.Cells[4].Paragraphs.First().Append(data[i].TENDVT);
                                newRow.Cells[5].Paragraphs.First().Append(data[i].SLBAN.ToString());
                                newRow.Cells[6].Paragraphs.First().Append(data[i].GIABAN.ToString());
                            }
                            cRow += 1;
                        }
                        myTable.RemoveRow(1);
                    }
                    document.ReplaceText(fTempTableData, "");
                    document.Save();
                    document.Dispose();
                }
            }
            catch (Exception ex)
            {
                res = ex.Message;
            }
            return res;
        }
    }
}
