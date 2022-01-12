using System;

namespace _8ci_tapshirig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Verilmis ededdin axirdan 3 - cu reqemi ile sonuncu reqeminin cemini tap
            Console.WriteLine("Eded daxil edin");
            int num;
            int num1;
            num = Convert.ToInt32(Console.ReadLine());

            num = num / 100;
            num = num % 10;
            num1 = num % 10;
            num = num + num1;
            Console.WriteLine($"Cavab : {num}");

        }
    }
}
