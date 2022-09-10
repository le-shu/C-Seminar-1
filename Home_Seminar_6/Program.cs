Console.Clear();
Console.WriteLine("Введите номер задачи (41, 43): ");
int a = Convert.ToInt32(Console.ReadLine());

if (a == 41)
{
    Task41();
}
else if (a == 43)
{
    Task43();
}
else
{
    Console.WriteLine("Неверный ввод");
}

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void Task41()
{
    Console.Write("Введите размер массива: ");
    int elementsCount = Convert.ToInt32(Console.ReadLine());

    int[] myArray = new int[elementsCount];

    for (int i = 0; i < myArray.Length; i++)
    {
        Console.Write($"Введите элемент массива под индексом {i}: ");
        myArray[i] = Convert.ToInt32(Console.ReadLine());
    }

    Console.WriteLine("Вывод массива: " +String.Join(" ", myArray));

    int count = 0;
    for (int i = 0; i < myArray.Length; i++)
    {
        if (myArray[i] > 0)
        count++;
    }
    Console.Write($"Количество положительных значений массива: {count}");
}

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void Task43()
{
    Console.WriteLine("Введите число b1: ");
    int b1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите число k1: ");
    int k1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите число b2: ");
    int b2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите число k2: ");
    int k2 = Convert.ToInt32(Console.ReadLine());

    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;

    Console.WriteLine($"Прямые пересекаются в точке: ({x}, {y})");
}
