// int GetFact(int num)
// {
//     if (num == 1)
//     {
//         return 1;
//     }
//     else 
//     {
//         int m = GetFact(num - 1);
//         Console.WriteLine(m);
//         return num * m;
//     }
// }

// Console.WriteLine(GetFact(5));

void Swap (ref int frst,ref int sec)
    {
        //Console.Write("Swap " + frst + " "+ sec + " ");
        int tmp = frst;
        frst = sec;
        sec = tmp;
    }

int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7 };

for (int i = 0, j = arr.Length - 1; i < arr.Length/2; i++, j--)
{
    Swap (ref arr[i],ref arr[j]);
}

for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");
}
