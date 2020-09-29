using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02._Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<decimal>> grades = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                decimal grade = decimal.Parse(input[1]);

                if (!grades.ContainsKey(name))
                {
                    grades.Add(name, new List<decimal>());
                }
                grades[name].Add(grade);
            }

            foreach (var item in grades)
            {
                StringBuilder allGrades = new StringBuilder();
                for (int i = 0; i < item.Value.Count; i++)
                {
                    allGrades.Append($"{item.Value[i]:F2} ");
                }
                Console.WriteLine($"{item.Key} -> {allGrades.ToString()}(avg: {item.Value.Average():F2})");
            }
        }
    }
}
