Console.WriteLine("Введите номер задачи (46, 48, 49, 51): ");
int a = Convert.ToInt32(Console.ReadLine());

if (a == 46)
{
    Task46();
}
else if (a == 48)
{
   Task48();
}
else if (a == 49)
{
   Task49();
}
else if (a == 51)
{
    Task51();
}
else
{
    Console.WriteLine("Неверный ввод");
}


// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

void Task46()
{
    Console.Clear();

    Console.Write("Введите количество строк массива: ");
    int m = int.Parse(Console.ReadLine());

    Console.Write("Введите количество столбцов массива: ");
    int n = int.Parse(Console.ReadLine());

    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(-100, 100);
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₙₙ = m+n.
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

void Task48()
{
  Console.Clear();

    Console.Write("Введите количество строк массива: ");
    int m = int.Parse(Console.ReadLine());

    Console.Write("Введите количество столбцов массива: ");
    int n = int.Parse(Console.ReadLine());

    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = i+j;
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    } 
}

// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.

// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Новый массив будет выглядеть
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

void Task49()
{
    Console.Clear();

    Console.Write("Введите количество строк массива: ");
    int m = int.Parse(Console.ReadLine());

    Console.Write("Введите количество столбцов массива: ");
    int n = int.Parse(Console.ReadLine());

    int[,] array = new int[m, n];
    Console.WriteLine("Исходный массив: ");
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(-100, 100);
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine("Измененный массив: ");

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if ((i % 2 == 0) && (j % 2 == 0))
            {
                array[i, j] = (array[i, j]) * (array[i, j]);
                Console.Write($"{array[i, j]} ");
            }
            else 
            {
                Console.Write($"{array[i, j]} ");
            }
        }
        Console.WriteLine();
    }
}

// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

void Task51()
{
    Console.Clear();

    Console.Write("Введите количество строк массива: ");
    int m = int.Parse(Console.ReadLine());

    Console.Write("Введите количество столбцов массива: ");
    int n = int.Parse(Console.ReadLine());

    int[,] array = new int[m, n];
    Console.WriteLine("Исходный массив: ");
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(-100, 100);
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }

    int Sum = 0;
   
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if ((i == j))
            {
               Sum = Sum + array[i, j];
            }
        }
    }
    Console.WriteLine($"Сумма элементов главной диагонали: {Sum}");
}