// **Задача 42:** Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
//
// 45 -> 101101
//
// 3 -> 11
//
// 2 -> 10
//
string decimalToBinary(int num)
{
  string result = String.Empty;
  int rest = 0;
  while (num > 0)
  {
    rest = num % 2;
    num /= 2;
    result = Convert.ToString(rest) + result;
  }
  return result;
}

Console.WriteLine($"{45} -> {decimalToBinary(45)}");
