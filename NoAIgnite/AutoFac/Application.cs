using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoAIgnite.AutoFac
{
    public class Application : IApplication
    {
        private readonly IBusinessLogic _businessLogic;

        public Application(IBusinessLogic businessLogic)
        {
            _businessLogic = businessLogic;
        }

        public void Run()
        {
            _businessLogic.ProcessData();
        }
    }
}
