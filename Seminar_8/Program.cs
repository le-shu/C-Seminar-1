Console.WriteLine("Введите номер задачи (53, 55, 57, 59, 61): ");
int a = Convert.ToInt32(Console.ReadLine());

if (a == 53)
{
    Task53();
}
else if (a == 55)
{
   Task55();
}
//else if (a == 57)
//{
//   Task57();
//}
else if (a == 59)
{
    Task59();
}
else if (a == 61)
{
    Task61();
}
else
{
    Console.WriteLine("Неверный ввод");
}

// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

void Task53()
{
    int[,] array = SwapArray(CreateRandomTwoDimensionalArray());
    PrintArray(array);
}


int[,] CreateRandomTwoDimensionalArray()
{
    Random random = new Random();
    int rows = random.Next(3, 5);
    int columns = random.Next(3, 5);
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = random.Next(0, 10);
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return array;
}

int[,] SwapArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
            var temp = arr[arr.GetLength(0) - 1, i];
            arr [arr.GetLength(0) - 1, i] = arr[0, i];
            arr[0, i] = temp;
        }
    return arr;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для пользователя.

int[,] CreateRandomTwoDimensionalArray1()
{
    Random random = new Random();
    int rows = random.Next(5, 6);
    int columns = random.Next(5, 6);
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = random.Next(0, 10);
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return array;
}

int[,] SwapArray1(int[,] arr)
{
    int row = arr.GetLength(0);
    int columns = arr.GetLength(1);
    int[,] arrNew = new int[row, columns];
    if (row != columns)
    {
        Console.WriteLine("Ошибка");
        return new int[1,1];
    }
    else
    {
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                arrNew[j, i] = arr[i, j];
            }
        }
        return arrNew;
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void Task55()
{
    int[,] array = SwapArray1(CreateRandomTwoDimensionalArray1());
    PrintArray(array);
}

// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент входных данных.

void GetArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}
void PrintArray(int[,] array)
{
    Console.Clear();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
Random rnd = new Random();
int m = rnd.Next(6, 10);
int n = rnd.Next(6, 10);
int[,] array = new int[m, n];

GetArray(array);
PrintArray(array);
Console.WriteLine();
Рамон Харин: int trg = 0;
int[,] dict = new int[m * n, 2];
int k = 0;

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        trg = 0;
        for (int r = 0; r < k; r++)
        {
            if (dict[r, 0] == array[i, j])
            {
                dict[r, 1]++;
                trg = 1;
                break;
            }

        }
        if (trg == 0)
        {
            //dict = new int[k+1,2] (dict);
            dict[k, 0] = array[i, j];
            dict[k, 1]++;
            k++;
        }
    }
}

for (int i = 0; i < k; i++)
{
    for (int j = 0; j < dict.GetLength(1); j++)
    {
        Console.Write($"{dict[i, j]} ");
    }
    System.Console.WriteLine();
}

// void GetArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }
// void PrintArray(int[,] array)
// {
//     Console.Clear();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// Random rnd = new Random();
// int m = rnd.Next(6, 10);
// int n = rnd.Next(6, 10);
// int[,] array = new int[m, n];

// GetArray(array);
// PrintArray(array);
// Console.WriteLine();
// int trg = 0;
// int[,] dict = new int[m * n, 2];
// int k = 0;

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         trg = 0;
//         for (int r = 0; r < k; r++)
//         {
//             if (dict[r, 0] == array[i, j])
//             {
//                 dict[r, 1]++;
//                 trg = 1;
//                 break;
//             }

//         }
//         if (trg == 0)
//         {
//             //dict = new int[k+1,2] (dict);
//             dict[k, 0] = array[i, j];
//             dict[k, 1]++;
//             k++;
//         }
//     }
// }

// for (int i = 0; i < k; i++)
// {
//     for (int j = 0; j < dict.GetLength(1); j++)
//     {
//         Console.Write($"{dict[i, j]} ");
//     }
//     System.Console.WriteLine();
// }
 
// // решение два.

// public static int[,] SlovArr(int [,] MyArr)
//     {
//         int rows = MyArr.GetLength(0), cols = MyArr.GetLength(1);
//         int[,] slovar = new int[2, rows*cols];
//         int count = 0;   //количество разных цифр в массиве
//         slovar[0,0] =MyArr[0,0];
//         for ( int i = 0; i < rows; i++ )
//         {
//             for (int j = 0; j < cols; j++)
//             {
//                 for (int k = 0; k < rows*cols; k++)
//                 {
//                     if  (slovar[0,k] == MyArr[i,j])
//                     {
//                         slovar [1, k] ++;
//                         break;
//                     } 
//                     else 
//                     {
//                         count++;
//                         slovar[0, count] = MyArr[i,j];
//                         slovar[1, count] = 1;
//                     }
//                 }
//             }
//         }

//         return slovar;
//     }


// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент массива.

// Задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника



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
