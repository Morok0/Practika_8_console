using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Pr_8_zad_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            String line = Console.ReadLine();
            Console.WriteLine("Исходная строка: " + line);
            Console.WriteLine("Исходный текст: {0}\nВведите длину слов: ", line);
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine($"{string.Join(" ", Regex.Matches(line, @"\w+").Cast<Match>().Where(t => t.Length == length))}");

        }
    }
}
