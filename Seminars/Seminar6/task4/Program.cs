// Задача 40: Напишите программу, которая принимает на вход три числа
// и проверяет, может ли существовать треугольник с сторонами такой длины.
//

bool existTriangle(int a, int b, int c)
{
  if (a + b > c && a + c > b && c + b > a)
    return true;
  else
    return false;
}

Console.WriteLine($"{(existTriangle(3, 3, 10) ? "Да" : "Нет")}");
