// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
//
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double X(double k1, double k2, double b1, double b2)
{
    return (b2 - b1) / (k1 - k2);
}

double Y(double x, double k1, double b1)
{
    return k1 * x + b1;
}

double inputDouble(string promt)
{
    Console.Write(promt);
    return Convert.ToDouble(Console.ReadLine());
}

bool ValidateLines(double k1, double b1, double k2, double b2)
{
    if (k1 == k2)
    {
        if (b1 == b2)
            Console.WriteLine("Прямые совдадают");
        else
            Console.WriteLine("Прямые параллельны");

        return false;
    }
    return true;
}

Console.WriteLine("Для уравнений вида y=k*x+b");
double k1 = inputDouble("Введите к1: ");
double b1 = inputDouble("Введите b1: ");
double k2 = inputDouble("Введите к2: ");
double b2 = inputDouble("Введите b2: ");
if (ValidateLines(k1, b1, k2, b2))
{
    double x = X(k1, k2, b1, b2);
    double y = Y(x, k1, b1);
    Console.WriteLine($"Для уравнений y={k1}*x+{b1} и y={k2}*x+{b2}");
    Console.WriteLine($"Общая точка имеет координаты ({x}; {y})");
}
