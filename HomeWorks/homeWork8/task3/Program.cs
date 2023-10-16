using System;

public class Answer
{
    public static void MultiplyIfPossible(int[,] matrixA, int[,] matrixB)
    { // Введите свое решение ниже
        if (matrixA.GetLength(1) != matrixB.GetLength(0))
            Console.WriteLine("It is impossible to multiply.");
        else
            PrintMatrix(MatrixMultiplication(matrixA, matrixB));
    }

    public static int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
    { // Введите свое решение ниже
        int rows = matrixA.GetLength(0);
        int columns = matrixB.GetLength(1);
        int[,] result = new int[rows, columns];
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < columns; j++)
            {
                result[i, j] = ScalarMultiplication(
                    GetRowOrColFromMatrix(matrixA, i, 0),
                    GetRowOrColFromMatrix(matrixB, j, 1)
                );
            }
        return result;
    }

    public static int ScalarMultiplication(int[] matrixA, int[] matrixB)
    {
        int size = matrixA.Length;
        int result = 0;
        for (int i = 0; i < size; i++)
        {
            result += matrixA[i] * matrixB[i];
        }
        return result;
    }

    public static int[] GetRowOrColFromMatrix(int[,] matrix, int Number, int Shape)
    {
        //int rows = matrix.GetLength(0);
        int row,
            col;
        int numbers = matrix.GetLength(Shape ^ 1);
        int[] result = new int[numbers];
        for (int i = 0; i < numbers; i++)
        {
            row = Shape == 0 ? Number : i;
            col = Shape == 1 ? Number : i;
            System.Console.WriteLine($"row={row}; col={col}; i={i}");
            result[i] = matrix[row, col];
        }
        return result;
    }

    public static void PrintMatrix(int[,] matrix)
    {
        // Введите свое решение ниже
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{matrix[i, j]}\t");
            }
            Console.WriteLine();
        }
    }

    // Не удаляйте и не меняйте метод Main!
    public static void Main(string[] args)
    {
        int[,] matrix;

        if (args.Length == 0)
        {
            // Если аргументы не переданы, используем матрицу по умолчанию
            matrix = new int[,]
            {
                { 2, 4 },
                { 1, 3 },
                { 5, 6 }
            };
        }
        else
        {
            // Иначе, парсим аргументы в двумерный массив
            string[] rows = args[0].Split(';');
            matrix = new int[rows.Length, rows[0].Split(',').Length];
            for (int i = 0; i < rows.Length; i++)
            {
                string[] elements = rows[i].Split(',');
                for (int j = 0; j < elements.Length; j++)
                {
                    if (int.TryParse(elements[j], out int number))
                    {
                        matrix[i, j] = number;
                    }
                    else
                    {
                        Console.WriteLine($"Ошибка при парсинге аргумента {elements[j]}.");
                        return;
                    }
                }
            }
        }

        Console.WriteLine("Исходная матрица:");
        PrintMatrix(matrix);

        int[,] matrixB =
        {
            { 5, 6 },
            { 7, 8 }
        };

        Console.WriteLine("\nMatrix B:");
        PrintMatrix(matrixB);

        Console.WriteLine("\nMultiplication result:");

        MultiplyIfPossible(matrix, matrixB);
    }
}
