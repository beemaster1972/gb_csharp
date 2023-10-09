// Задача 52: Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом
// столбце.
//
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

double[] GetMean(int[,] array)
{
  double[] result = new double[array.GetLength(1)];
  int rows = array.GetLength(0);
  int columns = array.GetLength(1);
  int sum;
  for (int i = 0; i < columns; i++)
  {
    sum = 0;
    for (int j = 0; j < rows; j++)
    {
      sum += array[j, i];
    }
    result[i] = sum / Convert.ToDouble(rows);
  }
  return result;
}

void ShowArray(double[] array)
{
  Console.Write("[");
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write($"{array[i]:0.00} {(i < array.Length - 1 ? ";" : "] -> ")}");
  }
}

int rows = PromptInt("Введите кол-во строк: ");
int columns = PromptInt("Введите кол-во столбцов: ");
int min = PromptInt("Введите минимальное значение элемента:");
int max = PromptInt("Введите максимальное значение элемента:");
int[,] array = SetArray(rows, columns, min, max);
ShowMatrix(array);
double[] means = GetMean(array);
ShowArray(means);
