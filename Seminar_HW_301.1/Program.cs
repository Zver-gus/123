Console.WriteLine("Введите число для проверки на полиндромность");
int n = Convert.ToInt32(Console.ReadLine());
int n1 = n;
int changed = n % 10;
for (int i = 0; i < 4; i++)
{
    n = n / 10;
    changed = (changed * 10) + n % 10;
    Console.WriteLine(changed);
}
if (n1 == changed)
    Console.WriteLine("Полиндром");
else
    Console.WriteLine("Не полиндром");