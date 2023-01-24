Console.WriteLine("Введите число для проверки кратности на 7 и 23 ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(n);

if ((n % 7 == 0) & (n % 23 == 0)) Console.WriteLine("Кратное");
else Console.WriteLine("Не кратное");