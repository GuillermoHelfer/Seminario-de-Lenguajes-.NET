
double[,]? Suma(double[,] A, double[,] B)
{
    if (A.GetLength(0) != B.GetLength(0) || A.GetLength(1) != B.GetLength(1))
        return null;
    double [,] mtx = new double [A.GetLength(0),B.GetLength(1)];
    for (int i=0; i< A.GetLength(1); i++)
    {
        mtx[i/A.GetLength(1), i%A.GetLength(1)] = A[i/A.GetLength(1), i%A.GetLength(1)] + B[i/A.GetLength(1), i%A.GetLength(1)];
    }
    return mtx;
}


double[,]? Resta(double[,] A, double[,] B)
{
    if (A.GetLength(0) != B.GetLength(0) || A.GetLength(1) != B.GetLength(1))
        return null;
    double [,] mtx = new double [A.GetLength(0),B.GetLength(1)];
    for (int i=0; i< A.GetLength(1); i++)
    {
        mtx[i/A.GetLength(1), i%A.GetLength(1)] = A[i/A.GetLength(1), i%A.GetLength(1)] - B[i/A.GetLength(1), i%A.GetLength(1)];
    }
    return mtx;
}


double[,] Multiplicacion(double[,] A, double[,] B)
{
    if (A.GetLength(0) != B.GetLength(1))
        throw new ArgumentException ("columnas de A no coincide con filas de B");
    double [,] mtx = new double [A.GetLength(0),B.GetLength(1)];
    for (int i=0; i< A.GetLength(1); i++)
    {
        mtx[i/A.GetLength(1), i%A.GetLength(1)] = A[i/A.GetLength(1), i%A.GetLength(1)] * B[i%A.GetLength(1), i/A.GetLength(1)];
    }
    return mtx;
}