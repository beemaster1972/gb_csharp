// Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.
//
// [1,0,1,1,0,1,0,0]
//
int[] SetArray(int Length, int minV, int maxV)
{
    Random rand = new Random();
    int[] result = new int[Length];
    for (int i = 0; i < Length; i++)
    {
        result[i] = rand.Next(minV, maxV + 1);
    }
    return result;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"array[{i}] = {array[i]} ");
    }
}

ShowArray(SetArray(10, 0, 1));
