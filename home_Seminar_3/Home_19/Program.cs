using System;

namespace Home3
{
    class TestMetods
    {
        public static void Main(string[] args)
        {
            // Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
            // 14212 -> нет
            // 23432 -> да
            // 12821 -> да

            static void Palindrome ()
            {
            int number;
           
            while (true)
            {
                try
                {
                    Console.Write("Укажите пятизначное число: ");
                    number = Convert.ToInt32(Console.ReadLine());

                    if(number >9999 && number < 100000)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка ввода. Введите корректное число.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка ввода. Введите корректное число.");
                }
            }

            if (((number % 10) == (number / 10000)) && (((number / 10) % 10) == ((number / 1000) % 10)))
            {
                Console.WriteLine($"Число {number} является палиндромом."); 
            }
            else
            {
                Console.WriteLine($"Число {number} не является палиндромом."); 
            }
            }
            Palindrome ();
        }
    }
}