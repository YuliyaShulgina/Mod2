using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiPark.Core
{
    public class Engine
    {
        public int Power { get; private set; }
        public DateTime CreationDate { get; private set; }
        public Engine (int power)
        {
            Power = power;
            CreationDate = DateTime.UtcNow;
        }
        public void Richat ()
        {
            Console.Beep(40, 1500);
        }
    }
}
