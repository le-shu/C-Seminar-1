// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

void CountNumbers()
{
    int [] Array = new int [20];
    int count = 0;
        
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = new Random().Next(100, 1000);
        
        if ((Array[i] % 2) == 0)
        {
            count++;
        }
    }
    Console.WriteLine(String.Join(", ", Array));
    Console.Write($"Количество четных чисел: {count}");   
}
CountNumbers();