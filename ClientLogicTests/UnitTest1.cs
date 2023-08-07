
namespace ClientLogicTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DownloadFileTest_valid_url()
        {
            //Arrange
            var url = "https://www.dwsamplefiles.com/download-txt-sample-files/";
            string location = "text.txt";
            //Act 
            ClientLogic.DownloadFile(url, location );
            //Assert


        }
    }
}