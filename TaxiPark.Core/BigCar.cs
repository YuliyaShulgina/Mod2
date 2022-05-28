using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiPark.Core
{
    public abstract class BigCar : Car
    {
        protected BigCar(Engine engine):base(engine)
        {
        }

        public abstract int LiftingCapasity { set; get; }
    }
}
