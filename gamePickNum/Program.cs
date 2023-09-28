Random rand = new Random();
int num;
int left = 1, right = 100;

void Answer(int left, int right, int num)
{
    bool flag = true;
    int answer;
    while (flag==true)
    {
        Console.Write($"Ваше число {num}?\n Ответьте 1, если да.\n 0, если меньше.\n2, если больше: ");
        answer = Convert.ToInt32(Console.ReadLine());
        switch (answer)
        {
            case 0:
                left = num;
                flag = false;
                break;
            case 1:
                left = int.MinValue;
                right = int.MaxValue;
                flag = false;
                break;
            case 2:
                right = num;
                flag = false;
                break;
            default:
                Console.WriteLine("Неверный ответ!");
                break;
                
        }
        if (flag==false)
        {
            break;
        }
    }
}

int binarySearch(int left, int right)
{
    return  (right-left+1)/2;
}

void Main()
{
    Console.WriteLine("Загадайте число от 1 до 100");
    int count = 1;
    while (true)
    {
        num = binarySearch(left, right);
        Answer(left, right, num);
        if (left == int.MinValue && right == int.MaxValue)
        {
            break;
        }
        count++;
    }
    Console.WriteLine($"Компьютер угадал число {num} за {count} попыток");

}

Main();