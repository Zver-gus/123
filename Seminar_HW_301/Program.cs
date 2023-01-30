void FillArray (int[] arr, int len)
{
    for (int i = 0; i < len; i++)
    {
        arr[i] = new Random().Next(0,11);
        Console.Write(arr[i]+" "); 
    }
}

Console.WriteLine("Введите длину массива ");
int N = Convert.ToInt32(Console.ReadLine());

int[] array = new int[N];

FillArray(array, N);

Console.WriteLine();

int sum = 0;
float result = 0;
int countOfEvens = 0;
for (int i = 0; i < N; i++)
{
    if (array[i] % 2 == 0)
    {
        sum += array[i];
        countOfEvens++;
    }
}

    result = (float)sum / countOfEvens;
    Console.WriteLine(result);