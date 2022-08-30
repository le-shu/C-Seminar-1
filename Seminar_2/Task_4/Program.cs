﻿// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

// ну, по условию выходит, что у нас известны 2 числа - 7 и 23, на них мы должны поделить наш ввод
// получим какой-то ввод, я опять же заморочусь с проверками, меня сильно раздражает ошибка ввода. Видимо что-то на генном уровне :)
// тут сделаю еще интереснее, я зациклю программу, что б мы могли писать числа и получать результаты, пока не напишем ключ-фразу

// тогда объявляем две переменные, input - туда будем писать ввод пользователя и end - наша ключ-фраза (в нижнем регистре)
string? end = "конец", input = "";

// теперь цикл, который будет работать, пока input не равен end. Input тоже приведем к нижнему регистру
while( input?.ToLower() != end)
{
    // объявляем переменную с целочисленным типом
    int number;

    // В этом цикле, как и прежде, проверяем число. А пусть это будет теперь вообще любое целое число с любым знаком
    while(true){
        // просим ввести число
        Console.Write("Укажите какое-нибудь целое число: ");
        // пишем ввод в строковую переменную
        string? str = Console.ReadLine();
        // пытаемся преобразовать строку в число
        if(int.TryParse(str, out number)){
            // если успешно, то у нас есть целое число с любым знаком. Выходим из цикла.
            break;
        }else{
            // если не успешно - продолжаем цикл
            Console.WriteLine("Неверный формат ввода. Введите число");
        }
    }
    
    // Теперь есть какое-то число, записанное в рамках while( input.ToLower() != end)
    // Теперь укажем переменные, в которые запишем 7 и 23.
    int num1 = 7, num2 = 23;

    // Теперь поделим наш number (введенное число) на переменные num1 и num2, лучше через несколько действий
    // Для этого инициализируем еще несколько переменных, куда запишем результаты действий
    int res1 = number / num1;
    int res2 = number / num2;

    // если результат деления res1 равен числу num2 И результат деления res2 равен num1, то нашли общее кратное
    if(res1 == num2 && res2 == num1)
    {
        Console.WriteLine($"Число {number} кратно {num1} и {num2}");
    }
    else
    {
        Console.WriteLine($"Число {number} не кратно {num1} и {num2}");
    }

    // Также можем найти наименьшее общее кратное перемножив num1 и num2 и сравнив сумму с number
    int sum = num1 * num2;
    if(sum == number)
    {
        Console.WriteLine($"Число {number} кратно {num1} и {num2} в другом примере");
    }
    else
    {
        Console.WriteLine($"Число {number} не кратно {num1} и {num2} в другом примере");
    }

    // Теперь с помощью метода решим эту задачу. Опишем метод
    int FindNumber(int data)
    {
        // В этот раз я верну int, а не стринг. Метод будет только делать какие-то вычисления
        // Объявим аргументы для вычислений
        // int num1 = 7, num2 = 23; - в методе эту строчку сейчас можем не описывать, т.к. переменные number, num1 и num2
        // были уже инициализированы выше, за пределами этого метода
        if(number / num1 == num2 && number / num2 == num1)
        {
            // чтобы вернуть число, если уравнение выше выполняется - пишем 1 (нашли кратное)
            return 1;
        }
        else
        {
            // Тут уравнение не выполнилось - не кратное, пишем 0
            return 0;
        }
    }
    // Применяем метод через условие, если вернулась 1 - значит кратное есть, выводим сообщение
    if (FindNumber(number) == 1)
    {
        Console.WriteLine($"Число {number} кратно {num1} и {num2} - это метод");
    }
    // Если вернулся ноль - значит не кратное, тоже выводим это сообщение
    else{
        Console.WriteLine($"Число {number} не кратно {num1} и {num2} - это метод");
    }

    // Вот этот кусочек кода отвечает за самый верхний цикл. После отработки всех логик и методов, мы можем перестать вводить что-то
    // И написать слово "конец" (в разном регистре), а можем нажать Enter и будем писать числа дальше.
    Console.WriteLine("Если хотите закончить вводить числа, напишите - Конец. А для продолжения - нажмите Enter");
    input = Console.ReadLine();
}

// Метод void можете написать сами. Там логика такая же будет, просто не нужен return