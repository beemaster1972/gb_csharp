using System;

public class Answer
{
    public static int SumOddElements(int[] array)
    {
        // Введите свое решение нижеешение ниже
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 > 0)
                count += array[i];
        }
        return count;
    }

    public static void PrintArray(int[] array)
    {
        // Введите свое решение нижеешение ниже
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]}\t");
        }
        Console.WriteLine();
    }

    // Не удаляйте и не меняйте метод Main!
    public static void Main(string[] args)
    {
        int[] array;
        if (args.Length == 0)
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            array = new int[] { 12, 64, 28, 93, 35, 47, 6, 72, 58, 21 };
        }
        else
        {
            string[] argStrings = args[0].Split(", ");
            array = new int[argStrings.Length];
            for (int i = 0; i < argStrings.Length; i++)
            {
                if (int.TryParse(argStrings[i], out int number))
                {
                    array[i] = number;
                }
                else
                {
                    Console.WriteLine($"Ошибка при парсинге аргумента {argStrings[i]}.");
                    return;
                }
            }
        }

        // Не удаляйте строки ниже
        PrintArray(array);
        int sumOdd = SumOddElements(array);
        Console.WriteLine($"Сумма нечетных элементов: {sumOdd}");
    }
}
