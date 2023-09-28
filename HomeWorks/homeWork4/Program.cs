// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
//

int GetPower(int baseNum, int exponent)
{
  int result = 1;
  for (int i = 1; i <= exponent; i++)
  {
    result *= baseNum;
  }
  return result;
}

// Задача 27: Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
//
int GetSumDigits(int num)
{
  int result = 0;
  while (Math.Abs(num) > 0)
  {
    result += num % 10;
    num /= 10;
  }

  return result;
}

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
//
int[] SetArray(int size, int min, int max)
{
  int[] result = new int[size];
  Random rand = new Random();
  for (int i = 0; i < size; i++)
  {
    result[i] = rand.Next(min, max + 1);
  }
  return result;
}

void ShowArray(int[] array)
{
  int size = array.Length;
  for (int i = 0; i < size; i++)
  {
    Console.Write($"{(i == 0 ? "[" : "")}{array[i]}{(i < size - 1 ? ", " : "]")}");
  }
}

Console.WriteLine(GetPower(3, 5));
Console.WriteLine(GetPower(2, 4));
Console.WriteLine(GetSumDigits(452));
Console.WriteLine(GetSumDigits(82));
Console.WriteLine(GetSumDigits(9012));
ShowArray(SetArray(5, 1, 19));
