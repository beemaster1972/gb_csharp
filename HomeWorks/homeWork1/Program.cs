// // Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// // a = 5; b = 7 -> max = 7
// // a = 2 b = 10 -> max = 10
// // a = -9 b = -3 -> max = -3

// System.Console.WriteLine("Введите первое число: ");
// int numA = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите второе число: ");
// int numB = Convert.ToInt32(Console.ReadLine());
// if (numA>numB)
// {
//     System.Console.WriteLine($"a = {numA} b = {numB} -> max = {numA}");
// }
// else if (numB > numA)
// {
//     System.Console.WriteLine($"a = {numA} b = {numB} -> max = {numB}");
// }
// else
// {
//     System.Console.WriteLine($"a = {numA} b = {numB} -> a = b");
// }
// 
// // Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// // 2, 3, 7 -> 7
// // 44 5 78 -> 78
// // 22 3 9 -> 22
// System.Console.Write("Введите сколько чисел будут сравниваться: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int max = int.MinValue;
// int[] array = new int[N];
// for (int i = 0; i < N; i++)
// {
//     System.Console.Write($"Введите число {i + 1}: ");
//     array[i] = Convert.ToInt32(Console.ReadLine());
//     if (array[i]>max)
//     {
//         max = array[i];
//     }
// }
// for (int i = 0; i < N; i++)
// {
//     System.Console.Write(array[i] + (i<N-1 ? ", " : " -> "));
// }
// System.Console.WriteLine(max);
// 
// // Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// // 4 -> да
// // -3 -> нет
// // 7 -> нет
// System.Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// string result = (num % 2 == 0) ? "да" : "нет";
// System.Console.WriteLine($"{num} -> {result}");
// 
// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
System.Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
System.Console.Write($"{N} -> ");
for (int i=2; i<=N; i+=2)
{
    System.Console.Write(i + (i<N-1? ", " : ""));
}
System.Console.WriteLine();
