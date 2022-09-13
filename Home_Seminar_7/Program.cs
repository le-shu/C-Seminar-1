Console.WriteLine("Введите номер задачи (47, 50, 52): ");
int a = Convert.ToInt32(Console.ReadLine());

if (a == 47)
{
    Task47();
}
else if (a == 50)
{
   Task50();
}
else if (a == 52)
{
   Task52();
}
else
{
    Console.WriteLine("Неверный ввод");
}

// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void Task47()
{
    Console.Clear();

    Console.Write("Введите количество строк массива: ");
    int m = int.Parse(Console.ReadLine());

    Console.Write("Введите количество столбцов массива: ");
    int n = int.Parse(Console.ReadLine());

    double[,] array = new double[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Random rnd = new Random();
            int random  = rnd.Next(-1000, 1000);

            array[i, j] = new Random().NextDouble();
            array[i, j] = array[i, j] * random;

            Console.Write($"{Math.Round(array[i, j], 1)} ");
        }
        Console.WriteLine();
    }
}

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void Task50()
{
    Console.Clear();
    
    Console.Write("Введите количество строк массива: ");
    int rows = int.Parse(Console.ReadLine());

    Console.Write("Введите количество столбцов массива: ");
    int columns = int.Parse(Console.ReadLine());

    int[,] array = GetArrayDouble(rows, columns, 0, 10);
    PrintArray(array);

    Console.WriteLine("Введите позицию элемента: ");
    int position = int.Parse(Console.ReadLine());
    int count = 0;
    int ArrPosition = 0;

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            count++;
            if (count == position)
            {
                ArrPosition = array[i, j];
                break;
            }
        }
    }

    if (ArrPosition == 0)
    {
        Console.WriteLine("такого числа в массиве нет");
    }    
    else
    {
        Console.WriteLine($"Значение элемента на позиции {position} - {ArrPosition}");
    }
}

int[,] GetArrayDouble(int rows, int columns, int minValue, int maxValue)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3

void Task52()
{
    Console.Clear();
    
    Console.Write("Введите количество строк массива: ");
    int rows = int.Parse(Console.ReadLine());

    Console.Write("Введите количество столбцов массива: ");
    int columns = int.Parse(Console.ReadLine());

    int[,] array = GetArrayDouble(rows, columns, 0, 10);
    PrintArray(array);

    int[] Sum = new int[columns];

    for (int j = 0; j < columns; j++)
    {
        Sum[j] = 0;

        for (int i = 0; i < rows; i++)
        {
            Sum[j] = Sum[j] + array[i, j];
        }
    }
    Console.WriteLine();

    double[] SumDif = new double[columns];

    for (int i = 0; i < columns; i++)
    {
        SumDif[i] = (Sum[i] / rows);
    }

    Console.WriteLine(String.Join(" ", SumDif));
}