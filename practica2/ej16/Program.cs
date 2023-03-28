int FacA(int n)
{
    int suma = n;
    for (int i = n-1; i>= 0; i--)
    {
        if (i == 0 || i == 1)
            suma+= 1;
        else
            suma *= i;
    }
    return suma;
}

int FacB(int n)
{
    if (n == 0 || n == 1)
        return 1;
    return n * FacB(n-1);
}

int FacC(int n)
{
    return n <= 1? 1 : n * FacC(n-1);
}
