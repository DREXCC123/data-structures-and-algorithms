static int CountNumbersWithoutFive(int start, int end)
{
    int count = 0;

    for (int i = start; i <= end; i++)
    {
        if (!i.ToString().Contains("5"))
        {
            count++;
        }
    }

    return count;
}
Console.WriteLine(CountNumbersWithoutFive(1, 9));
Console.WriteLine(CountNumbersWithoutFive(4, 17));