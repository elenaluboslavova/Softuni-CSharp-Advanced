using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace RawData
{
    class Program
    {
        static void Main(string[] args)
        {
            int n =int.Parse(Console.ReadLine());
            List<Engine> engines = new List<Engine>();
            List<Cargo> cargos = new List<Cargo>();
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                string model = input[0];
                int engineSpeed = int.Parse(input[1]);
                int enginePower = int.Parse(input[2]);
                int cargoWeight = int.Parse(input[3]);
                string cargoType = input[4];
                double tire1Pressure = double.Parse(input[5]);
                int tire1Age = int.Parse(input[6]);
                double tire2Pressure = double.Parse(input[7]);
                int tire2Age = int.Parse(input[8]);
                double tire3Pressure = double.Parse(input[9]);
                int tire3Age = int.Parse(input[10]);
                double tire4Pressure = double.Parse(input[11]);
                int tire4Age = int.Parse(input[12]);

                Engine engine = new Engine(engineSpeed, enginePower);
                engines.Add(engine);

                Cargo cargo = new Cargo(cargoWeight, cargoType);
                cargos.Add(cargo);

                Tire tire1 = new Tire(tire1Pressure, tire1Age);
                Tire tire2 = new Tire(tire2Pressure, tire2Age);
                Tire tire3 = new Tire(tire3Pressure, tire3Age);
                Tire tire4 = new Tire(tire4Pressure, tire4Age);

                Car car = new Car(model, engine, cargo, new List<Tire> { tire1, tire2, tire3, tire4 });
                cars.Add(car);
            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                foreach (Car car in cars)
                {
                    if (car.Cargo.Type == "fragile")
                    {
                        Tire current = car.Tires.FirstOrDefault(x => x.Pressure < 1);
                        if (car.Tires.Contains(current))
                        {
                            Console.WriteLine(car.Model);
                        }
                    }
                }
            }

            else
            {
                foreach (Car car in cars)
                {
                    if (car.Cargo.Type == "flamable")
                    {
                        if (car.Engine.Power > 250)
                        {
                            Console.WriteLine(car.Model);
                        }
                    }
                }
            }
        }
    }
}
