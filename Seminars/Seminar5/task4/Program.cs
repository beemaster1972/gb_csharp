// **Задача 32:** Напишите программу замена элементов массива:
// положительные элементы замените на соответствующие отрицательные, и наоборот.
//
// [-4, -8, 8, 2] -> [4, 8, -8, -2]
//
//

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

void ChangeElement(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} {(i < array.Length - 1 ? ", " : " -> ")}");
    }
}

int size = 10;
int min = -10;
int max = 10;

int[] array = SetArray(size, min, max);
ShowArray(array);
ChangeElement(array);
Console.WriteLine();
ShowArray(array);
