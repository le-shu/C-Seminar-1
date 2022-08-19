// 3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

// Вариант преподавателя 1 и 2

Console.Write("Enter number : ");
int number = Convert.ToInt32(Console.ReadLine());

if(number >= 1 && number <= 7 )
{

switch(number)
{
case 1: System.Console.WriteLine("Monday"); break;

case 2: System.Console.WriteLine("Tuesday"); break;

case 3: System.Console.WriteLine("Wednesday"); break;

default: System.Console.WriteLine("Bad number");  break;
}

if(number == 1){
System.Console.WriteLine("Monday");
}  
else if(number == 2){
System.Console.WriteLine("Tuesday");
}
else if(number == 3){
System.Console.WriteLine("Wednesday");
}
else{
System.Console.WriteLine("Bad number"); 
}

}
else
{
System.Console.WriteLine("Bad Number");
}