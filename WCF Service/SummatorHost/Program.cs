using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace SummatorHost
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание хоста
            // При создании ищется конфигурация для Summator.Summator в конфиг файле.
            using (var host = new ServiceHost(typeof(Summator.Summator)))
            {
                host.Open();

                Console.WriteLine("Service start");
                Console.ReadLine();
            }
        }
    }
}
