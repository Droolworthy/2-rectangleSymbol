using System;

namespace CS14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char symbol;
            string name;
            string line = "";
            int namelenght;

            Console.WriteLine("Введите своё имя: ");
            name = Console.ReadLine();
            Console.WriteLine("Введите символ: ");
            symbol = Convert.ToChar(Console.ReadLine());
            namelenght = name.Length;
            Console.WriteLine("\n");

            for (int i = 0; i < namelenght + 2; i++)
            {
                line += symbol;
            }
            Console.WriteLine(line);
            Console.WriteLine(symbol + name + symbol);
            Console.WriteLine(line);
        }
    }
}
