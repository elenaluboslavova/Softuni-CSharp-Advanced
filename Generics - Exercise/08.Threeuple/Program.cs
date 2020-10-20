using System;

namespace _08.Threeuple
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstTokens = Console.ReadLine().Split();
            string personFullName = firstTokens[0] + " " + firstTokens[1];
            string personAddress = firstTokens[2];
            string personTown = string.Empty;
            if (firstTokens.Length == 4)
            {
                personTown = firstTokens[3];
            }
            else
            {
                personTown = firstTokens[3] + " " + firstTokens[4];
            }
            
            Threeuple<string, string, string> firstPersonInfo = new Threeuple<string, string, string>(personFullName, personAddress, personTown);
            Console.WriteLine(firstPersonInfo.ToString());

            string[] secondTokens = Console.ReadLine().Split();
            string name = secondTokens[0];
            int litersBeer = int.Parse(secondTokens[1]);
            string drunk = secondTokens[2];
            Threeuple<string, int, string> secondPersonInfo = new Threeuple<string, int, string>("", 0, "");
            if (drunk == "drunk")
            {
                secondPersonInfo = new Threeuple<string, int, string>(name, litersBeer, "True");
            }
            else
            {
                secondPersonInfo = new Threeuple<string, int, string>(name, litersBeer, "False");
            }
            
            Console.WriteLine(secondPersonInfo);

            string[] thirdTokens = Console.ReadLine().Split();
            string personName = thirdTokens[0];
            double balance = double.Parse(thirdTokens[1]);
            string bankName = thirdTokens[2];
            Threeuple<string, double, string> thirdPersonInfo = new Threeuple<string, double, string>(personName, balance, bankName);
            Console.WriteLine(thirdPersonInfo);
        }
    }
}
