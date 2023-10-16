namespace ArrayClass;

public static class IntArrayClass
{
    public static int[] CreateInt(this int size)
    {
        return new int[size];
    }

    public static int[] FillInt(this int[] array, int min = 0, int max = 10, int seed = 0)
    {
        Random rand = seed == 0 ? new Random() : new Random(seed);
        return array.Select(item => rand.Next(min, max + 1)).ToArray();
    }

    public static string IntConvertToString(this int[] array, string sep = ", ")
    {
        return $"[{String.Join(sep, array)}]";
    }

    public static void PrintInt(this int[] array)
    {
        Console.Write(array.IntConvertToString());
    }
}

public static class DoubleArrayClass
{
    public static double[] CreateDouble(this int size)
    {
        return new double[size];
    }

    public static double[] FillDouble(this double[] array, int min = 0, int max = 10, int seed = 0)
    {
        Random rand = seed == 0 ? new Random() : new Random(seed);
        return array.Select(item => rand.NextDouble() * (max + 1 - min) + min).ToArray();
    }

    public static string ConvertToStringDouble(this double[] array, int dec = 2, string sep = "; ")
    {
        string result = "[";
        for (int i = 0; i < array.Length; i++)
        {
            result += $"{array[i].ToString($"F{dec}")}{(i < array.Length - 1 ? sep : "]")}";
        }
        return result;
    }

    public static void PrintDouble(this double[] array)
    {
        Console.Write(array.ConvertToStringDouble());
    }
}
