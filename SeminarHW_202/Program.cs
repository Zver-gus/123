int n = new Random().Next(1, 655536);
Console.WriteLine(n);

if (n < 100)
{
    Console.WriteLine("Третьей цифры нет");
    
}
else
{
    while (n > 999) n = n / 10;
    n = n % 10;
    Console.WriteLine(n);
}

