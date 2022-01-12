using System;

namespace _9cu_tapshirig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //9 reqemli ededdin tek yerde dayananlardan bir eded duzlet: 132346389 = 12439
            step1:
            Console.WriteLine(" 9 reqemli eded daxil edin :");
            int num;
            num = Convert.ToInt32(Console.ReadLine());

            if (num < 100000000 || num > 999999999)
                goto step1;

        }
    }
}
