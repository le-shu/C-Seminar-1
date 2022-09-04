// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

bool SearchNumber()
{
    Console.WriteLine("Введите длину массива: ");
    int length = Convert.ToInt32(Console.ReadLine());

    int [] Array = new int [length];
    bool numInArr = false;

    Console.WriteLine("Введите число от -100 до 100: ");
    int number = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i < length; i++)
    {
        Array[i] = new Random().Next(-100, 101);
    }
    Console.WriteLine(String.Join(", ", Array));

    for (int i = 0; i< Array.Length; i++)
        {
            if ((Array[i] == number))
            {
                numInArr = true;
            }
        }
        return numInArr;
}

Console.WriteLine(SearchNumber());