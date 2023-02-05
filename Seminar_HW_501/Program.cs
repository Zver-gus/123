int[] FillArr (int len)
{
    int[] arr = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < len; i++)
    {
        arr[i] = rnd.Next(-101,101);
        Console.Write(arr[i] + " ");
    }
    return arr;
}

Console.WriteLine("Введите длину массива ");
int len = Convert.ToInt32(Console.ReadLine());

int[] array = FillArr(len);

int sum = 0;
for (int i = 0; i<len; i++)
{
    if (i % 2 != 0)
        sum = sum + array[i];
}
Console.WriteLine();
Console.WriteLine(sum);

