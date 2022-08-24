// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int number1 = 2;
while(number2 >= number1)
{
     Console.Write(number1);
     number1 = (number1 + 2);
}

// Вариант преподавателя:
// for (int i = 2; i <=number1; i+=2);
// {
     // Console.Write(i + " ");
// }

// Вариант преподавателя №2:
// for (int i = 1; i <=number1; i++);
// {
     // if (i % 2 == 0)
     // Console.Write(i + " ");
// }


// string str = $"hello {number1}";