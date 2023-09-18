// // // System.Console.WriteLine("Введите число: ");
// // // int num = Convert.ToInt32(System.Console.ReadLine());
// // // System.Console.WriteLine($"Квадарат числа {num} = {num*num}");
// // int num;
// // while (true)
// // {
// // System.Console.WriteLine("Введите трёхзначное число: ");
// // num = Convert.ToInt32(System.Console.ReadLine());
// // if (num >= 100 && num <= 999)
// // { break;}
// // }
// // System.Console.WriteLine($"Последняя цифра в числе {num} = {num % 10}");
// System.Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(System.Console.ReadLine());
// int i = -1*num;
// while (i<=num)
// {
//     System.Console.WriteLine(i++);
// }
System.Console.WriteLine("Ввдеите число А: ");
int numA = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Введите число В: ");
int numB = Convert.ToInt32(System.Console.ReadLine());
if (numB*numB == numA)
{
    System.Console.WriteLine($"a={numA}; b={numB} -> Да");
}
else
{
    System.Console.WriteLine($"a={numA}; b={numB} -> Нет");
}
