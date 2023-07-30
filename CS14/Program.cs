//Вывести имя в прямоугольник из символа, который введет сам пользователь.
//Вы запрашиваете имя, после запрашиваете символ, а после отрисовываете в консоль его имя в прямоугольнике из его символов.
//Пример:
//Alexey
//%
//%%%%%%
//% Alexey %
//%%%%%%
//Примечание:
//Длину строки можно всегда узнать через свойство Length
//string someString = “Hello”;
//Console.WriteLine(someString.Length); //5.
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
            int nameLenght;

            Console.WriteLine("Введите своё имя: ");
            name = Console.ReadLine();
            Console.WriteLine("Введите символ: ");
            symbol = Convert.ToChar(Console.ReadLine());
            nameLenght = name.Length;
            Console.WriteLine("\n");

            for (int i = 0; i < nameLenght + 2; i++)
            {
                line += symbol;
            }
            Console.WriteLine(line);
            Console.WriteLine(symbol + name + symbol);
            Console.WriteLine(line);
        }
    }
}
