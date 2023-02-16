Console.WriteLine("Введите коэффециенты - b1 , k1 , b2 , k2 - задающие прямые ");
double b1 = Convert.ToDouble(Console.ReadLine());
double k1 = Convert.ToDouble(Console.ReadLine());
double b2 = Convert.ToDouble(Console.ReadLine());
double k2 = Convert.ToDouble(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);

double y = (k2 * x) + b2;

Console.WriteLine(y + " " + x);