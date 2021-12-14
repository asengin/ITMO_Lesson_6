using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Palindrom
{
    class Program
    {
        /*
         * Обязательная задача*. Ввести с клавиатуры предложение. Предложение представляет собой слова, разделенные 
         * пробелом. Знаки препинания не используются. Составить программу, определяющую является ли строка палиндромом 
         * без учёта пробелов и регистра (пример палиндрома – «А роза упала на лапу Азора»).
         * 
         * Логика работы:
         * Считывание строки -> преобразование (все в нижний регистр, удаление пробелов) -> в массив знаков методом
         * ToCharArray -> Метод Reverse класса Array -> Сравнение до реверса и после, метод Equals -> Вывод
         */
        static void Main(string[] args)
        {
            Console.Write("Введите предложение: ");
            string enteredString = Console.ReadLine().ToLower().Replace(" ", ""); //в нижний регистр, убраны пробелы
            char[] stringArray = enteredString.ToCharArray(); //перевод в массив символов
            Array.Reverse(stringArray); 
            string reverseString = new string(stringArray);
            Console.WriteLine($"Преобразованная строка: {enteredString}");
            Console.WriteLine($"Реверсная строка: {reverseString}");
            Console.WriteLine(Equals(enteredString, reverseString)?"Введенная строка палиндром!":"Введенная строка не палиндром");
            Console.ReadKey();
        }
    }
}
