//9. Напишите программу, которая выводит
//случайное число из отрезка [10, 99] и показывает
//наибольшую цифру числа.
//78 -> 8
//12-> 2
//85 -> 8

Console.WriteLine("Решаем задачу без методов");
// Немного о логических операторах, которые будут встречаться постоянно (есть разные операторы, тут укажу только 2)

// && - Условный оператор логического И. Вычисляет логическое И для своих операндов. 
// Результат операции x && y принимает значение true, если оба оператора x и y имеют значение true. 
// В противном случае результат будет false. Если x имеет значение false, y не вычисляется.

// || - Условный оператор логического ИЛИ. Вычисляет логическое ИЛИ для своих операндов. 
// Результат операции x || y принимает значение true, если хотя бы один из операторов x или y имеет значение true.
// В противном случае результат будет false. Если x имеет значение true, y не вычисляется.

// Теперь к задаче
// В условии у нас отрезок от 10 до 99, потому логично принимать на ввод только десятки
// Потому сделаем проверку на введенное чиcло

// Просим ввести число
Console.WriteLine("Укажите любое положительное число в диапазоне от 10 до 99");
// Принимаем и проверяем число
int number = Convert.ToInt32(Console.ReadLine());

// в этом цикле мы проверяем, соответствует ли ввод условиям:
// цикл продлжится, пока введенное число меньше 10 ИЛИ больше 100 
while(number < 10 || number > 99)
{
    // Каждый раз просим ввести нужное число
    Console.WriteLine("Введенное число неверно. Введите число: ");
    // А тут при каждой итерации переписываем ввод пользователя. Выйдем из цикла, когда получим корректный ввод.
    number = Convert.ToInt32(Console.ReadLine());
}

// Как только получили корректный ввод, вычисляем какая цифра у нас будет больше
// Для этого сперва получим первую цифру нашего десятка, разделив число на 10 (работаем только с десятками же)
int num1 = number / 10;

// Теперь получим значение второй цифры в нашем десятке, тут используем остаток от деления на 10
// Чтобы получить последнюю цифру в числе - используйте остаток от деления
// Если число десяток - то делим на 10, сотни делим на 100, тысячи на 1000 и т.д.
int num2 = number % 10;

// Поскольку нам теперь известны обе цифры в числе, то мы просто их сравним через знакомый if - else
if(num1 > num2)
{
    // Если первая цифра больше второй, скажем, что она больше
    Console.WriteLine("В числе "+number+" наибольшая цифра "+num1);
}
else if(num1 == num2)
{
    // Если цифры равны - так и скажем
    Console.WriteLine("В числе "+number+" цифры равны");
}
else
{
    // В последнем else мы всегда будем получать цифру num2 больше, потому нет смысла проверять, просто пишем
    Console.WriteLine("В числе "+number+" наибольшая цифра "+num2);
}
// Задача решена. Думаю, есть другие варианты, но мне в голову пришел этот


//______________________________________________________________________________________________________________________

// Теперь решим эту задача с помощью метода.
// Методы или функции чаще всего описывают до приема каких-либо данных для работы, потому пусть наш метод тоже будет тут
// В описании метода с названием MaxNumber указываем, что он принимает для работы какие-то данные в целочисленном формате (int data)
// void указываем для определения того, что метод не возвращает значение, т.е. игнорируем return в этой функции

Console.WriteLine("Вот теперь пошло решение через void метод с названием: MaxNumber");

void MaxNumber(int data)
{
    // Далее реализовываем логику, что выше в задаче
    int num1 = data / 10;
    int num2 = data % 10;
    // Здесь я ввел строковую переменную result с пустым значением. "" - означает, что строка пуста.
    string result = "";

    // Если первая цифра больше второй, как и в логике выше, то
    if(num1 > num2)
    {
        // Записываем в нашу переменую строку. Помните, что при такой конструкции: "текст +data+ текст +num1" - кроме текста мы еще и записываем значение переменных
       result = "В числе "+data+" наибольшая цифра "+num1;
    }
    else if(num1 == num2)
    {
        // Если цифры равны - также записываем это в наш стринг. Альтернативный вывод значения переменных в строках может выглядеть и так: $"текст {переменная} текст"
        result = $"В числе {data} цифры равны";
    }
    else
    {
        // В последнем else применю сразу оба варианта извлечения данных из меременных в строках, они же практически равноценны :)
        // Предпочтительно использовать какой-то один вариант, но если уж решили таким способом, как ниже, то обязательно 
        // после использования конструкции +переменная+ до продолжения строки укажите оператор $
       result = "В числе "+data+ $" наибольшая цифра {num2}, наименьшая же "+num1+ $" в этом числе :)";
    }
    // Здесь, собственно, подводим итог нашего решения и выводим в консоль одну из получившихся фраз, через переменную result
    Console.WriteLine(result);
}

// Метод написан, теперь мы готовы пытаться принять какое-то чило
Console.WriteLine("Укажите любое положительное число в диапазоне от 10 до 99");
int number1 = Convert.ToInt32(Console.ReadLine());

// Вообще, заморочка с вайл не обязательна, но проще же работать с корректными данными, так?
// Я тут не обрабатываю все ошибки ввода, только целые положительные числа
while(number1 < 10 || number1 > 99)
{
    Console.WriteLine("Введенное число неверно. Введите число: ");
    number1 = Convert.ToInt32(Console.ReadLine());
}

// Все, есть корректные данные, применяем метод
// Просто пишем название метода, а вместо data указываем переменную, данные которой нам надо рассчитать

MaxNumber(number1);
// Счатье :)

//______________________________________________________________________________________________________________________

Console.WriteLine("А теперь решение через метод с названием: WhatIsGreater - а что же больше?");
// Теперь та же задача, но без void и немного иначе в теле метода. Назову метод тоже иначе.
// И пусть метод возвращает строку, у нас там же Console.WriteLine, а принимает на вход Integer - целое число
string WhatIsGreater(int some_number)
{
    // Тут все так же, только никаких строковых переменных
    int num1 = some_number / 10;
    int num2 = some_number % 10;

    // var означает, что переменной result1 будет установлен тип, который система выберет сама
    var result1 = "";

    // В условиях та же логика, ничего не менял, только все записываю в переменную result1
    if(num1 > num2)
    {
        result1 = "В числе "+some_number+" наибольшая цифра "+num1;
    }
    else if(num1 == num2)
    {
        result1 = "В числе "+some_number+" цифры равны";
    }
    else
    {
        result1 = "В числе "+some_number+" наибольшая цифра "+num2;
    }
    // Здесь, собственно, подводим итог нашего решения и выводим наш result1
    return result1;
}

// Метод готов, теперь получим что-то на ввод и орбработаем, как и во всех примерах до
Console.WriteLine("Укажите любое положительное число в диапазоне от 10 до 99");
int number2 = Convert.ToInt32(Console.ReadLine());

while(number2 < 10 || number2 > 99)
{
    Console.WriteLine("Введенное число неверно. Введите число: ");
    number2 = Convert.ToInt32(Console.ReadLine());
}

// Применим метод, записав обработанное с его помощью в переменную и выведем результат
string some_text = WhatIsGreater(number2);
Console.WriteLine(some_text);