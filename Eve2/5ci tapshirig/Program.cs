using System;

namespace _5ci_tapshirig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5) verilmihs 6 reqemli ededin 1 ci reqemini hemin ededin axirina at.
            step1:
            Console.WriteLine("6 Reqemli eded daxil edin : ");
            int num;
            int num1;
            int num2;
            int num3;
            num = Convert.ToInt32(Console.ReadLine());
            if (num>=100000 && num <1000000)
            {
                Console.WriteLine(num);
            }
            else
            {
                goto step1;
            }
            Console.Clear();
            num1 = num / 100000;
           
            num2 = num % 100000;
            
            num3 = num2 * 10 + 1;
            Console.WriteLine($"Cavab :{ num3}");    
        }
    }
}
