// Вид 1.

void Method ()
{
    Console.WriteLine("Автор: ");
}
// Method ();

// Вид 2.

void Method2 (string abc)
{
    Console.WriteLine(abc);
}
// Method2 ("Текст сообщения");

void Method21 (string abc, int count)
{
    int i =0;
    while (i < count)
    {
        Console.WriteLine(abc);
        i++;
    }
}
// Method21 (count: 4, abc: "Текст сообщения");
// Method21 ("Текст сообщения", 4);

// Вид 3.

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
// Console.WriteLine(year);

// Вид 4.

string Method4 (int count, string text)
{
    int i = 0;
    string result = String.Empty; // = "";

    while (i < count)
    {
        result = result + text;
        i++;
    }
    
    // for (int i = 1; i < count; i++)
    // {
    //     result = result + text;
    // }

    return result;
}

string res = Method4 (10, "Привет! ");
// Console.WriteLine(res);

for (int i = 2; i <= 9; i++)
{
    for (int j = 2; j <= 9; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j}");
    }
    Console.WriteLine("");
}

