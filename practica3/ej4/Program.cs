double [,] mtx = new double [10,10];

for (int i = 0; i< 10*10; i++)
    mtx[i/10,i%10] = i;

if (args[1] == "principal")
    Console.WriteLine(GetDiagonalPrincipal(mtx));
else
    Console.WriteLine(GetDiagonalSecundaria(mtx));

double[] GetDiagonalPrincipal(double[,] matriz)
{
    if (matriz.GetLength(0) != matriz.GetLength(1))
    {
        throw new ArgumentException ("no es cuadratica");
    }
    int x = matriz.GetLength(0);
    int y = matriz.GetLength(1);
    double [] vector = new double [matriz.GetLength(0)];
    for (int i = 0; i< (x * y); i++)
    {
        vector[i] = matriz[i,i];
    }
    return vector;
}

double[] GetDiagonalSecundaria(double[,] matriz)
{
    if (matriz.GetLength(0) != matriz.GetLength(1))
    {
        throw new ArgumentException ("no es cuadratica");
    }
    int x = matriz.GetLength(0);
    int y = matriz.GetLength(1);
    double [] vector = new double [matriz.GetLength(0)];
    for (int i = (x*y); i>0; i--)
    {
        vector[i] = matriz[i,i];
    }
    return vector;
}