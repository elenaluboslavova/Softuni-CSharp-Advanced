using DefiningClasses;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> list = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split();
                string name = line[0];
                int age = int.Parse(line[1]);

                if (age > 30)
                {
                    Person person = new Person(name, age);
                    list.Add(person);
                }
            }
            if (list.Count > 0)
            {
                foreach (Person person in list.OrderBy(x => x.Name))
                {
                    Console.WriteLine($"{person.Name} - {person.Age}");
                }
            }

        }
    }
}
