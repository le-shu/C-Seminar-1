// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.Write ("Введите число: ");
int num = int.Parse(Console.ReadLine());

int GetSumNums1 (int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum += num % 10;
        num /= 10;
    }
    return sum;
}

Console.WriteLine ($"Сумма цифр = {GetSumNums1(num)}");

int GetSumNums2 (int num)
{
    int result = 0;

    for (int i = 1; i <= num; i++)
    {
        result += i;
    }
    return result;
}

Console.WriteLine ($"Сумма значений от 1 до {num} = {GetSumNums2(num)}");