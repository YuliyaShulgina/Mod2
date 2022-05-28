using System;

namespace TaxiPark.Core
{
    public abstract class Car
    {
        public  abstract ConsoleColor Color {get;}
        public abstract string Name { get; set; }
        public abstract int Speed { get;}
        public abstract decimal Price { get;}
        public abstract int FuelConsumption { get;}
        public abstract void Move();
        public Engine Engine { get; set; }
        protected Car (Engine engine)
        {
            Engine = engine ?? throw new ArgumentNullException(nameof(engine));
        }
    }
}
