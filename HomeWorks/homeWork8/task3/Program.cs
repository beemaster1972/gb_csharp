// Реализуйте класс MatrixOperations, который содержит следующие статические методы:
//
// MultiplyIfPossible(int[,] matrixA, int[,] matrixB): Метод для проверки,
// возможно ли умножения двух матриц matrixA и matrixB. Если число столбцов
// в матрице matrixA не равно числу строк в матрице matrixB, то выводится сообщение
// "It is impossible to multiply." В противном случае, вызывается метод MatrixMultiplication
// для умножения матриц, и результат выводится с помощью метода PrintMatrix.
//
// MatrixMultiplication(int[,] matrixA, int[,] matrixB): Метод для умножения
// двух матриц matrixA и matrixB. Метод возвращает новую матрицу, которая представляет
// собой результат умножения матрицы matrixA на матрицу matrixB.
//
// PrintMatrix(int[,] matrix): Метод для вывода матрицы на консоль.
//
// Если аргументы не переданы, программа использует матрицы по умолчанию.
// Если аргументы переданы, программа парсит их в двумерные массивы целых
// чисел и выполняет умножение матриц.
//
// Аргументы, передаваемые в метод/функцию:
//
// '1,2;3,4'
// На выходе:
//
//
// Исходная матрица:
// 1   2
// 3   4
//
// Matrix B:
// 5   6
// 7   8
//
// Multiplication result:
// 19  22
// 43  50
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
        int row,
            col;
        int numbers = matrix.GetLength(Shape ^ 1);
        int[] result = new int[numbers];
        for (int i = 0; i < numbers; i++)
        {
            row = Shape == 0 ? Number : i;
            col = Shape == 1 ? Number : i;
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
            Console.Write($"{String.Join("\t", GetRowOrColFromMatrix(matrix, i, 0))}\t");
            // for (int j = 0; j < columns; j++)
            // {
            //     Console.Write($"{matrix[i, j]}\t");
            // }
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
