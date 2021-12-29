using System;
using System.Collections.Generic;
using System.Linq;

namespace Module_15
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowCalculateFactorialByLINQAggregateMethods();
        }

        private static void SearchCommonLetters()
        {
            string firstWord = "one";
            string secondWord = "two";

            var result = firstWord.Intersect(secondWord);

            foreach (var elem in result)
            {
                Console.WriteLine(elem);
            }
        }

        private static void ShowUnionWithOutRepeat()
        {
            var softwareManufacturers = new List<string>()
            {
               "Microsoft", "Apple", "Oracle"
            };

            var hardwareManufacturers = new List<string>()
            {
               "Apple", "Samsung", "Intel"
            };

            var itCompanies = softwareManufacturers.Union(hardwareManufacturers);

            foreach (var company in itCompanies) Console.WriteLine(company);
        }

        private static void ShowUniqueLettersWithOutRepeatInResultCollectionByLINQ()
        {
            Console.WriteLine("Введите текст:");
            var message = Console.ReadLine();

            if (string.IsNullOrEmpty(message.Trim()))
            {
                Console.WriteLine("Введена пустая строка");
                return;
            }

            var punctuation = ",.;:?! ";

            var messageWithOutPunctuation = message.Except(punctuation);

            Console.WriteLine(messageWithOutPunctuation.ToArray());
        }

        private static void ShowCalculateFactorialByLINQAggregateMethods()
        {
            Console.WriteLine("Введите число для посдчета факториала:");

            if (!int.TryParse(Console.ReadLine(), out int intNumber))
            { Console.WriteLine("Неверный формат данных"); return; }

            List<int> numbers = new List<int>();

            for (int i = 1; i <= intNumber; i++) numbers.Add(i);

            long result = numbers.Aggregate((x,y) => x * y);

            Console.WriteLine($"Факториал числа {intNumber} = {result}");
        }
    }
}
 