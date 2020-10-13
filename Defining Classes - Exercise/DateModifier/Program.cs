using System;

namespace DateModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            DateModifier dateModifier = new DateModifier();
            string startDate = Console.ReadLine();
            string endDate = Console.ReadLine();

            Console.WriteLine(dateModifier.GetDaysDifference(startDate, endDate));
        }
    }
}
