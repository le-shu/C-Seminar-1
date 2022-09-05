// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void SumElem()
{
    int [] Array = new int [5];
    int Sum = 0;

    for (int i = 1; i < Array.Length; i++)
    {
        Array[i] = new Random().Next(-100, 100);

        if (((i % 2) > 0) || ((i % 2) < 0))
        {
            Sum = Sum + Array[i];
        }
    }

    Console.Write("Случайный массив: ");
    Console.WriteLine(String.Join(", ", Array));

    Console.WriteLine($"Сумма элементов: {Sum}");
}
SumElem();