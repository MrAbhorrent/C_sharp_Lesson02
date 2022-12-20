using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson02
{
    class Program
    {


        static void Main(string[] args)
        {

            /*
             * Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
             * 456 -> 5
             * 782 -> 8
             * 918 -> 1
             */
            Console.Write("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введено число: " + number);
            Console.WriteLine(" -> " + findDecimalDigit(number));
            Console.WriteLine("=======================================================");
            /* 
             * Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
             * 645 -> 5
             * 78 -> третьей цифры нет
             * 32679 -> 6
             */
            int number1 = 645;
            Console.WriteLine(number1 + " -> " + findDecimalDigit(number1, 3));
            number1 = 78;
            Console.WriteLine(number1 + " -> " + findDecimalDigit(number1, 3));
            number1 = 32679;
            Console.WriteLine(number1 + " -> " + findDecimalDigit(number1, 3));
            Console.WriteLine("=======================================================");
            /* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
             * 6 -> да
             * 7 -> да
             * 1 -> нет
             */

            Console.Write("Введите число: ");
            while (true) 
            {
                int dayOfWeek = Convert.ToInt32(Console.ReadLine());
                if (dayOfWeek >= 1 || dayOfWeek <= 7)
                {
                    if (dayOfWeek >= 6)
                    {
                        Console.WriteLine(dayOfWeek + " -> да");
                    }
                    else
                    {
                        Console.WriteLine(dayOfWeek + " -> нет");
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Введитк число от 1 до 7");
                }
            }
            Console.ReadKey();
        }


        private static String findDecimalDigit(int _number)
        {
            char[] array = Convert.ToString(_number).ToCharArray();
            if (array.Length > 2)
            {
                String decimalDigit = array[array.Length - 2].ToString();
                return decimalDigit;
            }
            else
            {
                return "В числе нет второго разряда";
            }
        }

        private static String findDecimalDigit(int _number, int _position)
        {
            char[] array = Convert.ToString(_number).ToCharArray();
            if (array.Length >= _position)
            {
                String decimalDigit = array[_position - 1].ToString();
                return decimalDigit;
            }
            else
            {
                return "В числе нет разряда в позиции " + _position;
            }
        }

    }
}
