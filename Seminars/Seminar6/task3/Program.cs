// **Задача 44:** Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Первые два числа Фибоначчи: 0 и 1.
//
// Если N = 5 -> 0 1 1 2 3
//
// Если N = 3 -> 0 1 1
//
// Если N = 7 -> 0 1 1 2 3 5 8
//
//
int Fibonachi(int num)
{
    if (num == 0)
        return 0;
    if (num <= 2)
        return 1;
    return Fibonachi(num - 1) + Fibonachi(num - 2);
}

for (int i = 0; i <= 20; i++)
{
    Console.Write($"{Fibonachi(i)} ");
}
