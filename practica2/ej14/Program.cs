bool EsPrimo(int n)
{
    double root = Math.Sqrt(n);
    Boolean esPrimo = true;
    if (n == 1)
        return false;
    if (n == 2)
        return true;
    for (int i= 2; i<= root; i++)
    {
        if(n % i == 0)
            esPrimo = false;
    }
    return esPrimo;
}

for (int i = 1; i<= int.Parse(args[0]); i++)
{
    if (EsPrimo(i))
        Console.WriteLine(i + "es Primo");
}

Console.ReadKey(true);