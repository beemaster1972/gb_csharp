using System;

public class Answer
{
  static int GetReverseInt(int number)
  {
    int result = 0;
    int index = 4;
    while (number > 0)
    {
      result += number % 10 * Convert.ToInt32(Math.Pow(10, index));
      number /= 10;
      index--;
    }
    return result;
  }

  static bool IsPalindrome(int number)
  {
    // Введите свое решение ниже
    if (number < 10000 || number > 99999)
    {
      System.Console.Write($"{number} -> Число не пятизначное");
      return false;
    }
    int reverseInt = GetReverseInt(number);
    System.Console.Write($"{number} -> ");
    if (number == reverseInt)
      return true;
    else
      return false;
  }

  // Не удаляйте и не меняйте метод Main!
  static public void Main(string[] args)
  {
    int number;

    if (args.Length >= 1)
    {
      number = int.Parse(args[0]);
    }
    else
    {
      // Здесь вы можете поменять значения для отправки кода на Выполнение
      number = 64546;
    }

    // Не удаляйте строки ниже
    bool result = IsPalindrome(number);
    System.Console.WriteLine($"{result}");
  }
}
