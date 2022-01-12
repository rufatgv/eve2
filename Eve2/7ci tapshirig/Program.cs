using System;

namespace _7ci_tapshirig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //verilmihs 4 reqemli ededin tersine duzub axirina ve evveline 8 artir
            ERROR1:
            Console.WriteLine("4 reqemli eded daxil edin");
            int num;
            num = Convert.ToInt32(Console.ReadLine());
            if (num<1000 || num >9999)
            {
                
                goto ERROR1;
            }
            int box = 0;
            while (num>0)
            {
                box = box + num % 10;
                num = num / 10;
                box = box * 10;
            }
            box = box / 10;
            box = box * 10 + 8;
            Console.WriteLine(box);
        }
    }
}
