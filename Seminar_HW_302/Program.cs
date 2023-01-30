int[] A = new int[3];
int[] B = new int[3];

Console.WriteLine("Введите X Y Z координаты первой точки");
for (int i = 0; i < 3; i++)
A[i] = Convert.ToInt32(Console.ReadLine());

//A[1] = Convert.ToInt32(Console.ReadLine());
//A[2] = Convert.ToInt32(Console.ReadLine());
 
Console.WriteLine("Введите X Y Z координаты второй точки");
for (int i = 0; i < 3; i++)
B[i] = Convert.ToInt32(Console.ReadLine());

/*B[0] = Convert.ToInt32(Console.ReadLine());
B[1] = Convert.ToInt32(Console.ReadLine());
B[2] = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < 3; i++)
{
    Console.WriteLine(A[i]+" "+B[i]);
}*/

double range = Math.Sqrt((B[0] - A [0]) * (B[0] - A [0]) + (B[1] - A[1]) * (B[1] - A[1]) + (B[2] - A[2]) * (B[2] - A[2]));
Console.WriteLine(range);
