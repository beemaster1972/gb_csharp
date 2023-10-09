// Задача 47: Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.


int PromptInt(string prompt)
{
    Console.Write(prompt);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

double PromptFloat(string prompt)
{
    Console.Write(prompt);
    double result = Convert.ToDouble(Console.ReadLine());
    return result;
}

double[,] SetArray(int rows, int columns, double min, double max)
{
    Random rand = new Random();
    double[,] result = new double[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = rand.NextDouble() * max + min;
        }
    return result;
}

void ShowArray(double[,] array)
{
    Console.Write("[");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]:0.00} ");
        }
        if (i < array.GetLength(0) - 1)
            Console.WriteLine();
        else
            Console.Write("]");
    }
}

int rows = PromptInt("Введите кол-во строк в массиве: ");
int columns = PromptInt("Введите кол-во столбцов в массиве: ");
double min = PromptFloat("Введите минимальное значение для элементов в массиве:");
double max = PromptFloat("Введите максимальное значение для элементов в массиве:");
double[,] array = SetArray(rows, columns, min, max);
ShowArray(array);
