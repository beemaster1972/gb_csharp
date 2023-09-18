System.Console.Write("Введите имя пользователя: "); 
string userName = Console.ReadLine();
if (userName == "BeeMaster")
{
    System.Console.WriteLine($"Вы успешно авторизованы, дорогой {userName}!");
}
else
{
    System.Console.WriteLine($"Вы не авторизованы, НЕ дорогой {userName}!");    
}