using System;

namespace Eve2
{
    internal class Program
    {
        static void Main(string[] args)
        {
        // verilmihs 6 reqemli ededin ilk 3 denesinin reqemleri cemi tap: example: 123600 = 1 + 2 + 3
            Console.Write("6 reqemli eded daxil et: ");
            int num;
            step1:
             num= Convert.ToInt32(Console.ReadLine());
            if (num>=100000 && num<1000000)
            {
                Console.WriteLine(num);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Duzgun daxil edin!");
                goto step1;
            }
            Console.Clear();

            num = num / 1000;
            int digits = 0;
            while (num>0)
            {
                digits = digits + num % 10;     
                num = num / 10;            
                
            }
            Console.WriteLine($"Your Result: {digits}");

            
            
           

        }
    }
}
