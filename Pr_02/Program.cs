using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Pr_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Даны два целых положительных числа A и B (число A меньше числа B). Найти произведение всех четных чисел расположенных между этими числами A и B.
            // Даны два целых положительных числа A и B (число A меньше числа B). Найти произведение всех четных чисел расположенных между этими числами A и B.
            m1:
            try {
                Console.WriteLine("Введите число A");
                int A = Convert.ToInt32(Console.ReadLine());
                if (A % 1 == 0 && A > 0)
                {
                    Console.WriteLine("Введите число B");
                    int B = Convert.ToInt32(Console.ReadLine());
                    if (B % 1 == 0 && B > 0)
                    {
                        int product = 1;
                        for (int i = A + 1; i < B; i++)
                        {
                            if (i % 2 == 0) 
                            {
                                product *= i; 
                            }
                        }
                        Console.WriteLine($"Произведение четных чисел между {A} и {B} равно: {product}");
                    }
                    else
                    {
                        Console.WriteLine("Число B должно быть целым и положительным!");
                    }
                }
                else
                {
                    Console.WriteLine("Число A должно быть целым и положительным!");
                }
            }
            catch(FormatException e){
                Console.WriteLine(e.Message);
                Console.WriteLine("Не вводим строку!!");
                goto m1;
            }
            Console.ReadKey();

            // Даны ненулевые числа x, y. Проверить истинность высказывания: «Точка с координатами (x, y) лежит во второй координатной четверти».
            m2:
            try
            {
                Console.WriteLine("Введите пятизначное положительное число:");
                int number = int.Parse(Console.ReadLine());

                if (number >= 10000 && number <= 99999)
                {
                    bool[] digits = new bool[10];

                    int temp = number;
                    bool allDigitsUnique = true;

                    while (temp > 0)
                    {
                        int digit = temp % 10;
                        if (digits[digit]) // Если цифра уже встречалась
                        {
                            allDigitsUnique = false;
                            break;
                        }
                        digits[digit] = true;
                        temp /= 10;
                    }

                    if (allDigitsUnique)
                    {
                        Console.WriteLine("Все цифры данного числа различны.");
                    }
                    else
                    {
                        Console.WriteLine("Не все цифры данного числа различны.");
                    }
                }
                else
                {
                    Console.WriteLine("Введенное число не является пятизначным.");
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Введите число");
                goto m2;
            }
            Console.ReadKey();
            // Дано целое положительное пятизначное число N (N > 0). Найти разницу между суммой всех его цифр и произведением четных цифр.
            m3: 
            try {
                Console.WriteLine("Введите пятизначное положительное число:");
                int number = int.Parse(Console.ReadLine());

                if (number >= 10000 && number <= 99999) 
                {
                    int sumOfDigits = 0;
                    int productOfEvenDigits = 1;

                    int temp = number;

                    while (temp > 0)
                    {
                        int digit = temp % 10;
                        sumOfDigits += digit;

                        if (digit % 2 == 0)
                        {
                            productOfEvenDigits *= digit;
                        }

                        temp /= 10;
                    }

                    int difference = sumOfDigits - productOfEvenDigits;
                    Console.WriteLine($"Разница между суммой всех цифр и произведением четных цифр: {difference}");
                }
                else
                {
                    Console.WriteLine("Введенное число не является пятизначным.");
                }
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Введите число!");
                goto m3;
            }
            Console.ReadKey();
            // Даны ненулевые числа x, y. Проверить истинность высказывания: «Точка с координатами (x, y) лежит во второй координатной четверти».
            m4:
            try {
                Console.WriteLine("Введите координату x:");
                double x = double.Parse(Console.ReadLine());

                Console.WriteLine("Введите координату y:");
                double y = double.Parse(Console.ReadLine());

                bool isSecondQuadrant = (x < 0) && (y > 0);

                if (isSecondQuadrant)
                {
                    Console.WriteLine("Точка лежит во второй координатной четверти.");
                }
                else
                {
                    Console.WriteLine("Точка не лежит во второй координатной четверти.");
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Введите число!");
                goto m4;
            }
            Console.ReadKey();
            // Дано целое число N в диапазоне от -9000 до 9000. Вывести строку-описание данного числа, например: "положительное четырехзначное число" или "отрицательное двузначное".
            m5:
            try {
                Console.WriteLine("Введите число в диапазоне от -9000 до 9000");
                int N = int.Parse(Console.ReadLine());
                if (N > 9000 || N < -9000)
                {
                    if (N == 0)
                    {
                        Console.WriteLine("нулевое число");
                    }
                    else if (N < 0)
                    {
                        Console.Write("отрицательное ");
                        N *= -1;
                    }
                    else
                    {
                        Console.Write("положительное ");
                    }

                    if (N >= 1000)
                    {
                        Console.WriteLine("четырехзначное число");
                    }
                    else if (N >= 100)
                    {
                        Console.WriteLine("трехзначное число");
                    }
                    else if (N >= 10)
                    {
                        Console.WriteLine("двузначное число");
                    }
                    else
                    {
                        Console.WriteLine("однозначное число");
                    }
                }
                else {
                    Console.WriteLine("Вы не попали в диапазон");
                    goto m5;
                }
            }
            catch (FormatException e) { 
            Console.WriteLine(e.Message);
            Console.WriteLine("Введите число!");
            goto m5;
            }
            Console.ReadKey();
        }
    }
    }

