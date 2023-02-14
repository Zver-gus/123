Console.WriteLine("Введите желаемое количество чисел, а затем поочерёдно сами числа ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 0, memb = 0;

for (int i = 0; i < num; i++)
{
    memb = Convert.ToInt32(Console.ReadLine());
    if (memb > 0) count++;
}

Console.WriteLine("Введено чисел больше '0': " + count);