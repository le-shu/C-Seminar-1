// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите число 1: ");

int number = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число 2: ");

int number2 = Convert.ToInt32(Console.ReadLine());

if (number > number2)
{
    Console.WriteLine("max = "+number);
}
if (number2 > number)
{
    Console.WriteLine("max = "+number2);
}
if (number2 == number)
{
    Console.WriteLine("error");
}