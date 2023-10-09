// Задача 51: Задайте двумерный массив.
// Найдите сумму элементов, находящихся на главной диагонали
// (с индексами (0,0); (1;1) и т.д.

int PromptInt(string prompt)
{
    Console.Write(prompt);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[,] FillArray(int rows, int columns, int min, int max)
{
    Random rand = new Random();
    int sum = 0;
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = rand.Next(min, max + 1);
            if (i == j)
                sum += result[i, j];
        }
    Console.WriteLine($"Сумма главной диаганоли = {sum}");
    return result;
}

void ShowMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j], 3}");
        }
        Console.Write("]");
        Console.WriteLine();
    }
}

int rows = PromptInt("Введите кол-во строк: ");
int columns = PromptInt("Введите кол-во столбцов: ");
int min = PromptInt("Введите минимальное значение элемента:");
int max = PromptInt("Введите максимальное значение элемента:");
int[,] array = FillArray(rows, columns, min, max);
ShowMatrix(array);
