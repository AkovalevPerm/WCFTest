using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CarHost
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание хоста
            // При создании ищется конфигурация для CarService.CarService в конфиг файле.
            // Всю конфигурацию можно задавать и из кода!
            using (var host = new ServiceHost(typeof(CarService.CarService)))
            {
                host.Open();

                Console.WriteLine("Service car start");
                Console.ReadLine();
            }
        }
    }
}
