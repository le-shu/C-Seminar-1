// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

void AntiArray()
{
    Console.WriteLine("Введите длину массива: ");
    int length = Convert.ToInt32(Console.ReadLine());

    int [] Array = new int [length];
    int [] ArrayNew = new int [length];
    
    for (int i = 0; i < length; i++)
    {
        Array[i] = new Random().Next(-9, 10);
        ArrayNew[i] = Array[i] * (-1);
    }

    Console.Write("Случайный массив: ");
    Console.WriteLine(String.Join(", ", Array));

    Console.Write("Обратный массив: ");
    Console.WriteLine(String.Join(", ", ArrayNew));       
}
AntiArray();