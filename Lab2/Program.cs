using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Я считаю количество нечётных чисел в последовательности длинны N");

            
            int N;
            Console.WriteLine("Введдите N");
            while (!int.TryParse(Console.ReadLine(), out N))
                Console.WriteLine("Введдите ЧИСЛО");

            Console.WriteLine("Введите последовательность чисел");

            int Num, i, odd = 0;

            for (i = 1; i <= N; i++)
            {
                while (!int.TryParse(Console.ReadLine(), out Num))
                    Console.WriteLine("Введдите ЧИСЛО");

                if ((Num % 2) != 0)
                    odd++;
            }

            Console.WriteLine("Количество нечётных чисел в последовательности = {0}", odd);

            Console.ReadKey(true);
        }
    }
}
