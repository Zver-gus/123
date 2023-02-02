Console.WriteLine("Введите любое число ");
int n = Convert.ToInt32(Console.ReadLine());
int n0 = n;
int sum = 0;
int num = 0;
for (int i = 0; i < n; i++)
{
    num = n % 10;
    n = n / 10;
    if (num != 0)
        if (n0 % num == 0)
            sum += num;
}
Console.WriteLine(sum);