using FluentAssertions;


namespace Excel_Converter_Project.Tests.ClientTests
{
    public class ClientLogicTests
    {
        [Fact]
        public void ClientLogic_Test_DownloadFile_return_true()
        {
            
            var url = "https://www.dwsamplefiles.com/download-txt-sample-files/";
            var location = "text.txt";
            
            var result = ClientLogic.DownloadFile(url,location);
            
            result.Should().BeTrue();
        }
        [Fact]
        public void ClientLogic_Test_DownloadFile_return_false_due_url()
        {
            
            var url = "";
            var location = "text.txt";
          
            var result = ClientLogic.DownloadFile(url, location);
            
            result.Should().BeFalse();
        }
        [Fact]
        public void ClientLogic_Test_DownloadFile_return_false_due_location()
        {
           
            var url = "https://www.dwsamplefiles.com/download-txt-sample-files/";
            var location = "";
       
            var result = ClientLogic.DownloadFile(url, location);
         
            result.Should().BeFalse();
        }
        [Fact]
        public void Client_Logic_Test_FindFileURLUsingName()
        {
           
            var website = "https://www.dwsamplefiles.com/download-txt-sample-files/";
            var fileName = "Download Sample1.TXT";
          
            var result = ClientLogic.FindFileURLUsingName(website, fileName);
            
          
            result.Should().NotBeSameAs(website);
            result.Should().NotBe("");
           
        }
        
    }
}
