using System;

namespace _3cu_tapsiriq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // verilmihs 9 reqemli ededin duz ortaya dushen 3 reqeminin reqemleri cemi
            Console.Write("9 reqemli eded daxil edin :");
            int num;
            step1:
            num = Convert.ToInt32(Console.ReadLine());
            if (num >=100000000 && num <1000000000)
            {
                Console.WriteLine(num);
            }
            else
            {
                Console.Clear();
                Console.Write("duzgun daxil edin :");
                goto step1;
            }
            Console.Clear();
            num = num / 1000;
            num = num % 1000;
            int digits = 0;
            while (num>0)
            {
                digits = digits + num % 10;
                num = num / 10;
            }
            Console.WriteLine(digits);
        }
    }
}
