// 17. Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта точка.

static void ViewQuarterNumber()
        {
            Console.Write("Введите X: ");
            int X = int.Parse(Console.ReadLine());

            Console.Write("Введите Y: ");
            int Y = int.Parse(Console.ReadLine());

            if (X > 0 && Y > 0)
            {
                Console.WriteLine("1 четверть");
            }
            else if (X < 0 && Y > 0)
            {
                Console.WriteLine("2 четверть");
            }
            else if (X < 0 && Y < 0)
            {
                Console.WriteLine("3 четверть");
            }
            else if (X > 0 && Y < 0)
            {
                Console.WriteLine("4 четверть");
            }
        }
ViewQuarterNumber();