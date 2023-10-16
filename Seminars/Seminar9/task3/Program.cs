// /Задача 3. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
//
// //M = 1; N = 5. -> "1, 2, 3, 4, 5"
// //M = 4; N = 8. -> "4, 5, 6, 7, 8"
//
void PrintRange(int m, int n)
{
    int min = m > n ? n : m;
    int max = m > n ? m : n;
    if (min < max)
    {
        PrintRange(min, max - 1);
        System.Console.Write($"{max} ");
    }
    else if (min == max)
        System.Console.Write($"{min} ");
}

PrintRange(23, 1);
