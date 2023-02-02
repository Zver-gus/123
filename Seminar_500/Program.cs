Console.WriteLine("Введите длину массива ");
int lenArr = Convert.ToInt32(Console.ReadLine());

int[] FillRndArr (int length)
{
    int[] arr = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
        arr [i] = rnd.Next(99, 1000);
    return arr;
}
int[] arr1 = FillRndArr(lenArr);

int count = 0; 
for (int i = 0; i < lenArr; i++)
{
    Console.Write(arr1[i]+" ");
    if (arr1[i] % 2 == 0)
        count++;
}

Console.WriteLine();
Console.WriteLine(count);