Console.WriteLine("Введите номер задачи (39, 40, 42, 44, 45): ");
int a = Convert.ToInt32(Console.ReadLine());

if (a == 39)
{
    Task39();
}
else if (a == 40)
{
    Task40();
}
else if (a == 42)
{
    Task42();
}
else if (a == 44)
{
    Task44();
}
else if (a == 45)
{
    Task45();
}
else
{
    Console.WriteLine("Неверный ввод");
}




// Задача 39: Напишите программу, которая перевернёт одномерный массив
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

void Task39()
{
    Console.Clear();
    
    int[] array = new int[10];
    for (int i = 0; i < 10; i++)
    {
        array[i] = new Random().Next(0, 11);
    }

    Console.WriteLine();
    Console.WriteLine("Исходный массив: " + String.Join(" ", array));
    ReversArray1(array);
    Console.WriteLine("Перевернутый массив: " + String.Join(" ", array));

    Console.WriteLine();
    Console.WriteLine("Исходный массив: " + String.Join(" ", array));
    int[] reversArray = ReversArray2(array);
    Console.WriteLine("Перевернутый массив: " + String.Join(" ", reversArray));
}

void ReversArray1 (int[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        int NewTemp = Array[i];
        Array[i] = Array[Array.Length-1-i];
        Array[Array.Length-1-i] = NewTemp;
    }
}

int[] ReversArray2 (int[] Array)
{
    int[] result = new int[Array.Length];

    for (int i = 0; i < Array.Length; i++)
    {
        result[i] = Array[Array.Length-1-i];
    }
    return result;
}

// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

void Task40()
{
    Console.WriteLine("Введите длину 1: ");
    int a = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите длину 2: ");
    int b = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите длину 3: ");
    int c = Convert.ToInt32(Console.ReadLine());

    if(((a+b)>c)&&((a+c)>b)&&((b+c)>a))
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}

//  42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

void Task42()
{
    Console.WriteLine("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine();

    int value = number;
    int count = 0;
    int a = number;

    while (a != 0)
    {
        a = a / 2;
        count++;
    }
    int[] Binarr = new int[count];

    count--;
    while (number != 0)
    {
        Binarr[count] = number % 2;
        number = number / 2;
        count--;
    }
    Console.WriteLine(String.Join("", Binarr));

    string binary = Convert.ToString(value, 2);            // перевод в двоичное число
    System.Console.WriteLine(binary);
}

// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

void Task44()
{
    Console.WriteLine("Введите число: ");
    int N = Convert.ToInt32(Console.ReadLine());
    
    int[] array = new int[N];
    array[0] = 0;
    array[1] = 1;
    
    for (int i = 2; i < N; i++)
    {
        array[i] = array[i-1] + array[i-2];
    }

    Console.WriteLine(String.Join(" ", array));
}

// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int[] CopyArray (int[] arr)
{
    int[] copy = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        copy[i] = arr[i];
    }
    return copy;
}


void Task45()
{
    int[] array = new int[10];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 101);
    }
    int[] array2 = CopyArray(array);
    Console.WriteLine("Исходный массив: " +String.Join(" ", array));
    Console.WriteLine("Копия: " +String.Join(" ", array2));

}