void FillArray2(int [,] matrix)
{
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = rnd.Next(1,10);
}


int MinSumRow(int [,] matrix)
{
    int sum = 0;
    int min = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            sum += matrix[i,j];
        if (min > sum) min = sum;
        sum = 0;
    }
    return min;
}


void PrintArray2(int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
         for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} ");
    Console.WriteLine();
    }
}


Console.WriteLine("Введите через побел размер массива строки и столбцы");
int row = Convert.ToInt32(Console.ReadLine());
int col = Convert.ToInt32(Console.ReadLine());


int[,] arr = new int[row,col];
FillArray2(arr);
PrintArray2(arr);


Console.WriteLine(MinSumRow(arr));