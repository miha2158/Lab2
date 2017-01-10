using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 100;
            Console.WriteLine("Я ищу первый отрицательный элемент в последовательности из {0} чисел", N);
            Console.WriteLine("Введите последовательность из {0} чисел", N);

            int i = 0, Num = 1;
            for (; i < N && Num >= 0; i++) 
                while (!int.TryParse(Console.ReadLine(), out Num))
                    Console.WriteLine("Введите ЧИСЛО");

            if (Num < 0)
                Console.WriteLine("Номер первого отрицательного числа - {0} ", i);
            else Console.WriteLine("Нет отрицательных элементов");

            Console.ReadKey(true);
        }
    }
}
