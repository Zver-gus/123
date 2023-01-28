Console.WriteLine("Ведите длину массива ");
int N = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[N];

for (int i = 0; i < N; i++)
{
    arr[i] = new Random().Next(1,11);
    Console.Write(arr[i]+" ");
}

int summ = 0;
int result = 0;
int countOfEvens = 0;
for (int i = 0; i < N; i++)
{
    if (arr[i] % 2 == 0)
    {
        summ += arr[i];
        countOfEvens++;
    }
}