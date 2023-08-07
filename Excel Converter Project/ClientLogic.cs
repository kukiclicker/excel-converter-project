
using System.Net;
using HtmlAgilityPack;

namespace Excel_Converter_Project
{
    public static class ClientLogic
    {

        public static bool DownloadFile(string url,string location)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.DownloadFile(url, location);

                Console.WriteLine("File downloaded successfully!");

                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error occured while downloading file! Try again!");
                return false;
            }
        }
        public static string FindFileURLUsingName(string website, string fileName)
        {
            try
            {
                HtmlWeb web = new HtmlWeb();
                var htmlDoc = web.Load(website);
                var node = htmlDoc.DocumentNode.SelectSingleNode("//a[contains(text(),'" + fileName + "')]");
                string url = node.OuterHtml.Substring(9, node.OuterHtml.Substring(9).IndexOf("\""));

                return url;
            }catch(Exception ex)
            {
                Console.WriteLine("There is no file called " + fileName + " on provided page!");
                return "";
            }
            

            
        }

    }
}
