// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5


// 1 решение

Console.Write ("Введите число: ");
int num = int.Parse(Console.ReadLine());

int count = 1;

while (num >= 10)
{
    num = num / 10;
    count++;
}
Console.WriteLine ($"Число цифр =  {count}");

// 2 решение

Console.Write ("Введите число: ");

string number = Console.ReadLine();

int i = number.Length;

Console.WriteLine ($"Число цифр = " +i);