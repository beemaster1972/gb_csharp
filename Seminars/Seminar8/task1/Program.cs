// Задание 1. Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку массива.

//Например, задан массив:

//1 4 7 2
//5 9 2 3
//8 4 2 4

//В итоге получается вот такой массив:

//8 4 2 4
//5 9 2 3
//1 4 7 2
//

int[,] CreateMatrix(int rows, int columns)
{
  return new int[rows, columns];
}

void FillMatrix(int[,] array, int min, int max)
{
  int rows = array.GetLength(0);
  int columns = array.GetLength(1);
  Random rand = new Random(100);
  for (int i = 0; i < rows; i++)
    for (int j = 0; j < columns; j++)
      array[i, j] = rand.Next(min, max + 1);
}

void PrintMatrix(int[,] array)
{
  int rows = array.GetLength(0);
  int columns = array.GetLength(1);
  for (int i = 0; i < rows; i++)
  {
    Console.Write("[");
    for (int j = 0; j < columns; j++)
    {
      Console.Write($"{array[i, j]}\t");
    }
    Console.WriteLine("]");
  }
}
void ChangeRows(int[,] array, int FirstRow, int SecondRow)
{
  int rows = array.GetLength(0);
  int columns = array.GetLength(1);
  if (FirstRow > rows - 1 || SecondRow > rows - 1)
  {
    Console.WriteLine($"FirstRow or SecondRow > {rows}");
    return;
  }
  int tmp;
  for (int col = 0; col < columns; col++)
  {
    tmp = array[FirstRow, col];
    array[FirstRow, col] = array[SecondRow, col];
    array[SecondRow, col] = tmp;
  }
}

int[,] matrix = CreateMatrix(5, 5);
FillMatrix(matrix, -10, 10);
PrintMatrix(matrix);
ChangeRows(matrix, 0, 4);
Console.WriteLine("После замены");
PrintMatrix(matrix);
