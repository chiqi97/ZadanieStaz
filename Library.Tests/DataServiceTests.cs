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
        [InlineData(new string[] { "", "" }, false)]
        [InlineData(new string[] { "bb", "as" }, false)]
        [InlineData(new string[] { "", "as" }, false)]
        [InlineData(new string[] { "05.13.2013", "05.23.2013" }, false)]
        [InlineData(new string[] { "35.12.2013", "05.01.2013" }, false)]
        [InlineData(new string[] { "05.13.201123213", "05.11.2011323" }, false)]
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
