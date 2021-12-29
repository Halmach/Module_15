using System;
using System.Linq;

namespace Module_15
{
    class Program
    {
        static void Main(string[] args)
        {
            SearchCommonLetters();
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
    }
}
 