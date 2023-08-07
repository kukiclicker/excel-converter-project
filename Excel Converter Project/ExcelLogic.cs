
using IronXL;

namespace Excel_Converter_Project
{
    public static class ExcelLogic
    {
        public static WorkBook FilterByLast2Years(WorkBook workbook)
        {
            try
            {
                WorkSheet workSheet = workbook.WorkSheets.First();
                WorkBook filteredWorkBook = WorkBook.Create(ExcelFileFormat.XLSX);
                WorkSheet filteredSheet = filteredWorkBook.CreateWorkSheet("filtered data");

                //ovako bi izgledalo da se uradi rucno / probati automatski sam da filtrira
                var range = workSheet["B22:K50"];
                range.Copy(filteredSheet, "A1");
                return filteredWorkBook;
            }catch(Exception ex)
            {
                Console.WriteLine("Error occured while filtering or reading data! Please try again!");
                return null;
            }
            
        }
        public static bool ConvertToCSV(WorkBook workbook,string path)
        {
            try
            {
                workbook.SaveAs(path + ".csv");
                Console.WriteLine("\nConversion successfull!");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exeption " + ex.Message + " occured while converting file!");
                return false;
            }
            return true;
        }
    }
}
