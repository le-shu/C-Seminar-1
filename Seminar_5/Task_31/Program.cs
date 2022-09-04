// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива. Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна -20.

void SumPosNeg()
{
    int [] Array = new int [12];
    int SumPos = 0;
    int SumNeg = 0;

    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = new Random().Next(-9, 10);

        if (Array[i] > 0)
        {
            SumPos = SumPos + Array[i];
        }
        else
        {
            SumNeg = SumNeg + Array[i];
        }
    }

    Console.Write("Случайный массив: ");
    Console.WriteLine(String.Join(", ", Array));
    Console.WriteLine($"Сумма отрицательных {SumNeg}");
    Console.WriteLine($"Сумма положительных {SumPos}");    
}
SumPosNeg();