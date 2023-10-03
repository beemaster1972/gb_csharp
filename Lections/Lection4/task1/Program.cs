// Факториал числа

int Factorial(int num)
{
  if (num == 1 || num == 0)
    return 1;
  return num * Factorial(num - 1);
}

int num = 10;
Console.WriteLine($"{num}! = {Factorial(num)}");
