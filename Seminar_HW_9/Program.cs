Console.Clear();
Console.WriteLine("Введите номер задачи (64, 66, 68): ");
int a = Convert.ToInt32(Console.ReadLine());

if (a == 64)
{
    Task64();
}
else if (a == 66)
{
   Task66();
}
else if (a == 68)
{
   Task68();
}
else
{
    Console.WriteLine("Неверный ввод");
}

//Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

//M = 1; N = 5. -> ""1, 2, 3, 4, 5""
//M = 4; N = 8. -> ""4, 6, 7, 8""

void Task64()
{
    Console.Clear();
    
    Console.WriteLine("Введите число M: ");
    int M = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите число N: ");
    int N = Convert.ToInt32(Console.ReadLine());

    if (M < N)
        for (int i = M; i <= N; i++)
            Console.Write($"{i}, ");
    else
        for (int i = N; i <= M; i++)
            Console.Write($"{i}, ");
}

//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

void Task66()
{
    Console.Clear();
    
    Console.WriteLine("Введите число M: ");
    int M = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите число N: ");
    int N = Convert.ToInt32(Console.ReadLine());
    int Sum = 0;

    if (M < N)
        for (int i = M; i <= N; i++)
        {
            Sum = Sum + i;
        }
    else
        for (int i = N; i <= M; i++)
        {
            Sum = Sum + i;
        }
    Console.WriteLine($"Сумма натуральных элементов в промежутке между {M} и {N}: {Sum}");
}

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

//m = 2, n = 3 -> A(m,n) = 29

void Task68()
{
    Console.Clear();
    
    Console.WriteLine("Введите число M: ");
    int M = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите число N: ");
    int N = Convert.ToInt32(Console.ReadLine());
        
    Console.WriteLine($"Функция Аккермана: {Akkerman(M, N)}");
}

int Akkerman(int m, int n)
{
  if (m == 0) 
  return n + 1;

  else if (n == 0) 
  return Akkerman(m - 1, 1);

  else 
  return Akkerman(m - 1, Akkerman(m, n - 1));
}