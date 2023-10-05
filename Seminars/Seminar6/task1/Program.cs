// **Задача 39:** Напишите программу, которая перевернёт одномерный массив
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
//
// [1 2 3 4 5] -> [5 4 3 2 1]
//
// [6 7 3 6] -> [6 3 7 6]
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

void ReverseArray(int[] array)
{
    int left,
        right,
        tmp;
    left = 0;
    right = array.Length - 1;
    while (left <= right)
    {
        tmp = array[left];
        array[left] = array[right];
        array[right] = tmp;
        left++;
        right--;
    }
}

void ShowArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} {(i < array.Length - 1 ? ", " : "] -> ")}");
    }
}

int[] array = SetArray(5, 1, 11);
ShowArray(array);
ReverseArray(array);
Console.WriteLine();
ShowArray(array);
