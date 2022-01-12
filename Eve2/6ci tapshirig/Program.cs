using System;

namespace _6ci_tapshirig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // verilmihs 8 reqemli ededin ilk I ve axirinci reqemlerini legv et
            step1:
            Console.WriteLine("8 Reqemli eded daxil edin  :");
            int num;
            num = Convert.ToInt32(Console.ReadLine());
            if (num < 10000000 || num >100000000)
            {
                goto step1;
            }
            num = num % 10000000;
           
            num = num / 10;
            Console.WriteLine($"Cavab : {num}");
        }
    }
}
