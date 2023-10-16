//Задание 3. Из двумерного массива целых чисел
//удалить строку и столбец, на пересечении которых расположен наименьший элемент.
// то есть удалаем и строку и столбец в которой находится этот элемент



int[,] CreateMatrix(int rows, int columns)
{
  return new int[rows, columns];
}

void FillMatrix(int[,] array, int min, int max)
{
  int rows = array.GetLength(0);
  int columns = array.GetLength(1);
  Random rand = new Random(100);
  for (int i = 0; i < rows; i++)
    for (int j = 0; j < columns; j++)
      array[i, j] = rand.Next(min, max + 1);
}

void PrintMatrix(int[,] array)
{
  int rows = array.GetLength(0);
  int columns = array.GetLength(1);
  for (int i = 0; i < rows; i++)
  {
    Console.Write("[");
    for (int j = 0; j < columns; j++)
    {
      Console.Write($"{array[i, j]}\t");
    }
    Console.WriteLine("]");
  }
}

int[] GetCoordsMinElement(int[,] array)
{
  int rows = array.GetLength(0);
  int columns = array.GetLength(1);
  int min = array[0, 0];
  int[] coords = { 0, 0 };
  for (int i = 0; i < rows; i++)
    for (int j = 0; j < columns; j++)
    {
      if (array[i, j] < min)
      {
        min = array[i, j];
        coords[0] = i;
        coords[1] = j;
      }
    }
  return coords;
}

int[,] DeleteRowAndCol(int[,] array, int row, int col)
{
  int rows = array.GetLength(0);
  int columns = array.GetLength(1);
  int[,] result = CreateMatrix(rows - 1, columns - 1);
  int x,
      y;
  for (int i = 0; i < rows; i++)
  {
    if (i == row)
      continue;
    for (int j = 0; j < columns; j++)
    {
      if (j == col)
        continue;
      x = i > row ? i - 1 : i;
      y = j > col ? j - 1 : j;
      result[x, y] = array[i, j];
    }
  }

  return result;
}

int[,] matrix = CreateMatrix(5, 5);
FillMatrix(matrix, 0, 9);
PrintMatrix(matrix);
Console.WriteLine();
int[] minCoords = GetCoordsMinElement(matrix);
int[,] NewMatrix = DeleteRowAndCol(matrix, minCoords[0], minCoords[1]);
PrintMatrix(NewMatrix);
