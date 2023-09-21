// Задача 10: Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
int GetDigit(int number, int digitNumber)
{
  // int count = 0;
  int result;
  result = number % (10 * *(digitNumber));
  return result;
}
