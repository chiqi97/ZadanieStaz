using Library.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class BusinessLogic : IBusinessLogic
    {
        private readonly ILogicService _logicService;
        private readonly IDataService _dataService;

        public BusinessLogic(ILogicService logicService,
                                IDataService dataService)
        {
            _logicService = logicService;
            _dataService = dataService;
        }
        public void ProcessData()
        {
            do
            {
                var output = _logicService.CompareTwoDates(_dataService.GetTwoDates());
                Console.WriteLine($"{output}");
                Console.WriteLine("Press spacebar if you want to continue or any key to exit.");

            } while (Console.ReadKey(true).Key == ConsoleKey.Spacebar);
            Environment.Exit(0);


        }
    }
}
