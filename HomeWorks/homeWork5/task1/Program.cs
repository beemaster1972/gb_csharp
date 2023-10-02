using System;

public class Answer
{
  public static int CountEvenElements(int[] array)
  {
    // Введите свое решение ниже
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
      if (array[i] % 2 == 0)
        count += 1;
    }
    return count;
  }

  public static void PrintArray(int[] array)
  {
    // Введите свое решение ниже
    for (int i = 0; i < array.Length; i++)
    {
      Console.Write($"{array[i]}\t");
    }
    Console.WriteLine();
  }

  // Не удаляйте и не меняйте метод Main!
  public static void Main(string[] args)
  {
    int[] array;
    if (args.Length == 0)
    {
      // Здесь вы можете поменять значения для отправки кода на Выполнение
      array = new int[] { 100, 102, 105, 166, 283, 764, 300, 499, 133 };
    }
    else
    {
      string[] argStrings = args[0].Split(", ");
      array = new int[argStrings.Length];
      for (int i = 0; i < argStrings.Length; i++)
      {
        if (int.TryParse(argStrings[i], out int number))
        {
          array[i] = number;
        }
        else
        {
          Console.WriteLine($"Ошибка при парсинге аргумента {argStrings[i]}.");
          return;
        }
      }
    }

    // Не удаляйте строки ниже
    Console.WriteLine("Массив:");
    PrintArray(array);
    int evenCount = CountEvenElements(array);
    Console.WriteLine($"Количество четных элементов: {evenCount}");
  }
}

