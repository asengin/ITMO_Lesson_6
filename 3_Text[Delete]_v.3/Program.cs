using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Text_Delete__v._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string enteredString = Console.ReadLine();
            int strLenght = enteredString.Length;
            const char openChar = '[';
            const char closeChar = ']';
            int[] openChars = new int[strLenght]; //Массив индексов открывающихся скобок
            int[] closeChars = new int[strLenght]; //Массив индексов закрывающихся скобок
            int indOpenString = 0; //Счетчик для открытых скобок
            int indCloseString = 0; // Счеттчик для закрытых скобок

            if (enteredString.Contains(openChar) && enteredString.Contains(closeChar))
            {
                //Console.WriteLine("Обработка строк");
                for (int i = 0; i < strLenght; i++) //Формирование массивов открытых и закрытых скобок
                {
                    if (enteredString[i] == openChar)
                        openChars[indOpenString++] = i; //Нашли открытую скобку, занесли позициюы в массив, увеличили счетчик массива
                    if (enteredString[i] == closeChar)
                        closeChars[indCloseString++] = i; //Аналогично с закрытой скобкой
                }
                Console.WriteLine($"Открытых скобок: {indOpenString}. Закрытых скобок: {indCloseString}");
                Array.Resize(ref openChars, indOpenString); //Обрезали массивы до найденных значений
                Array.Resize(ref closeChars, indCloseString);

                int minDist = strLenght; //Минимальная дистанция. Начальное значение длина строки
                int m = 0; int n = 0; //Счетчики циклов
                while (m <= closeChars.Length - 1)
                {
                    while (openChars[n] < closeChars[m])
                    {
                        //(closeChars[m] - openChars[n] < minDist) ?
                        if (closeChars[m] - openChars[n] < minDist)
                            minDist = closeChars[m] - openChars[n];
                        if (n == openChars.Length - 1)
                            break;
                        n++;
                    }
                     //действие над строкой (замена скобок произвольным символом или сразу удаление
                    Console.WriteLine($"Минимальная дистанция между {m + 1}-й закрытой и {n}-й открытой: {minDist}");
                    minDist = strLenght;
                    m++;
                }
            }
            else
                Console.WriteLine($"Строка без изменений: {enteredString}");

            Console.ReadKey();
        }
    }
}
