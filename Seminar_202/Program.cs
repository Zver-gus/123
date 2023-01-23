Console.WriteLine("Введите первое число ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int y = Convert.ToInt32(Console.ReadLine());
if (x > y)
{
    if (x % y == 0)
    {
        Console.WriteLine("Первое число кратно второму");
    }
    else
    {
        double result =  x % y;
        Console.WriteLine("Не кратно, остаток равен " + result);
    }
}
else
{
     if (y % x == 0)
    {
        Console.WriteLine("Второе число кратно первому");
    }
    else
    {
        double result = y % x;
        Console.WriteLine("Не кратно, остаток равен " + result);
    }
}