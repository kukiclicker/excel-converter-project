using FluentAssertions;
using IronXL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Excel_Converter_Project.Tests.ExcelLogicTests
{
    public class ExcelLogicTests
    {
        [Fact]
        public void ExcelLogic_Test_FilterByLast2Years()
        {
            
            var fileName = "Worldwide Rig Count Jun 2023.xlsx";
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            var fullPath = Path.Combine(path, fileName);
            WorkBook workbook = new WorkBook(fullPath);

            
            var result = ExcelLogic.FilterByLast2Years(workbook);
            
            result.Should().NotBeNull();
            result.Should().BeOfType<WorkBook>();

        }
        [Fact]
        public void ExcelLogic_Test_ConvertToCSV()
        {
           
            var fileName = "Worldwide Rig Count Jun 2023.xlsx";
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            var fullPath = Path.Combine(path, fileName);
            WorkBook workbook = new WorkBook(fullPath);

            
            var result = ExcelLogic.ConvertToCSV(workbook,fileName);
            
            result.Should().BeTrue();

        }
    }
}
