// **Задача 33:** Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.
//
// 4; массив [6, 7, 19, 345, 3] -> нет
//
// 3; массив [6, 7, 19, 345, 3] -> да
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

bool FindElement(int[] array, int element)
{
  bool result = false;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] == element)
    {
      result = true;
      break;
    }
  }
  return result;
}

void ShowArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write($"{array[i]} {(i < array.Length - 1 ? ", " : " -> ")}");
  }
}

int size = 1000;
int min = -10;
int max = 10;
int element = 5;
int[] array = SetArray(size, min, max);
string answer = "";
ShowArray(array);
if (FindElement(array, element))
  answer = "Да";
else
  answer = "Нет";
Console.WriteLine(answer);
