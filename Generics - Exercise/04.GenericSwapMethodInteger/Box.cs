using System;
using System.Collections.Generic;
using System.Text;

namespace _04.GenericSwapMethodInteger
{
    public class Box<T>
    {
        public List<T> Values { get; set; } = new List<T>();

        public Box(List<T> values)
        {
            this.Values = values;
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            T tempValue = this.Values[firstIndex];
            this.Values[firstIndex] = this.Values[secondIndex];
            this.Values[secondIndex] = tempValue;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (T value in this.Values)
            {
                sb.AppendLine($"{value.GetType()}: {value}");
            }
            return sb.ToString();
        }
    }
}
