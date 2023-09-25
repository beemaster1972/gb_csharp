// Задача 10: Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

bool checkDayOfWeek(int numOfDay, bool ISO8601)
{
  if (((numOfDay == 6 || numOfDay == 7) && ISO8601) || ((numOfDay == 1 || numOfDay == 7) && !ISO8601))
  {
    return true;
  }
  else
  {
    return false;
  }
}

// Одним выстрелом двух зайцев, в смысле две задачи

int GetDigit(int number, int digitNumber)
{
  if (number < Convert.ToInt32(Math.Pow(10,digitNumber)))
  {
    return int.MinValue;
  }
  int result;
  result = number % Convert.ToInt32(Math.Pow(10, digitNumber));
  result /= Convert.ToInt32(Math.Pow(10,digitNumber-1));
  return result;
}

void task10()
{
  Console.Write("Enter number: ");
  int number = Convert.ToInt32(Console.ReadLine());
  Console.Write("Enter digit number: ");
  int digitNumber = Convert.ToInt32(Console.ReadLine());
  int answer = GetDigit(number, digitNumber);
  Console.WriteLine($"{number} -> {(answer == int.MinValue ? $"цифры под номером {digitNumber} нет": answer)}");
}

void task15()
{
  Console.Write("Введите номер дня недели (1-7): ");
  try
  {
    int num = Convert.ToInt32(Console.ReadLine());
    if (num < 1 || num > 7)
    {
      Console.WriteLine("Нет такого дня недели!");
      return;
    }
    Console.Write("Вы признаёте стандарт ISO8601? (y/n): ");
    bool ISO8601 = Console.ReadLine() == "y";
    Console.WriteLine($"{num} -> {(checkDayOfWeek(num, ISO8601)==true ? "да" : "нет")}");
    return;
  }
  catch (FormatException e)
  {
    Console.WriteLine($"Что-то пошло не так: {e.Message}");
  }

}

void Main()
{
  Console.WriteLine("1. Задача 10\n2. Задача 13\n3. Задача 15");
  Console.Write("Выберите какую задачу Вам решить: ");
  int ans = Convert.ToInt32(Console.ReadLine());
  switch (ans)
  {
    case 1: case 2:
      task10();
      break;
    case 3:
      task15();
      break;
    default:
      Console.WriteLine("Вас не понял!");
      break;
  }
}

Main();
