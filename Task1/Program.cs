int GetSumAllDigit(int a)
{

    int sum = 0;
    while (a / 10 != 0)
    {
        sum += a % 10;
        a /= 10;
    }
    sum += a;
    return sum;
}

while (true)
{

    string? stop = Console.ReadLine();
    if (stop != "q")
    {
        int num = Convert.ToInt32(stop);
        if (GetSumAllDigit(num) % 2 == 0)
        {
            break;
        }
    }
    else
    {
        break;
    }
}
