using Library.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Library.Tests
{
    public class DataServiceTests
    {

        [Theory]
        [InlineData(new string[] { "20.02.2020", "02.10.2010" }, true)]
        [InlineData(new string[] { "20-02.2020", "02.10.2010" }, false)]
        [InlineData(new string[] { "20.02.2020", "as" }, false)]
        public void Validate_CheckInputData(string[] arrayOfDates, bool expected)
        {
            //Arrange

            //Act
            DataService dataService = new DataService();
            var actual = dataService.Validate(arrayOfDates.ToList());
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
