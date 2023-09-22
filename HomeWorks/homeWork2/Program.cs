// Задача 10: Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

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

void Main()
{
  Console.Write("Enter number: ");
  int number = Convert.ToInt32(Console.ReadLine());
  Console.Write("Enter digit number: ");
  int digitNumber = Convert.ToInt32(Console.ReadLine());
  int answer = GetDigit(number, digitNumber);
  Console.WriteLine($"{number} -> {(answer == int.MinValue ? $"цифры под номером {digitNumber} нет": answer)}");
}

Main();