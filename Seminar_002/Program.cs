int N = new Random().Next(10, 99);
int first = N / 10;
int second = N % 10;
if (first > second)
{
    Console.WriteLine(first);
}
else
{
    Console.WriteLine(second);
}
