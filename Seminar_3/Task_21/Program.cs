// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и
// находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

static void DistanceBetweenPoints(int x1, int x2, int y1, int y2)
        {
            double distanceBetweenPoints = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));

            Console.WriteLine($"A ({x1},{y1}); B ({x2},{y2}) -> {distanceBetweenPoints}");
        }
DistanceBetweenPoints( 1, -6, -9, 7);