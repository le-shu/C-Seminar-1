// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 1 && number <= 7)
{
    if (number >= 1 && number <= 5)
    {
        Console.WriteLine("нет");
    }

    if (number >= 6 && number <= 7)
    {
        Console.WriteLine("да");
    }
}
else
{
    Console.WriteLine("Ошибка ввода. Введите корректное число.");
}