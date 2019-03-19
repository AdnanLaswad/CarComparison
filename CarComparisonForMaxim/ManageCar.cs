using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarComparisonForMaxim
{
    public class ManageCar
    {
        CarService carService;
        public ManageCar()
        {
            carService = new CarService();
        }
        public void NewestVehiclesInOrder()
        {
            Console.WriteLine("Make\t Modle\t Color\t Year\t Price\t TCCRating\t Hwy MPG");
            foreach (var car in carService.NewestVehiclesInOrder())
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}", car.CarMake, car.CarModel, car.CarColor, car.CarYear, car.CarPrice, car.TCCRating, car.HwyMPG);
            }
        }
        public void AlphabetizedOrder()
        {
            Console.WriteLine("Make \t Modle \t Color \t Year \t Price \t TCCRating \t Hwy MPG");
            foreach (var car in carService.AlphabetizedOrder())
            {
                Console.WriteLine("{0}\t {1} \t {2} \t {3} \t {4} \t {5}  \t{6}", car.CarMake, car.CarModel, car.CarColor, car.CarYear, car.CarPrice, car.TCCRating, car.HwyMPG);
            }
        }
        public void OrderByPrice()
        {
            Console.WriteLine("Make \t Modle \t Color \t Year \t Price \t TCCRating \t Hwy MPG");
            foreach (var car in carService.OrderByPrice())
            {
                Console.WriteLine("{0}\t {1} \t {2} \t {3} \t {4} \t {5}  \t{6}", car.CarMake, car.CarModel, car.CarColor, car.CarYear, car.CarPrice, car.TCCRating, car.HwyMPG);
            }
        }
        public void OrderByBestValue()
        {
            Console.WriteLine("Make \t Modle \t Color \t Year \t Price \t TCCRating \t Hwy MPG");
            foreach (var car in carService.OrderByBestValue())
            {
                Console.WriteLine("{0}\t {1} \t {2} \t {3} \t {4} \t {5}  \t{6}", car.CarMake, car.CarModel, car.CarColor, car.CarYear, car.CarPrice, car.TCCRating, car.HwyMPG);
            }
        }
        public void FuelConsumption()
        {
            Console.WriteLine("Make \t Modle \t Color \t Year \t Price \t TCCRating \t Hwy MPG");
            foreach (var car in carService.FuelConsumption())
            {
                Console.WriteLine("{0}\t {1} \t {2} \t {3} \t {4} \t {5}  \t{6}", car.CarMake, car.CarModel, car.CarColor, car.CarYear, car.CarPrice, car.TCCRating, car.HwyMPG);
            }

        }
        public void RandomCar()
        {
            Console.WriteLine("The random car = {0}",carService.RandomCar());
        }
        public void AvgMPG(int year)
        {
            Console.WriteLine("The Avg MPG for {0} Year = {1} ",year,carService.AvgMPG(year));
        }
    }
}
