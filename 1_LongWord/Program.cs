using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_LongWord
{
    class Program
    {
        /*
         * Обязательная задача*. Ввести с клавиатуры предложение. Предложение представляет собой слова, разделенные пробелом. 
         * Знаки препинания не используются. Найти самое длинное слово в строке.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение: ");
            string enteredString = Console.ReadLine();
            string[] arrayWords = enteredString.Split();
            string longestWord = "";
            foreach (string s in arrayWords)
            {
                if (s.Length > longestWord.Length)
                    longestWord = s;
            }
            Console.WriteLine($"Самое длинное слово в строке: {longestWord}");
            Console.ReadKey();
        }
    }
}
