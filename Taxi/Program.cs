using System;
using TaxiPark.Core;

var engine = new Engine(power: 12);
var pegeo = new Peugeot(engine, ConsoleColor.Magenta, 100000, 220);
pegeo.Move();
Console.ReadKey();
