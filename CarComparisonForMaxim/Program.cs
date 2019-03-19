using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarComparisonForMaxim
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ManageCar manageCar = new ManageCar();

            manageCar.NewestVehiclesInOrder();
            Console.WriteLine("______________________");

            manageCar.AlphabetizedOrder();
            Console.WriteLine("_______________________");

            manageCar.OrderByPrice();
            Console.WriteLine("_______________________");

            manageCar.OrderByBestValue();
            Console.WriteLine("_______________________");

            manageCar.FuelConsumption();
            Console.WriteLine("_______________________");

            manageCar.RandomCar();
            Console.WriteLine("_______________________");

            // here you can enter which year you want the avrage for (2016 or 2017)
            manageCar.AvgMPG(2017);
           
            
            Console.ReadLine();
        }
    }
}
