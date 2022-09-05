// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
// второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


void MultArrayElements()
{
    int n = new Random().Next(2, 10);
    int [] Array = new int [n];

    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = new Random().Next(-100, 101);
    }

    Console.WriteLine(String.Join(" ", Array));

    int length = Array.Length/2;

    if ((Array.Length % 2) == 1)
    {
        length ++;
    }

    int [] ArrayNew = new int [length];

    for (int i = 0; i < ArrayNew.Length; i++)
    {
        ArrayNew[i] = (Array[i] * Array[Array.Length - 1 - i]);
    }

    if (Array.Length % 2 == 1) 
    {
        ArrayNew[length-1] = Array[Array.Length / 2];
    }

    Console.WriteLine(String.Join(" ", ArrayNew));   
}

MultArrayElements();