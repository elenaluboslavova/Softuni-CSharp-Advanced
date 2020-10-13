using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace CarSalesman
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = input[0];
                int power = int.Parse(input[1]);

                if (input.Length == 2)
                {
                    Engine engine = new Engine(model, power);
                    engines.Add(engine);
                }

                else if (input.Length == 4)
                {
                    int displacement = int.Parse(input[2]);
                    string efficiency = input[3];

                    Engine engine = new Engine(model, power, displacement, efficiency);
                    engines.Add(engine);
                }

                else
                {
                    if (char.IsLetter(input[2][0]))
                    {
                        Engine engine = new Engine(model, power, input[2]);
                        engines.Add(engine);
                    }
                    else
                    {
                        Engine engine = new Engine(model, power, int.Parse(input[2]));
                        engines.Add(engine);
                    }
                }

                
            }

            int m = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = input[0];
                string engineModel = input[1];
                Engine engine = engines.FirstOrDefault(x => x.Model == engineModel);

                if (input.Length == 2)
                {
                    Car car = new Car(model, engine);
                    cars.Add(car);
                }

                else if (input.Length == 4)
                {
                    int weight = int.Parse(input[2]);
                    string color = input[3];
                    Car car = new Car(model, engine, weight, color);
                    cars.Add(car);
                }

                else
                {
                    if (char.IsDigit(input[2][0]))
                    {
                        Car car = new Car(model, engine, int.Parse(input[2]));
                        cars.Add(car);
                    }
                    else
                    {
                        Car car = new Car(model, engine, input[2]);
                        cars.Add(car);
                    }
                }
            }

            foreach (Car car in cars)
            {
                Console.WriteLine(car.Model+":");
                Console.WriteLine($"    {car.Engine.Model}:");
                Console.WriteLine($"        Power: {car.Engine.Power}");
                if (car.Engine.Displacement != 0)
                {
                    Console.WriteLine($"        Displacement: {car.Engine.Displacement}");
                }
                else
                {
                    Console.WriteLine($"        Displacement: n/a");
                }

                if (car.Engine.Efficiency != null)
                {
                    Console.WriteLine($"        Efficiency: {car.Engine.Efficiency}");
                }
                else
                {
                    Console.WriteLine($"        Efficiency: n/a");
                }

                if (car.Weight != 0)
                {
                    Console.WriteLine($"    Weight: {car.Weight}");
                }
                else
                {
                    Console.WriteLine($"    Weight: n/a");
                }

                if (car.Color != null)
                {
                    Console.WriteLine($"    Color: {car.Color}");
                }
                else
                {
                    Console.WriteLine($"    Color: n/a");
                }
            }
        }
    }
}
