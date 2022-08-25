// Задача 13: Напишите программу, которая выводит
// третью цифру заданного числа или сообщает, что третьей
// цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Укажите число: ");
int number = Convert.ToInt32(Console.ReadLine());

void ThirdNumber (int number)
{
    int Number3 = 0;

    if ((number > -100) && (number < 100))
    {
        Console.WriteLine("Третьей цифры нет."); 
    }
    else
    {
        while (number < -999 || number > 999)
        {
            number = number / 10;
        }
        Number3 = number % 10;

   if (Number3 < 0)
   {
    Number3 = Number3*(-1);
   }
   Console.WriteLine($"Третья цифра числа: {Number3}");
}
}
ThirdNumber (number);