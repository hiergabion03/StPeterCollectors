using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;
using StPeterCollectors.Models;

namespace StPeterCollectors.Services
{
    public class ExcelImportService
    {
        public static List<sp_collectors_main> ReadExcelFile(string filePath)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            List<sp_collectors_main> records = new List<sp_collectors_main>();

            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                var worksheet = package.Workbook.Worksheets[0]; // Assuming data is in the first sheet
                int rowCount = worksheet.Dimension.Rows;

                for (int row = 2; row <= rowCount; row++) // Assuming row 1 is the header
                {
                    try
                    {
                        var record = new sp_collectors_main
                        {
                            collector_name = worksheet.Cells[row, 19].Text == "" ? worksheet.Cells[row, 19].Text : "",
                            contract_no = worksheet.Cells[row, 2].Text,
                            plan_holder = worksheet.Cells[row, 3].Text,
                            description = worksheet.Cells[row, 5].Text,
                            effectivity_date = DateTime.Parse(worksheet.Cells[row, 6].Text),
                            due_date = DateTime.Parse(worksheet.Cells[row, 7].Text),
                            quota_comm = decimal.TryParse(worksheet.Cells[row, 8].Text, out var comm) ? comm : (decimal?)null,
                            quota_ncomm = decimal.TryParse(worksheet.Cells[row, 9].Text, out var ncomm) ? ncomm : (decimal?)null,
                            cbi = decimal.TryParse(worksheet.Cells[row, 10].Text, out var cbiVal) ? cbiVal : 0,
                            inst_no = int.TryParse(worksheet.Cells[row, 11].Text, out var inst) ? inst : 0,
                            aging = int.TryParse(worksheet.Cells[row, 12].Text, out var age) ? age : 0,
                            balance = decimal.TryParse(worksheet.Cells[row, 13].Text, out var bal) ? bal : 0,
                            tax = worksheet.Cells[row, 14].Text,
                            ins = worksheet.Cells[row, 15].Text,
                            or_no = int.TryParse(worksheet.Cells[row, 16].Text, out var orNum) ? orNum : (int?)null,
                            or_date = DateTime.TryParse(worksheet.Cells[row, 17].Text, out var orDate) ? orDate : (DateTime?)null,
                            coll_due = decimal.TryParse(worksheet.Cells[row, 18].Text, out var due) ? due : (decimal?)null,
                            coll_advance = decimal.TryParse(worksheet.Cells[row, 19].Text, out var adv) ? adv : (decimal?)null,
                        };

                        records.Add(record);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error processing row {row}: {ex.Message}");
                    }
                }
            }

            return records;
        }
    }
}
