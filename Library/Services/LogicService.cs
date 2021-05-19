using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
    public class LogicService : ILogicService

    {




        public string CompareTwoDates(List<DateTime> input)
        {
            if (input.Count != 2)
            {
                Console.WriteLine("Something went wrong.");
                Environment.Exit(0);
            }

            input = input.OrderBy(x => x).ToList();

            string date = null;
            if (input[0].Year == input[1].Year)
            {
                date = input[0].Year.ToString();
            }
            else
            {
                return PrintDates(ChangeAllDate(input[0]), ChangeAllDate(input[1]));
            }

            if(input[0].Month == input[1].Month)
            {
                date = input[0].Month.ToString() + "." + date;
            }
            else
            {
                return PrintDates(ChangeToDayAndMonth(input[0]), ChangeAllDate(input[1]));
            }

            if(input[0].Day == input[1].Day)
            {
                return PrintDates(ChangeAllDate(input[0]));
            }
            else
            {
                return PrintDates(ChangeToDay(input[0]), ChangeAllDate(input[1]));
            }
            
        }

        private string ChangeToDay(DateTime inputDate)
        {
            return inputDate.ToString("dd");
        }

        private string ChangeToDayAndMonth(DateTime inputDate)
        {
            return inputDate.ToString("dd/MM");
        }

        private string ChangeToYear(DateTime inputDate)
        {
            return inputDate.ToString("yyyy");
        }
        private string ChangeAllDate(DateTime inputDate)
        {
            return inputDate.ToString("dd.MM.yyyy");
        }

        private string PrintDates(string date1, string date2 = null)
        {
            if (date2 == null)
            {
                return $"{date1}";
            }
            else
            {
                return $"{date1}-{date2}";
            }
        }
    }
}
