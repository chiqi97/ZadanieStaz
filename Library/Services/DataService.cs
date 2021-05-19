using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
    public class DataService : IDataService
    {

        public List<DateTime> GetTwoDates()
        {
            List<DateTime> dateTime = new List<DateTime>();

            Console.WriteLine("Enter 2 dates as in the pattern:\"dd.mm.yyyy dd.mm.yyyy\"");
            List<string> inputParams = Console.ReadLine().Split(' ').ToList();

            if (Validate(inputParams))
            {
                foreach (var inputParam in inputParams)
                {
                    dateTime.Add(DateTime.ParseExact(inputParam, "dd.MM.yyyy",
                     CultureInfo.InvariantCulture, DateTimeStyles.AssumeLocal));
                }
            }
            else
            {
                Console.WriteLine("Click any button to close the application.");
                Console.ReadLine();
                Environment.Exit(0);
            }

            return dateTime;
        }

        public bool Validate(List<string> tab)
        {
            List<DateTime> dateTime = new List<DateTime>();
            if (tab==null || tab.Count != 2)
            {
                Console.WriteLine("Invalid number of parameters.");
                return false;
            }

            foreach (var param in tab)
            {
                try
                {
                    DateTime.ParseExact(param, "dd.MM.yyyy",
                 CultureInfo.InvariantCulture, DateTimeStyles.AssumeLocal);
                }
                catch
                {
                    Console.WriteLine("Invalid input data.");
                    return false;
                }
            }

            return true;
        }
    }
}
