using System;
using System.IO;
using OfficeOpenXml;

namespace Visual.Programming.Project.Grey.Helpers
{
    internal static class ExcelHelper
    {
        private static readonly string DataFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "VisualProgrammingData.xlsx");

        static ExcelHelper()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        }

        public static void AppendCredential(string name, string email, string password)
        {
            EnsureFileAndSheet("Credentials", new[] { "Name", "Email", "Password", "SavedAtUtc" }, (ws, nextRow) =>
            {
                ws.Cells[nextRow, 1].Value = name;
                ws.Cells[nextRow, 2].Value = email;
                ws.Cells[nextRow, 3].Value = password;
                ws.Cells[nextRow, 4].Value = DateTime.UtcNow;
            });
        }

        public static void AppendOrder(int id, string productName, string customerName, decimal price, string email, DateTime createdAt)
        {
            EnsureFileAndSheet("Orders", new[] { "Id", "ProductName", "CustomerName", "Price", "Email", "CreatedAtUtc" }, (ws, nextRow) =>
            {
                ws.Cells[nextRow, 1].Value = id;
                ws.Cells[nextRow, 2].Value = productName;
                ws.Cells[nextRow, 3].Value = customerName;
                ws.Cells[nextRow, 4].Value = price;
                ws.Cells[nextRow, 5].Value = email;
                ws.Cells[nextRow, 6].Value = createdAt;
            });
        }

        private static void EnsureFileAndSheet(string sheetName, string[] headers, Action<ExcelWorksheet, int> appendRow)
        {
            using var package = CreateOrOpenPackage();

            var ws = package.Workbook.Worksheets[sheetName] ?? package.Workbook.Worksheets.Add(sheetName);

            if (ws.Dimension == null)
            {
                for (int i = 0; i < headers.Length; i++)
                    ws.Cells[1, i + 1].Value = headers[i];
            }

            int nextRow = ws.Dimension.End.Row + 1;
            appendRow(ws, nextRow);

            package.Save();
        }

        private static ExcelPackage CreateOrOpenPackage()
        {
            var file = new FileInfo(DataFilePath);
            if (!file.Directory.Exists)
                Directory.CreateDirectory(file.DirectoryName!);

            return file.Exists ? new ExcelPackage(file) : new ExcelPackage(file);
        }
    }
}
