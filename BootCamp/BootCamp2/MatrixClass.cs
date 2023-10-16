namespace MatrixClass;

public static class IntMatrix
{
  public static int[,] CreateIntMatrix(int rows, int columns)
  {
    return new int[rows, columns];
  }

  public static int[,] FillIntMatrix(this int[,] matrix, int min = 0, int max = 10, int seed = 0)
  {
    Random rand = seed == 0 ? new Random() : new Random(seed);
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    for (int i = 0; i < rows; i++)
      for (int j = 0; j < columns; j++)
      {
        matrix[i, j] = rand.Next(min, max + 1);
      }
    return matrix;
  }

  public static void PrintIntMatrix(this int[,] matrix)
  {
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
      Console.Write("[");
      for (int j = 0; j < columns; j++)
      {
        Console.Write($"{matrix[i, j]}\t");
      }
      Console.Write("]");
      Console.WriteLine();
    }
  }
}
