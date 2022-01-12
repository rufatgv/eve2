using System;

namespace _4cu
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //verilmihs 5 reqemli ilk ve son reqemlerinin ceminin kvadrati
            step1:
            Console.WriteLine("5 reqemli eded daxil edin  :");
            int num;
            int num1;
            int num2;
            
            num= Convert.ToInt32(Console.ReadLine());
            if (num >=10000 && num <100000)
            {
                Console.WriteLine(num);
            }
            else
            {
                goto step1;
            }
            Console.Clear();

            num1 = num / 10000;
            num = num % 10;
            num2 = (num + num1) * (num + num1);
            Console.WriteLine($"Cavab : { num2}");



        }
    }
}
