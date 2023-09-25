// Напишите программу, которая принимает на вход координаты точки (X и Y),
//   причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости,
//   в которой находится эта точка.
// int GetQuadrante(int x, int y)
// {
//   if (x > 0 && y > 0)
//   {
//     return 1;
//   }
//   else if (x < 0 && y > 0)
//   {
//     return 2;
//   }
//   else if (x < 0 && y < 0)
//   {
//     return 3;
//   }
//   else
//   {
//     return 4;
//   }
// }
//
// Console.WriteLine(GetQuadrante(1, 2));
// Напишите программу, которая принимает на вход число (N) и
// выдаёт таблицу квадратов чисел от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
//
// 2 -> 1,4
//
void GetSquares(int n)
{
  Console.Write($"{n} -> ");
  for (int i = 0; i <= n; i++)
  {
    Console.Write($"{i * i}{(i < n ? ", " : "")}");
  }
}

int n = Convert.ToInt32(Console.ReadLine());
GetSquares(n); 
