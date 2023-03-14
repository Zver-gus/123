/*
void FillArray2(int [,] matrix)
{
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = rnd.Next(1,10);
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


int[,] arr1 = new int[,] { {2, 4},
                           {3, 2} }; 

int[,] arr2 = new int[,] { {3, 4},
                           {3, 3} };

int[,] multiplication (int[,] arr1, int[,] arr2)
{
    int[,] res = new int[arr1.GetLength(0), arr1.GetLength(1)];
    for (int row = 0; row < arr1.GetLength(0); row++)
        for (int col = 0; col < arr1.GetLength(1); col++)
            res[row, col] = arr1[row, col] + arr2[row, col];
    return res;
}

int[,] res = multiplication(arr1, arr2);

PrintArray2(res);