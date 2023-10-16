// 15:30
//Задача 4.Напишите программу, которая на вход принимает два числа A и B,
//и возводит число А в целую степень B с помощью рекурсии.

//A = 3; B = 5 -> 243 (3⁵)
//A = 2; B = 3 -> 8
//

int GetPower(int base_, int exponent)
{
    if (exponent == 1)
        return base_;
    return GetPower(base_, exponent - 1) * base_;
}

int base_ = 3;
int exponent = 3;
System.Console.WriteLine($"{base_}^{exponent} = {GetPower(base_, exponent)}");
