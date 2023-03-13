for (int i=1; i<=1000; i++)
{
    if (( i % 17 == 0 ) || ( i % 29 == 0))
    {
        Console.WriteLine(i);
    }
}

Console.ReadKey(true);