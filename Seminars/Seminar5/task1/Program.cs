///Задача 1. Задайте массив из 12 элементов,
/// заполненный случайными числами из промежутка [-9, 9].
/// Найдите сумму отрицательных и положительных элементов массива.
///
///Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29,
/// сумма отрицательных равна -20.
///
int[] SetArray(int size, int min, int max)
{
    Random rand = new Random();
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = rand.Next(min, max);
    }
    return result;
}

int[] GetSums(int[] array)
{
    int[] result = new int[2];
    int negativSum = 0;
    int positivSum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
            negativSum += array[i];
        else
            positivSum += array[i];
    }
    result[0] = negativSum;
    result[1] = positivSum;
    return result;
}

int[] sums = GetSums(SetArray(12, -9, 9));
Console.WriteLine($"Сумма положительных чисел = {sums[1]}");
Console.WriteLine($"Сумма отрицательных чисел = {sums[0]}");
