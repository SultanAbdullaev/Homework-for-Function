int[] array = { 1, 2, 3, 4, 5 };

int[] ReversArray(int[] arr)
{
    int cesh = 0;
    for (int i = 0; i < arr.Length / 2; i++)
    {
        cesh = array[i];
        array[i] = array[arr.Length - i - 1];
        array[arr.Length - i - 1] = cesh;
    }
    return arr;
}

void PrintArray(int[] arr)
{
foreach (int e in arr)
    {
        Console.WriteLine(e);
    }
}



ReversArray(array);

PrintArray(array);