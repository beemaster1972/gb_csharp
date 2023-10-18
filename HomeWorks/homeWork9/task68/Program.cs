// Задача 68: Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
//
// функция ack(n, m)
//    если n = 0
//      вернуть m + 1
//    иначе, если m = 0
//      вернуть ack (n - 1, 1)
//    еще
//      вернуть ack(n - 1, ack (n, m - 1))


int Ack(int n, int m)
{
    if (n == 0)
        return m + 1;
    else if (m == 0)
        return Ack(n - 1, 1);
    else
        return Ack(n - 1, Ack(n, m - 1));
}

int n = 2;
int m = 3;
System.Console.WriteLine($"Ackerman({n},{m})= {Ack(n, m)}");
n = 3;
m = 2;
System.Console.WriteLine($"Ackerman({n},{m})= {Ack(n, m)}");
