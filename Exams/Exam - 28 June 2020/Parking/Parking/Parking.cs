using System;
using System.Collections.Generic;
using System.Text;

namespace Parking
{
    public class Parking
    {
        public Parking(string type, int capacity)
        {
            this.Type = type;
            this.Capacity = capacity;
            this.Data = new List<Car>();
        }

        public string Type { get; set; }
        public int Capacity { get; set; }
        public List<Car> Data { get; set; }
        public int Count
        {
            get 
            {
                return Data.Count;
            }
        }

        public void Add(Car car)
        {
            if (Capacity > Data.Count)
            {
                Data.Add(car);
            }
        }

        public bool Remove(string manufacturer, string model)
        {
            foreach (var car in Data)
            {
                if (car.Manufacturer == manufacturer && car.Model == model)
                {
                    Data.Remove(car);
                    return true;
                }
            }
            return false;
        }

        public Car GetLatestCar()
        {
            int maxYear = int.MinValue;
            Car maxCar = null;
            foreach (var car in Data)
            {
                if (car.Year > maxYear)
                {
                    maxYear = car.Year;
                    maxCar = car;
                }
            }
            return maxCar;
        }

        public Car GetCar(string manufacturer, string model)
        {
            foreach (var car in Data)
            {
                if (car.Manufacturer == manufacturer && car.Model == model)
                {
                    return car;
                }
            }
            return null;
        }

        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The cars are parked in {this.Type}:");
            foreach (var car in Data)
            {
                sb.AppendLine(car.ToString());
            }
            return sb.ToString();
        }
    }
}
