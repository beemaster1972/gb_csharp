// Задача 66: Задайте значения M и N.
// Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
//

int GetSumRange(int m, int n)
{
    int min = m > n ? n : m;
    int max = m > n ? m : n;
    if (min < max)
    {
        return GetSumRange(min, max - 1) + max;
        // System.Console.Write($"{max} ");
    }
    else if (min == max)
        return min;
    else
        return 0;
}

int m = 1;
int n = 5;
System.Console.WriteLine($"sum({m};{n}) = {GetSumRange(m, n)}");
