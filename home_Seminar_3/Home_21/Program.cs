using System;

namespace Home3
{
    class TestMetods
    {
        public static void Main(string[] args)
        {
            // Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между
            // ними в 3D пространстве.
            // A (3,6,8); B (2,1,-7), -> 15.84
            // A (7,-5, 0); B (1,-1,9) -> 11.53

            static void Distance ()
            {
              Console.WriteLine("Введите x1 для точки А: ");
              int x1 = int.Parse(Console.ReadLine());

              Console.WriteLine("Введите y1 для точки А: ");
              int y1 = int.Parse(Console.ReadLine());

              Console.WriteLine("Введите z1 для точки А: ");
              int z1 = int.Parse(Console.ReadLine());

              Console.WriteLine("Введите x2 для точки B: ");
              int x2 = int.Parse(Console.ReadLine());

              Console.WriteLine("Введите y2 для точки B: ");
              int y2 = int.Parse(Console.ReadLine());

              Console.WriteLine("Введите z2 для точки B: ");
              int z2 = int.Parse(Console.ReadLine());

              double distance = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
              Console.WriteLine($"Расстояние между A ({x1},{y1},{z1}) и B ({x2},{y2};{z2}) -> {distance}");  
            }
            Distance ();
        }
    }
}