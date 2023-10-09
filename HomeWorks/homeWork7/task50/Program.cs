// Задача 50: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.


int PromptInt(string prompt)
{
    Console.Write(prompt);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[,] SetArray(int rows, int columns, int min, int max)
{
    Random rand = new Random();
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = rand.Next(min, max);
        }
    return result;
}

void ShowArray(int[,] array)
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
int[,] array = SetArray(rows, columns, min, max);
ShowArray(array);
int row = PromptInt("Введите номер строки:");
int col = PromptInt("Введите номер столбца:");
ShowArray(array);
Console.Write($"{row}{col} -> ");
if (row > rows || col > columns)
    Console.WriteLine("Нет такого элемента");
else
    Console.WriteLine($"{array[row - 1, col - 1]}");
