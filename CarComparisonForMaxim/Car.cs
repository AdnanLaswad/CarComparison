using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarComparisonForMaxim
{
   public class Car
    {
        public int CarID { get; set; }
        public string CarMake { get; set; }
        public string CarModel { get; set; }
        public string CarColor { get; set; }
        public int CarYear { get; set; }
        public double CarPrice { get; set; }
        public double TCCRating { get; set; }
        public int HwyMPG { get; set; }
    }
}
