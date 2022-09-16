Console.Clear();
Console.WriteLine("Введите номер задачи (54, 56, 58, 60, 62): ");
int a = Convert.ToInt32(Console.ReadLine());

if (a == 54)
{
    Task54();
}
else if (a == 56)
{
   Task56();
}
else if (a == 58)
{
   Task58();
}
else if (a == 60)
{
   Task60();
}
else if (a == 62)
{
   Task62();
}
else
{
    Console.WriteLine("Неверный ввод");
}

// Задача 54: Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.

void Task54()
{
    Console.Clear();
    
    Console.Write("Введите количество строк массива: ");
    int rows = int.Parse(Console.ReadLine());

    Console.Write("Введите количество столбцов массива: ");
    int columns = int.Parse(Console.ReadLine());

    int[,] array = GetArrayDouble(rows, columns, 0, 10);

    PrintArray(array);
    Console.WriteLine();

    int[] row = new int[columns];
    for (int i = 0; i < rows; i++)
    {
         for (int j = 0; j < columns; j++)
        {
            row[j] = array[i, j];
        }
        BubbleSort(row);
        Console.WriteLine(String.Join(" ", row));
    }
}

void BubbleSort(int[] inArray) // по убыванию
{
    for (int i = 0; i < inArray.Length; i++)
        {
            for (int j = 0; j < inArray.Length - i - 1; j++)
            {
                if (inArray[j] < inArray[j + 1]) // (inArray[j] > inArray[j + 1]) - по возрастанию
                {
                    int temp = inArray[j];
                    inArray[j] = inArray[j + 1];
                    inArray[j + 1] = temp;
                }
            }
        }
 }

// Задача 56: Задайте прямоугольный двумерный массив. Напишите
// программу, которая будет находить строку с наименьшей суммой элементов.

void Task56()
{
    Console.Clear();
    int[,] array = GetArrayDouble(6, 4, 0, 10);

    PrintArray(array);
    Console.WriteLine();

    int[] Sum = new int[6];
    int SumMin = 60;
    int count = 1;
    int MinRow = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Sum[i] = 0;
        
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Sum[i] = Sum[i] + array[i, j];
        }

        if (Sum[i] < SumMin)
        {
            SumMin = Sum[i];
            MinRow = count;            
        }

        count++;
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов: {MinRow}");
}

// Задача 58: Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц.

void Task58()
{
    Console.Clear();

    Console.Write("Введите количество строк массива 1: ");
    int rows = int.Parse(Console.ReadLine());

    Console.Write("Введите количество столбцов массива 1: ");
    int columns = int.Parse(Console.ReadLine());

    int[,] array1 = GetArrayDouble(rows, columns, 0, 10);

    Console.Clear();
    PrintArray(array1);
    Console.WriteLine();

    int[,] array2 = GetArrayDouble(columns, rows, 0, 10);

    PrintArray(array2);
    Console.WriteLine();

    PrintArray(Multiplication(array1, array2));
}

int[,] Multiplication(int[,] inArray1, int[,] inArray2)
{
    int[,] NewArray = new int[inArray1.GetLength(0), inArray2.GetLength(1)];

            for (int i = 0; i < inArray1.GetLength(0); i++)
            {
                for (int j = 0; j < inArray2.GetLength(1); j++)
                {
                    for (int k = 0; k < inArray2.GetLength(0); k++)
                    {
                        NewArray[i,j] = NewArray[i,j] + inArray1[i,k] * inArray2[k,j];
                    }
                }
            }
            return NewArray;
}

// Задача 60: Сформируйте трёхмерный массив из неповторяющихся 
// двузначных чисел. Напишите программу, которая будет построчно выводить
// массив, добавляя индексы каждого элемента.

void Task60()
{
    Console.Clear();

    Console.Write("Введите количество строк массива: ");
    int rows = int.Parse(Console.ReadLine());

    Console.Write("Введите количество столбцов массива: ");
    int columns = int.Parse(Console.ReadLine());

    Console.Write("Введите количество уровней массива: ");
    int depth = int.Parse(Console.ReadLine());

    int[,,] array = GetArrayTriple(rows, columns, depth, 10, 99);

    IEnumerator<int> iterator = UniqueRandomNumbers(10, 90).GetEnumerator();

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (!iterator.MoveNext())
                {
                    Console.WriteLine("Уникальные числа закончились!");
                    return;
                }

                array[i, j, k] = iterator.Current;
            }
    Console.Clear();
    PrintArray2(array);
    Console.WriteLine();
}

IEnumerable<int> UniqueRandomNumbers(int from, int to)
{
    Random rand = new();
    int[] values = Enumerable.Range(from, to).ToArray();
    int i = values.Length;
    while (i > 0)
    {
        int j = rand.Next(i--);
        yield return values[j];
 
        (values[i], values[j]) = (values[j], values[i]);
    }
}

int[,,] GetArrayTriple(int a, int b, int c, int minValue, int maxValue)
{
    int[,,] result = new int[a, b, c];

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int x = 0; x < result.GetLength(1); x++)
            {
                result[i, j, x] = new Random().Next(minValue, maxValue + 1);
            }
        }
    }
    return result;
}


void PrintArray2(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int h = 0; h < inArray.GetLength(2); h++)
            {
            Console.Write($"{inArray[i, j, h]} ({i}, {j}, {h}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}


// Задача 62: Заполните спирально массив 4 на 4.

void Task62()
{
    Console.Clear();

    int[,] Array = GetArrayDouble(4, 4, 0, 0);

    Console.Clear();
    
    PrintArray(Spiral(Array));
}

int[,] Spiral(int[,] array)
{
    int count = 0;
    int i = 0;

    for (int j = 0; j < array.GetLength(1); j++)
    {
        count++;
        array[i, j] = count;
    }

    int m = 3;

    for (int k = 1; k < array.GetLength(0); k++)
    {
        count++;
        array[k, m] = count;
    }

    int a = 3;

    for (int b = 2; b >= 0; b--)
    {
        count++;
        array[a, b] = count;
    }

    int c = 0;

    for (int d = 2; d > 0; d--)
    {
        count++;
        array[d, c] = count;
    }

    int e = 1;

    for (int f = 1; f < 3; f++)
    {
        count++;
        array[e, f] = count;
    }

    int h = 2;

    for (int g = 2; g > 0; g--)
    {
        count++;
        array[h, g] = count;
    }
    return array;
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