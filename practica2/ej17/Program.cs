int f;
Fac(10, out f);
Console.WriteLine(f);

void Fac(int n, out int f)
{
    int suma = n;
    for (int i = n-1; i>= 0; i--)
    {
        if (i == 0 || i == 1)
            suma *= 1;
        else
            suma *= i;
    }
    f = suma;
}