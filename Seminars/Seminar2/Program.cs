using System.Globalization;

Random rand = new Random();
int pickedNumber;
int numberOfAttempts;
string answer;

int pickNumber(int min, int max)
{
    int num = rand.Next(min, max);
    return num;
}

string Answer(int num, int pickedNumber)
{
    string answer = "";
    if (num < pickedNumber)
    {
        answer = "Холодно";
    }
    else if (num > pickedNumber)
    {
        answer = "Горячо";
    }
    else
    {
        answer = "Верно";
    }
    return answer;
}

void Main()
{
    Console.Write("Введите минимальное число: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальное число: ");
    int max = Convert.ToInt32(Console.ReadLine());
    pickedNumber = pickNumber(min, max);
    Console.Write("Введите количество попыток: ");
    numberOfAttempts = Convert.ToInt32(Console.ReadLine());
    for (int count = 0; count < numberOfAttempts; count++)
    {
        Console.Write("Введите число: ");
        int num = Convert.ToInt32(Console.ReadLine());
        answer = Answer(num, pickedNumber);
        Console.WriteLine(answer);
        if (answer == "Верно")
        {
            break;
        }
    }
}

Main();
