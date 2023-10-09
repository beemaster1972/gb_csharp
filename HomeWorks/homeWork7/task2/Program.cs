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

    public static int[] FindNumberByPosition(int[,] matrix, int rowPosition, int columnPosition)
    {
        // Введите свое решение ниже

        int res =
            (rowPosition > matrix.GetLength(0) || columnPosition > matrix.GetLength(1))
                ? 0
                : matrix[rowPosition - 1, columnPosition - 1];
        int error =
            (rowPosition > matrix.GetLength(0) || columnPosition > matrix.GetLength(1)) ? 1 : 0;
        int[] result = { res, error };
        return result;
    }

    public static void PrintCheckIfError(int[] results, int X, int Y)
    {
        // Введите свое решение ниже
        string[] answer = { $"The number in [{X}, {Y}] is {results[0]}", "There is no such index" };
        Console.WriteLine(answer[results[1]]);
    }

    // Не удаляйте и не меняйте метод Main!
    static public void Main(string[] args)
    {
        int n,
            m,
            k,
            x,
            y;

        if (args.Length >= 5)
        {
            n = int.Parse(args[0]);
            m = int.Parse(args[1]);
            k = int.Parse(args[2]);
            x = int.Parse(args[3]);
            y = int.Parse(args[4]);
        }
        else
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            n = 4;
            m = 5;
            k = 3;
            x = 3;
            y = 3;
        }

        // Не удаляйте строки ниже
        int[,] result = CreateIncreasingMatrix(n, m, k);
        PrintArray(result);
        PrintCheckIfError(FindNumberByPosition(result, x, y), x, y);
    }
}
