// 7. Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.Write("Enter number: ");

int number = Convert.ToInt32(Console.ReadLine());

if(((number / 100) > 0) && ((number / 1000) < 1) )
{
int lastNumber = number % 10;
System.Console.WriteLine( "Last number: "+ lastNumber);
}
else
{
    System.Console.WriteLine("Bad number");
}