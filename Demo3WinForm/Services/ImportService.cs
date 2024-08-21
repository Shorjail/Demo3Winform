using Demo3WinForm.Data;
using Demo3WinForm.Models;
using System.Collections.Generic;
using System.IO;

using OfficeOpenXml;

namespace Demo3WinForm.Services
{
    public class ImportService
    {

        public List<ProcessParameters> ParseCsvFile(string filePath)
        {
            
            List<ProcessParameters> parametersList = new List<ProcessParameters>();

            
            using (var reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    var parameter = new ProcessParameters
                    {
                        ParameterName = values[0],
                        ParameterValue = values[1],
                        Version = int.Parse(values[2]),
                        ProcessId = int.Parse(values[3]) 
                    };

                    parametersList.Add(parameter);
                }
            }

            return parametersList;
        }

        public List<ProcessParameters> ParseExcelFile(string filePath)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            var processParametersList = new List<ProcessParameters>();

            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                int rowCount = worksheet.Dimension.Rows;

                for (int row = 1; row <= rowCount; row++) 
                {
                    var processParameter = new ProcessParameters
                    {
                        ParameterName = worksheet.Cells[row, 1].Value.ToString(),
                        ParameterValue = worksheet.Cells[row, 2].Value.ToString(),
                        Version = int.Parse(worksheet.Cells[row, 3].Value.ToString()),
                        ProcessId = int.Parse(worksheet.Cells[row, 4].Value.ToString())
                    };

                    processParametersList.Add(processParameter);
                }
            }

            return processParametersList;
        }

        public bool SaveToData(List<ProcessParameters> importedData)
        {
            using (var context = new DemoDbContext())
            {
                context.Configuration.AutoDetectChangesEnabled = true;
                context.ProcessParameters.AddRange(importedData);
                try
                {
                    context.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
                
            }

            
        }
    }
}
