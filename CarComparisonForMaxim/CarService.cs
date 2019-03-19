using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarComparisonForMaxim
{
    public class CarService
    {
        // A function to calculate the newest vehicles in order
        CarRepository carRespostery = new CarRepository();
        public IEnumerable<Car> NewestVehiclesInOrder()
        {
            return carRespostery.GetList().OrderByDescending(c => c.CarYear).ToList();
        }
        //A function to calculate an alphabetized List of vehicles
        public IEnumerable<Car> AlphabetizedOrder()
        {
            return carRespostery.GetList().OrderBy(c => c.CarModel).ToList();
        }
        // A function to calculate an ordered List of Vehicles by Price

        public IEnumerable<Car> OrderByPrice()
        {
            return carRespostery.GetList().OrderBy(c => c.CarPrice).ToList();
        }
        // A function to calculate the best value
        public IEnumerable<Car> OrderByBestValue()
        {
            return carRespostery.GetList().OrderByDescending(c => c.TCCRating).ToList();
        }
        // A function to calculate fuel consumption for a given distance

        public IEnumerable<Car> FuelConsumption()
        {
            return carRespostery.GetList().OrderByDescending(c => c.HwyMPG).ToList();
        }
        // A function to return a random car from the list

        public string RandomCar()
        {

            var rnd = new Random();
            
            int index = rnd.Next(1,carRespostery.GetList().Count);

            return carRespostery.GetList().SingleOrDefault(c => c.CarID == index).CarModel;
        }
        //A function to return average MPG by year
        public double AvgMPG(int year)
        {
            var result = carRespostery.GetList().Where(c => c.CarYear == year).Select(c => c.HwyMPG).Average();
            return result;
           
        }
    }
}
