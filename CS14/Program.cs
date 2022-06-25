using System;

namespace CS14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            char symbol;
            int namelenght;

            Console.Write("Введите имя: ");
            name = Console.ReadLine();
            namelenght = name.Length;
            Console.Write("Введите символ: ");
            symbol = Convert.ToChar(Console.ReadLine());
            Console.Write("\n");

            for(int i = 0; i < namelenght + 2; i++)
            {
                Console.Write(symbol);
            }
            Console.WriteLine("\n" + symbol + name + symbol);

            for (int i = 0; i < namelenght + 2; i++)
            {
                Console.Write(symbol);
            }
            Console.ReadKey();
        }
    }
}