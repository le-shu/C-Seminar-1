// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.WriteLine("Укажите число: ");
int number = Convert.ToInt32(Console.ReadLine());

void Multiple (int number)
{
int number1 = 7, number2 = 23;
int DivNumber = number1 * number2;

if ((number % DivNumber) == 0)
{
    Console.WriteLine($"Число {number} кратно {number1} и {number2}");
}
else
{
    Console.WriteLine($"Число {number} не кратно {number1} и {number2}");
}
}
Multiple (number);