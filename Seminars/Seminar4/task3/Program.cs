// Напишите программу, которая принимает на вход число (А) и
// выдаёт сумму чисел от 1 до А.
//
// 7 -> 28
//
// 4 -> 10
//
// 8 -> 36
//
int GetSumNumbers(int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        sum += i;
    }
    return sum;
}

int GetFactorial(int num)
{
    int prod = 1;
    for (int i = 1; i <= num; i++)
    {
        prod *= i;
    }
    return prod;
}
Console.WriteLine(GetSumNumbers(5));
Console.WriteLine(GetFactorial(5));
