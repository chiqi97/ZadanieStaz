using Library.Services;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Library.Tests
{
    public class LogicServiceTests
    {
        [Theory]
        [InlineData(  new string[] { "01.01.2017", "05.01.2017" }, "01-05.01.2017" )]
        [InlineData(  new string[] { "01.01.2017", "05.02.2017" }, "01.01-05.02.2017" )]
        [InlineData(  new string[] { "01.01.2016", "05.01.2017" }, "01.01.2016-05.01.2017" )]
        public void CompareTwoDates_MethodCompareDateAndWriteDatesRange(string[] inputArray, string expected)
        {
            List<DateTime> dateTimes = new List<DateTime>();

            //Arrange
            foreach (var date in inputArray)
            {
                dateTimes.Add( DateTime.ParseExact(date, "dd.MM.yyyy",
                CultureInfo.InvariantCulture, DateTimeStyles.AssumeLocal));
            }

            //Act
            ILogicService logicService = new LogicService();
            string actual = logicService.CompareTwoDates(dateTimes);

            //Assert
            Assert.Equal(expected, actual);

        }
    }
}
