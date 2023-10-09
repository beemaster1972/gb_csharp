using System;

public class Answer
{
  public static void PrintArray(int[,] matrix)
  {
    // Введите свое решение ниже
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
        Console.Write($"{matrix[i, j]}\t");
      }
      Console.WriteLine();
    }
  }

  public static int[,] CreateIncreasingMatrix(int n, int m, int k)
  {
    // Введите свое решение ниже
    int[,] result = new int[n, m];
    int increament = 1;
    for (int i = 0; i < n; i++)
    {
      for (int j = 0; j < m; j++)
      {
        increament += i == 0 && j == 0 ? 0 : k;
        result[i, j] = (i == 0 && j == 0) ? 1 : increament;
      }
    }
    return result;
  }

  static void PrintListAvr(double[] list)
  {
    // Введите свое решение ниже
    Console.WriteLine("The averages in columns are: ");
    for (int i = 0; i < list.Length; i++)
    {
      Console.Write($"{list[i]:f2}\t");
    }
  }

  static double[] FindAverageInColumns(int[,] matrix)
  {
    // Введите свое решение ниже
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    double[] result = new double[columns];
    for (int col = 0; col < columns; col++)
    {
      int sum = 0;
      for (int row = 0; row < rows; row++)
      {
        sum += matrix[row, col];
      }
      result[col] = sum / Convert.ToDouble(rows);
    }
    return result;
  }

  // Не удаляйте и не меняйте метод Main!
  static public void Main(string[] args)
  {
    int n,
        m,
        k;

    if (args.Length >= 3)
    {
      n = int.Parse(args[0]);
      m = int.Parse(args[1]);
      k = int.Parse(args[2]);
    }
    else
    {
      // Здесь вы можете поменять значения для отправки кода на Выполнение
      n = 3;
      m = 4;
      k = 2;
    }

    // Не удаляйте строки ниже
    int[,] result = CreateIncreasingMatrix(n, m, k);
    PrintArray(result);
    PrintListAvr(FindAverageInColumns(result));
  }
}
