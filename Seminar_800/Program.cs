Console.WriteLine("Введите элементы через пробел");

int[] arr2 = Console.ReadLine().Split(' ').Select(Int32.Parse).ToArray();//.Where(e => e%2 == 0).ToArray()

//String[] arr3 = Console.ReadLine().Split(' ');


void PrintArray(int [] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
         //for (int j = 0; j < matr.GetLength(1); j++)
            Console.Write($"{matrix[i]} ");
    //Console.WriteLine();
    }
}


/*void PrintArray2(int [,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
         for (int j = 0; j < matr.GetLength(1); j++)
            Console.Write($"{matr[i, j]} ");
    Console.WriteLine();
    }
}
*/
PrintArray(arr2);
