// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


void DiffElements()
{
    int j = new Random().Next(2, 10);
    double[] Array = new double[j];
    
    for (int i = 0; i < Array.Length; i++)
    {
        Array [i] = new Random().NextDouble(); 
    }

    Console.Write("Случайный массив: ");
    Console.WriteLine(String.Join(", ", Array));

    double max = 0;
    double min = 1;
    double dif = 0;
    
    for (int i = 0; i < Array.Length; i++)
    {
    if (Array[i] > max)
        {
            max = Array[i];
        }
    
    if (Array[i] < min)
        {
            min = Array[i];
        }
    }
    dif = max - min;
 

    Console.WriteLine($"Разница элементов: {(max-min)}");  
}

DiffElements();