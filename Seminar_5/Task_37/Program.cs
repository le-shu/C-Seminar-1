// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

// доделать - не работает


void MultArrayElements()
{
    Console.WriteLine("Введите длину массива: ");
    int length = Convert.ToInt32(Console.ReadLine());

    int [] Array = new int [length];
    int [] ArrayNew;
   
    for (int i = 0; i < Array.Length; i++)
        {
        Array[i] = new Random().Next(-100, 101);
        }

    Console.WriteLine(String.Join(" ", Array));

    for (int j = 0; j < Array.Length/2; j++)
    {
        if ((j % 2) == 0)
        {   
            ArrayNew[j] = (Array[j] * Array[Array.Length-1-j]);
        }

        else
        {
            ArrayNew[j] = (Array[j] * Array[Array.Length-1-j]);
        }
    Console.WriteLine(String.Join(" ", ArrayNew));
    }
}
MultArrayElements();