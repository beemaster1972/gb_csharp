// Напишите программу, которая по заданному номеру четверти,
//   показывает диапазон возможных координат точек в этой четверти (x и y).
//
void GetRangeCoords(int quadrant)
{
  switch (quadrant)
  {
    case 1:
      Console.WriteLine("1 -> x = {0...+inf} y = {0...+inf}");
      break;
    case 2:
      Console.WriteLine("2 -> x = {0...-inf} y = {0...+inf}");
      break;
    case 3:

      Console.WriteLine("3 -> x = {0...-inf} y = {0...-inf}");
      break;

    case 4:

      Console.WriteLine("4 -> x = {0...+inf} y = {0...-inf}");
      break;
  }
}
GetRangeCoords(1);
GetRangeCoords(2);
GetRangeCoords(3);
GetRangeCoords(4);
