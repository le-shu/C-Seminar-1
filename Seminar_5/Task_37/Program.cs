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
    int [] ArrayNew = new int [length/2];;

    for (int i = 0; i < (length/2); i++)
    {
        Array[i] = new Random().Next(-100, 101);
        ArrayNew[i] = (Array[i] * Array[length-1-i]);
    }
    Console.WriteLine(String.Join(" ", ArrayNew));
}
MultArrayElements();