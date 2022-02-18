using Structural.Adapter.Adaptee;
using Structural.Adapter.Adapter;
using System;
using Xunit;

namespace Structural.Adapter
{
    public class AdapterTest
    {
        [Fact]
        public void Test1()
        {
            // Arrange 
            EmployeeManager manger = new EmployeeManager();

            EmployeeAdapter adapter = new EmployeeAdapter();

            // Act 
            var listOfEmployees = manger.GetAllEmployees();

            Assert.Contains("Reza" ,listOfEmployees);

            // Assert 
            var result = adapter.GetAllEmployees();

            Assert.Contains("Research and Development", result); 
        }
    }
}
