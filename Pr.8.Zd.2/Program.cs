using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите трехзначное число:");
            int x;
            String input = Console.ReadLine();
            int.TryParse(input, out x);
            int first = x / 100;
            int second = (x % 100) / 10;
            if (first < second)
                Console.WriteLine("Второе число больше чем первое");
            if (first > second)
                Console.WriteLine("Первое число больше чем второе");
            if (first == second)
                Console.WriteLine("Числа равны между собой");

        }
    }
}
