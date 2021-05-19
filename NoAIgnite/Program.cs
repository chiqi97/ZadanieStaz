using Autofac;
using NoAIgnite.AutoFac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoAIgnite
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = ContainerConfig.Configure();
            using(var scope = container.BeginLifetimeScope())
            {
                var app = scope.Resolve<IApplication>();
                app.Run();
            }
            Console.ReadLine();
        }
    }
}
