﻿//Задача 1. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

//N = 5 -> "1, 2, 3, 4, 5"
//N = 6 -> "1, 2, 3, 4, 5, 6"

void PrintN(int N)
{
    if (N > 0)
    {
        PrintN(N - 1);
        System.Console.Write($"{N} ");
    }
}

PrintN(10);