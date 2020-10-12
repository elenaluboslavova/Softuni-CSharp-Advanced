using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var tires = new List<Tire[]>();

            string command = Console.ReadLine();
            while (command != "No more tires")
            {
                string[] commandSplitted = command.Split();

                Tire tire1 = new Tire(int.Parse(commandSplitted[0]), double.Parse(commandSplitted[1]));
                Tire tire2 = new Tire(int.Parse(commandSplitted[2]), double.Parse(commandSplitted[3]));
                Tire tire3 = new Tire(int.Parse(commandSplitted[4]), double.Parse(commandSplitted[5]));
                Tire tire4 = new Tire(int.Parse(commandSplitted[6]), double.Parse(commandSplitted[7]));

                tires.Add(new Tire[] { tire1, tire2, tire3, tire4 });

                command = Console.ReadLine();
            }

            List<Engine> engines = new List<Engine>();

            string command2 = Console.ReadLine();
            while (command2 != "Engines done")
            {
                int horsePower = int.Parse(command2.Split()[0]);
                double cubicCapacity = double.Parse(command2.Split()[1]);

                Engine engine = new Engine(horsePower, cubicCapacity);
                engines.Add(engine);

                command2 = Console.ReadLine();
            }

            var newCars = new List<Car>();
            string command3 = Console.ReadLine();
            while (command3 != "Show special")
            {
                string[] commandSplitted = command3.Split();
                string make = commandSplitted[0];
                string model = commandSplitted[1];
                int year = int.Parse(commandSplitted[2]);
                double fuelQuantity = double.Parse(commandSplitted[3]);
                double fuelConsumption = double.Parse(commandSplitted[4]);
                int engineIndex = int.Parse(commandSplitted[5]);
                int tiresIndex = int.Parse(commandSplitted[6]);

                Engine currentEngine = engines[engineIndex];
                Tire[] currentTires = tires[tiresIndex];

                Car car = new Car(make, model, year, fuelQuantity, fuelConsumption, currentEngine, currentTires);

                newCars.Add(car);

                command3 = Console.ReadLine();
            }

            for (int i = 0; i < newCars.Count; i++)
            {
                Car current = newCars[i];
                double currentTirePressure = current.Tires.Sum(x => x.Pressure);
                bool isDriven = current.Year >= 2017 && current.Engine.HorsePower > 330 && currentTirePressure >= 9 && currentTirePressure <= 10;

                if (isDriven)
                {
                    current.Drive(20);
                    Console.WriteLine($"Make: {current.Make}");
                    Console.WriteLine($"Model: {current.Model}");
                    Console.WriteLine($"Year: {current.Year}");
                    Console.WriteLine($"HorsePowers: {current.Engine.HorsePower}");
                    Console.WriteLine($"FuelQuantity: {current.FuelQuantity}");
                }
                

            }
        }
    }
}
