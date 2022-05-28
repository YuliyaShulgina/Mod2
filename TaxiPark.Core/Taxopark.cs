using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiPark.Core
{
    public class Taxopark

    {
        private readonly List<Car> _cars = new List<Car>();
        public void AddCar(Car car) => _cars.Add(car);
    }
}
