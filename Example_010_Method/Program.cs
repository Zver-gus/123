int [] array ={1,24,35,4,98,26,17,68,98};

int n = array.Length;
int find = 98;

int index = 0;

while (index < n)
{

    if (array[index]==find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;

}