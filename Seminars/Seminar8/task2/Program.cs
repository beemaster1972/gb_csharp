//Задание 2. Задайте двумерный массив. Напишите программу,
//которая заменяет строки на столбцы.
//В случае, если это невозможно, программа должна вывести
//сообщение для пользователя.

//Например, задан массив:

//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7

//В итоге получается вот такой массив:

//1 5 8 5
//4 9 4 2
//7 2 2 6
//2 3 4 7
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

void ChangeRowsToColumns(int[,] array)
{
  int rows = array.GetLength(0);
  int columns = array.GetLength(1);
  if (rows != columns)
  {
    Console.WriteLine("Invalid matrix");
    return;
  }
  for (int i = 0; i < rows; i++)
    for (int j = i + 1; j < columns; j++)
    {
      int tmp = array[i, j];
      array[i, j] = array[j, i];
      array[j, i] = tmp;
    }
}
int[,] matrix = CreateMatrix(3, 3);
PrintMatrix(matrix);
ChangeRowsToColumns(matrix);
Console.WriteLine();
PrintMatrix(matrix);
