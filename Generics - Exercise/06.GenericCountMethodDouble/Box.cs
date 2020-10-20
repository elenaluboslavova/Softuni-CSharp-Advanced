using System;
using System.Collections.Generic;
using System.Text;

namespace _06.GenericCountMethodDouble
{
    public class Box<T> where T : IComparable
    {
        public List<T> Values { get; set; } = new List<T>();

        public Box(List<T> values)
        {
            this.Values = values;
        }
        public int GetCountOfGreaterElements(T value)
        {
            int counter = 0;

            foreach (T currentValue in this.Values)
            {
                if (value.CompareTo(currentValue) < 0)
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
