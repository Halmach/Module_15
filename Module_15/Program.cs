﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Module_15
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowHowSumLINQWorking();
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

        private static void ShowHowCountWorking()
        {
            var contacts = new List<Contact>()
            {
               new Contact() { Name = "Андрей", Phone = 79994500508 },
               new Contact() { Name = "Сергей", Phone = 799990455 },
               new Contact() { Name = "Иван", Phone = 79999675334 },
               new Contact() { Name = "Игорь", Phone = 8884994 },
               new Contact() { Name = "Анна", Phone = 665565656 },
               new Contact() { Name = "Василий", Phone = 3434 }
            };

            var result = (from contact in contacts
                          let phoneTemp = contact.Phone.ToString()
                          where phoneTemp.Length != 11 || !phoneTemp.StartsWith('7')
                          select contact).Count();
            
            Console.WriteLine("Количество людей с  неправильными номерами: " + result);
        }

        private static void ShowHowSumLINQWorking()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };

            var result = numbers.Sum() / numbers.Length;

            Console.WriteLine(result);

        }

        private static void ShowHowAllAggregateMethodsWorking()
        {

        }
    }
}
 