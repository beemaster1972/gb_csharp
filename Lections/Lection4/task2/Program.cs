// Числа Фибоначчи
//
int Fibonachi(int num)
{
  if (num <= 2)
    return 1;
  return Fibonachi(num - 1) + Fibonachi(num - 2);
}

for (int i = 1; i <= 20; i++)
{
  Console.Write($"{Fibonachi(i)} ");
}
