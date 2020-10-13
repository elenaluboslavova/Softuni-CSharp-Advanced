using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string model = input[0];
                double fuelAmount = double.Parse(input[1]);
                double fuelConsumption = double.Parse(input[2]);

                Car car = new Car(model, fuelAmount, fuelConsumption);
                cars.Add(car);
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                string model = command.Split()[1];
                int km = int.Parse(command.Split()[2]);

                Car car = cars.FirstOrDefault(x => x.Model == model);
                car.Drive(km);

                command = Console.ReadLine();
            }

            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }

        //private static Car GetCar(List<Car> cars ,string model)
        //{
        //    foreach (var car in cars)
        //    {
        //        if (car.Model == model)
        //        {
        //            return car;
        //        }
        //    }
        //    return null;
        //}
    }
}

