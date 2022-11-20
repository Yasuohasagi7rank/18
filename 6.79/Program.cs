using System;

namespace _6._79
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите число m: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите первый член g: ");
            int g = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите знаменатель z: ");
            int z = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            while (i < m)
            {
                i = g * z;
                g = g * z;
                Console.WriteLine(g);
            }
            if (i == m)
                Console.WriteLine("Геометрическая прогрессия");
            else
                Console.WriteLine("Не геометрическая прогрессия");
        }
    }
}
