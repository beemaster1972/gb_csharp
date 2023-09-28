int GetDigigtsCount(int number)
{
    int result = 0;
    while (Math.Abs(number) > 0)
    {
        result++;
        number /= 10;
    }
    return result;
}

Console.WriteLine(GetDigigtsCount(-1024));
