// // // using System.Globalization;
// // //
// // // Random rand = new Random();
// // // int pickedNumber;
// // // int numberOfAttempts;
// // // string answer;
// // //
// // // int pickNumber(int min, int max)
// // // {
// // //     int num = rand.Next(min, max);
// // //     return num;
// // // }
// // //
// // // string Answer(int num, int pickedNumber)
// // // {
// // //     string answer = "";
// // //     if (num > pickedNumber)
// // //     {
// // //         answer = "Холодно";
// // //     }
// // //     else if (num < pickedNumber)
// // //     {
// // //         answer = "Горячо";
// // //     }
// // //     else
// // //     {
// // //         answer = "Верно";
// // //     }
// // //     return answer;
// // // }
// // //
// // // void Main()
// // // {
// // //     Console.Write("Введите минимальное число: ");
// // //     int min = Convert.ToInt32(Console.ReadLine());
// // //     Console.Write("Введите максимальное число: ");
// // //     int max = Convert.ToInt32(Console.ReadLine());
// // //     pickedNumber = pickNumber(min, max);
// // //     Console.Write("Введите количество попыток: ");
// // //     numberOfAttempts = Convert.ToInt32(Console.ReadLine());
// // //     for (int count = 0; count < numberOfAttempts; count++)
// // //     {
// // //         Console.Write("Введите число: ");
// // //         int num = Convert.ToInt32(Console.ReadLine());
// // //         answer = Answer(num, pickedNumber);
// // //         Console.WriteLine(answer);
// // //         if (answer == "Верно")
// // //         {
// // //             break;
// // //         }
// // //     }
// // //     Console.WriteLine($"Было загадано число {pickedNumber}");
// // // }
// // //
// // // Main();

// // // Напишите программу, которая будет принимать на вход два числа и выводить, 
// // // является ли второе число кратным первому. Если второе число не кратно числу первому, 
// // // то программа выводит остаток от деления.

// // // 34, 5 -> не кратно, остаток 4
// // // 16, 4  -> кратно

// // int checkMultiplicity(int numA, int numB)
// // {
// //     int result = numA % numB;
// //     return result;
// // }

// // void Main()
// // {
// //     Console.Write("Введите первое число: ");
// //     int numA = Convert.ToInt32(Console.ReadLine());
// //     Console.Write("Введите второе число: ");
// //     int numB = Convert.ToInt32(Console.ReadLine());
// //     int result = checkMultiplicity(numA, numB);
// //     Console.WriteLine($"{numA}, {numB} -> {(result == 0? "кратно" : "не кратно, остаток "+result)}");
// //     Console.ReadKey();

// // }

// // Main();
// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// 78 -> 8

// 12-> 2

// 85 -> 8

Random rand = new Random();

int max