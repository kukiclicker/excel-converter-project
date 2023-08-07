
using IronXL;


namespace Excel_Converter_Project
{

    internal class Program
    {
        
        static void Main()
        {
            //Downloading file from website
            
            var website = "https://bakerhughesrigcount.gcs-web.com/intl-rig-count?c=79687&p=irol-rigcountsintl";
            string fileName = "Worldwide Rig Count Jun 2023.xlsx";
            var url = ClientLogic.FindFileURLUsingName(website, fileName);

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var fullPath = Path.Combine(path, fileName);
            ClientLogic.DownloadFile(url, fullPath);
            


            //Filtering data and converting to CSV 
            
            WorkBook workbook = new WorkBook(fullPath);
            var filteredWorkbook = ExcelLogic.FilterByLast2Years(workbook);

           if (filteredWorkbook != null)
           {
               ExcelLogic.ConvertToCSV(filteredWorkbook,fullPath);
           }
          

        }
        
    }
}