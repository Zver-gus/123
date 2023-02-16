void FillArrRND (double[,] arr)
{
    Random random = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
            arr[i, j] = (double)random.Next(-100, 100) / 10;
}

void PrintArr (double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write(arr[i, j] + " ");
    Console.WriteLine();
    }
}
Console.WriteLine("Введите последовательно размер массива - строки и столбцы");
int rowCount = Convert.ToInt32(Console.ReadLine());
int columnCount = Convert.ToInt32(Console.ReadLine());
double[,] array = new double [rowCount, columnCount];

FillArrRND(array);
Console.WriteLine();
PrintArr(array);

Console.WriteLine("Введите последовательно адрес ячейки для вывода значения");
int row = Convert.ToInt32(Console.ReadLine());
int column = Convert.ToInt32(Console.ReadLine());
if (row > rowCount | column > columnCount) 
    Console.Write("Такого числа в массиве нет");
else
    Console.WriteLine(array[row, column] + " ");
