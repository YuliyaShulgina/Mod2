using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiPark.Core
{
    public class Peugeot : LightCar
    {
        public override int Passagiri { get => 4; }
        public override ConsoleColor Color { get; }
        public override string Name { get; set;}
        public override int Speed { get;}
        public override decimal Price { get;}
        public override int FuelConsumption { get => 10; }

        public Peugeot(Engine engine):base(engine)
        {

        }
        public Peugeot(Engine engine, ConsoleColor color, decimal price, int speed): this(engine)
        {
            Color = color;
            Name = "Peugeot";
            Price = price;
            Speed = speed;

        }

        public override void Move()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = Color;
            Engine.Richat();
            Console.WriteLine($"{Color} {Name} is moving with speed {Speed} and consuming {FuelConsumption} l/100km.");
            Console.WriteLine($"Engine power is: {Engine.Power}");
            Console.ResetColor();
        }
    }
}
