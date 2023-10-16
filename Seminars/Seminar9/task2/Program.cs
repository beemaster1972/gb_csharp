//Задание 2. Напишите программу, которая будет принимать на вход число
//и возвращать сумму его цифр.

//453 -> 12
//45 -> 9
//

int GetSumdigits(int num)
{
    if (num == 0)
        return 0;

    return GetSumdigits(num / 10) + num % 10;
}
int num = 123;
System.Console.WriteLine($"sum({num})= {GetSumdigits(num)}");
