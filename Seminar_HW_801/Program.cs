void FillArray2(int [,] matrix)
{
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = rnd.Next(1,10);
}


/*
void PrintArray(int [] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i]} ");
    Console.WriteLine();
    }
}
*/


void PrintArray2(int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
         for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} ");
    Console.WriteLine();
    }
}


void TransformArray(ref int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int k = 0; k < matrix.GetLength(0); k++)
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                if (matrix [i,j] > matrix [i, j + 1])
                {
                    int z = matrix [i, j];
                    matrix [i, j] = matrix [i, j + 1];
                    matrix [i, j + 1] = z;
                }
}


Console.WriteLine("Введите через побел размер массива строки и столбцы");
int row = Convert.ToInt32(Console.ReadLine());
int col = Convert.ToInt32(Console.ReadLine());
 
int[,] arr = new int[row,col];
FillArray2(arr);
PrintArray2(arr);

Console.WriteLine();
Console.WriteLine();

TransformArray(ref arr);
PrintArray2(arr);