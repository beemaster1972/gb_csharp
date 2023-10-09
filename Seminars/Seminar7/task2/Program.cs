// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5
//

int PromptInt(string prompt)
{
  Console.Write(prompt);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}

int[,] FillArray(int rows, int columns, int min, int max)
{
  int[,] result = new int[rows, columns];
  for (int i = 0; i < rows; i++)
    for (int j = 0; j < columns; j++)
    {
      result[i, j] = i + j;
    }
  return result;
}

void ShowMatrix(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    Console.Write("[");
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write($"{array[i, j],3}");
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
