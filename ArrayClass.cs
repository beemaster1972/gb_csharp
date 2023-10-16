namespace ArrayClass;

public static class IntArrayClass
{
    public static int[] Create(this int size) 
    { 
      return new int[size];
    }

    public static int[] Fill(int[] array, int min = 0, int max = 10, int seed = 0)
    {
      Random rand = new Random(seed);
      return array.Select(item ==> rand.Next(min,max)).ToArray();
    }
    public static string ToString(int[] array)
    {
      return $"[{String.Join(", ", array)}]";
    }
}

