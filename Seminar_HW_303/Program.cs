Console.WriteLine("Введите число ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

void FillArray (int[] arr, int N)
{
    for (int i = 1; i <= n; i++)
        arr[i-1] = i*i*i;
}

int[] Array = new int[n];

FillArray(Array, n);

for (int i = 0; i < n; i++) 
    Console.WriteLine(Array[i]);
