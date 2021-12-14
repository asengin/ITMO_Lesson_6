using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Text_Delete_
{
    class Program
    {
        /*
         * Дана строка S. Из строки требуется удалить текст, заключенный в фигурные скобки. В строке может быть несколько 
         * фрагментов, заключённых в фигурные скобки. Возможно использование вложенных фигурных скобок, необходимо, чтобы 
         * программа это учитывала.
         * 
         * Вариант простой.
         */
        static void Main(string[] args)
        {
            Console.Write("Введите строку. В [ ] укажите часть для удаления: ");
            string enteredString = Console.ReadLine();
            int countSymbols = enteredString.LastIndexOf(']') - enteredString.IndexOf('[') + 1; //Количество символов между скобками
            if (enteredString.Contains('['))
            {
                string resultString = enteredString.Remove(enteredString.IndexOf('['), countSymbols);
                Console.WriteLine($"Результат: {resultString}");
            }
            else
                Console.WriteLine($"Строка без изменений: {enteredString}");
            Console.ReadKey();

        }
    }
}
