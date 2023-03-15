// void PrintArray(int [,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//          for (int j = 0; j < matr.GetLength(1); j++)
//             Console.Write($"{matr[i, j]} ");
//     Console.WriteLine();
//     }
// }

// void FillArray(int [,] matr)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < matr.GetLength(0); i++)
//         for (int j = 0; j < matr.GetLength(1); j++)
//             matr[i, j] = rnd.Next(1,10);
// }

/* void PrintImage(int [,] image)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
         for (int j = 0; j < matr.GetLength(1); j++)
            //Console.Write($"{matr[i, j]} ");
            if (image[i, j] == 0) Console.Write($" ");
            else Console.Write($"+");
    Console.WriteLine();
    }
}

void FillImage (int row, int col)
{
    if (pic[row, col] == 0) 
    {
        pic[row, col] = 1;
        FillImage(row - 1, col);
        FillImage(row, col - 1);
        FillImage(row + 1, col);
        FillImage(row, col + 1);
    }
}*/

int PrintNaturalNumb (int num1)
{
    if (num1 > 0)
    {
        Console.WriteLine(num1);
        num1 = PrintNaturalNumb(num1 - 1);
        return num1 - 1;
    }
    else 
        return 0;
}

PrintNaturalNumb(9);