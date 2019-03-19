using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarComparisonForMaxim
{
   public class CarRepository
    {
        List<Car> CarList = new List<Car>()
        {
            new Car(){ CarID=1, CarMake="Honda", CarModel="CRV", CarColor="Green", CarYear=2016, CarPrice=23.845, TCCRating=8, HwyMPG=33},
            new Car(){CarID=2, CarMake="Ford", CarModel="Escape", CarColor="Red", CarYear=2017, CarPrice=23.590, TCCRating=7.8, HwyMPG=32},
            new Car(){CarID=3, CarMake="Hyundai", CarModel="Sante Fe", CarColor="Grey", CarYear=2016, CarPrice=24.950, TCCRating=8, HwyMPG=27},
            new Car(){CarID=4, CarMake="Mazda", CarModel="CX-5", CarColor="Red", CarYear=2017, CarPrice=21.795, TCCRating=8, HwyMPG=35},
            new Car(){CarID=5, CarMake="Subaru", CarModel="Forester", CarColor="Blue", CarYear=2016, CarPrice=22.395, TCCRating=8.4, HwyMPG=32},

        };
        public List<Car> GetList()
        {
            return CarList;
        }

    }
}



