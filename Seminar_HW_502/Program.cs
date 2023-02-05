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

int max = array[0];
int min = array[0];
for (int i = 0; i < len; i++)
{
    if (max < array[i])
        max = array[i];
    else if (min > array[i])
        min = array[i];
}

int diff = max - min;

Console.WriteLine();
Console.Write(diff);