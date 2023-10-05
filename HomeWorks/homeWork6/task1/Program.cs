// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
//

int countPositive(int[] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] > 0)
      count++;
  }
  return count;
}

int[] inputInt(int M)
{
  int[] array = new int[M];
  for (int i = 0; i < M; i++)
  {
    Console.Write("Введите целое число: ");
    array[i] = int.Parse(Console.ReadLine());
  }
  return array;
}

Console.Write("Введите кол-во целых чисел: ");
int M = int.Parse(Console.ReadLine());
int[] array = inputInt(M);
Console.Write($"Ввели {countPositive(array)} положительных чисел");
