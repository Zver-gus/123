Console.WriteLine("Введите число и степень в которую возвести это число");
int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());
int result = A;
for (int i = 1; i < B; i++)
{
    result *= A;
}
Console.WriteLine(result);