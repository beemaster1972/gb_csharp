// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
//
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Single GetDistance(int x1, int y1, int x2, int y2)
{
  return Convert.ToSingle(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));
}

Console.WriteLine(Math.Round(GetDistance(1, 2, 4, 6), 2));
