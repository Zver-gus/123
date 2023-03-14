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


int[,] multiplication = new int[arr1.GetLength(0), arr1.GetLength(1)];
for (int i = 0; i < arr1.GetLength(0); i++)
{
    for (int j = 0; j < arr2.GetLength(1); j++)
        for (int k = 0; k < arr1.GetLength(0); k++)
            multiplication[i, j] = (arr1[i, k] * arr2[i, k]) + (arr1[i + 1, j] * arr2[i, j + 1]);
}

PrintArray2(multiplication);
