using System.Data;
using Aspose.Cells;

namespace ReadingfromExceltoDatabase;

class Program
{
    static void Main()
    {
        Z.BulkOperations.LicenseManager.AddLicense("972;300-DOWNLOADDEVTOOLS.COM",
            "3017071-1928EF3-1311475-8D63374-8859");
        string connStr =
            "Persist Security Info=False;Data Source=(local);Initial Catalog=test;Integrated Security=SSPI";
#region Aspose处理

        // Aspose.Cells.License license = new Aspose.Cells.License();
        // new Aspose.Cells.License().SetLicense(@"D:\AsposeLicense\Aspose.Total.lic");
        // string sourceDir = @"C:\Users\p\OneDrive\文档\按项目列示采购订单报表231128汇总401项目\";
        // var startPoint = sourceDir.Length;
        // string[] files = Directory.GetFiles(sourceDir);
        // var orderedFiles = from f in files
        //     orderby Convert.ToInt32(f.Substring(startPoint, f.IndexOf('.') - startPoint))
        //     select f;
        //
        // foreach (var file in orderedFiles)
        // {
        //     var filename = Path.GetFileName(file);
        //     // var index = filename.IndexOf('.');
        //     // Console.WriteLine(file);
        //     // Console.WriteLine(filename);
        //     // Console.WriteLine(index);
        //     // Console.WriteLine(Path.GetFileName(file));
        //     Workbook book = new Workbook(file);
        //     Worksheet sheet = book.Worksheets[0];
        //
        //     var maxDataColumn = sheet.Cells.MaxDataColumn;
        //     var maxDataRow = sheet.Cells.MaxDataRow;
        //     // Console.WriteLine($"{filename}");
        //     // Console.WriteLine($"{maxDataColumn}:{maxDataRow}");
        //     // Console.WriteLine($"maxdatarow = {maxDataRow},maxdatacolumn = {maxDataColumn}");
        //     // Export Data Table Options with FormatStrategy as CellStyle
        //     ExportTableOptions opts = new ExportTableOptions();
        //     // opts.ExportAsString = true;
        //     // opts.FormatStrategy = CellValueFormatStrategy.CellStyle;
        //     DataTable dt = sheet.Cells.ExportDataTable(0, 0, maxDataRow + 1, maxDataColumn + 1, opts);
        //     // Export Data Table
        //     if (maxDataRow >= 1)
        //     {
        //         // Console.WriteLine(filename);
        //         // Console.WriteLine(dt.Rows[0][61]);
        //         if (!dt.Rows[0][61].Equals("付款金额"))
        //         {
        //             Console.WriteLine(filename);
        //             Console.WriteLine(dt.Rows[0][61]);
        //         }
        //     }

            #endregion

    }
}