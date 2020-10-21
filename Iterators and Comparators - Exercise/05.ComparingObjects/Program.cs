using System;
using System.Collections.Generic;

namespace _05.ComparingObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Person> people = new List<Person>();

            while (input != "END")
            {
                string[] splitted = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = splitted[0];
                int age = int.Parse(splitted[1]);
                string town = splitted[2];

                Person person = new Person(name, age, town);
                people.Add(person);
                input = Console.ReadLine();
            }
            int n = int.Parse(Console.ReadLine());
            Person comparedPerson = people[n - 1];

            int samePersonCount = 0;
            foreach (Person person in people)
            {
                if (person.CompareTo(comparedPerson) == 0)
                {
                    samePersonCount++;
                }
            }
            if (samePersonCount == 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                int notSamePersonCount = people.Count - samePersonCount;
                Console.WriteLine($"{samePersonCount} {notSamePersonCount} {people.Count}");
            }
        }
    }
}
