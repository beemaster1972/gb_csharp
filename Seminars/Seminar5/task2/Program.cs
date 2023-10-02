// **Задача 35:** Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
//
// *Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123*
//
// [5, 18, 123, 6, 2] -> 1
//
// [1, 2, 3, 6, 2] -> 0
//
// [10, 11, 12, 13, 14] -> 5
//

int[] SetArray(int size, int min, int max)
{
  Random rand = new Random();
  int[] result = new int[size];
  for (int i = 0; i < size; i++)
  {
    result[i] = rand.Next(min, max);
  }
  return result;
}

int GetCountInRange(int[] array, int min, int max)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] >= min && array[i] <= max)
      count += 1;
  }
  return count;
}

int size = 123;
int min = -100;
int max = 100;
int minRange = 10;
int maxRange = 99;
Console.WriteLine(
    $"Кол-во эл-в в диапазоне [{minRange},{maxRange}] = {GetCountInRange(SetArray(size, min, max), minRange, maxRange)}"
);
