// Задача 29: Напишите программу, которая задаёт массив из введенного числа и выводит их на экран.
// пользователь вводит число элементов в массиве и минимальное, и максимальное значение . надо заполнить массив рандоными данными 
// от минимального до максимального значение. И важное уточнениее, делать все в методе который возвращает массив
// 5, 1, 20 -> [1, 2, 5, 7, 19]
// 3, 1, 33 -> [6, 1, 33]

int[] Array()
{
    Console.Write("Введите число элементов в массиве: ");
    int index = int.Parse(Console.ReadLine());

    Console.Write("Введите минимальное значение в массиве: ");
    int min = int.Parse(Console.ReadLine());

    Console.Write("Введите максимальное значение элемента в массиве: ");
    int max = int.Parse(Console.ReadLine());

    int[] array = new int[index];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max+1);
        Console.Write($"{array[i]}  ");
    }
    return array;
}
Array();