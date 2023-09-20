int[] array = new int[10];
Random rand = new Random();

void FillArray(int[] collection)
{
  int length = collection.Length;
  int index = -1;
  while (index++ < length - 1)
  {
    // Console.WriteLine($"index = {index}");
    collection[index] = rand.Next(0, 100);
  }
}

void printArray(int[] collection)
{
  int length = collection.Length;
  int index = -1;
  while (index++ < length - 1)
  {
    Console.Write($"array[{index}]={collection[index]}{(index < (length - 1) ? ", " : "")}");
  }
}

void Main()
{
  Console.WriteLine("");
  FillArray(array);
  printArray(array);
  Console.WriteLine("");
}

Main();
