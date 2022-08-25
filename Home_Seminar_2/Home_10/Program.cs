// Задача 10: Напишите программу, которая принимает на
// вход трёхзначное число и на выходе показывает вторую
// цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int number;

while (true)
{
    try
    {
        Console.Write("Укажите число: ");
        number = Convert.ToInt32(Console.ReadLine());
        
        if(number >99 && number < 1000)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ошибка ввода. Введите корректное число.");
        }
        
    }catch (FormatException)
    {
        Console.WriteLine("Ошибка ввода. Введите корректное число.");
    }
}

// Решение без метода:

int result = ((number / 10) % 10);
Console.WriteLine($"Вторая цифра числа {number} - {result}");

// Решение с помощью метода:

void SecondNumber (int number)
{
    int Number1 = (number / 10) % 10;
    Console.WriteLine($"Вторая цифра числа {number} - {Number1}");
}
SecondNumber (number);