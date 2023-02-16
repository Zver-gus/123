// int Fibonachi (int n)
// {
//     if (n == 0 || n == 1) return n;
//     return Fibonachi(n-1)+Fibonachi(n-2);
// }

void FillArrRND (int[,] arr)
{
    Random random = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
            arr[i, j] = random.Next(1, 5);
}

void ChangeElementToSquire (int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        if (i % 2 == 0 && j % 2 == 0) arr[i,j] *= arr[i,j];
    }
}

void PrintArr (int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write(arr[i, j] + " ");
    Console.WriteLine();
    }
}

int rowCount = 3;
int columnCount = 4; 
int[,] array = new int[rowCount, columnCount];

FillArrRND(array);
PrintArr(array);
Console.WriteLine();
ChangeElementToSquire(array);
PrintArr(array);