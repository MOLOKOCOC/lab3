using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 0, b = 0, c = 0;
            Console.WriteLine("введите а \n введите b \n 1) + \n 2) - \n 3) * \n 4) /");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            if (c == 1) { Console.WriteLine(a + b); }
            else if (c == 2) { Console.WriteLine(a - b); }
            else if (c == 3) { Console.WriteLine(a * b); }
            else if (c == 4) { Console.WriteLine(a / b); }
        }
    }
}
