void FillingArray(int[] arr)
{
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(100, 1000);
    }

}

int GetEven(int[] arr)
{
    int count = 0;
    foreach (int e in arr)
    {
        if (e % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];

FillingArray(array);

Console.WriteLine(GetEven(array));