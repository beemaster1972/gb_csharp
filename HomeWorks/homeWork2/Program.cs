// Задача 10: Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
int GetDigit(int number, int digitNumber)
{
  // int count = 0;
  int result;
  result = number / Convert.ToInt32(Math.Pow(10, digitNumber));
  Console.WriteLine(result);
  result %= Convert.ToInt32(Math.Pow(10,digitNumber-1));
  return result;
}

void Main()
{
  Console.Write("Enter number: ");
  int number = Convert.ToInt32(Console.ReadLine());
  Console.Write("Enter digit number: ");
  int digitNumber = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine(GetDigit(number, digitNumber));
}

Main();