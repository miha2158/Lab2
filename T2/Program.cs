using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Я ищу минимальный элемент последовательности");
            Console.WriteLine("Введите последовательность чисел");

            int Num, min = 0;
            bool Run1 = true;

            Console.WriteLine("\"0\" - Выход");

            string Input = Console.ReadLine();

            while (Input != "0")
            {    
                while (!int.TryParse(Input, out Num))
                {
                    Console.WriteLine("Введдите ЧИСЛО");
                    Input = Console.ReadLine();
                }

                if(Run1)
                {
                    min = Num;
                    Run1 = false;
                }

                
                if (min > Num)
                    min = Num;

                Input = Console.ReadLine();
            }

            if (!Run1)
                Console.WriteLine("Минимальный элемент - {0}", min);
            else Console.WriteLine("Минимального элемента не существует");

            Console.ReadKey(true);
        }
    }
}
