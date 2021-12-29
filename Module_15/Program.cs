using System;
using System.Collections.Generic;
using System.Linq;

namespace Module_15
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowUniqueLettersWithOutRepeatInResultCollectionByLINQ();
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
    }
}
 